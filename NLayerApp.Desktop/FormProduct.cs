using NLayerApp.Core.ApiFilter;
using NLayerApp.Core.DTOs.Categories;
using NLayerApp.Core.DTOs.Products;
using NLayerApp.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLayerApp.Desktop
{
    public partial class FormProduct : Form
    {
        private ProductDto selectedProduct;
        List<ProductDto> products;
        List<CategoryDto> categories;
        public FormProduct()
        {
            InitializeComponent();
            Load += FormProduct_Load;
        }

        private async void FormProduct_Load(object? sender, EventArgs e)
        {
            Temizle();
            await ProductList();
            await CategoryList();
        }

        private async Task CategoryList()
        {

            using (HttpClient client = new HttpClient())
            {
                categories = await client.GetFromJsonAsync<List<CategoryDto>>(new Uri(Parametres.url + "Categories/GetList"));
            }
            if (categories is not null)
            {
                cboxCategory.DataSource = categories.ToList();
                cboxCategory.DisplayMember = "Name";
                cboxCategory.ValueMember = "Id";
            }
        }

        private async Task ProductList()
        {
            products = new List<ProductDto>();
            using (HttpClient client = new HttpClient())
            {
                if (string.IsNullOrEmpty(txtNameSearch.Text))
                    products = await client.GetFromJsonAsync<List<ProductDto>>(new Uri(Parametres.url + "Products/GetList"));
                else
                {
                    ProductFilter productFilter = new ProductFilter()
                    {
                        Name = txtNameSearch.Text
                    };

                    // Todo get categorlist from HttpPost to call Api 
                    var result = await client.PostAsJsonAsync(new Uri(Parametres.url + "Products/GetByFilter"), productFilter);
                    if (result.IsSuccessStatusCode)
                    {
                        products = result.Content.ReadFromJsonAsync<List<ProductDto>>().Result;
                    }
                }
            }
            dtgv_ProductList.DataSource = null;
            dtgv_ProductList.DataSource = products.ToList();
        }

        private async void btnAra_Click(object sender, EventArgs e)
        {
            await ProductList();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private async void Temizle()
        {
            txtCode.Text = string.Empty;
            txtName.Text = string.Empty;
            txtFiyat.Text = string.Empty;
            txtStok.Text = string.Empty;
            txtNameSearch.Text = string.Empty;
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {
            ProductAddDto productAddDto = new ProductAddDto()
            {
                Name = txtName.Text,
                CategoryId = ((CategoryDto)cboxCategory.SelectedItem).Id,
                Code = txtCode.Text,
                Price = decimal.Parse(txtFiyat.Text),
                Stock = int.Parse(txtStok.Text)
            };

            using (HttpClient client = new HttpClient())
            {
                var sonuc = await client.PostAsJsonAsync<ProductAddDto>(new Uri(Parametres.url + "Products/AddProduct"), productAddDto);
                if (sonuc.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    await ProductList();
                }
                else
                {
                    lblMessage.Text = sonuc.RequestMessage.Content.ToString();
                }
            }

        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                var sonuc = await client.PostAsJsonAsync<int> (new Uri(Parametres.url + "Delete/"+ selectedProduct.Id),selectedProduct.Id);
                if (sonuc.IsSuccessStatusCode)
                {
                    await ProductList();
                }
            }
        }

        private void dtgv_ProductList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedProduct = null;
            int selectedId = int.Parse(dtgv_ProductList.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            selectedProduct = products.SingleOrDefault(x => x.Id == selectedId);
            txtCode.Text = selectedProduct.Code;
            txtFiyat.Text = selectedProduct.Price.ToString();
            txtName.Text = selectedProduct.Name;
            txtStok.Text = selectedProduct.Stock.ToString();
            cboxCategory.SelectedValue = selectedProduct.CategoryId;
        }

        private async void btnGuncelle_Click(object sender, EventArgs e)
        {
            ProductUpdateDto productUpdateDto = new ProductUpdateDto()
            {
                CategoryId = ((CategoryDto)cboxCategory.SelectedItem).Id,
                Code = txtCode.Text,
                Name = txtName.Text,
                Id = selectedProduct.Id,
                Price = decimal.Parse( txtFiyat.Text),
                Stock = int.Parse( txtStok.Text),
                UpdateDate = DateTime.Now

            };
            using (HttpClient client = new HttpClient())
            {
              var sonuc=  await  client.PostAsJsonAsync<ProductUpdateDto>(new Uri(Parametres.url + "Products/UpdateProduct"), productUpdateDto);
                if (sonuc.IsSuccessStatusCode)
                {
                   await  ProductList();
                    lblMessage.Text = "Güncelleme Başarılı";
                }
            }
        }
    }
}
