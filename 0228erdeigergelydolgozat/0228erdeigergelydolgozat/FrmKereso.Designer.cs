namespace _0228erdeigergelydolgozat
{
    partial class FrmKereso
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
            this.cb_nyelvek = new System.Windows.Forms.ComboBox();
            this.dgv_kereso = new System.Windows.Forms.DataGridView();
            this.idopont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nyelv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kereso)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_nyelvek
            // 
            this.cb_nyelvek.FormattingEnabled = true;
            this.cb_nyelvek.Location = new System.Drawing.Point(13, 13);
            this.cb_nyelvek.Name = "cb_nyelvek";
            this.cb_nyelvek.Size = new System.Drawing.Size(318, 21);
            this.cb_nyelvek.TabIndex = 0;
            this.cb_nyelvek.SelectedIndexChanged += new System.EventHandler(this.cb_nyelvek_SelectedIndexChanged);
            // 
            // dgv_kereso
            // 
            this.dgv_kereso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kereso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idopont,
            this.nyelv,
            this.szint});
            this.dgv_kereso.Location = new System.Drawing.Point(13, 41);
            this.dgv_kereso.Name = "dgv_kereso";
            this.dgv_kereso.RowHeadersVisible = false;
            this.dgv_kereso.Size = new System.Drawing.Size(318, 190);
            this.dgv_kereso.TabIndex = 1;
            // 
            // idopont
            // 
            this.idopont.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idopont.HeaderText = "Időpont";
            this.idopont.Name = "idopont";
            // 
            // nyelv
            // 
            this.nyelv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nyelv.HeaderText = "Nyelv";
            this.nyelv.Name = "nyelv";
            // 
            // szint
            // 
            this.szint.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.szint.HeaderText = "Szint";
            this.szint.Name = "szint";
            // 
            // FrmKereso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 243);
            this.Controls.Add(this.dgv_kereso);
            this.Controls.Add(this.cb_nyelvek);
            this.Name = "FrmKereso";
            this.Text = "Vizsgakereső";
            this.Load += new System.EventHandler(this.FrmKereso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kereso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_nyelvek;
        private System.Windows.Forms.DataGridView dgv_kereso;
        private System.Windows.Forms.DataGridViewTextBoxColumn idopont;
        private System.Windows.Forms.DataGridViewTextBoxColumn nyelv;
        private System.Windows.Forms.DataGridViewTextBoxColumn szint;
    }
}