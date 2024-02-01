
namespace GirilenKelimeKaçHarfli
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
            this.lblSayac = new System.Windows.Forms.Label();
            this.tbxMetin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSayac
            // 
            this.lblSayac.AutoSize = true;
            this.lblSayac.Location = new System.Drawing.Point(226, 61);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(0, 13);
            this.lblSayac.TabIndex = 0;
            // 
            // tbxMetin
            // 
            this.tbxMetin.Location = new System.Drawing.Point(103, 58);
            this.tbxMetin.Name = "tbxMetin";
            this.tbxMetin.Size = new System.Drawing.Size(100, 20);
            this.tbxMetin.TabIndex = 1;
            this.tbxMetin.TextChanged += new System.EventHandler(this.tbxMetin_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Metin gir:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 133);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxMetin);
            this.Controls.Add(this.lblSayac);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSayac;
        private System.Windows.Forms.TextBox tbxMetin;
        private System.Windows.Forms.Label label2;
    }
}

