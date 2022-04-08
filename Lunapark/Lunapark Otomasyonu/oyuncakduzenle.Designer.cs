
namespace Lunapark_Otomasyonu
{
    partial class oyuncakduzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oyuncakduzenle));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 475);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oyuncak Düzenle";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(446, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 41);
            this.button3.TabIndex = 41;
            this.button3.Text = "Oyuncakları Görüntüle";
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
            this.listView1.Location = new System.Drawing.Point(446, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(155, 218);
            this.listView1.TabIndex = 40;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Numara";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Oyuncak Adı";
            this.columnHeader2.Width = 200;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.White;
            this.checkBox2.ForeColor = System.Drawing.Color.Black;
            this.checkBox2.Location = new System.Drawing.Point(201, 304);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(119, 29);
            this.checkBox2.TabIndex = 39;
            this.checkBox2.Text = "Devre Dışı";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.White;
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(201, 269);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 29);
            this.checkBox1.TabIndex = 38;
            this.checkBox1.Text = "Aktif";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(6, 360);
            this.textBox9.Name = "textBox9";
            this.textBox9.PlaceholderText = "Fiyat";
            this.textBox9.Size = new System.Drawing.Size(167, 31);
            this.textBox9.TabIndex = 37;
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
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(6, 267);
            this.textBox6.Name = "textBox6";
            this.textBox6.PlaceholderText = "Minimum Kilo";
            this.textBox6.Size = new System.Drawing.Size(167, 31);
            this.textBox6.TabIndex = 29;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(6, 313);
            this.textBox7.Name = "textBox7";
            this.textBox7.PlaceholderText = "Minimum Yaş";
            this.textBox7.Size = new System.Drawing.Size(167, 31);
            this.textBox7.TabIndex = 27;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(6, 221);
            this.textBox5.Name = "textBox5";
            this.textBox5.PlaceholderText = "Maksimum Kilo";
            this.textBox5.Size = new System.Drawing.Size(167, 31);
            this.textBox5.TabIndex = 25;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 173);
            this.textBox4.Name = "textBox4";
            this.textBox4.PlaceholderText = "Minimum Boy";
            this.textBox4.Size = new System.Drawing.Size(167, 31);
            this.textBox4.TabIndex = 23;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 127);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "Maksimum Boy";
            this.textBox3.Size = new System.Drawing.Size(167, 31);
            this.textBox3.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 67);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Oyuncak Adı";
            this.textBox2.Size = new System.Drawing.Size(295, 54);
            this.textBox2.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Oyuncak Numarası";
            this.textBox1.Size = new System.Drawing.Size(176, 31);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // oyuncakduzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 491);
            this.Controls.Add(this.groupBox1);
            this.Name = "oyuncakduzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oyuncak Düzenleme Ekranı";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button3;
    }
}