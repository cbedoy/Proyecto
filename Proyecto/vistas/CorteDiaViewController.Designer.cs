namespace Proyecto.vistas
{
    partial class CorteDiaViewController
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.mTitleView = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mCostoTotal = new System.Windows.Forms.Label();
            this.mPrecioTotalMasIva = new System.Windows.Forms.Label();
            this.mPrecioTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mGanancias = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Corte del día";
            // 
            // mTitleView
            // 
            this.mTitleView.AutoSize = true;
            this.mTitleView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTitleView.Location = new System.Drawing.Point(305, 14);
            this.mTitleView.Name = "mTitleView";
            this.mTitleView.Size = new System.Drawing.Size(100, 24);
            this.mTitleView.TabIndex = 1;
            this.mTitleView.Text = "00/00/0000";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(510, 322);
            this.dataGridView1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Costo Total del Corte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 476);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Precio total del corte + IVA";
            // 
            // mCostoTotal
            // 
            this.mCostoTotal.AutoSize = true;
            this.mCostoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mCostoTotal.Location = new System.Drawing.Point(305, 397);
            this.mCostoTotal.Name = "mCostoTotal";
            this.mCostoTotal.Size = new System.Drawing.Size(111, 24);
            this.mCostoTotal.TabIndex = 5;
            this.mCostoTotal.Text = "$0.00 pesos";
            // 
            // mPrecioTotalMasIva
            // 
            this.mPrecioTotalMasIva.AutoSize = true;
            this.mPrecioTotalMasIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mPrecioTotalMasIva.Location = new System.Drawing.Point(305, 476);
            this.mPrecioTotalMasIva.Name = "mPrecioTotalMasIva";
            this.mPrecioTotalMasIva.Size = new System.Drawing.Size(111, 24);
            this.mPrecioTotalMasIva.TabIndex = 6;
            this.mPrecioTotalMasIva.Text = "$0.00 pesos";
            // 
            // mPrecioTotal
            // 
            this.mPrecioTotal.AutoSize = true;
            this.mPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mPrecioTotal.Location = new System.Drawing.Point(305, 438);
            this.mPrecioTotal.Name = "mPrecioTotal";
            this.mPrecioTotal.Size = new System.Drawing.Size(111, 24);
            this.mPrecioTotal.TabIndex = 8;
            this.mPrecioTotal.Text = "$0.00 pesos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Precio total del corte";
            // 
            // mGanancias
            // 
            this.mGanancias.AutoSize = true;
            this.mGanancias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mGanancias.Location = new System.Drawing.Point(305, 508);
            this.mGanancias.Name = "mGanancias";
            this.mGanancias.Size = new System.Drawing.Size(111, 24);
            this.mGanancias.TabIndex = 10;
            this.mGanancias.Text = "$0.00 pesos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 508);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ganancias Totales";
            // 
            // CorteDiaViewController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.mGanancias);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mPrecioTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mPrecioTotalMasIva);
            this.Controls.Add(this.mCostoTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mTitleView);
            this.Controls.Add(this.label1);
            this.Name = "CorteDiaViewController";
            this.Size = new System.Drawing.Size(553, 547);
            this.Load += new System.EventHandler(this.CorteDiaViewController_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mTitleView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label mCostoTotal;
        private System.Windows.Forms.Label mPrecioTotalMasIva;
        private System.Windows.Forms.Label mPrecioTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label mGanancias;
        private System.Windows.Forms.Label label5;
    }
}
