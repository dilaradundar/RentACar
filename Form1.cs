using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string productsText = "Kiralanmamış Arabalar";
            var addToCartButtonText = "Kirala";
            var cartLabel = "Kiralanmış Arabalar";
            var removeFromCartButtonText = "Kira Süresi bitti !! Teslim al";

            lblProducts.Text = productsText;// başlık ismi
            btnAddToCart.Text = addToCartButtonText;//buton ismi
            lblCart.Text = cartLabel;// sepetin başlık ismi
            btnRemoveFromCart.Text = removeFromCartButtonText;

            string[] products = new string[] { "Megane", "Honda", "Ford","Dacia","Tesla","Hyundai" };

            foreach (var item in products) 
            {
                lbxProducts.Items.Add(item);
            }

            if (lbxCart.Items.Count == 0)
            {
                btnRemoveFromCart.Enabled = false; // aktifliğini kapattık.
            } 
        }

        private void btnAddToCart_Click(object sender, EventArgs e) // yarattığımız buton için 
        {
            if (lbxProducts.SelectedItem != null)
            {
                btnAddToCart.Enabled = true;
                lbxCart.Items.Add(lbxProducts.SelectedItem); //Ürünler kısmındaki seçilen öğeleri butona basılınca sepete atıyoruz.
                lbxProducts.Items.Remove(lbxProducts.SelectedItem);// Seçilen öğeyi ürünler başlığının altından sildik
                btnRemoveFromCart.Enabled = true;
            }
            else 
            {
                MessageBox.Show("Select a product First");
            }

            if (lbxProducts.Items.Count == 0)
            {
                btnAddToCart.Enabled = false; // aktifliğini kapattık.
            }
            int num = lbxCart.Items.Count;// control
            
        }

        private void lbxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (lbxProducts.SelectedItem != null || lbxCart.SelectedItem != null)
            {
                lbxProducts.Items.Add(lbxCart.SelectedItem);
                lbxCart.Items.Remove(lbxCart.SelectedItem);
                if (lbxProducts.Items.Count != 0)
                {
                    btnAddToCart.Enabled = true;
                }
                
            }
            else
            {
                MessageBox.Show("Select a product from the Cart First");
            }

            if (lbxCart.Items.Count == 0)
            {
                btnRemoveFromCart.Enabled = false; // aktifliğini kapattık.
            }

        }

        private void lbxCart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
