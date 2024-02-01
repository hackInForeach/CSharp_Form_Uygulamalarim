
namespace Calisma4
{
    partial class frmHeader1
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
            this.lblSayi1 = new System.Windows.Forms.Label();
            this.lblSayi2 = new System.Windows.Forms.Label();
            this.lblToplam1 = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.lblfrmHeader = new System.Windows.Forms.Label();
            this.lblCarpim1 = new System.Windows.Forms.Label();
            this.tbxSayi1 = new System.Windows.Forms.TextBox();
            this.tbxSayi2 = new System.Windows.Forms.TextBox();
            this.lblCarpim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSayi1
            // 
            this.lblSayi1.AutoSize = true;
            this.lblSayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi1.Location = new System.Drawing.Point(58, 77);
            this.lblSayi1.Name = "lblSayi1";
            this.lblSayi1.Size = new System.Drawing.Size(65, 24);
            this.lblSayi1.TabIndex = 0;
            this.lblSayi1.Text = "1.Sayı:";
            // 
            // lblSayi2
            // 
            this.lblSayi2.AutoSize = true;
            this.lblSayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi2.Location = new System.Drawing.Point(58, 112);
            this.lblSayi2.Name = "lblSayi2";
            this.lblSayi2.Size = new System.Drawing.Size(65, 24);
            this.lblSayi2.TabIndex = 1;
            this.lblSayi2.Text = "2.Sayı:";
            // 
            // lblToplam1
            // 
            this.lblToplam1.AutoSize = true;
            this.lblToplam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam1.Location = new System.Drawing.Point(159, 164);
            this.lblToplam1.Name = "lblToplam1";
            this.lblToplam1.Size = new System.Drawing.Size(46, 24);
            this.lblToplam1.TabIndex = 3;
            this.lblToplam1.Text = "------";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.Location = new System.Drawing.Point(58, 164);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(79, 24);
            this.lblToplam.TabIndex = 2;
            this.lblToplam.Text = "Toplam:";
            // 
            // lblfrmHeader
            // 
            this.lblfrmHeader.AutoSize = true;
            this.lblfrmHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblfrmHeader.Location = new System.Drawing.Point(58, 29);
            this.lblfrmHeader.Name = "lblfrmHeader";
            this.lblfrmHeader.Size = new System.Drawing.Size(260, 24);
            this.lblfrmHeader.TabIndex = 5;
            this.lblfrmHeader.Text = "İki Sayının Toplamı ve Çarpımı";
            // 
            // lblCarpim1
            // 
            this.lblCarpim1.AutoSize = true;
            this.lblCarpim1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCarpim1.Location = new System.Drawing.Point(159, 199);
            this.lblCarpim1.Name = "lblCarpim1";
            this.lblCarpim1.Size = new System.Drawing.Size(46, 24);
            this.lblCarpim1.TabIndex = 4;
            this.lblCarpim1.Text = "------";
            // 
            // tbxSayi1
            // 
            this.tbxSayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSayi1.Location = new System.Drawing.Point(163, 74);
            this.tbxSayi1.Name = "tbxSayi1";
            this.tbxSayi1.Size = new System.Drawing.Size(148, 29);
            this.tbxSayi1.TabIndex = 6;
            // 
            // tbxSayi2
            // 
            this.tbxSayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSayi2.Location = new System.Drawing.Point(163, 109);
            this.tbxSayi2.Name = "tbxSayi2";
            this.tbxSayi2.Size = new System.Drawing.Size(148, 29);
            this.tbxSayi2.TabIndex = 7;
            this.tbxSayi2.TextChanged += new System.EventHandler(this.tbxSayi2_TextChanged);
            // 
            // lblCarpim
            // 
            this.lblCarpim.AutoSize = true;
            this.lblCarpim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCarpim.Location = new System.Drawing.Point(62, 199);
            this.lblCarpim.Name = "lblCarpim";
            this.lblCarpim.Size = new System.Drawing.Size(75, 24);
            this.lblCarpim.TabIndex = 8;
            this.lblCarpim.Text = "Çarpım:";
            // 
            // frmHeader1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 236);
            this.Controls.Add(this.lblCarpim);
            this.Controls.Add(this.tbxSayi2);
            this.Controls.Add(this.tbxSayi1);
            this.Controls.Add(this.lblfrmHeader);
            this.Controls.Add(this.lblCarpim1);
            this.Controls.Add(this.lblToplam1);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.lblSayi2);
            this.Controls.Add(this.lblSayi1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHeader1";
            this.Text = "İki Sayının Toplmanı ve Çarpımı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSayi1;
        private System.Windows.Forms.Label lblSayi2;
        private System.Windows.Forms.Label lblToplam1;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label lblfrmHeader;
        private System.Windows.Forms.Label lblCarpim1;
        private System.Windows.Forms.TextBox tbxSayi1;
        private System.Windows.Forms.TextBox tbxSayi2;
        private System.Windows.Forms.Label lblCarpim;
    }
}

