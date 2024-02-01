
namespace Calisma5
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
            this.rbtnKare = new System.Windows.Forms.RadioButton();
            this.rbtnKup = new System.Windows.Forms.RadioButton();
            this.tbxSayi1 = new System.Windows.Forms.TextBox();
            this.tbxSayi2 = new System.Windows.Forms.TextBox();
            this.lblSayi1 = new System.Windows.Forms.Label();
            this.lblSayi2 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblMessageError = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbtnKare
            // 
            this.rbtnKare.AutoSize = true;
            this.rbtnKare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnKare.Location = new System.Drawing.Point(102, 129);
            this.rbtnKare.Name = "rbtnKare";
            this.rbtnKare.Size = new System.Drawing.Size(77, 24);
            this.rbtnKare.TabIndex = 0;
            this.rbtnKare.TabStop = true;
            this.rbtnKare.Text = "2(kare)";
            this.rbtnKare.UseVisualStyleBackColor = true;
            // 
            // rbtnKup
            // 
            this.rbtnKup.AutoSize = true;
            this.rbtnKup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnKup.Location = new System.Drawing.Point(193, 129);
            this.rbtnKup.Name = "rbtnKup";
            this.rbtnKup.Size = new System.Drawing.Size(72, 24);
            this.rbtnKup.TabIndex = 1;
            this.rbtnKup.TabStop = true;
            this.rbtnKup.Text = "3(küp)";
            this.rbtnKup.UseVisualStyleBackColor = true;
            // 
            // tbxSayi1
            // 
            this.tbxSayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSayi1.Location = new System.Drawing.Point(120, 60);
            this.tbxSayi1.Name = "tbxSayi1";
            this.tbxSayi1.Size = new System.Drawing.Size(100, 26);
            this.tbxSayi1.TabIndex = 2;
            // 
            // tbxSayi2
            // 
            this.tbxSayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSayi2.Location = new System.Drawing.Point(120, 89);
            this.tbxSayi2.Name = "tbxSayi2";
            this.tbxSayi2.Size = new System.Drawing.Size(100, 26);
            this.tbxSayi2.TabIndex = 3;
            this.tbxSayi2.TextChanged += new System.EventHandler(this.tbxSayi2_TextChanged);
            // 
            // lblSayi1
            // 
            this.lblSayi1.AutoSize = true;
            this.lblSayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi1.Location = new System.Drawing.Point(32, 63);
            this.lblSayi1.Name = "lblSayi1";
            this.lblSayi1.Size = new System.Drawing.Size(52, 20);
            this.lblSayi1.TabIndex = 4;
            this.lblSayi1.Text = "1.Sayı";
            // 
            // lblSayi2
            // 
            this.lblSayi2.AutoSize = true;
            this.lblSayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi2.Location = new System.Drawing.Point(32, 94);
            this.lblSayi2.Name = "lblSayi2";
            this.lblSayi2.Size = new System.Drawing.Size(52, 20);
            this.lblSayi2.TabIndex = 5;
            this.lblSayi2.Text = "2.Sayı";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMessage.Location = new System.Drawing.Point(32, 176);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(55, 20);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "Mesaj:";
            // 
            // lblMessageError
            // 
            this.lblMessageError.AutoSize = true;
            this.lblMessageError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMessageError.Location = new System.Drawing.Point(117, 176);
            this.lblMessageError.Name = "lblMessageError";
            this.lblMessageError.Size = new System.Drawing.Size(109, 20);
            this.lblMessageError.TabIndex = 7;
            this.lblMessageError.Text = "--------------------";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.Location = new System.Drawing.Point(48, 18);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(269, 20);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "İki Sayının Kare ve Küplerinin Toplamı";
            // 
            // frmHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 234);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblMessageError);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblSayi2);
            this.Controls.Add(this.lblSayi1);
            this.Controls.Add(this.tbxSayi2);
            this.Controls.Add(this.tbxSayi1);
            this.Controls.Add(this.rbtnKup);
            this.Controls.Add(this.rbtnKare);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHeader";
            this.Text = "İki Sayının Kare ve Küplerinin Toplamı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnKare;
        private System.Windows.Forms.RadioButton rbtnKup;
        private System.Windows.Forms.TextBox tbxSayi1;
        private System.Windows.Forms.TextBox tbxSayi2;
        private System.Windows.Forms.Label lblSayi1;
        private System.Windows.Forms.Label lblSayi2;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblMessageError;
        private System.Windows.Forms.Label lblHeader;
    }
}

