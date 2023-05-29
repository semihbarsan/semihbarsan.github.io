namespace GelirGiderOtomasyonu
{
    partial class Giderler
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guncelleBtn = new System.Windows.Forms.Button();
            this.noTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.silBtn = new System.Windows.Forms.Button();
            this.kaydetBtn = new System.Windows.Forms.Button();
            this.tarihMtb = new System.Windows.Forms.MaskedTextBox();
            this.alisTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.alinanTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1232, 1182);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.guncelleBtn);
            this.groupBox1.Controls.Add(this.noTxt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.silBtn);
            this.groupBox1.Controls.Add(this.kaydetBtn);
            this.groupBox1.Controls.Add(this.tarihMtb);
            this.groupBox1.Controls.Add(this.alisTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.alinanTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(1281, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 1182);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gider Ekle";
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelleBtn.Location = new System.Drawing.Point(346, 1105);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(292, 62);
            this.guncelleBtn.TabIndex = 32;
            this.guncelleBtn.Text = "GÜNCELLE";
            this.guncelleBtn.UseVisualStyleBackColor = true;
            this.guncelleBtn.Click += new System.EventHandler(this.guncelleBtn_Click);
            // 
            // noTxt
            // 
            this.noTxt.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.noTxt.Location = new System.Drawing.Point(396, 88);
            this.noTxt.Name = "noTxt";
            this.noTxt.Size = new System.Drawing.Size(242, 46);
            this.noTxt.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(303, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 37);
            this.label10.TabIndex = 30;
            this.label10.Text = "No :";
            // 
            // silBtn
            // 
            this.silBtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silBtn.Location = new System.Drawing.Point(346, 1017);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(292, 62);
            this.silBtn.TabIndex = 29;
            this.silBtn.Text = "SİL";
            this.silBtn.UseVisualStyleBackColor = true;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydetBtn.Location = new System.Drawing.Point(346, 928);
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.Size = new System.Drawing.Size(292, 62);
            this.kaydetBtn.TabIndex = 28;
            this.kaydetBtn.Text = "KAYDET";
            this.kaydetBtn.UseVisualStyleBackColor = true;
            this.kaydetBtn.Click += new System.EventHandler(this.kaydetBtn_Click);
            // 
            // tarihMtb
            // 
            this.tarihMtb.Location = new System.Drawing.Point(396, 323);
            this.tarihMtb.Mask = "00/00/0000";
            this.tarihMtb.Name = "tarihMtb";
            this.tarihMtb.Size = new System.Drawing.Size(242, 78);
            this.tarihMtb.TabIndex = 27;
            this.tarihMtb.ValidatingType = typeof(System.DateTime);
            // 
            // alisTxt
            // 
            this.alisTxt.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alisTxt.Location = new System.Drawing.Point(396, 238);
            this.alisTxt.Name = "alisTxt";
            this.alisTxt.Size = new System.Drawing.Size(242, 46);
            this.alisTxt.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(273, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 37);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tarih :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(212, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 37);
            this.label7.TabIndex = 14;
            this.label7.Text = "Alış Fiyatı :         ";
            // 
            // alinanTxt
            // 
            this.alinanTxt.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alinanTxt.Location = new System.Drawing.Point(396, 156);
            this.alinanTxt.Name = "alinanTxt";
            this.alinanTxt.Size = new System.Drawing.Size(242, 46);
            this.alinanTxt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alınan :";
            // 
            // Giderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2103, 1206);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Giderler";
            this.Text = "Giderler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button guncelleBtn;
        private System.Windows.Forms.TextBox noTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.Button kaydetBtn;
        private System.Windows.Forms.MaskedTextBox tarihMtb;
        private System.Windows.Forms.TextBox alisTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox alinanTxt;
        private System.Windows.Forms.Label label1;
    }
}