using NLayerApp.Core.ApiFilter.CategoryFilters;
using NLayerApp.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLayerApp.Desktop
{
    public partial class FormProduct : Form
    {
        private Product selectedProduct;
        List<Product> products;

        public FormProduct()
        {
            InitializeComponent();
            Load += FormProduct_Load;
        }

        private async void FormProduct_Load(object? sender, EventArgs e)
        {
            await ProductList();
        }

        private async Task ProductList()
        {
            products = new List<Product>();
            using (HttpClient client = new HttpClient())
            {
                //if (string.IsNullOrEmpty(txtNameSearch.Text) && !checkHepsiniGetir.Checked)
                //{

                products = await client.GetFromJsonAsync<List<Product>>(new Uri(Parametres.url + "Products/GetList"));

                //}
                //else
                //{
                //    CategoryFilter categoryFilter = new CategoryFilter()
                //    {
                //        IsDeleted = !checkHepsiniGetir.Checked,
                //        Name = txtNameSearch.Text
                //    };

                //    // Todo get categorlist from HttpPost to call Api 
                //    var result = await client.PostAsJsonAsync(new Uri(Parametres.url + "Categories/GetByFilterAsync"), categoryFilter);
                //    if (result.IsSuccessStatusCode)
                //    {
                //        categories = result.Content.ReadFromJsonAsync<List<Category>>().Result;
                //    }
                //}
            }
            dtgv_ProductList.DataSource = null;
            dtgv_ProductList.DataSource = products.ToList();
        }
    }
}
