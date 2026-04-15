using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2401681027_Mariela_Ganzurova
{
    public partial class Form_Shop : Form
    {
        public Form_Shop()
        {
            InitializeComponent();
        }
        public double total = 0;
        public double discount = 0;
        public string info="";
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string product = cbProduct.Text;
                switch (product)
                {
                    case "Вафла":
                        {
                            tbPrice.Text = 1.20.ToString();
                            lbProducts.Items.Add(cbProduct.Text + " - 1.20");
                            total += double.Parse(tbPrice.Text);
                            tbTotal.Text= total.ToString();
                            break;
                        }
                    case "Сирене":
                        {
                            tbPrice.Text = 9.20.ToString();
                            lbProducts.Items.Add(cbProduct.Text + " - 9.20");
                            total += double.Parse(tbPrice.Text);
                            tbTotal.Text = total.ToString();
                            break;
                        }
                    case "Кашкавал":
                        {
                            tbPrice.Text = 12.50.ToString();
                            lbProducts.Items.Add(cbProduct.Text + " - 12.50"); 
                            total += double.Parse(tbPrice.Text);
                            tbTotal.Text = total.ToString();
                            break;
                        }
                    case "Кисело мляко":
                        {
                            tbPrice.Text = 1.30.ToString();
                            lbProducts.Items.Add(cbProduct.Text + " - 1.30");
                            total += double.Parse(tbPrice.Text);
                            tbTotal.Text = total.ToString();
                            break;
                        }
                    case "Прясно мляко":
                        {
                            tbPrice.Text = 3.20.ToString();
                            lbProducts.Items.Add(cbProduct.Text + " - 3.20");
                            total += double.Parse(tbPrice.Text);
                            tbTotal.Text = total.ToString();
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Не е намерена такава стока.", "Грешка");
                            cbProduct.Text = "";
                            break;
                        }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Невалидно въведена стока.", "Грешка");
            }
        }

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string product = cbProduct.Text;
                switch (product)
                {
                    case "Вафла":
                        {
                            tbPrice.Text = 1.20.ToString();
                            break;
                        }
                    case "Сирене":
                        {
                            tbPrice.Text = 9.20.ToString();
                            break;
                        }
                    case "Кашкавал":
                        {
                            tbPrice.Text = 12.50.ToString();
                            break;
                        }
                    case "Кисело мляко":
                        {
                            tbPrice.Text = 1.30.ToString();
                            break;
                        }
                    case "Прясно мляко":
                        {
                            tbPrice.Text = 3.20.ToString();
                            break;
                        }

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Невалидно въведена стока.", "Грешка");
            }
        }

        private void btnPromoCode_Click(object sender, EventArgs e)
        {
            try
            {
                string promoCode = tbPromoCode.Text;
                if (promoCode == "PK2020")
                {
                    discount = total * 0.05;
                    total = total - discount;
                    tbTotal.Text=Math.Round(total,2).ToString();
                }
                else
                {
                    throw new Exception("Невалиден промо код!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Грешка при въвеждането на промо кода!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = true;
            lblResultInfo.Visible = true;
            string info="Продукти\n";
            info = info + string.Join(Environment.NewLine, lbProducts.Items.Cast<string>());
            info = info + $"\nОтстъпка: {Math.Round(discount,2)}\nКрайна цена: {Math.Round(total,2)}";
            lblResultInfo.Text=info;
        }

        private void Form_Shop_Load(object sender, EventArgs e)
        {

        }
    }
}
