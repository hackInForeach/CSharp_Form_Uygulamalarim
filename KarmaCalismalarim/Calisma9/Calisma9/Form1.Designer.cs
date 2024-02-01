
namespace Calisma9
{
    partial class frmZarAtmaOyunu
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
            this.lblZarOyunuHeader = new System.Windows.Forms.Label();
            this.lblOyuncuSayisiHeader = new System.Windows.Forms.Label();
            this.tbxOyuncuSayisi = new System.Windows.Forms.TextBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOyuncu = new System.Windows.Forms.Label();
            this.btnZarAt = new System.Windows.Forms.Button();
            this.lblPuan = new System.Windows.Forms.Label();
            this.lblOyuncuPuaniHeader = new System.Windows.Forms.Label();
            this.btnBitir = new System.Windows.Forms.Button();
            this.tbxSetSayisi = new System.Windows.Forms.TextBox();
            this.lblSetSayisi = new System.Windows.Forms.Label();
            this.lblMessageHeader = new System.Windows.Forms.Label();
            this.lblMessageError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblZarOyunuHeader
            // 
            this.lblZarOyunuHeader.AutoSize = true;
            this.lblZarOyunuHeader.Location = new System.Drawing.Point(489, 35);
            this.lblZarOyunuHeader.Name = "lblZarOyunuHeader";
            this.lblZarOyunuHeader.Size = new System.Drawing.Size(84, 13);
            this.lblZarOyunuHeader.TabIndex = 12;
            this.lblZarOyunuHeader.Text = "Zar Atma Oyunu";
            // 
            // lblOyuncuSayisiHeader
            // 
            this.lblOyuncuSayisiHeader.AutoSize = true;
            this.lblOyuncuSayisiHeader.Location = new System.Drawing.Point(109, 121);
            this.lblOyuncuSayisiHeader.Name = "lblOyuncuSayisiHeader";
            this.lblOyuncuSayisiHeader.Size = new System.Drawing.Size(77, 13);
            this.lblOyuncuSayisiHeader.TabIndex = 13;
            this.lblOyuncuSayisiHeader.Text = "Oyuncu Sayısı:";
            // 
            // tbxOyuncuSayisi
            // 
            this.tbxOyuncuSayisi.Location = new System.Drawing.Point(192, 118);
            this.tbxOyuncuSayisi.MaxLength = 1;
            this.tbxOyuncuSayisi.Name = "tbxOyuncuSayisi";
            this.tbxOyuncuSayisi.Size = new System.Drawing.Size(16, 20);
            this.tbxOyuncuSayisi.TabIndex = 14;
            // 
            // btnOnayla
            // 
            this.btnOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayla.Location = new System.Drawing.Point(112, 170);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(71, 22);
            this.btnOnayla.TabIndex = 15;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(80, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(901, 309);
            this.dataGridView1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(851, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Oyuncu:";
            // 
            // lblOyuncu
            // 
            this.lblOyuncu.AutoSize = true;
            this.lblOyuncu.Location = new System.Drawing.Point(904, 134);
            this.lblOyuncu.Name = "lblOyuncu";
            this.lblOyuncu.Size = new System.Drawing.Size(19, 13);
            this.lblOyuncu.TabIndex = 18;
            this.lblOyuncu.Text = "----";
            // 
            // btnZarAt
            // 
            this.btnZarAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnZarAt.Location = new System.Drawing.Point(854, 183);
            this.btnZarAt.Name = "btnZarAt";
            this.btnZarAt.Size = new System.Drawing.Size(35, 22);
            this.btnZarAt.TabIndex = 19;
            this.btnZarAt.Text = "Zar At";
            this.btnZarAt.UseVisualStyleBackColor = true;
            this.btnZarAt.Click += new System.EventHandler(this.btnZarAt_Click);
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Location = new System.Drawing.Point(904, 157);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(19, 13);
            this.lblPuan.TabIndex = 21;
            this.lblPuan.Text = "----";
            // 
            // lblOyuncuPuaniHeader
            // 
            this.lblOyuncuPuaniHeader.AutoSize = true;
            this.lblOyuncuPuaniHeader.Location = new System.Drawing.Point(861, 157);
            this.lblOyuncuPuaniHeader.Name = "lblOyuncuPuaniHeader";
            this.lblOyuncuPuaniHeader.Size = new System.Drawing.Size(37, 13);
            this.lblOyuncuPuaniHeader.TabIndex = 20;
            this.lblOyuncuPuaniHeader.Text = "Puanı:";
            // 
            // btnBitir
            // 
            this.btnBitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBitir.Location = new System.Drawing.Point(112, 602);
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.Size = new System.Drawing.Size(37, 22);
            this.btnBitir.TabIndex = 22;
            this.btnBitir.Text = "Bitir";
            this.btnBitir.UseVisualStyleBackColor = true;
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            // 
            // tbxSetSayisi
            // 
            this.tbxSetSayisi.Location = new System.Drawing.Point(192, 144);
            this.tbxSetSayisi.MaxLength = 1;
            this.tbxSetSayisi.Name = "tbxSetSayisi";
            this.tbxSetSayisi.Size = new System.Drawing.Size(16, 20);
            this.tbxSetSayisi.TabIndex = 24;
            // 
            // lblSetSayisi
            // 
            this.lblSetSayisi.AutoSize = true;
            this.lblSetSayisi.Location = new System.Drawing.Point(128, 147);
            this.lblSetSayisi.Name = "lblSetSayisi";
            this.lblSetSayisi.Size = new System.Drawing.Size(56, 13);
            this.lblSetSayisi.TabIndex = 23;
            this.lblSetSayisi.Text = "Set Sayısı:";
            // 
            // lblMessageHeader
            // 
            this.lblMessageHeader.AutoSize = true;
            this.lblMessageHeader.Location = new System.Drawing.Point(109, 201);
            this.lblMessageHeader.Name = "lblMessageHeader";
            this.lblMessageHeader.Size = new System.Drawing.Size(38, 13);
            this.lblMessageHeader.TabIndex = 25;
            this.lblMessageHeader.Text = "Mesaj:";
            // 
            // lblMessageError
            // 
            this.lblMessageError.AutoSize = true;
            this.lblMessageError.Location = new System.Drawing.Point(153, 201);
            this.lblMessageError.Name = "lblMessageError";
            this.lblMessageError.Size = new System.Drawing.Size(0, 13);
            this.lblMessageError.TabIndex = 26;
            // 
            // frmZarAtmaOyunu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 747);
            this.Controls.Add(this.lblMessageError);
            this.Controls.Add(this.lblMessageHeader);
            this.Controls.Add(this.tbxSetSayisi);
            this.Controls.Add(this.lblSetSayisi);
            this.Controls.Add(this.btnBitir);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.lblOyuncuPuaniHeader);
            this.Controls.Add(this.btnZarAt);
            this.Controls.Add(this.lblOyuncu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.tbxOyuncuSayisi);
            this.Controls.Add(this.lblOyuncuSayisiHeader);
            this.Controls.Add(this.lblZarOyunuHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmZarAtmaOyunu";
            this.Text = "Zar Atma Oyunu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblZarOyunuHeader;
        private System.Windows.Forms.Label lblOyuncuSayisiHeader;
        private System.Windows.Forms.TextBox tbxOyuncuSayisi;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOyuncu;
        private System.Windows.Forms.Button btnZarAt;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label lblOyuncuPuaniHeader;
        private System.Windows.Forms.Button btnBitir;
        private System.Windows.Forms.TextBox tbxSetSayisi;
        private System.Windows.Forms.Label lblSetSayisi;
        private System.Windows.Forms.Label lblMessageHeader;
        private System.Windows.Forms.Label lblMessageError;
    }
}

