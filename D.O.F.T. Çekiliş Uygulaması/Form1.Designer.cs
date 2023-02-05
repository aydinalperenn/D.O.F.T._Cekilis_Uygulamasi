
namespace D.O.F.T.Çekiliş_Uygulaması
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
            this.btnKatilimciSec = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbKatilimcilar = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbOduller = new System.Windows.Forms.ListBox();
            this.btnOdulSec = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbCekilis = new System.Windows.Forms.ListBox();
            this.btnCekilisYap = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKatilimciSec
            // 
            this.btnKatilimciSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.btnKatilimciSec.FlatAppearance.BorderSize = 0;
            this.btnKatilimciSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKatilimciSec.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKatilimciSec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.btnKatilimciSec.Location = new System.Drawing.Point(12, 630);
            this.btnKatilimciSec.Name = "btnKatilimciSec";
            this.btnKatilimciSec.Size = new System.Drawing.Size(465, 61);
            this.btnKatilimciSec.TabIndex = 1;
            this.btnKatilimciSec.Text = "Katılımcıları Seç";
            this.btnKatilimciSec.UseVisualStyleBackColor = false;
            this.btnKatilimciSec.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbKatilimcilar
            // 
            this.lbKatilimcilar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.lbKatilimcilar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbKatilimcilar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbKatilimcilar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKatilimcilar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.lbKatilimcilar.FormattingEnabled = true;
            this.lbKatilimcilar.ItemHeight = 23;
            this.lbKatilimcilar.Location = new System.Drawing.Point(3, 44);
            this.lbKatilimcilar.Name = "lbKatilimcilar";
            this.lbKatilimcilar.Size = new System.Drawing.Size(459, 443);
            this.lbKatilimcilar.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-7, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1542, 128);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(444, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 45F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(653, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(650, 99);
            this.label1.TabIndex = 0;
            this.label1.Text = "Çekiliş Uygulaması";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.panel2.Location = new System.Drawing.Point(-7, 726);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1554, 47);
            this.panel2.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbKatilimcilar);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 27F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 490);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Katılımcılar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbOduller);
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 27F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.groupBox2.Location = new System.Drawing.Point(1055, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 490);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ödüller";
            // 
            // lbOduller
            // 
            this.lbOduller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.lbOduller.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbOduller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbOduller.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOduller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.lbOduller.FormattingEnabled = true;
            this.lbOduller.ItemHeight = 23;
            this.lbOduller.Location = new System.Drawing.Point(3, 44);
            this.lbOduller.Name = "lbOduller";
            this.lbOduller.Size = new System.Drawing.Size(459, 443);
            this.lbOduller.TabIndex = 3;
            // 
            // btnOdulSec
            // 
            this.btnOdulSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.btnOdulSec.FlatAppearance.BorderSize = 0;
            this.btnOdulSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdulSec.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdulSec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.btnOdulSec.Location = new System.Drawing.Point(1055, 630);
            this.btnOdulSec.Name = "btnOdulSec";
            this.btnOdulSec.Size = new System.Drawing.Size(465, 61);
            this.btnOdulSec.TabIndex = 2;
            this.btnOdulSec.Text = "Ödülleri Seç";
            this.btnOdulSec.UseVisualStyleBackColor = false;
            this.btnOdulSec.Click += new System.EventHandler(this.btnOdulSec_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbCekilis);
            this.groupBox3.Font = new System.Drawing.Font("Georgia", 27F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.groupBox3.Location = new System.Drawing.Point(533, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(465, 490);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Çekiliş Sonuçları";
            this.groupBox3.Visible = false;
            // 
            // lbCekilis
            // 
            this.lbCekilis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.lbCekilis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbCekilis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCekilis.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCekilis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.lbCekilis.FormattingEnabled = true;
            this.lbCekilis.ItemHeight = 23;
            this.lbCekilis.Location = new System.Drawing.Point(3, 44);
            this.lbCekilis.Name = "lbCekilis";
            this.lbCekilis.Size = new System.Drawing.Size(459, 443);
            this.lbCekilis.TabIndex = 3;
            // 
            // btnCekilisYap
            // 
            this.btnCekilisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.btnCekilisYap.FlatAppearance.BorderSize = 0;
            this.btnCekilisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCekilisYap.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCekilisYap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.btnCekilisYap.Location = new System.Drawing.Point(533, 630);
            this.btnCekilisYap.Name = "btnCekilisYap";
            this.btnCekilisYap.Size = new System.Drawing.Size(465, 61);
            this.btnCekilisYap.TabIndex = 3;
            this.btnCekilisYap.Text = "Çekilişi Gerçekleştir";
            this.btnCekilisYap.UseVisualStyleBackColor = false;
            this.btnCekilisYap.Visible = false;
            this.btnCekilisYap.Click += new System.EventHandler(this.btnCekilisYap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1532, 766);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCekilisYap);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnOdulSec);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnKatilimciSec);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "D.O.F.T. Çekiliş Uygulaması";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnKatilimciSec;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lbKatilimcilar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbOduller;
        private System.Windows.Forms.Button btnOdulSec;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbCekilis;
        private System.Windows.Forms.Button btnCekilisYap;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

