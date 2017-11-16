namespace bazadanych
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblImie = new System.Windows.Forms.Label();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Nazwisko = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.nr_tel = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.Adres = new System.Windows.Forms.Label();
            this.comboBoxplec = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBoxlogo = new System.Windows.Forms.PictureBox();
            this.search = new System.Windows.Forms.Label();
            this.textBoxsearche = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.BackColor = System.Drawing.Color.Transparent;
            this.lblImie.Cursor = System.Windows.Forms.Cursors.No;
            this.lblImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImie.Location = new System.Drawing.Point(8, 122);
            this.lblImie.Name = "lblImie";
            this.lblImie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblImie.Size = new System.Drawing.Size(39, 20);
            this.lblImie.TabIndex = 1;
            this.lblImie.Text = "Imię";
            this.lblImie.Click += new System.EventHandler(this.lblContactID_Click);
            // 
            // textBoxImie
            // 
            this.textBoxImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxImie.Location = new System.Drawing.Point(109, 116);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(170, 26);
            this.textBoxImie.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(109, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 26);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(8, 78);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(109, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 26);
            this.textBox2.TabIndex = 6;
            // 
            // Nazwisko
            // 
            this.Nazwisko.AutoSize = true;
            this.Nazwisko.BackColor = System.Drawing.Color.Transparent;
            this.Nazwisko.Cursor = System.Windows.Forms.Cursors.No;
            this.Nazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Nazwisko.Location = new System.Drawing.Point(8, 171);
            this.Nazwisko.Name = "Nazwisko";
            this.Nazwisko.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Nazwisko.Size = new System.Drawing.Size(76, 20);
            this.Nazwisko.TabIndex = 5;
            this.Nazwisko.Text = "Nazwisko";
            this.Nazwisko.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.Location = new System.Drawing.Point(109, 214);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(170, 26);
            this.textBox3.TabIndex = 8;
            // 
            // nr_tel
            // 
            this.nr_tel.AutoSize = true;
            this.nr_tel.BackColor = System.Drawing.Color.Transparent;
            this.nr_tel.Cursor = System.Windows.Forms.Cursors.No;
            this.nr_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nr_tel.Location = new System.Drawing.Point(8, 220);
            this.nr_tel.Name = "nr_tel";
            this.nr_tel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nr_tel.Size = new System.Drawing.Size(91, 20);
            this.nr_tel.TabIndex = 7;
            this.nr_tel.Text = "Nr Telefonu";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxID.Location = new System.Drawing.Point(109, 265);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(170, 37);
            this.textBoxID.TabIndex = 12;
            // 
            // Adres
            // 
            this.Adres.AutoSize = true;
            this.Adres.BackColor = System.Drawing.Color.Transparent;
            this.Adres.Cursor = System.Windows.Forms.Cursors.No;
            this.Adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Adres.Location = new System.Drawing.Point(8, 271);
            this.Adres.Name = "Adres";
            this.Adres.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Adres.Size = new System.Drawing.Size(51, 20);
            this.Adres.TabIndex = 11;
            this.Adres.Text = "Adres";
            this.Adres.Click += new System.EventHandler(this.Adres_Click);
            // 
            // comboBoxplec
            // 
            this.comboBoxplec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxplec.FormattingEnabled = true;
            this.comboBoxplec.Items.AddRange(new object[] {
            "Kobieta",
            "Mężczyzna"});
            this.comboBoxplec.Location = new System.Drawing.Point(109, 319);
            this.comboBoxplec.Name = "comboBoxplec";
            this.comboBoxplec.Size = new System.Drawing.Size(121, 28);
            this.comboBoxplec.TabIndex = 13;
            this.comboBoxplec.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(11, 320);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Płeć";
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnADD.ForeColor = System.Drawing.Color.Red;
            this.btnADD.Location = new System.Drawing.Point(136, 408);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(90, 46);
            this.btnADD.TabIndex = 15;
            this.btnADD.Text = "Dodaj";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Maroon;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpdate.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnUpdate.Location = new System.Drawing.Point(245, 408);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 46);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DimGray;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClear.Location = new System.Drawing.Point(467, 408);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 46);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gold;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnDelete.Location = new System.Drawing.Point(357, 408);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 46);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(357, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(471, 266);
            this.dataGridView1.TabIndex = 19;
            // 
            // pictureBoxlogo
            // 
            this.pictureBoxlogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxlogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxlogo.Image")));
            this.pictureBoxlogo.Location = new System.Drawing.Point(12, -1);
            this.pictureBoxlogo.Name = "pictureBoxlogo";
            this.pictureBoxlogo.Size = new System.Drawing.Size(66, 66);
            this.pictureBoxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxlogo.TabIndex = 0;
            this.pictureBoxlogo.TabStop = false;
            this.pictureBoxlogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.BackColor = System.Drawing.Color.Transparent;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.search.Location = new System.Drawing.Point(354, 83);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(57, 20);
            this.search.TabIndex = 20;
            this.search.Text = "Szukaj";
            // 
            // textBoxsearche
            // 
            this.textBoxsearche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxsearche.Location = new System.Drawing.Point(418, 82);
            this.textBoxsearche.Name = "textBoxsearche";
            this.textBoxsearche.Size = new System.Drawing.Size(306, 26);
            this.textBoxsearche.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(805, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 50);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(865, 502);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxsearche);
            this.Controls.Add(this.search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxplec);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.nr_tel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Nazwisko);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.lblImie);
            this.Controls.Add(this.pictureBoxlogo);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Econtac";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Nazwisko;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label nr_tel;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label Adres;
        private System.Windows.Forms.ComboBox comboBoxplec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBoxlogo;
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.TextBox textBoxsearche;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

