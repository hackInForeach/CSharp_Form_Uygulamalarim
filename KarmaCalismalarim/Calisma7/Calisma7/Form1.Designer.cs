
namespace Calisma7
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
            this.tbxBoyut = new System.Windows.Forms.TextBox();
            this.btnBoyut = new System.Windows.Forms.Button();
            this.lblBoyutAd = new System.Windows.Forms.Label();
            this.lblBoyut = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.tbxEkle = new System.Windows.Forms.TextBox();
            this.lblEkle = new System.Windows.Forms.Label();
            this.lblEklenenAd = new System.Windows.Forms.Label();
            this.btnOrt = new System.Windows.Forms.Button();
            this.lblOrt = new System.Windows.Forms.Label();
            this.lblKalan = new System.Windows.Forms.Label();
            this.lblKalanAd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxBoyut
            // 
            this.tbxBoyut.Location = new System.Drawing.Point(12, 12);
            this.tbxBoyut.MaxLength = 6;
            this.tbxBoyut.Name = "tbxBoyut";
            this.tbxBoyut.Size = new System.Drawing.Size(49, 20);
            this.tbxBoyut.TabIndex = 0;
            // 
            // btnBoyut
            // 
            this.btnBoyut.Location = new System.Drawing.Point(12, 38);
            this.btnBoyut.Name = "btnBoyut";
            this.btnBoyut.Size = new System.Drawing.Size(49, 23);
            this.btnBoyut.TabIndex = 1;
            this.btnBoyut.Text = "Boyut";
            this.btnBoyut.UseVisualStyleBackColor = true;
            this.btnBoyut.Click += new System.EventHandler(this.btnBoyut_Click);
            // 
            // lblBoyutAd
            // 
            this.lblBoyutAd.AutoSize = true;
            this.lblBoyutAd.Location = new System.Drawing.Point(91, 19);
            this.lblBoyutAd.Name = "lblBoyutAd";
            this.lblBoyutAd.Size = new System.Drawing.Size(63, 13);
            this.lblBoyutAd.TabIndex = 2;
            this.lblBoyutAd.Text = "Dizi Boyutu:";
            // 
            // lblBoyut
            // 
            this.lblBoyut.AutoSize = true;
            this.lblBoyut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBoyut.Location = new System.Drawing.Point(154, 19);
            this.lblBoyut.Name = "lblBoyut";
            this.lblBoyut.Size = new System.Drawing.Size(24, 15);
            this.lblBoyut.TabIndex = 3;
            this.lblBoyut.Text = "-----";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(12, 93);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(49, 23);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // tbxEkle
            // 
            this.tbxEkle.Location = new System.Drawing.Point(12, 67);
            this.tbxEkle.MaxLength = 6;
            this.tbxEkle.Name = "tbxEkle";
            this.tbxEkle.Size = new System.Drawing.Size(49, 20);
            this.tbxEkle.TabIndex = 4;
            // 
            // lblEkle
            // 
            this.lblEkle.AutoSize = true;
            this.lblEkle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEkle.Location = new System.Drawing.Point(154, 67);
            this.lblEkle.Name = "lblEkle";
            this.lblEkle.Size = new System.Drawing.Size(24, 15);
            this.lblEkle.TabIndex = 7;
            this.lblEkle.Text = "-----";
            // 
            // lblEklenenAd
            // 
            this.lblEklenenAd.AutoSize = true;
            this.lblEklenenAd.Location = new System.Drawing.Point(67, 67);
            this.lblEklenenAd.Name = "lblEklenenAd";
            this.lblEklenenAd.Size = new System.Drawing.Size(87, 13);
            this.lblEklenenAd.TabIndex = 6;
            this.lblEklenenAd.Text = "Eklenen Eleman:";
            // 
            // btnOrt
            // 
            this.btnOrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrt.Location = new System.Drawing.Point(94, 126);
            this.btnOrt.Name = "btnOrt";
            this.btnOrt.Size = new System.Drawing.Size(50, 15);
            this.btnOrt.TabIndex = 8;
            this.btnOrt.Text = "Ort.";
            this.btnOrt.UseVisualStyleBackColor = true;
            this.btnOrt.Click += new System.EventHandler(this.btnOrt_Click);
            // 
            // lblOrt
            // 
            this.lblOrt.AutoSize = true;
            this.lblOrt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOrt.Location = new System.Drawing.Point(154, 126);
            this.lblOrt.Name = "lblOrt";
            this.lblOrt.Size = new System.Drawing.Size(24, 15);
            this.lblOrt.TabIndex = 9;
            this.lblOrt.Text = "-----";
            // 
            // lblKalan
            // 
            this.lblKalan.AutoSize = true;
            this.lblKalan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKalan.Location = new System.Drawing.Point(52, 125);
            this.lblKalan.Name = "lblKalan";
            this.lblKalan.Size = new System.Drawing.Size(24, 15);
            this.lblKalan.TabIndex = 10;
            this.lblKalan.Text = "-----";
            // 
            // lblKalanAd
            // 
            this.lblKalanAd.AutoSize = true;
            this.lblKalanAd.Location = new System.Drawing.Point(12, 125);
            this.lblKalanAd.Name = "lblKalanAd";
            this.lblKalanAd.Size = new System.Drawing.Size(37, 13);
            this.lblKalanAd.TabIndex = 11;
            this.lblKalanAd.Text = "Kalan:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 167);
            this.Controls.Add(this.lblKalanAd);
            this.Controls.Add(this.lblKalan);
            this.Controls.Add(this.lblOrt);
            this.Controls.Add(this.btnOrt);
            this.Controls.Add(this.lblEkle);
            this.Controls.Add(this.lblEklenenAd);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.tbxEkle);
            this.Controls.Add(this.lblBoyut);
            this.Controls.Add(this.lblBoyutAd);
            this.Controls.Add(this.btnBoyut);
            this.Controls.Add(this.tbxBoyut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Verilen Dizi Ortalaması";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxBoyut;
        private System.Windows.Forms.Button btnBoyut;
        private System.Windows.Forms.Label lblBoyutAd;
        private System.Windows.Forms.Label lblBoyut;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox tbxEkle;
        private System.Windows.Forms.Label lblEkle;
        private System.Windows.Forms.Label lblEklenenAd;
        private System.Windows.Forms.Button btnOrt;
        private System.Windows.Forms.Label lblOrt;
        private System.Windows.Forms.Label lblKalan;
        private System.Windows.Forms.Label lblKalanAd;
    }
}

