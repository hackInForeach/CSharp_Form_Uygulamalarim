
namespace Calisma3
{
    partial class frmAsalHeader
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
            this.lblSayiGir = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.tbxAsalSayi1 = new System.Windows.Forms.TextBox();
            this.lbAsalHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSayiGir
            // 
            this.lblSayiGir.AutoSize = true;
            this.lblSayiGir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayiGir.Location = new System.Drawing.Point(32, 55);
            this.lblSayiGir.Name = "lblSayiGir";
            this.lblSayiGir.Size = new System.Drawing.Size(64, 20);
            this.lblSayiGir.TabIndex = 0;
            this.lblSayiGir.Text = "Sayı Gir";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(223, 55);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(39, 20);
            this.lblSonuc.TabIndex = 1;
            this.lblSonuc.Text = "------";
            // 
            // tbxAsalSayi1
            // 
            this.tbxAsalSayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAsalSayi1.Location = new System.Drawing.Point(102, 52);
            this.tbxAsalSayi1.Name = "tbxAsalSayi1";
            this.tbxAsalSayi1.Size = new System.Drawing.Size(115, 26);
            this.tbxAsalSayi1.TabIndex = 2;
            this.tbxAsalSayi1.TextChanged += new System.EventHandler(this.tbxAsalSayi1_TextChanged);
            // 
            // lbAsalHeader
            // 
            this.lbAsalHeader.AutoSize = true;
            this.lbAsalHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbAsalHeader.Location = new System.Drawing.Point(98, 9);
            this.lbAsalHeader.Name = "lbAsalHeader";
            this.lbAsalHeader.Size = new System.Drawing.Size(123, 20);
            this.lbAsalHeader.TabIndex = 3;
            this.lbAsalHeader.Text = "Asal Sayı Bulma";
            // 
            // frmAsalHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 110);
            this.Controls.Add(this.lbAsalHeader);
            this.Controls.Add(this.tbxAsalSayi1);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.lblSayiGir);
            this.Name = "frmAsalHeader";
            this.Text = "Asal Sayı Bulma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSayiGir;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.TextBox tbxAsalSayi1;
        private System.Windows.Forms.Label lbAsalHeader;
    }
}

