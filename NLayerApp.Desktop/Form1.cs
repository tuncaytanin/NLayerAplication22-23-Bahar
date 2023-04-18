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
    public partial class FormCategories : Form
    {

        private static string url = "https://localhost:7245/api/";
        public FormCategories()
        {
            InitializeComponent();
            Load += FormCategories_Load;
        }

        private async void FormCategories_Load(object? sender, EventArgs e)
        {
            dtgwKategoriler.DataSource = await CategoryList();
        }

        public async Task<List<Category>> CategoryList()
        {
            using (HttpClient client = new HttpClient())
            {
              var categories =  await  client.GetFromJsonAsync<List<Category>>(new Uri(url + "Categories/GetList"));

                return categories;
            }
        }
    }
}
