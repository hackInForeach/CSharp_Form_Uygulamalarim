
namespace Calisma8
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSifrelenmisMetin = new System.Windows.Forms.Label();
            this.txtSifrelenecekMetin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSifrelenmisMetin = new System.Windows.Forms.Button();
            this.btnSifreCoz = new System.Windows.Forms.Button();
            this.lblCozulmusMetin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtnIngZero = new System.Windows.Forms.RadioButton();
            this.rbtnTrZero = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(115, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "KEY:";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(149, 46);
            this.txtKey.MaxLength = 2;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(24, 20);
            this.txtKey.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(57, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifrelenmiş Metin:";
            // 
            // lblSifrelenmisMetin
            // 
            this.lblSifrelenmisMetin.AutoSize = true;
            this.lblSifrelenmisMetin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSifrelenmisMetin.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSifrelenmisMetin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSifrelenmisMetin.Location = new System.Drawing.Point(149, 111);
            this.lblSifrelenmisMetin.Name = "lblSifrelenmisMetin";
            this.lblSifrelenmisMetin.Size = new System.Drawing.Size(105, 15);
            this.lblSifrelenmisMetin.TabIndex = 4;
            this.lblSifrelenmisMetin.Text = "--------------------------------";
            // 
            // txtSifrelenecekMetin
            // 
            this.txtSifrelenecekMetin.Location = new System.Drawing.Point(149, 76);
            this.txtSifrelenecekMetin.Name = "txtSifrelenecekMetin";
            this.txtSifrelenecekMetin.Size = new System.Drawing.Size(100, 20);
            this.txtSifrelenecekMetin.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(48, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Şifrelenecek Metin:";
            // 
            // btnSifrelenmisMetin
            // 
            this.btnSifrelenmisMetin.Location = new System.Drawing.Point(152, 140);
            this.btnSifrelenmisMetin.Name = "btnSifrelenmisMetin";
            this.btnSifrelenmisMetin.Size = new System.Drawing.Size(98, 22);
            this.btnSifrelenmisMetin.TabIndex = 11;
            this.btnSifrelenmisMetin.Text = "Şifrele";
            this.btnSifrelenmisMetin.UseVisualStyleBackColor = true;
            this.btnSifrelenmisMetin.Click += new System.EventHandler(this.btnSifrelenmisMetin_Click);
            // 
            // btnSifreCoz
            // 
            this.btnSifreCoz.Location = new System.Drawing.Point(152, 221);
            this.btnSifreCoz.Name = "btnSifreCoz";
            this.btnSifreCoz.Size = new System.Drawing.Size(98, 22);
            this.btnSifreCoz.TabIndex = 12;
            this.btnSifreCoz.Text = "Şifreyi Çöz";
            this.btnSifreCoz.UseVisualStyleBackColor = true;
            this.btnSifreCoz.Click += new System.EventHandler(this.btnSifreCoz_Click);
            // 
            // lblCozulmusMetin
            // 
            this.lblCozulmusMetin.AutoSize = true;
            this.lblCozulmusMetin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCozulmusMetin.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCozulmusMetin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCozulmusMetin.Location = new System.Drawing.Point(149, 193);
            this.lblCozulmusMetin.Name = "lblCozulmusMetin";
            this.lblCozulmusMetin.Size = new System.Drawing.Size(105, 15);
            this.lblCozulmusMetin.TabIndex = 14;
            this.lblCozulmusMetin.Text = "--------------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(39, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Deşifre Edilmiş Metin:";
            // 
            // rbtnIngZero
            // 
            this.rbtnIngZero.AutoSize = true;
            this.rbtnIngZero.Location = new System.Drawing.Point(195, 49);
            this.rbtnIngZero.Name = "rbtnIngZero";
            this.rbtnIngZero.Size = new System.Drawing.Size(109, 17);
            this.rbtnIngZero.TabIndex = 15;
            this.rbtnIngZero.TabStop = true;
            this.rbtnIngZero.Text = "ING (1-0) (mod26)";
            this.rbtnIngZero.UseVisualStyleBackColor = true;
            // 
            // rbtnTrZero
            // 
            this.rbtnTrZero.AutoSize = true;
            this.rbtnTrZero.Location = new System.Drawing.Point(195, 26);
            this.rbtnTrZero.Name = "rbtnTrZero";
            this.rbtnTrZero.Size = new System.Drawing.Size(108, 17);
            this.rbtnTrZero.TabIndex = 16;
            this.rbtnTrZero.TabStop = true;
            this.rbtnTrZero.Text = "TR  (1-0) (mod29)";
            this.rbtnTrZero.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 273);
            this.Controls.Add(this.rbtnTrZero);
            this.Controls.Add(this.rbtnIngZero);
            this.Controls.Add(this.lblCozulmusMetin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSifreCoz);
            this.Controls.Add(this.btnSifrelenmisMetin);
            this.Controls.Add(this.txtSifrelenecekMetin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSifrelenmisMetin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSifrelenmisMetin;
        private System.Windows.Forms.TextBox txtSifrelenecekMetin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSifrelenmisMetin;
        private System.Windows.Forms.Button btnSifreCoz;
        private System.Windows.Forms.Label lblCozulmusMetin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtnIngZero;
        private System.Windows.Forms.RadioButton rbtnTrZero;
    }
}

