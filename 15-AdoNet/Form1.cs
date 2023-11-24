using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ProductDal sınıfı nesnesini oluşturuyoruz.
        ProductDal _productDal = new ProductDal();

        // Form yüklendiğinde çalışan olay
        private void Form1_Load(object sender, EventArgs e)
        {
            // DataGridView denilen kontrolü, ProductDal sınıfı üzerinden alınan veriyle dolduruyoruz.
            dgwProducts.DataSource = _productDal.Getall();
        }

        // "Add" düğmesine tıklandığında çalışan olay
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kullanıcının girdiği ürün bilgileri ile yeni bir Product nesnesi oluşturuyoruz.
            _productDal.Add(new Product
            {
                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text)
            });

            // Kullanıcıya ürünün başarıyla eklendiğini bildiren bir mesaj gösteriyoruz.
            MessageBox.Show("Product Added");

            // DataGridView kontrolünü güncelliyoruz, böylece yeni ürün görüntüleniyor.
            dgwProducts.DataSource = _productDal.Getall();
        }

        // DataGridView hücre içeriği tıklanıldığında çalışan olay (şu an için boş)
        private void dgwProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Bu olay şu anda kullanılmıyor.
        }

        // GroupBox'un içeriği giriş yapıldığında çalışan olay (şu an için boş)
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Bu olay şu anda kullanılmıyor.
        }
    }
}
