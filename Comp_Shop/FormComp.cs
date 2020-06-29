using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp_Shop
{
    public partial class FormComp : Form
    {
        public FormComp()
        {
            InitializeComponent();
            ShowItem();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void ShowItem()
        {
            listViewItems.Items.Clear();
            foreach (Buy buy in Program.buhgalter.Buy)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    buy.Date, buy.Item,
                    buy.Count, buy.Price
                });
                item.Tag = buy;
                listViewItems.Items.Add(item);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {

            if (textBoxDate.Text == "" && textBoxItem.Text == "" && textBoxCount.Text == "" && textBoxPrice.Text == "")
            {
                MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Buy buy = new Buy();
                buy.Date = textBoxDate.Text;
                buy.Item = textBoxItem.Text;
                buy.Count = textBoxCount.Text;
                buy.Price = textBoxPrice.Text;
                Program.buhgalter.Buy.Add(buy);
                Program.buhgalter.SaveChanges();
                FormComp formComp = new FormComp();
                formComp.Show();
                this.Hide();
            }
        }
    }
}
