using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meeting5_Task2
{
    public partial class MainForm : Form
    {
        private List<Accessories> accessories;
        private object[] obj;
        public MainForm()
        {
            accessories = new List<Accessories>();

            accessories.Add(
                new Accessories()
                {
                    Name = "Материнская плата",
                    Price = 50000
                });
            accessories.Add(
                new Accessories()
                {
                    Name = "Процессор",
                    Price = 60000
                });
            accessories.Add(
                new Accessories()
                {
                    Name = "Монитор",
                    Price = 25000
                });
            accessories.Add(
                new Accessories()
                {
                    Name = "Клавиатура",
                    Price = 3500
                });
            accessories.Add(
                new Accessories()
                {
                    Name = "Мышка",
                    Price = 1000
                });

            obj = new object[accessories.Count];

            for (int i = 0; i < accessories.Count; i++)
            {
                obj[i] = accessories[i].Name;
            }

            InitializeComponent();

            comboBox.Items.AddRange(obj);
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            listBox.Items.Add(comboBox.Text);
            int totalPrice = Int32.Parse(totalPriceLabel.Text);
            int onePrice = Int32.Parse(priceTextBox.Text);
            totalPrice += onePrice;
            totalPriceLabel.Text = totalPrice.ToString();
        }

        private void СomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            priceTextBox.Text = accessories.ElementAt((sender as ComboBox).SelectedIndex).Price.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            comboBox.ResetText();
            listBox.ResetText();
            priceTextBox.Clear();
            totalPriceLabel.Text = "0";
        }
    }
}
