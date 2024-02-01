
namespace Calisma6
{
    partial class frmHeader
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
            this.tbxSayi1 = new System.Windows.Forms.TextBox();
            this.tbxSayi3 = new System.Windows.Forms.TextBox();
            this.tbxSayi2 = new System.Windows.Forms.TextBox();
            this.rbtnTopla2 = new System.Windows.Forms.RadioButton();
            this.rbtnTopla4 = new System.Windows.Forms.RadioButton();
            this.rbtnTopla3 = new System.Windows.Forms.RadioButton();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tbxSayi4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbxSayi1
            // 
            this.tbxSayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSayi1.Location = new System.Drawing.Point(44, 43);
            this.tbxSayi1.Name = "tbxSayi1";
            this.tbxSayi1.Size = new System.Drawing.Size(100, 26);
            this.tbxSayi1.TabIndex = 1;
            // 
            // tbxSayi3
            // 
            this.tbxSayi3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSayi3.Location = new System.Drawing.Point(44, 107);
            this.tbxSayi3.Name = "tbxSayi3";
            this.tbxSayi3.Size = new System.Drawing.Size(100, 26);
            this.tbxSayi3.TabIndex = 2;
            // 
            // tbxSayi2
            // 
            this.tbxSayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSayi2.Location = new System.Drawing.Point(44, 75);
            this.tbxSayi2.Name = "tbxSayi2";
            this.tbxSayi2.Size = new System.Drawing.Size(100, 26);
            this.tbxSayi2.TabIndex = 3;
            // 
            // rbtnTopla2
            // 
            this.rbtnTopla2.AutoSize = true;
            this.rbtnTopla2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnTopla2.Location = new System.Drawing.Point(150, 64);
            this.rbtnTopla2.Name = "rbtnTopla2";
            this.rbtnTopla2.Size = new System.Drawing.Size(123, 24);
            this.rbtnTopla2.TabIndex = 5;
            this.rbtnTopla2.TabStop = true;
            this.rbtnTopla2.Text = "2 Sayıyı Topla";
            this.rbtnTopla2.UseVisualStyleBackColor = true;
            this.rbtnTopla2.CheckedChanged += new System.EventHandler(this.rbtnTopla2_CheckedChanged);
            // 
            // rbtnTopla4
            // 
            this.rbtnTopla4.AutoSize = true;
            this.rbtnTopla4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnTopla4.Location = new System.Drawing.Point(150, 124);
            this.rbtnTopla4.Name = "rbtnTopla4";
            this.rbtnTopla4.Size = new System.Drawing.Size(123, 24);
            this.rbtnTopla4.TabIndex = 6;
            this.rbtnTopla4.TabStop = true;
            this.rbtnTopla4.Text = "4 Sayıyı Topla";
            this.rbtnTopla4.UseVisualStyleBackColor = true;
            this.rbtnTopla4.CheckedChanged += new System.EventHandler(this.rbtnTopla4_CheckedChanged);
            // 
            // rbtnTopla3
            // 
            this.rbtnTopla3.AutoSize = true;
            this.rbtnTopla3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnTopla3.Location = new System.Drawing.Point(150, 94);
            this.rbtnTopla3.Name = "rbtnTopla3";
            this.rbtnTopla3.Size = new System.Drawing.Size(123, 24);
            this.rbtnTopla3.TabIndex = 7;
            this.rbtnTopla3.TabStop = true;
            this.rbtnTopla3.Text = "3 Sayıyı Topla";
            this.rbtnTopla3.UseVisualStyleBackColor = true;
            this.rbtnTopla3.CheckedChanged += new System.EventHandler(this.rbtnTopla3_CheckedChanged);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.Location = new System.Drawing.Point(135, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(198, 20);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "2, 3 veya 4 Sayının Toplamı";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(67, 182);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(59, 20);
            this.lblSonuc.TabIndex = 9;
            this.lblSonuc.Text = "Sonuc:";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMessage.Location = new System.Drawing.Point(162, 182);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(59, 20);
            this.lblMessage.TabIndex = 10;
            this.lblMessage.Text = "----------";
            // 
            // tbxSayi4
            // 
            this.tbxSayi4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSayi4.Location = new System.Drawing.Point(44, 139);
            this.tbxSayi4.Name = "tbxSayi4";
            this.tbxSayi4.Size = new System.Drawing.Size(100, 26);
            this.tbxSayi4.TabIndex = 11;
            // 
            // frmHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 247);
            this.Controls.Add(this.tbxSayi4);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.rbtnTopla3);
            this.Controls.Add(this.rbtnTopla4);
            this.Controls.Add(this.rbtnTopla2);
            this.Controls.Add(this.tbxSayi2);
            this.Controls.Add(this.tbxSayi3);
            this.Controls.Add(this.tbxSayi1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHeader";
            this.Text = "2, 3 ve 4 Sayının Toplamı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbxSayi1;
        private System.Windows.Forms.TextBox tbxSayi3;
        private System.Windows.Forms.TextBox tbxSayi2;
        private System.Windows.Forms.RadioButton rbtnTopla2;
        private System.Windows.Forms.RadioButton rbtnTopla4;
        private System.Windows.Forms.RadioButton rbtnTopla3;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox tbxSayi4;
    }
}

