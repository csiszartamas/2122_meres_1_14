
namespace _2122_meres_1_14
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
            this.btUjpalyazat = new System.Windows.Forms.Button();
            this.btKilepes = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keretosszeg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szamlakszama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szamlakosszege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btUjpalyazat
            // 
            this.btUjpalyazat.BackColor = System.Drawing.Color.Lime;
            this.btUjpalyazat.Location = new System.Drawing.Point(64, 350);
            this.btUjpalyazat.Name = "btUjpalyazat";
            this.btUjpalyazat.Size = new System.Drawing.Size(347, 52);
            this.btUjpalyazat.TabIndex = 0;
            this.btUjpalyazat.Text = "Új pályázat";
            this.btUjpalyazat.UseVisualStyleBackColor = false;
            this.btUjpalyazat.Click += new System.EventHandler(this.btUjpalyazat_Click);
            // 
            // btKilepes
            // 
            this.btKilepes.BackColor = System.Drawing.Color.Red;
            this.btKilepes.Location = new System.Drawing.Point(426, 350);
            this.btKilepes.Name = "btKilepes";
            this.btKilepes.Size = new System.Drawing.Size(331, 52);
            this.btKilepes.TabIndex = 1;
            this.btKilepes.Text = "Kilépés";
            this.btKilepes.UseVisualStyleBackColor = false;
            this.btKilepes.Click += new System.EventHandler(this.btKilepes_Click);
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.keretosszeg,
            this.szamlakszama,
            this.szamlakosszege});
            this.dgv.Location = new System.Drawing.Point(64, 54);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(693, 274);
            this.dgv.TabIndex = 2;
            // 
            // id
            // 
            this.id.FillWeight = 20F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // keretosszeg
            // 
            this.keretosszeg.HeaderText = "keretösszeg";
            this.keretosszeg.Name = "keretosszeg";
            // 
            // szamlakszama
            // 
            this.szamlakszama.HeaderText = "Számlák száma";
            this.szamlakszama.Name = "szamlakszama";
            this.szamlakszama.ReadOnly = true;
            // 
            // szamlakosszege
            // 
            this.szamlakosszege.HeaderText = "számlák összege";
            this.szamlakosszege.Name = "szamlakosszege";
            this.szamlakosszege.ReadOnly = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btKilepes);
            this.Controls.Add(this.btUjpalyazat);
            this.Name = "FrmMain";
            this.Text = "Pályázatok állapota";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btUjpalyazat;
        private System.Windows.Forms.Button btKilepes;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn keretosszeg;
        private System.Windows.Forms.DataGridViewTextBoxColumn szamlakszama;
        private System.Windows.Forms.DataGridViewTextBoxColumn szamlakosszege;
    }
}

