namespace _0228erdeigergelydolgozat
{
    partial class FrmMain
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
            this.dgv_main = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.neve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nyelv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ms_main = new System.Windows.Forms.MenuStrip();
            this.tsm_vizsgak = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_ujvizsgazo = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            this.ms_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_main
            // 
            this.dgv_main.AllowUserToAddRows = false;
            this.dgv_main.AllowUserToDeleteRows = false;
            this.dgv_main.AllowUserToResizeColumns = false;
            this.dgv_main.AllowUserToResizeRows = false;
            this.dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.neve,
            this.nyelv,
            this.szint});
            this.dgv_main.Location = new System.Drawing.Point(13, 55);
            this.dgv_main.Name = "dgv_main";
            this.dgv_main.RowHeadersVisible = false;
            this.dgv_main.Size = new System.Drawing.Size(490, 202);
            this.dgv_main.TabIndex = 2;
            this.dgv_main.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_main_CellClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // neve
            // 
            this.neve.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.neve.HeaderText = "Vizsgázó neve";
            this.neve.Name = "neve";
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
            // ms_main
            // 
            this.ms_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_vizsgak,
            this.tsm_ujvizsgazo});
            this.ms_main.Location = new System.Drawing.Point(0, 0);
            this.ms_main.Name = "ms_main";
            this.ms_main.Size = new System.Drawing.Size(515, 24);
            this.ms_main.TabIndex = 3;
            this.ms_main.Text = "menuStrip1";
            // 
            // tsm_vizsgak
            // 
            this.tsm_vizsgak.Name = "tsm_vizsgak";
            this.tsm_vizsgak.Size = new System.Drawing.Size(58, 20);
            this.tsm_vizsgak.Text = "Vizsgák";
            this.tsm_vizsgak.Click += new System.EventHandler(this.tsm_vizsgak_Click);
            // 
            // tsm_ujvizsgazo
            // 
            this.tsm_ujvizsgazo.Name = "tsm_ujvizsgazo";
            this.tsm_ujvizsgazo.Size = new System.Drawing.Size(77, 20);
            this.tsm_ujvizsgazo.Text = "Új vizsgázó";
            this.tsm_ujvizsgazo.Click += new System.EventHandler(this.tsm_ujvizsgazo_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 278);
            this.Controls.Add(this.dgv_main);
            this.Controls.Add(this.ms_main);
            this.MainMenuStrip = this.ms_main;
            this.Name = "FrmMain";
            this.Text = "Nyelviskola";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            this.ms_main.ResumeLayout(false);
            this.ms_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_main;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn neve;
        private System.Windows.Forms.DataGridViewTextBoxColumn nyelv;
        private System.Windows.Forms.DataGridViewTextBoxColumn szint;
        private System.Windows.Forms.MenuStrip ms_main;
        private System.Windows.Forms.ToolStripMenuItem tsm_vizsgak;
        private System.Windows.Forms.ToolStripMenuItem tsm_ujvizsgazo;
    }
}

