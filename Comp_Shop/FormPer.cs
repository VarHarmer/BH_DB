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
    public partial class FormPer : Form
    {
        public FormPer()
        {
            InitializeComponent();
            ShowItem();
        }

        private void listViewItemsPer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void ShowItem()
        {
            listViewItemsPer.Items.Clear();
            foreach (Personal pers in Program.buhgalter.Personal)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    pers.Last, pers.Name, pers.Middle , pers.Phone ,
                    pers.Dol, pers.Price
                });
                item.Tag = pers;
                listViewItemsPer.Items.Add(item);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            if (textBoxLast.Text == "" && textBoxName.Text == "" && textBoxMiddle.Text == "" && textBoxPhone.Text == "" && textBoxDol.Text == "" && textBoxPrice.Text == "")
            {
                MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Personal pers = new Personal();
                pers.Last = textBoxLast.Text;
                pers.Name = textBoxName.Text;
                pers.Middle = textBoxMiddle.Text;
                pers.Phone = textBoxPhone.Text;
                pers.Dol = textBoxDol.Text;
                pers.Price = textBoxPrice.Text;
                Program.buhgalter.Personal.Add(pers);
                Program.buhgalter.SaveChanges();
                FormPer formPer = new FormPer();
                formPer.Show();
                this.Hide();
            }
        }
    }
}
