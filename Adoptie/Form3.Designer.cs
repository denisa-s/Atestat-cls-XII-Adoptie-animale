namespace Adoptie
{
    partial class Form3
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
            System.Windows.Forms.Label prenumeLabel;
            System.Windows.Forms.Label cNPLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.înapoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inapoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cNPTextBox = new System.Windows.Forms.TextBox();
            this.vizitatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adoptieDataSet = new Adoptie.AdoptieDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.prenumeTextBox = new System.Windows.Forms.TextBox();
            this.numeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.vizitatorTableAdapter = new Adoptie.AdoptieDataSetTableAdapters.VizitatorTableAdapter();
            this.tableAdapterManager = new Adoptie.AdoptieDataSetTableAdapters.TableAdapterManager();
            this.label2 = new System.Windows.Forms.Label();
            numeLabel = new System.Windows.Forms.Label();
            prenumeLabel = new System.Windows.Forms.Label();
            cNPLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vizitatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adoptieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // numeLabel
            // 
            numeLabel.AutoSize = true;
            numeLabel.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numeLabel.Location = new System.Drawing.Point(36, 139);
            numeLabel.Name = "numeLabel";
            numeLabel.Size = new System.Drawing.Size(74, 28);
            numeLabel.TabIndex = 5;
            numeLabel.Text = "Nume:";
            // 
            // prenumeLabel
            // 
            prenumeLabel.AutoSize = true;
            prenumeLabel.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prenumeLabel.Location = new System.Drawing.Point(36, 188);
            prenumeLabel.Name = "prenumeLabel";
            prenumeLabel.Size = new System.Drawing.Size(99, 28);
            prenumeLabel.TabIndex = 6;
            prenumeLabel.Text = "Prenume:";
            // 
            // cNPLabel
            // 
            cNPLabel.AutoSize = true;
            cNPLabel.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cNPLabel.Location = new System.Drawing.Point(36, 248);
            cNPLabel.Name = "cNPLabel";
            cNPLabel.Size = new System.Drawing.Size(64, 28);
            cNPLabel.TabIndex = 11;
            cNPLabel.Text = "CNP:";
            cNPLabel.Click += new System.EventHandler(this.CNPLabel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.înapoiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(554, 24);
            this.menuStrip1.TabIndex = 0;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(cNPLabel);
            this.panel1.Controls.Add(this.cNPTextBox);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(prenumeLabel);
            this.panel1.Controls.Add(this.prenumeTextBox);
            this.panel1.Controls.Add(numeLabel);
            this.panel1.Controls.Add(this.numeTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(41, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 344);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // cNPTextBox
            // 
            this.cNPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vizitatorBindingSource, "CNP", true));
            this.cNPTextBox.Location = new System.Drawing.Point(194, 253);
            this.cNPTextBox.Name = "cNPTextBox";
            this.cNPTextBox.Size = new System.Drawing.Size(100, 20);
            this.cNPTextBox.TabIndex = 12;
            this.cNPTextBox.TextChanged += new System.EventHandler(this.CNPTextBox_TextChanged);
            // 
            // vizitatorBindingSource
            // 
            this.vizitatorBindingSource.DataMember = "Vizitator";
            this.vizitatorBindingSource.DataSource = this.adoptieDataSet;
            // 
            // adoptieDataSet
            // 
            this.adoptieDataSet.DataSetName = "AdoptieDataSet";
            this.adoptieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(194, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 36);
            this.button2.TabIndex = 11;
            this.button2.Text = "Accesare";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // prenumeTextBox
            // 
            this.prenumeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vizitatorBindingSource, "Prenume", true));
            this.prenumeTextBox.Location = new System.Drawing.Point(194, 193);
            this.prenumeTextBox.Name = "prenumeTextBox";
            this.prenumeTextBox.Size = new System.Drawing.Size(100, 20);
            this.prenumeTextBox.TabIndex = 7;
            this.prenumeTextBox.TextChanged += new System.EventHandler(this.PrenumeTextBox_TextChanged);
            // 
            // numeTextBox
            // 
            this.numeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vizitatorBindingSource, "Nume", true));
            this.numeTextBox.Location = new System.Drawing.Point(194, 144);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(100, 20);
            this.numeTextBox.TabIndex = 6;
            this.numeTextBox.TextChanged += new System.EventHandler(this.NumeTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 35.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logare";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-64, -34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(212, 182);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(554, 614);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 595);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(451, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "\"Saving animals is as simple as choosing synthetic alternatives instead of real f" +
    "ur.\"";
            // 
            // vizitatorTableAdapter
            // 
            this.vizitatorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AngajatTableAdapter = null;
            this.tableAdapterManager.AnimalTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Cerere_AdoptieTableAdapter = null;
            this.tableAdapterManager.Fisa_medicalaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Adoptie.AdoptieDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VizitatorTableAdapter = this.vizitatorTableAdapter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "(Vă rugăm să introduceți doar primele 9 \r\ncifre din CNP)";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(554, 614);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vizitatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adoptieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Form1 f1;
        public Form2 f2;
        public Form4 f4;
        public Form5 f5;
        public Form6 f6;
        public Form7 f7;
        //public string nume;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem înapoiToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem inapoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private AdoptieDataSet adoptieDataSet;
        private System.Windows.Forms.BindingSource vizitatorBindingSource;
        private AdoptieDataSetTableAdapters.VizitatorTableAdapter vizitatorTableAdapter;
        private AdoptieDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox prenumeTextBox;
        private System.Windows.Forms.TextBox numeTextBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox cNPTextBox;
        private System.Windows.Forms.Label label2;
    }
}