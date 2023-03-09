namespace Adoptie
{
    partial class Form7
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
            System.Windows.Forms.Label iD_animalLabel;
            System.Windows.Forms.Label localitateLabel;
            System.Windows.Forms.Label stradaLabel;
            System.Windows.Forms.Label cNPLabel;
            System.Windows.Forms.Label data_afectiuniiLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label afectiuneLabel;
            System.Windows.Forms.Label telefonLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cerere_AdoptieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adoptieDataSet = new Adoptie.AdoptieDataSet();
            this.cerere_AdoptieTableAdapter = new Adoptie.AdoptieDataSetTableAdapters.Cerere_AdoptieTableAdapter();
            this.tableAdapterManager = new Adoptie.AdoptieDataSetTableAdapters.TableAdapterManager();
            this.vizitatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vizitatorTableAdapter = new Adoptie.AdoptieDataSetTableAdapters.VizitatorTableAdapter();
            this.localitateTextBox = new System.Windows.Forms.TextBox();
            this.stradaTextBox = new System.Windows.Forms.TextBox();
            this.cNPTextBox = new System.Windows.Forms.TextBox();
            this.fisa_medicalaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fisa_medicalaTableAdapter = new Adoptie.AdoptieDataSetTableAdapters.Fisa_medicalaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fisamedicalaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data_afectiuniiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.afectiuneTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            iD_animalLabel = new System.Windows.Forms.Label();
            localitateLabel = new System.Windows.Forms.Label();
            stradaLabel = new System.Windows.Forms.Label();
            cNPLabel = new System.Windows.Forms.Label();
            data_afectiuniiLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            afectiuneLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerere_AdoptieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adoptieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vizitatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fisa_medicalaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fisamedicalaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_animalLabel
            // 
            iD_animalLabel.AutoSize = true;
            iD_animalLabel.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_animalLabel.Location = new System.Drawing.Point(54, 78);
            iD_animalLabel.Name = "iD_animalLabel";
            iD_animalLabel.Size = new System.Drawing.Size(70, 18);
            iD_animalLabel.TabIndex = 3;
            iD_animalLabel.Text = "ID animal:";
            // 
            // localitateLabel
            // 
            localitateLabel.AutoSize = true;
            localitateLabel.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            localitateLabel.Location = new System.Drawing.Point(68, 243);
            localitateLabel.Name = "localitateLabel";
            localitateLabel.Size = new System.Drawing.Size(68, 18);
            localitateLabel.TabIndex = 8;
            localitateLabel.Text = "Localitate:";
            // 
            // stradaLabel
            // 
            stradaLabel.AutoSize = true;
            stradaLabel.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stradaLabel.Location = new System.Drawing.Point(68, 286);
            stradaLabel.Name = "stradaLabel";
            stradaLabel.Size = new System.Drawing.Size(49, 18);
            stradaLabel.TabIndex = 10;
            stradaLabel.Text = "Strada:";
            // 
            // cNPLabel
            // 
            cNPLabel.AutoSize = true;
            cNPLabel.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cNPLabel.Location = new System.Drawing.Point(54, 199);
            cNPLabel.Name = "cNPLabel";
            cNPLabel.Size = new System.Drawing.Size(39, 18);
            cNPLabel.TabIndex = 12;
            cNPLabel.Text = "CNP:";
            // 
            // data_afectiuniiLabel
            // 
            data_afectiuniiLabel.AutoSize = true;
            data_afectiuniiLabel.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_afectiuniiLabel.Location = new System.Drawing.Point(68, 158);
            data_afectiuniiLabel.Name = "data_afectiuniiLabel";
            data_afectiuniiLabel.Size = new System.Drawing.Size(96, 18);
            data_afectiuniiLabel.TabIndex = 25;
            data_afectiuniiLabel.Text = "Data afecțiunii:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataLabel.Location = new System.Drawing.Point(54, 382);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(40, 18);
            dataLabel.TabIndex = 26;
            dataLabel.Text = "Data:";
            // 
            // afectiuneLabel
            // 
            afectiuneLabel.AutoSize = true;
            afectiuneLabel.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            afectiuneLabel.Location = new System.Drawing.Point(68, 121);
            afectiuneLabel.Name = "afectiuneLabel";
            afectiuneLabel.Size = new System.Drawing.Size(68, 18);
            afectiuneLabel.TabIndex = 29;
            afectiuneLabel.Text = "Afectiune:";
            afectiuneLabel.Click += new System.EventHandler(this.AfectiuneLabel_Click);
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefonLabel.Location = new System.Drawing.Point(68, 332);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(54, 18);
            telefonLabel.TabIndex = 33;
            telefonLabel.Text = "Telefon:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cerere adopție";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(580, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iesireToolStripMenuItem,
            this.iesireToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.fileToolStripMenuItem.Text = "Opțiuni";
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.iesireToolStripMenuItem.Text = "Înapoi";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.IesireToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem1
            // 
            this.iesireToolStripMenuItem1.Name = "iesireToolStripMenuItem1";
            this.iesireToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.iesireToolStripMenuItem1.Text = "Ieșire";
            this.iesireToolStripMenuItem1.Click += new System.EventHandler(this.IesireToolStripMenuItem1_Click);
            // 
            // cerere_AdoptieBindingSource
            // 
            this.cerere_AdoptieBindingSource.DataMember = "Cerere_Adoptie";
            this.cerere_AdoptieBindingSource.DataSource = this.adoptieDataSet;
            // 
            // adoptieDataSet
            // 
            this.adoptieDataSet.DataSetName = "AdoptieDataSet";
            this.adoptieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cerere_AdoptieTableAdapter
            // 
            this.cerere_AdoptieTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AngajatTableAdapter = null;
            this.tableAdapterManager.AnimalTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Cerere_AdoptieTableAdapter = this.cerere_AdoptieTableAdapter;
            this.tableAdapterManager.Fisa_medicalaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Adoptie.AdoptieDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VizitatorTableAdapter = null;
            // 
            // vizitatorBindingSource
            // 
            this.vizitatorBindingSource.DataMember = "Vizitator";
            this.vizitatorBindingSource.DataSource = this.adoptieDataSet;
            // 
            // vizitatorTableAdapter
            // 
            this.vizitatorTableAdapter.ClearBeforeFill = true;
            // 
            // localitateTextBox
            // 
            this.localitateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vizitatorBindingSource, "Localitate", true));
            this.localitateTextBox.Location = new System.Drawing.Point(235, 236);
            this.localitateTextBox.Name = "localitateTextBox";
            this.localitateTextBox.Size = new System.Drawing.Size(100, 20);
            this.localitateTextBox.TabIndex = 9;
            // 
            // stradaTextBox
            // 
            this.stradaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vizitatorBindingSource, "Strada", true));
            this.stradaTextBox.Location = new System.Drawing.Point(235, 279);
            this.stradaTextBox.Name = "stradaTextBox";
            this.stradaTextBox.Size = new System.Drawing.Size(100, 20);
            this.stradaTextBox.TabIndex = 11;
            // 
            // cNPTextBox
            // 
            this.cNPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vizitatorBindingSource, "CNP", true));
            this.cNPTextBox.Location = new System.Drawing.Point(235, 192);
            this.cNPTextBox.Name = "cNPTextBox";
            this.cNPTextBox.Size = new System.Drawing.Size(100, 20);
            this.cNPTextBox.TabIndex = 13;
            this.cNPTextBox.TextChanged += new System.EventHandler(this.CNPTextBox_TextChanged);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(266, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 47);
            this.button1.TabIndex = 21;
            this.button1.Text = "Finalizează adopția";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(446, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 28);
            this.button2.TabIndex = 22;
            this.button2.Text = "Afișează";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // fisamedicalaBindingSource
            // 
            this.fisamedicalaBindingSource.DataMember = "Fisa_medicala";
            this.fisamedicalaBindingSource.DataSource = this.adoptieDataSet;
            // 
            // data_afectiuniiDateTimePicker
            // 
            this.data_afectiuniiDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.fisa_medicalaBindingSource, "Data afectiunii", true));
            this.data_afectiuniiDateTimePicker.Location = new System.Drawing.Point(235, 151);
            this.data_afectiuniiDateTimePicker.Name = "data_afectiuniiDateTimePicker";
            this.data_afectiuniiDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_afectiuniiDateTimePicker.TabIndex = 26;
            this.data_afectiuniiDateTimePicker.Visible = false;
            this.data_afectiuniiDateTimePicker.ValueChanged += new System.EventHandler(this.Data_afectiuniiDateTimePicker_ValueChanged);
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cerere_AdoptieBindingSource, "Data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(235, 375);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataDateTimePicker.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 610);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(548, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "“Saving one dog will not change the world, but surely for that one dog, the world" +
    " will change forever.”";
            // 
            // afectiuneTextBox
            // 
            this.afectiuneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fisa_medicalaBindingSource, "Afectiune", true));
            this.afectiuneTextBox.Location = new System.Drawing.Point(235, 114);
            this.afectiuneTextBox.Name = "afectiuneTextBox";
            this.afectiuneTextBox.Size = new System.Drawing.Size(100, 20);
            this.afectiuneTextBox.TabIndex = 30;
            this.afectiuneTextBox.TextChanged += new System.EventHandler(this.AfectiuneTextBox_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-47, -26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(189, 159);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 33;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vizitatorBindingSource, "Telefon", true));
            this.telefonTextBox.Location = new System.Drawing.Point(235, 325);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonTextBox.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 631);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(458, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 26);
            this.button3.TabIndex = 36;
            this.button3.Text = "Introdu datele";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(580, 631);
            this.Controls.Add(this.button3);
            this.Controls.Add(telefonLabel);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(afectiuneLabel);
            this.Controls.Add(iD_animalLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.afectiuneTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(data_afectiuniiLabel);
            this.Controls.Add(this.data_afectiuniiDateTimePicker);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(cNPLabel);
            this.Controls.Add(this.cNPTextBox);
            this.Controls.Add(stradaLabel);
            this.Controls.Add(this.stradaTextBox);
            this.Controls.Add(localitateLabel);
            this.Controls.Add(this.localitateTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form7";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerere_AdoptieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adoptieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vizitatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fisa_medicalaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fisamedicalaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Form1 f1;
        public Form2 f2;
        public Form3 f3;
        public Form4 f4;
        public Form5 f5;
        public Form6 f6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem1;
        private AdoptieDataSet adoptieDataSet;
        private System.Windows.Forms.BindingSource cerere_AdoptieBindingSource;
        private AdoptieDataSetTableAdapters.Cerere_AdoptieTableAdapter cerere_AdoptieTableAdapter;
        private AdoptieDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource vizitatorBindingSource;
        private AdoptieDataSetTableAdapters.VizitatorTableAdapter vizitatorTableAdapter;
        private System.Windows.Forms.TextBox localitateTextBox;
        private System.Windows.Forms.TextBox stradaTextBox;
        private System.Windows.Forms.TextBox cNPTextBox;
        private System.Windows.Forms.BindingSource fisa_medicalaBindingSource;
        private AdoptieDataSetTableAdapters.Fisa_medicalaTableAdapter fisa_medicalaTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource fisamedicalaBindingSource;
        private System.Windows.Forms.DateTimePicker data_afectiuniiDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox afectiuneTextBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
    }
}