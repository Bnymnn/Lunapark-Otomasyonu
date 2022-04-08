
namespace Lunapark_Otomasyonu
{
    partial class uyeguncelleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uyeguncelleme));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 475);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye Düzenle";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(6, 357);
            this.textBox10.Name = "textBox10";
            this.textBox10.PasswordChar = '*';
            this.textBox10.PlaceholderText = "Üye Şifresi";
            this.textBox10.Size = new System.Drawing.Size(277, 31);
            this.textBox10.TabIndex = 45;
            this.textBox10.UseSystemPasswordChar = true;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(6, 320);
            this.textBox9.Name = "textBox9";
            this.textBox9.PlaceholderText = "Üye Bakiye";
            this.textBox9.Size = new System.Drawing.Size(277, 31);
            this.textBox9.TabIndex = 44;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(6, 252);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.PlaceholderText = "Üye E-Mail";
            this.textBox7.Size = new System.Drawing.Size(277, 62);
            this.textBox7.TabIndex = 43;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(6, 215);
            this.textBox6.Name = "textBox6";
            this.textBox6.PlaceholderText = "Üye Yaş";
            this.textBox6.Size = new System.Drawing.Size(277, 31);
            this.textBox6.TabIndex = 42;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(446, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 41);
            this.button3.TabIndex = 41;
            this.button3.Text = "Üyeleri Görüntüle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(304, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(297, 218);
            this.listView1.TabIndex = 40;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Telefon Numarası";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Üye Adı";
            this.columnHeader2.Width = 150;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(532, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 42);
            this.button2.TabIndex = 35;
            this.button2.Text = "Geri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(226, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 42);
            this.button1.TabIndex = 34;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(6, 427);
            this.textBox8.Name = "textBox8";
            this.textBox8.PasswordChar = '*';
            this.textBox8.PlaceholderText = "Onay Şifreniz";
            this.textBox8.Size = new System.Drawing.Size(167, 31);
            this.textBox8.TabIndex = 31;
            this.textBox8.UseSystemPasswordChar = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(6, 178);
            this.textBox5.Name = "textBox5";
            this.textBox5.PlaceholderText = "Üye Kilo";
            this.textBox5.Size = new System.Drawing.Size(277, 31);
            this.textBox5.TabIndex = 25;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 141);
            this.textBox4.Name = "textBox4";
            this.textBox4.PlaceholderText = "Üye Boy";
            this.textBox4.Size = new System.Drawing.Size(277, 31);
            this.textBox4.TabIndex = 23;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 104);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "Üye Soyadı";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(277, 31);
            this.textBox3.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Üye Adı";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(277, 31);
            this.textBox2.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 30);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Telefon  Numarası";
            this.textBox1.Size = new System.Drawing.Size(277, 31);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // uyeguncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 520);
            this.Controls.Add(this.groupBox1);
            this.Name = "uyeguncelleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye Düzenleme Ekranı";
            this.Load += new System.EventHandler(this.uyeguncelleme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
    }
}