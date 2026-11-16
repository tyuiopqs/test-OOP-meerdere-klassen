namespace test_OOP_meerdere_klassen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnFactuur = new Button();
            btnFactuurlijn = new Button();
            txtFactuurID = new TextBox();
            txtNaamKlant = new TextBox();
            txtKlantnummer = new TextBox();
            txtPrijs = new TextBox();
            txtAantal = new TextBox();
            txtProduct = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lblFactuurtotaal = new Label();
            lstFactuur = new ListBox();
            lstFactuurlijn = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 24);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 0;
            label1.Text = "Factuur";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(371, 24);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Factuurlijn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 77);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 2;
            label3.Text = "FactuurID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 126);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 3;
            label4.Text = "Naam klant:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 175);
            label5.Name = "label5";
            label5.Size = new Size(122, 25);
            label5.TabIndex = 4;
            label5.Text = "Klantnummer:";
            // 
            // btnFactuur
            // 
            btnFactuur.Location = new Point(23, 224);
            btnFactuur.Name = "btnFactuur";
            btnFactuur.Size = new Size(289, 34);
            btnFactuur.TabIndex = 8;
            btnFactuur.Text = "Maak factuur aan";
            btnFactuur.UseVisualStyleBackColor = true;
            btnFactuur.Click += button1_Click;
            // 
            // btnFactuurlijn
            // 
            btnFactuurlijn.Location = new Point(371, 224);
            btnFactuurlijn.Name = "btnFactuurlijn";
            btnFactuurlijn.Size = new Size(244, 34);
            btnFactuurlijn.TabIndex = 9;
            btnFactuurlijn.Text = "Maak factuurlijn aan";
            btnFactuurlijn.UseVisualStyleBackColor = true;
            btnFactuurlijn.Click += btnFactuurlijn_Click;
            // 
            // txtFactuurID
            // 
            txtFactuurID.Location = new Point(162, 71);
            txtFactuurID.Name = "txtFactuurID";
            txtFactuurID.Size = new Size(150, 31);
            txtFactuurID.TabIndex = 10;
            // 
            // txtNaamKlant
            // 
            txtNaamKlant.Location = new Point(162, 120);
            txtNaamKlant.Name = "txtNaamKlant";
            txtNaamKlant.Size = new Size(150, 31);
            txtNaamKlant.TabIndex = 11;
            // 
            // txtKlantnummer
            // 
            txtKlantnummer.Location = new Point(162, 169);
            txtKlantnummer.Name = "txtKlantnummer";
            txtKlantnummer.Size = new Size(150, 31);
            txtKlantnummer.TabIndex = 12;
            // 
            // txtPrijs
            // 
            txtPrijs.Location = new Point(465, 169);
            txtPrijs.Name = "txtPrijs";
            txtPrijs.Size = new Size(150, 31);
            txtPrijs.TabIndex = 18;
            // 
            // txtAantal
            // 
            txtAantal.Location = new Point(465, 120);
            txtAantal.Name = "txtAantal";
            txtAantal.Size = new Size(150, 31);
            txtAantal.TabIndex = 17;
            // 
            // txtProduct
            // 
            txtProduct.Location = new Point(465, 71);
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(150, 31);
            txtProduct.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(371, 172);
            label6.Name = "label6";
            label6.Size = new Size(48, 25);
            label6.TabIndex = 15;
            label6.Text = "Prijs:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(371, 123);
            label7.Name = "label7";
            label7.Size = new Size(66, 25);
            label7.TabIndex = 14;
            label7.Text = "Aantal:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(371, 74);
            label8.Name = "label8";
            label8.Size = new Size(78, 25);
            label8.TabIndex = 13;
            label8.Text = "Product:";
            // 
            // lblFactuurtotaal
            // 
            lblFactuurtotaal.AutoSize = true;
            lblFactuurtotaal.Location = new Point(23, 466);
            lblFactuurtotaal.Name = "lblFactuurtotaal";
            lblFactuurtotaal.Size = new Size(118, 25);
            lblFactuurtotaal.TabIndex = 19;
            lblFactuurtotaal.Text = "Factuurtotaal:";
            // 
            // lstFactuur
            // 
            lstFactuur.FormattingEnabled = true;
            lstFactuur.Location = new Point(23, 273);
            lstFactuur.Name = "lstFactuur";
            lstFactuur.Size = new Size(289, 179);
            lstFactuur.TabIndex = 20;
            lstFactuur.SelectedIndexChanged += lstFactuur_SelectedIndexChanged;
            // 
            // lstFactuurlijn
            // 
            lstFactuurlijn.FormattingEnabled = true;
            lstFactuurlijn.Location = new Point(371, 273);
            lstFactuurlijn.Name = "lstFactuurlijn";
            lstFactuurlijn.Size = new Size(417, 179);
            lstFactuurlijn.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 518);
            Controls.Add(lstFactuurlijn);
            Controls.Add(lstFactuur);
            Controls.Add(lblFactuurtotaal);
            Controls.Add(txtPrijs);
            Controls.Add(txtAantal);
            Controls.Add(txtProduct);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(txtKlantnummer);
            Controls.Add(txtNaamKlant);
            Controls.Add(txtFactuurID);
            Controls.Add(btnFactuurlijn);
            Controls.Add(btnFactuur);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnFactuur;
        private Button btnFactuurlijn;
        private TextBox txtFactuurID;
        private TextBox txtNaamKlant;
        private TextBox txtKlantnummer;
        private TextBox txtPrijs;
        private TextBox txtAantal;
        private TextBox txtProduct;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lblFactuurtotaal;
        private ListBox lstFactuur;
        private ListBox lstFactuurlijn;
    }
}
