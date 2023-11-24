using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntitiyFrameWork
{
    public partial class Form1 : Form
    {
        ProductDal _productDal = new ProductDal();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde ürünleri yükleme işlemi yapılır.
            LoadProducts();
        }

        private void LoadProducts()
        {
            // Tüm ürünleri DataGridView'e yükleme işlemi
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Yeni ürün eklemek için butona tıklanınca çalışan metod
            _productDal.Add(new Product
            {
                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text),
            });

            MessageBox.Show("Ürün Eklendi");
            // Ürün ekledikten sonra tekrar ürünleri yükleme işlemi yapılır.
            LoadProducts();
        }

        private void SearchProducts(string key)
        {
            // Arama metodu, veritabanından ürünleri adı içerisinde belirli bir anahtar kelime ile filtreler
            dgwProducts.DataSource = _productDal.GetByName(key);
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            // Arama kutusu değiştiğinde çalışır ve ürünleri arar.
            SearchProducts(tbxSearch.Text);
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            // Belirli bir ID'ye sahip ürünü getirme işlemi
            _productDal.GetByID(1); // ID 1 için çağrı yapılıyor, sonucu bir yerde kullanılması gerekebilir.
        }
    }
}
