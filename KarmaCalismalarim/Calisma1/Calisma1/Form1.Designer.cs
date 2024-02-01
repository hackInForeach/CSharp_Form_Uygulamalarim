
namespace Calisma1
{
    partial class frmEmeklilik
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblYas = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblHeaderName = new System.Windows.Forms.Label();
            this.tbxYas = new System.Windows.Forms.TextBox();
            this.rbtnKadin = new System.Windows.Forms.RadioButton();
            this.rbtnErkek = new System.Windows.Forms.RadioButton();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lblSonucHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Location = new System.Drawing.Point(42, 60);
            this.lblYas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(62, 16);
            this.lblYas.TabIndex = 1;
            this.lblYas.Text = "Yaşınız:";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(14, 101);
            this.lblCinsiyet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(90, 16);
            this.lblCinsiyet.TabIndex = 2;
            this.lblCinsiyet.Text = "Cinsiyetiniz:";
            // 
            // lblHeaderName
            // 
            this.lblHeaderName.AutoSize = true;
            this.lblHeaderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeaderName.Location = new System.Drawing.Point(55, 9);
            this.lblHeaderName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeaderName.Name = "lblHeaderName";
            this.lblHeaderName.Size = new System.Drawing.Size(174, 20);
            this.lblHeaderName.TabIndex = 3;
            this.lblHeaderName.Text = "Emeklilik Hesaplama";
            // 
            // tbxYas
            // 
            this.tbxYas.Location = new System.Drawing.Point(111, 60);
            this.tbxYas.Name = "tbxYas";
            this.tbxYas.Size = new System.Drawing.Size(145, 22);
            this.tbxYas.TabIndex = 4;
            // 
            // rbtnKadin
            // 
            this.rbtnKadin.AutoSize = true;
            this.rbtnKadin.Location = new System.Drawing.Point(198, 101);
            this.rbtnKadin.Name = "rbtnKadin";
            this.rbtnKadin.Size = new System.Drawing.Size(65, 20);
            this.rbtnKadin.TabIndex = 5;
            this.rbtnKadin.TabStop = true;
            this.rbtnKadin.Text = "Kadın";
            this.rbtnKadin.UseVisualStyleBackColor = true;
            // 
            // rbtnErkek
            // 
            this.rbtnErkek.AutoSize = true;
            this.rbtnErkek.Location = new System.Drawing.Point(126, 101);
            this.rbtnErkek.Name = "rbtnErkek";
            this.rbtnErkek.Size = new System.Drawing.Size(66, 20);
            this.rbtnErkek.TabIndex = 6;
            this.rbtnErkek.TabStop = true;
            this.rbtnErkek.Text = "Erkek";
            this.rbtnErkek.UseVisualStyleBackColor = true;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(195, 177);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 7;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(108, 135);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 16);
            this.lblSonuc.TabIndex = 8;
            // 
            // lblSonucHeader
            // 
            this.lblSonucHeader.AutoSize = true;
            this.lblSonucHeader.Location = new System.Drawing.Point(49, 135);
            this.lblSonucHeader.Name = "lblSonucHeader";
            this.lblSonucHeader.Size = new System.Drawing.Size(55, 16);
            this.lblSonucHeader.TabIndex = 9;
            this.lblSonucHeader.Text = "Sonuç:";
            // 
            // frmEmeklilik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 224);
            this.Controls.Add(this.lblSonucHeader);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.rbtnErkek);
            this.Controls.Add(this.rbtnKadin);
            this.Controls.Add(this.tbxYas);
            this.Controls.Add(this.lblHeaderName);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.lblYas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmEmeklilik";
            this.Text = "Emeklilik Hesaplama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblHeaderName;
        private System.Windows.Forms.TextBox tbxYas;
        private System.Windows.Forms.RadioButton rbtnKadin;
        private System.Windows.Forms.RadioButton rbtnErkek;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblSonucHeader;
    }
}

