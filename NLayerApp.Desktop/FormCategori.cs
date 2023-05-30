using NLayerApp.Core.ApiFilter.CategoryFilters;
using NLayerApp.Core.DTOs.Categorie;
using NLayerApp.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLayerApp.Desktop
{
    public partial class FormCategories : Form
    {



        private Category selectedCategory;

        private List<Category> categories;
        public FormCategories()
        {
            InitializeComponent();
            Temizle();
            Load += FormCategories_Load;
        }

        private async void FormCategories_Load(object? sender, EventArgs e)
        {
            await CategoryList();

        }

        public async Task CategoryList()
        {
            categories = new List<Category>();
            using (HttpClient client = new HttpClient())
            {
                if (string.IsNullOrEmpty(txtNameSearch.Text) && !checkHepsiniGetir.Checked)
                {

                    categories = await client.GetFromJsonAsync<List<Category>>(new Uri(Parametres.url + "Categories/GetList"));

                }
                else
                {
                    CategoryFilter categoryFilter = new CategoryFilter()
                    {
                        IsDeleted = !checkHepsiniGetir.Checked,
                        Name = txtNameSearch.Text
                    };

                    // Todo get categorlist from HttpPost to call Api 
                    var result = await client.PostAsJsonAsync(new Uri(Parametres.url + "Categories/GetByFilterAsync"), categoryFilter);
                    if (result.IsSuccessStatusCode)
                    {
                        categories = result.Content.ReadFromJsonAsync<List<Category>>().Result;
                    }
                }
            }
            dtgwKategoriler.DataSource = null;
            dtgwKategoriler.DataSource = categories.ToList();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private async void btnGuncelle_Click(object sender, EventArgs e)
        {
            CategoryUpdateDto categoryUpdateDto = new CategoryUpdateDto()
            {
                Id = selectedCategory.Id,
                Name = txtName.Text,
                Description = rtxtDescription.Text
            };

            using (HttpClient client = new HttpClient())
            {
                var result = await client.PutAsJsonAsync<CategoryUpdateDto>(new Uri(Parametres.url + "Categories/UpdateCategory"), categoryUpdateDto);
                if (result.IsSuccessStatusCode)
                {
                    await CategoryList();
                }
            }
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {
            // ekleme
            using (HttpClient client = new HttpClient())
            {
                CategoryAddDto categoryAddDto = new CategoryAddDto()
                {
                    Description = rtxtDescription.Text,
                    Name = txtName.Text
                };
                var result = await client.PostAsJsonAsync(new Uri(Parametres.url + "Categories/AddCategory"), categoryAddDto);
                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                    await CategoryList();
                else
                {
                    // hata message dönebiliriz
                    lblMessage.Text = result.RequestMessage.Content.ToString();
                }

            }
            // listeleme

        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                var result = await client.PostAsync(new Uri(Parametres.url + "Categories/IsDeletedCategoryById/" + selectedCategory.Id), null);
                if (result.IsSuccessStatusCode)
                {
                    await CategoryList();
                }
            }
        }

        private void dtgwKategoriler_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedCategory = null;
            int selectedId = int.Parse(dtgwKategoriler.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            selectedCategory = categories.SingleOrDefault(x => x.Id == selectedId);
            if (selectedCategory is not null)
            {
                txtName.Text = selectedCategory.Name;
                rtxtDescription.Text = selectedCategory.Description;
            }
        }



        private void Temizle()
        {
            selectedCategory = null;
            rtxtDescription.Text = string.Empty;
            txtName.Text = string.Empty;
            lblMessage.Text = string.Empty;
        }

        private async void checkHepsiniGetir_CheckedChanged(object sender, EventArgs e)
        {
            await CategoryList();
        }

        private async void btnAra_Click(object sender, EventArgs e)
        {
            await CategoryList();
        }
    }
}
