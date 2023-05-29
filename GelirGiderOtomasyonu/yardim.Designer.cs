namespace GelirGiderOtomasyonu
{
    partial class yardim
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mailTxt = new System.Windows.Forms.TextBox();
            this.konuTxt = new System.Windows.Forms.TextBox();
            this.aciklamaTxt = new System.Windows.Forms.RichTextBox();
            this.gonderBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAIL :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "KONU :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "AÇIKLAMA :";
            // 
            // mailTxt
            // 
            this.mailTxt.Location = new System.Drawing.Point(271, 56);
            this.mailTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mailTxt.Name = "mailTxt";
            this.mailTxt.Size = new System.Drawing.Size(375, 45);
            this.mailTxt.TabIndex = 3;
            // 
            // konuTxt
            // 
            this.konuTxt.Location = new System.Drawing.Point(271, 128);
            this.konuTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.konuTxt.Name = "konuTxt";
            this.konuTxt.Size = new System.Drawing.Size(375, 45);
            this.konuTxt.TabIndex = 4;
            // 
            // aciklamaTxt
            // 
            this.aciklamaTxt.Location = new System.Drawing.Point(271, 234);
            this.aciklamaTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aciklamaTxt.Name = "aciklamaTxt";
            this.aciklamaTxt.Size = new System.Drawing.Size(375, 358);
            this.aciklamaTxt.TabIndex = 5;
            this.aciklamaTxt.Text = "";
            // 
            // gonderBtn
            // 
            this.gonderBtn.Location = new System.Drawing.Point(431, 611);
            this.gonderBtn.Name = "gonderBtn";
            this.gonderBtn.Size = new System.Drawing.Size(215, 45);
            this.gonderBtn.TabIndex = 6;
            this.gonderBtn.Text = "GÖNDER";
            this.gonderBtn.UseVisualStyleBackColor = true;
            this.gonderBtn.Click += new System.EventHandler(this.gonderBtn_Click);
            // 
            // yardim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(760, 912);
            this.Controls.Add(this.gonderBtn);
            this.Controls.Add(this.aciklamaTxt);
            this.Controls.Add(this.konuTxt);
            this.Controls.Add(this.mailTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "yardim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "yardim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox konuTxt;
        private System.Windows.Forms.RichTextBox aciklamaTxt;
        private System.Windows.Forms.Button gonderBtn;
        public System.Windows.Forms.TextBox mailTxt;
    }
}