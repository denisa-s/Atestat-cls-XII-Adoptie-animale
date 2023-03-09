namespace Adoptie
{
    partial class Form6
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label numeLabel;
            System.Windows.Forms.Label rasaLabel;
            System.Windows.Forms.Label numar_cuscaLabel;
            System.Windows.Forms.Label culoareLabel;
            System.Windows.Forms.Label varstaLabel;
            System.Windows.Forms.Label sexulLabel;
            System.Windows.Forms.Label tipLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label afectiuneLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.înapoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inapoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adoptieDataSet = new Adoptie.AdoptieDataSet();
            this.label9 = new System.Windows.Forms.Label();
            this.adoptieDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalTableAdapter = new Adoptie.AdoptieDataSetTableAdapters.AnimalTableAdapter();
            this.tableAdapterManager = new Adoptie.AdoptieDataSetTableAdapters.TableAdapterManager();
            this.numeTextBox = new System.Windows.Forms.TextBox();
            this.rasaTextBox = new System.Windows.Forms.TextBox();
            this.numar_cuscaTextBox = new System.Windows.Forms.TextBox();
            this.culoareTextBox = new System.Windows.Forms.TextBox();
            this.varstaTextBox = new System.Windows.Forms.TextBox();
            this.sexulTextBox = new System.Windows.Forms.TextBox();
            this.tipTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.animalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.fisa_medicalaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fisa_medicalaTableAdapter = new Adoptie.AdoptieDataSetTableAdapters.Fisa_medicalaTableAdapter();
            this.afectiuneTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            numeLabel = new System.Windows.Forms.Label();
            rasaLabel = new System.Windows.Forms.Label();
            numar_cuscaLabel = new System.Windows.Forms.Label();
            culoareLabel = new System.Windows.Forms.Label();
            varstaLabel = new System.Windows.Forms.Label();
            sexulLabel = new System.Windows.Forms.Label();
            tipLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            afectiuneLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adoptieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adoptieDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fisa_medicalaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // numeLabel
            // 
            numeLabel.AutoSize = true;
            numeLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numeLabel.Location = new System.Drawing.Point(56, 80);
            numeLabel.Name = "numeLabel";
            numeLabel.Size = new System.Drawing.Size(61, 22);
            numeLabel.TabIndex = 20;
            numeLabel.Text = "Nume:";
            // 
            // rasaLabel
            // 
            rasaLabel.AutoSize = true;
            rasaLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rasaLabel.Location = new System.Drawing.Point(56, 120);
            rasaLabel.Name = "rasaLabel";
            rasaLabel.Size = new System.Drawing.Size(53, 22);
            rasaLabel.TabIndex = 21;
            rasaLabel.Text = "Rasă:";
            // 
            // numar_cuscaLabel
            // 
            numar_cuscaLabel.AutoSize = true;
            numar_cuscaLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numar_cuscaLabel.Location = new System.Drawing.Point(56, 160);
            numar_cuscaLabel.Name = "numar_cuscaLabel";
            numar_cuscaLabel.Size = new System.Drawing.Size(118, 22);
            numar_cuscaLabel.TabIndex = 22;
            numar_cuscaLabel.Text = "Număr cușcă:";
            // 
            // culoareLabel
            // 
            culoareLabel.AutoSize = true;
            culoareLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            culoareLabel.Location = new System.Drawing.Point(56, 200);
            culoareLabel.Name = "culoareLabel";
            culoareLabel.Size = new System.Drawing.Size(76, 22);
            culoareLabel.TabIndex = 23;
            culoareLabel.Text = "Culoare:";
            // 
            // varstaLabel
            // 
            varstaLabel.AutoSize = true;
            varstaLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            varstaLabel.Location = new System.Drawing.Point(56, 240);
            varstaLabel.Name = "varstaLabel";
            varstaLabel.Size = new System.Drawing.Size(68, 22);
            varstaLabel.TabIndex = 24;
            varstaLabel.Text = "Vârstă:";
            // 
            // sexulLabel
            // 
            sexulLabel.AutoSize = true;
            sexulLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sexulLabel.Location = new System.Drawing.Point(56, 280);
            sexulLabel.Name = "sexulLabel";
            sexulLabel.Size = new System.Drawing.Size(60, 22);
            sexulLabel.TabIndex = 25;
            sexulLabel.Text = "Sexul:";
            // 
            // tipLabel
            // 
            tipLabel.AutoSize = true;
            tipLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipLabel.Location = new System.Drawing.Point(56, 320);
            tipLabel.Name = "tipLabel";
            tipLabel.Size = new System.Drawing.Size(42, 22);
            tipLabel.TabIndex = 27;
            tipLabel.Text = "Tip:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDLabel.Location = new System.Drawing.Point(56, 40);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(38, 22);
            iDLabel.TabIndex = 30;
            iDLabel.Text = "ID:";
            iDLabel.Click += new System.EventHandler(this.IDLabel_Click);
            // 
            // afectiuneLabel
            // 
            afectiuneLabel.AutoSize = true;
            afectiuneLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            afectiuneLabel.Location = new System.Drawing.Point(56, 360);
            afectiuneLabel.Name = "afectiuneLabel";
            afectiuneLabel.Size = new System.Drawing.Size(92, 22);
            afectiuneLabel.TabIndex = 35;
            afectiuneLabel.Text = "Afectiune:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.înapoiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(657, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // înapoiToolStripMenuItem
            // 
            this.înapoiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inapoiToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.înapoiToolStripMenuItem.Name = "înapoiToolStripMenuItem";
            this.înapoiToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.înapoiToolStripMenuItem.Text = "Opțiuni";
            this.înapoiToolStripMenuItem.Click += new System.EventHandler(this.ÎnapoiToolStripMenuItem_Click);
            // 
            // inapoiToolStripMenuItem
            // 
            this.inapoiToolStripMenuItem.Name = "inapoiToolStripMenuItem";
            this.inapoiToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.inapoiToolStripMenuItem.Text = "Înapoi";
            this.inapoiToolStripMenuItem.Click += new System.EventHandler(this.InapoiToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.iesireToolStripMenuItem.Text = "Ieșire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.IesireToolStripMenuItem_Click);
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "Animal";
            this.animalBindingSource.DataSource = this.adoptieDataSet;
            // 
            // adoptieDataSet
            // 
            this.adoptieDataSet.DataSetName = "AdoptieDataSet";
            this.adoptieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(315, 673);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(330, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "\"Dogs are not our whole life, but they make our lives whole.\"";
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // adoptieDataSetBindingSource
            // 
            this.adoptieDataSetBindingSource.DataSource = this.adoptieDataSet;
            this.adoptieDataSetBindingSource.Position = 0;
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AngajatTableAdapter = null;
            this.tableAdapterManager.AnimalTableAdapter = this.animalTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Cerere_AdoptieTableAdapter = null;
            this.tableAdapterManager.Fisa_medicalaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Adoptie.AdoptieDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VizitatorTableAdapter = null;
            // 
            // numeTextBox
            // 
            this.numeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "Nume", true));
            this.numeTextBox.Location = new System.Drawing.Point(229, 80);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(100, 20);
            this.numeTextBox.TabIndex = 21;
            // 
            // rasaTextBox
            // 
            this.rasaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "Rasa", true));
            this.rasaTextBox.Location = new System.Drawing.Point(229, 120);
            this.rasaTextBox.Name = "rasaTextBox";
            this.rasaTextBox.Size = new System.Drawing.Size(100, 20);
            this.rasaTextBox.TabIndex = 22;
            // 
            // numar_cuscaTextBox
            // 
            this.numar_cuscaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "Numar_cusca", true));
            this.numar_cuscaTextBox.Location = new System.Drawing.Point(229, 161);
            this.numar_cuscaTextBox.Name = "numar_cuscaTextBox";
            this.numar_cuscaTextBox.Size = new System.Drawing.Size(100, 20);
            this.numar_cuscaTextBox.TabIndex = 23;
            // 
            // culoareTextBox
            // 
            this.culoareTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "Culoare", true));
            this.culoareTextBox.Location = new System.Drawing.Point(229, 202);
            this.culoareTextBox.Name = "culoareTextBox";
            this.culoareTextBox.Size = new System.Drawing.Size(100, 20);
            this.culoareTextBox.TabIndex = 24;
            // 
            // varstaTextBox
            // 
            this.varstaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "Varsta", true));
            this.varstaTextBox.Location = new System.Drawing.Point(229, 242);
            this.varstaTextBox.Name = "varstaTextBox";
            this.varstaTextBox.Size = new System.Drawing.Size(100, 20);
            this.varstaTextBox.TabIndex = 25;
            // 
            // sexulTextBox
            // 
            this.sexulTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "Sexul", true));
            this.sexulTextBox.Location = new System.Drawing.Point(229, 283);
            this.sexulTextBox.Name = "sexulTextBox";
            this.sexulTextBox.Size = new System.Drawing.Size(100, 20);
            this.sexulTextBox.TabIndex = 26;
            // 
            // tipTextBox
            // 
            this.tipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "Tip", true));
            this.tipTextBox.Location = new System.Drawing.Point(229, 322);
            this.tipTextBox.Name = "tipTextBox";
            this.tipTextBox.Size = new System.Drawing.Size(100, 20);
            this.tipTextBox.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(229, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 32);
            this.button1.TabIndex = 29;
            this.button1.Text = "Inserează";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(442, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 27);
            this.button2.TabIndex = 30;
            this.button2.Text = "Șterge";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(229, 40);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 31;
            this.iDTextBox.TextChanged += new System.EventHandler(this.IDTextBox_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.animalBindingSource1;
            this.comboBox1.DisplayMember = "ID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(420, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // animalBindingSource1
            // 
            this.animalBindingSource1.DataMember = "Animal";
            this.animalBindingSource1.DataSource = this.adoptieDataSet;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-78, 536);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(257, 205);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // fisa_medicalaBindingSource
            // 
            this.fisa_medicalaBindingSource.DataMember = "Fisa_medicala";
            this.fisa_medicalaBindingSource.DataSource = this.adoptieDataSet;
            // 
            // fisa_medicalaTableAdapter
            // 
            this.fisa_medicalaTableAdapter.ClearBeforeFill = true;
            // 
            // afectiuneTextBox
            // 
            this.afectiuneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fisa_medicalaBindingSource, "Afectiune", true));
            this.afectiuneTextBox.Location = new System.Drawing.Point(229, 362);
            this.afectiuneTextBox.Name = "afectiuneTextBox";
            this.afectiuneTextBox.Size = new System.Drawing.Size(100, 20);
            this.afectiuneTextBox.TabIndex = 36;
            this.afectiuneTextBox.TextChanged += new System.EventHandler(this.AfectiuneTextBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(657, 694);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(657, 694);
            this.Controls.Add(afectiuneLabel);
            this.Controls.Add(this.afectiuneTextBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(tipLabel);
            this.Controls.Add(this.tipTextBox);
            this.Controls.Add(sexulLabel);
            this.Controls.Add(this.sexulTextBox);
            this.Controls.Add(varstaLabel);
            this.Controls.Add(this.varstaTextBox);
            this.Controls.Add(culoareLabel);
            this.Controls.Add(this.culoareTextBox);
            this.Controls.Add(numar_cuscaLabel);
            this.Controls.Add(this.numar_cuscaTextBox);
            this.Controls.Add(rasaLabel);
            this.Controls.Add(this.rasaTextBox);
            this.Controls.Add(numeLabel);
            this.Controls.Add(this.numeTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adoptieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adoptieDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fisa_medicalaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Form2 f2;
        public Form3 f3;
        public Form4 f4;
        public Form5 f5;
        public Form6 f1;
        public Form7 f7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem înapoiToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem inapoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.BindingSource adoptieDataSetBindingSource;
        private AdoptieDataSet adoptieDataSet;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private AdoptieDataSetTableAdapters.AnimalTableAdapter animalTableAdapter;
        private AdoptieDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox numeTextBox;
        private System.Windows.Forms.TextBox rasaTextBox;
        private System.Windows.Forms.TextBox numar_cuscaTextBox;
        private System.Windows.Forms.TextBox culoareTextBox;
        private System.Windows.Forms.TextBox varstaTextBox;
        private System.Windows.Forms.TextBox sexulTextBox;
        private System.Windows.Forms.TextBox tipTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource animalBindingSource1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.BindingSource fisa_medicalaBindingSource;
        private AdoptieDataSetTableAdapters.Fisa_medicalaTableAdapter fisa_medicalaTableAdapter;
        private System.Windows.Forms.TextBox afectiuneTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}