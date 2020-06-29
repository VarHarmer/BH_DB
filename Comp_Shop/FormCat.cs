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
    public partial class FormCat : Form
    {
        public FormCat()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form formComp = new FormComp();
            formComp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formDet = new FormDet();
            formDet.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formPer = new FormPer();
            formPer.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Show();
        }
    }
}
