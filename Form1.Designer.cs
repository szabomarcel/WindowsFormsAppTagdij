namespace WindowsFormsAppTagdij
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox_tagok = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_torles = new System.Windows.Forms.Button();
            this.button_modositas = new System.Windows.Forms.Button();
            this.button_letrehozas = new System.Windows.Forms.Button();
            this.textBox_orsz = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownSzulev = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownIrszam = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_azon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSzulev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIrszam)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_tagok
            // 
            this.listBox_tagok.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBox_tagok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_tagok.FormattingEnabled = true;
            this.listBox_tagok.Location = new System.Drawing.Point(0, 0);
            this.listBox_tagok.Name = "listBox_tagok";
            this.listBox_tagok.Size = new System.Drawing.Size(120, 450);
            this.listBox_tagok.TabIndex = 0;
            this.listBox_tagok.SelectedIndexChanged += new System.EventHandler(this.listBox_tagok_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.textBox_orsz);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDownSzulev);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDownIrszam);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_nev);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_azon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(120, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 450);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiválasztott_tag";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Chocolate;
            this.groupBox3.Controls.Add(this.button_torles);
            this.groupBox3.Controls.Add(this.button_modositas);
            this.groupBox3.Controls.Add(this.button_letrehozas);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 347);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 100);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Műveletek";
            // 
            // button_torles
            // 
            this.button_torles.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_torles.Location = new System.Drawing.Point(163, 19);
            this.button_torles.Name = "button_torles";
            this.button_torles.Size = new System.Drawing.Size(75, 23);
            this.button_torles.TabIndex = 2;
            this.button_torles.Text = "Törlés";
            this.button_torles.UseVisualStyleBackColor = false;
            this.button_torles.Click += new System.EventHandler(this.button_torles_Click);
            // 
            // button_modositas
            // 
            this.button_modositas.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_modositas.Location = new System.Drawing.Point(84, 19);
            this.button_modositas.Name = "button_modositas";
            this.button_modositas.Size = new System.Drawing.Size(75, 23);
            this.button_modositas.TabIndex = 1;
            this.button_modositas.Text = "Módosítás";
            this.button_modositas.UseVisualStyleBackColor = false;
            this.button_modositas.Click += new System.EventHandler(this.button_modositas_Click);
            // 
            // button_letrehozas
            // 
            this.button_letrehozas.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_letrehozas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_letrehozas.Location = new System.Drawing.Point(3, 19);
            this.button_letrehozas.Name = "button_letrehozas";
            this.button_letrehozas.Size = new System.Drawing.Size(75, 23);
            this.button_letrehozas.TabIndex = 0;
            this.button_letrehozas.Text = "Létrehozás";
            this.button_letrehozas.UseVisualStyleBackColor = false;
            this.button_letrehozas.Click += new System.EventHandler(this.button_letrehozas_Click);
            // 
            // textBox_orsz
            // 
            this.textBox_orsz.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_orsz.Location = new System.Drawing.Point(10, 224);
            this.textBox_orsz.Name = "textBox_orsz";
            this.textBox_orsz.Size = new System.Drawing.Size(100, 20);
            this.textBox_orsz.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(13, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Országok";
            // 
            // numericUpDownSzulev
            // 
            this.numericUpDownSzulev.BackColor = System.Drawing.SystemColors.Info;
            this.numericUpDownSzulev.Location = new System.Drawing.Point(10, 180);
            this.numericUpDownSzulev.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.numericUpDownSzulev.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDownSzulev.Name = "numericUpDownSzulev";
            this.numericUpDownSzulev.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSzulev.TabIndex = 7;
            this.numericUpDownSzulev.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownSzulev.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(13, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Születési év";
            // 
            // numericUpDownIrszam
            // 
            this.numericUpDownIrszam.BackColor = System.Drawing.SystemColors.Info;
            this.numericUpDownIrszam.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownIrszam.Location = new System.Drawing.Point(10, 136);
            this.numericUpDownIrszam.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownIrszam.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownIrszam.Name = "numericUpDownIrszam";
            this.numericUpDownIrszam.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownIrszam.TabIndex = 5;
            this.numericUpDownIrszam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownIrszam.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(13, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Írányító szám";
            // 
            // textBox_nev
            // 
            this.textBox_nev.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_nev.Location = new System.Drawing.Point(10, 92);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(214, 20);
            this.textBox_nev.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Név";
            // 
            // textBox_azon
            // 
            this.textBox_azon.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_azon.Location = new System.Drawing.Point(10, 49);
            this.textBox_azon.Name = "textBox_azon";
            this.textBox_azon.ReadOnly = true;
            this.textBox_azon.Size = new System.Drawing.Size(100, 20);
            this.textBox_azon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Azonosító";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_tagok);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tagok nyilvántartása";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSzulev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIrszam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_tagok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_azon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownIrszam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownSzulev;
        private System.Windows.Forms.TextBox textBox_orsz;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_torles;
        private System.Windows.Forms.Button button_modositas;
        private System.Windows.Forms.Button button_letrehozas;
    }
}

