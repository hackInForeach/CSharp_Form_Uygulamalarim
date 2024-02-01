
namespace Calisma2
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
            this.components = new System.ComponentModel.Container();
            this.tbxSayi1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblSayi1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSayi2 = new System.Windows.Forms.Label();
            this.tbxSayi2 = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lblCikti = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxSayi1
            // 
            this.tbxSayi1.Location = new System.Drawing.Point(87, 51);
            this.tbxSayi1.Name = "tbxSayi1";
            this.tbxSayi1.Size = new System.Drawing.Size(193, 20);
            this.tbxSayi1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblSayi1
            // 
            this.lblSayi1.AutoSize = true;
            this.lblSayi1.Location = new System.Drawing.Point(15, 54);
            this.lblSayi1.Name = "lblSayi1";
            this.lblSayi1.Size = new System.Drawing.Size(68, 13);
            this.lblSayi1.TabIndex = 2;
            this.lblSayi1.Text = "1.Sayıyı girin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Faktöriel Hesaplama";
            // 
            // lblSayi2
            // 
            this.lblSayi2.AutoSize = true;
            this.lblSayi2.Location = new System.Drawing.Point(15, 90);
            this.lblSayi2.Name = "lblSayi2";
            this.lblSayi2.Size = new System.Drawing.Size(68, 13);
            this.lblSayi2.TabIndex = 5;
            this.lblSayi2.Text = "2.Sayıyı girin:";
            // 
            // tbxSayi2
            // 
            this.tbxSayi2.Location = new System.Drawing.Point(87, 87);
            this.tbxSayi2.Name = "tbxSayi2";
            this.tbxSayi2.Size = new System.Drawing.Size(193, 20);
            this.tbxSayi2.TabIndex = 4;
            this.tbxSayi2.TextChanged += new System.EventHandler(this.tbxSayi2_TextChanged);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(42, 134);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(41, 13);
            this.lblSonuc.TabIndex = 6;
            this.lblSonuc.Text = "Sonuc:";
            // 
            // lblCikti
            // 
            this.lblCikti.AutoSize = true;
            this.lblCikti.Location = new System.Drawing.Point(98, 134);
            this.lblCikti.Name = "lblCikti";
            this.lblCikti.Size = new System.Drawing.Size(72, 13);
            this.lblCikti.TabIndex = 7;
            this.lblCikti.Text = "UYARI/ÇIKTI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 198);
            this.Controls.Add(this.lblCikti);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.lblSayi2);
            this.Controls.Add(this.tbxSayi2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSayi1);
            this.Controls.Add(this.tbxSayi1);
            this.Name = "Form1";
            this.Text = "Faktöriel Hesaplama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSayi1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblSayi1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSayi2;
        private System.Windows.Forms.TextBox tbxSayi2;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblCikti;
    }
}

