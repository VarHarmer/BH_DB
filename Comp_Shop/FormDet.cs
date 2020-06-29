using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp_Shop
{
    public partial class FormDet : Form
    {
        public FormDet()
        {
            InitializeComponent();
            ShowItem();
        }

        void ShowItem()
        {
            listViewItemsDet.Items.Clear();
            foreach (Visa visa in Program.buhgalter.Visa)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    visa.visa1, visa.Doh,
                    visa.Trat, visa.Ost
                });
                item.Tag = visa;
                listViewItemsDet.Items.Add(item);
            }
        }

        private void listViewItemsDet_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            if (comboBoxVisa.Text == "" && textBoxDoh.Text == "" && textBoxTrat.Text == "" && textBoxOst.Text == "")
            {
                MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Visa visa = new Visa();
                visa.visa1 = comboBoxVisa.Text;
                visa.Doh = textBoxDoh.Text;
                visa.Trat = textBoxTrat.Text;
                visa.Ost = textBoxOst.Text;
                Program.buhgalter.Visa.Add(visa);
                Program.buhgalter.SaveChanges();
                FormDet formDet = new FormDet();
                formDet.Show();
                this.Hide();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormDet_Load(object sender, EventArgs e)
        {

        }
    }
}
