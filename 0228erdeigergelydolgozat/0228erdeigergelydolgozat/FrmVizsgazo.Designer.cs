namespace _0228erdeigergelydolgozat
{
    partial class FrmVizsgazo
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
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_nev = new System.Windows.Forms.TextBox();
            this.tb_szul = new System.Windows.Forms.TextBox();
            this.tb_tel = new System.Windows.Forms.TextBox();
            this.lbl_szul = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_nev = new System.Windows.Forms.Label();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.btn_torles = new System.Windows.Forms.Button();
            this.btn_uj = new System.Windows.Forms.Button();
            this.btn_ment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(121, 12);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 20);
            this.tb_id.TabIndex = 0;
            // 
            // tb_nev
            // 
            this.tb_nev.Location = new System.Drawing.Point(121, 53);
            this.tb_nev.Name = "tb_nev";
            this.tb_nev.Size = new System.Drawing.Size(100, 20);
            this.tb_nev.TabIndex = 1;
            // 
            // tb_szul
            // 
            this.tb_szul.Location = new System.Drawing.Point(121, 136);
            this.tb_szul.Name = "tb_szul";
            this.tb_szul.Size = new System.Drawing.Size(100, 20);
            this.tb_szul.TabIndex = 3;
            // 
            // tb_tel
            // 
            this.tb_tel.Location = new System.Drawing.Point(121, 95);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.Size = new System.Drawing.Size(100, 20);
            this.tb_tel.TabIndex = 2;
            // 
            // lbl_szul
            // 
            this.lbl_szul.AutoSize = true;
            this.lbl_szul.Location = new System.Drawing.Point(12, 143);
            this.lbl_szul.Name = "lbl_szul";
            this.lbl_szul.Size = new System.Drawing.Size(69, 13);
            this.lbl_szul.TabIndex = 5;
            this.lbl_szul.Text = "Születési idő:";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(12, 15);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(21, 13);
            this.lbl_id.TabIndex = 5;
            this.lbl_id.Text = "ID:";
            // 
            // lbl_nev
            // 
            this.lbl_nev.AutoSize = true;
            this.lbl_nev.Location = new System.Drawing.Point(12, 53);
            this.lbl_nev.Name = "lbl_nev";
            this.lbl_nev.Size = new System.Drawing.Size(30, 13);
            this.lbl_nev.TabIndex = 7;
            this.lbl_nev.Text = "Név:";
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.Location = new System.Drawing.Point(12, 98);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(70, 13);
            this.lbl_tel.TabIndex = 8;
            this.lbl_tel.Text = "Telefonszám:";
            // 
            // btn_torles
            // 
            this.btn_torles.Enabled = false;
            this.btn_torles.Location = new System.Drawing.Point(300, 53);
            this.btn_torles.Name = "btn_torles";
            this.btn_torles.Size = new System.Drawing.Size(75, 23);
            this.btn_torles.TabIndex = 4;
            this.btn_torles.Text = "Törlés";
            this.btn_torles.UseVisualStyleBackColor = true;
            // 
            // btn_uj
            // 
            this.btn_uj.Enabled = false;
            this.btn_uj.Location = new System.Drawing.Point(300, 98);
            this.btn_uj.Name = "btn_uj";
            this.btn_uj.Size = new System.Drawing.Size(75, 23);
            this.btn_uj.TabIndex = 6;
            this.btn_uj.Text = "Új";
            this.btn_uj.UseVisualStyleBackColor = true;
            // 
            // btn_ment
            // 
            this.btn_ment.Location = new System.Drawing.Point(300, 9);
            this.btn_ment.Name = "btn_ment";
            this.btn_ment.Size = new System.Drawing.Size(75, 23);
            this.btn_ment.TabIndex = 6;
            this.btn_ment.Text = "Mentés";
            this.btn_ment.UseVisualStyleBackColor = true;
            this.btn_ment.Click += new System.EventHandler(this.btn_ment_Click);
            // 
            // FrmVizsgazo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 184);
            this.Controls.Add(this.lbl_tel);
            this.Controls.Add(this.lbl_nev);
            this.Controls.Add(this.btn_uj);
            this.Controls.Add(this.btn_ment);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_szul);
            this.Controls.Add(this.btn_torles);
            this.Controls.Add(this.tb_szul);
            this.Controls.Add(this.tb_tel);
            this.Controls.Add(this.tb_nev);
            this.Controls.Add(this.tb_id);
            this.Name = "FrmVizsgazo";
            this.Text = "FrmVizsgazo";
            this.Load += new System.EventHandler(this.FrmVizsgazo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_szul;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_nev;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.Button btn_torles;
        private System.Windows.Forms.Button btn_uj;
        private System.Windows.Forms.Button btn_ment;
        internal System.Windows.Forms.TextBox tb_id;
        internal System.Windows.Forms.TextBox tb_nev;
        internal System.Windows.Forms.TextBox tb_szul;
        internal System.Windows.Forms.TextBox tb_tel;
    }
}