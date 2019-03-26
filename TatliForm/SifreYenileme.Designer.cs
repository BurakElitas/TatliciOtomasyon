namespace TatliForm
{
    partial class SifreYenileme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifreYenileme));
            this.label1 = new System.Windows.Forms.Label();
            this.txtkullan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelsoru = new System.Windows.Forms.Label();
            this.txtcevap = new System.Windows.Forms.TextBox();
            this.btnonay = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btncevap = new System.Windows.Forms.Button();
            this.txtyenisifre = new System.Windows.Forms.TextBox();
            this.lblyenisifre = new System.Windows.Forms.Label();
            this.btnyenisifre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(72, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // txtkullan
            // 
            this.txtkullan.Location = new System.Drawing.Point(75, 128);
            this.txtkullan.Name = "txtkullan";
            this.txtkullan.Size = new System.Drawing.Size(217, 20);
            this.txtkullan.TabIndex = 3;
            this.txtkullan.TextChanged += new System.EventHandler(this.txtkullan_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(134, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre Yenileme Ekranı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(72, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Güvenlik Sorusu:";
            // 
            // labelsoru
            // 
            this.labelsoru.AutoSize = true;
            this.labelsoru.ForeColor = System.Drawing.Color.Maroon;
            this.labelsoru.Location = new System.Drawing.Point(166, 177);
            this.labelsoru.Name = "labelsoru";
            this.labelsoru.Size = new System.Drawing.Size(0, 13);
            this.labelsoru.TabIndex = 6;
            // 
            // txtcevap
            // 
            this.txtcevap.Location = new System.Drawing.Point(75, 198);
            this.txtcevap.Name = "txtcevap";
            this.txtcevap.Size = new System.Drawing.Size(217, 20);
            this.txtcevap.TabIndex = 7;
            // 
            // btnonay
            // 
            this.btnonay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnonay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnonay.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnonay.ForeColor = System.Drawing.Color.Lime;
            this.btnonay.Location = new System.Drawing.Point(298, 124);
            this.btnonay.Name = "btnonay";
            this.btnonay.Size = new System.Drawing.Size(70, 28);
            this.btnonay.TabIndex = 16;
            this.btnonay.Text = "Onay";
            this.btnonay.UseVisualStyleBackColor = true;
            this.btnonay.Click += new System.EventHandler(this.btnonay_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(155, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btncevap
            // 
            this.btncevap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncevap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncevap.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncevap.ForeColor = System.Drawing.Color.Lime;
            this.btncevap.Location = new System.Drawing.Point(298, 194);
            this.btncevap.Name = "btncevap";
            this.btncevap.Size = new System.Drawing.Size(70, 28);
            this.btncevap.TabIndex = 18;
            this.btncevap.Text = "Onay";
            this.btncevap.UseVisualStyleBackColor = true;
            this.btncevap.Click += new System.EventHandler(this.btncevap_Click);
            // 
            // txtyenisifre
            // 
            this.txtyenisifre.Location = new System.Drawing.Point(75, 251);
            this.txtyenisifre.Name = "txtyenisifre";
            this.txtyenisifre.Size = new System.Drawing.Size(217, 20);
            this.txtyenisifre.TabIndex = 20;
            // 
            // lblyenisifre
            // 
            this.lblyenisifre.AutoSize = true;
            this.lblyenisifre.BackColor = System.Drawing.Color.Transparent;
            this.lblyenisifre.ForeColor = System.Drawing.Color.Yellow;
            this.lblyenisifre.Location = new System.Drawing.Point(72, 235);
            this.lblyenisifre.Name = "lblyenisifre";
            this.lblyenisifre.Size = new System.Drawing.Size(52, 13);
            this.lblyenisifre.TabIndex = 19;
            this.lblyenisifre.Text = "Yeni Şifre";
            // 
            // btnyenisifre
            // 
            this.btnyenisifre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnyenisifre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnyenisifre.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyenisifre.ForeColor = System.Drawing.Color.Lime;
            this.btnyenisifre.Location = new System.Drawing.Point(298, 247);
            this.btnyenisifre.Name = "btnyenisifre";
            this.btnyenisifre.Size = new System.Drawing.Size(70, 28);
            this.btnyenisifre.TabIndex = 21;
            this.btnyenisifre.Text = "Onay";
            this.btnyenisifre.UseVisualStyleBackColor = true;
            this.btnyenisifre.Click += new System.EventHandler(this.btnyenisifre_Click);
            // 
            // SifreYenileme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(416, 359);
            this.Controls.Add(this.btnyenisifre);
            this.Controls.Add(this.txtyenisifre);
            this.Controls.Add(this.lblyenisifre);
            this.Controls.Add(this.btncevap);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnonay);
            this.Controls.Add(this.txtcevap);
            this.Controls.Add(this.labelsoru);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtkullan);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SifreYenileme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SifreYenileme";
            this.Load += new System.EventHandler(this.SifreYenileme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtkullan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelsoru;
        private System.Windows.Forms.TextBox txtcevap;
        private System.Windows.Forms.Button btnonay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btncevap;
        private System.Windows.Forms.TextBox txtyenisifre;
        private System.Windows.Forms.Label lblyenisifre;
        private System.Windows.Forms.Button btnyenisifre;
    }
}