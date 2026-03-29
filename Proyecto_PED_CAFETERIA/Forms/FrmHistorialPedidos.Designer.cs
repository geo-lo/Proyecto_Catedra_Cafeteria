namespace Proyecto_PED_CAFETERIA.Forms
{
    partial class FrmHistorialPedidos
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
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c,
            this.p,
            this.t});
            this.dgvHistorial.Location = new System.Drawing.Point(25, 58);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.Size = new System.Drawing.Size(523, 211);
            this.dgvHistorial.TabIndex = 0;
            // 
            // c
            // 
            this.c.Frozen = true;
            this.c.HeaderText = "Cliente";
            this.c.Name = "c";
            this.c.ReadOnly = true;
            // 
            // p
            // 
            this.p.Frozen = true;
            this.p.HeaderText = "Productos";
            this.p.Name = "p";
            this.p.ReadOnly = true;
            // 
            // t
            // 
            this.t.Frozen = true;
            this.t.HeaderText = "Total";
            this.t.Name = "t";
            this.t.ReadOnly = true;
            // 
            // FrmHistorialPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 320);
            this.Controls.Add(this.dgvHistorial);
            this.Name = "FrmHistorialPedidos";
            this.Text = "FrmHistorialPedidos";
            this.Load += new System.EventHandler(this.FrmHistorialPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn c;
        private System.Windows.Forms.DataGridViewTextBoxColumn p;
        private System.Windows.Forms.DataGridViewTextBoxColumn t;
    }
}