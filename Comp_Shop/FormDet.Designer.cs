namespace Comp_Shop
{
    partial class FormDet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.listViewItemsDet = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.textBoxTrat = new System.Windows.Forms.TextBox();
            this.textBoxDoh = new System.Windows.Forms.TextBox();
            this.comboBoxVisa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOst = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listViewItemsDet
            // 
            this.listViewItemsDet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewItemsDet.FullRowSelect = true;
            this.listViewItemsDet.GridLines = true;
            this.listViewItemsDet.HideSelection = false;
            this.listViewItemsDet.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewItemsDet.Location = new System.Drawing.Point(12, 12);
            this.listViewItemsDet.MultiSelect = false;
            this.listViewItemsDet.Name = "listViewItemsDet";
            this.listViewItemsDet.Size = new System.Drawing.Size(499, 307);
            this.listViewItemsDet.TabIndex = 1;
            this.listViewItemsDet.UseCompatibleStateImageBehavior = false;
            this.listViewItemsDet.View = System.Windows.Forms.View.Details;
            this.listViewItemsDet.SelectedIndexChanged += new System.EventHandler(this.listViewItemsDet_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Счет";
            this.columnHeader1.Width = 152;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Доход";
            this.columnHeader2.Width = 108;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Траты";
            this.columnHeader3.Width = 119;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Остаток";
            this.columnHeader4.Width = 116;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Red;
            this.buttonClose.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold);
            this.buttonClose.Location = new System.Drawing.Point(529, 274);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(138, 45);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.BackColor = System.Drawing.Color.Lime;
            this.buttonOrder.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold);
            this.buttonOrder.Location = new System.Drawing.Point(529, 223);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(138, 45);
            this.buttonOrder.TabIndex = 3;
            this.buttonOrder.Text = "Добавить";
            this.buttonOrder.UseVisualStyleBackColor = false;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // textBoxTrat
            // 
            this.textBoxTrat.Location = new System.Drawing.Point(529, 104);
            this.textBoxTrat.Name = "textBoxTrat";
            this.textBoxTrat.Size = new System.Drawing.Size(138, 20);
            this.textBoxTrat.TabIndex = 6;
            // 
            // textBoxDoh
            // 
            this.textBoxDoh.Location = new System.Drawing.Point(529, 67);
            this.textBoxDoh.Name = "textBoxDoh";
            this.textBoxDoh.Size = new System.Drawing.Size(138, 20);
            this.textBoxDoh.TabIndex = 7;
            // 
            // comboBoxVisa
            // 
            this.comboBoxVisa.FormattingEnabled = true;
            this.comboBoxVisa.Items.AddRange(new object[] {
            "Visa Сбербанк",
            "Наличные",
            "Счет в банке",
            "Сейф"});
            this.comboBoxVisa.Location = new System.Drawing.Point(529, 27);
            this.comboBoxVisa.Name = "comboBoxVisa";
            this.comboBoxVisa.Size = new System.Drawing.Size(138, 21);
            this.comboBoxVisa.TabIndex = 8;
            this.comboBoxVisa.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Счет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Доход";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Траты";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(526, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Остаток";
            // 
            // textBoxOst
            // 
            this.textBoxOst.Location = new System.Drawing.Point(529, 144);
            this.textBoxOst.Name = "textBoxOst";
            this.textBoxOst.Size = new System.Drawing.Size(138, 20);
            this.textBoxOst.TabIndex = 12;
            // 
            // FormDet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 339);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxOst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxVisa);
            this.Controls.Add(this.textBoxDoh);
            this.Controls.Add(this.textBoxTrat);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.listViewItemsDet);
            this.Name = "FormDet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бухгалтерия 1.0 - Счета";
            this.Load += new System.EventHandler(this.FormDet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewItemsDet;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.TextBox textBoxTrat;
        private System.Windows.Forms.TextBox textBoxDoh;
        private System.Windows.Forms.ComboBox comboBoxVisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxOst;
    }
}