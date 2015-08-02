namespace Proyecto.vistas
{
    partial class VentaViewController
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
            this.mFecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mProductoSelector = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mCantidadSelector = new System.Windows.Forms.ComboBox();
            this.mConfirmAction = new System.Windows.Forms.Button();
            this.mDetalleVentaGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mProductoBuscador = new System.Windows.Forms.TextBox();
            this.mBuscarAction = new System.Windows.Forms.Button();
            this.mSubTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mIVA = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.mTotal = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.mPagoCliente = new System.Windows.Forms.TextBox();
            this.mConfirmarPagoAction = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mDetalleVentaGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // mFecha
            // 
            this.mFecha.AutoSize = true;
            this.mFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mFecha.Location = new System.Drawing.Point(237, 16);
            this.mFecha.Name = "mFecha";
            this.mFecha.Size = new System.Drawing.Size(184, 24);
            this.mFecha.TabIndex = 1;
            this.mFecha.Text = "10 de Mayo del 2015";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seleccione Producto";
            // 
            // mProductoSelector
            // 
            this.mProductoSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mProductoSelector.FormattingEnabled = true;
            this.mProductoSelector.Location = new System.Drawing.Point(241, 59);
            this.mProductoSelector.Name = "mProductoSelector";
            this.mProductoSelector.Size = new System.Drawing.Size(412, 32);
            this.mProductoSelector.TabIndex = 3;
            this.mProductoSelector.SelectedIndexChanged += new System.EventHandler(this.mProductoSelector_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cantidad";
            // 
            // mCantidadSelector
            // 
            this.mCantidadSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mCantidadSelector.FormattingEnabled = true;
            this.mCantidadSelector.Location = new System.Drawing.Point(241, 135);
            this.mCantidadSelector.Name = "mCantidadSelector";
            this.mCantidadSelector.Size = new System.Drawing.Size(265, 32);
            this.mCantidadSelector.TabIndex = 5;
            // 
            // mConfirmAction
            // 
            this.mConfirmAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mConfirmAction.Location = new System.Drawing.Point(512, 135);
            this.mConfirmAction.Name = "mConfirmAction";
            this.mConfirmAction.Size = new System.Drawing.Size(141, 32);
            this.mConfirmAction.TabIndex = 6;
            this.mConfirmAction.Text = "Confirmar Cantidad";
            this.mConfirmAction.UseVisualStyleBackColor = true;
            this.mConfirmAction.Click += new System.EventHandler(this.mConfirmAction_Click);
            // 
            // mDetalleVentaGridView
            // 
            this.mDetalleVentaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mDetalleVentaGridView.Location = new System.Drawing.Point(18, 225);
            this.mDetalleVentaGridView.Name = "mDetalleVentaGridView";
            this.mDetalleVentaGridView.Size = new System.Drawing.Size(635, 172);
            this.mDetalleVentaGridView.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Articulos Seleccionados";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Buscar Producto";
            // 
            // mProductoBuscador
            // 
            this.mProductoBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mProductoBuscador.Location = new System.Drawing.Point(241, 100);
            this.mProductoBuscador.Name = "mProductoBuscador";
            this.mProductoBuscador.Size = new System.Drawing.Size(265, 29);
            this.mProductoBuscador.TabIndex = 10;
            // 
            // mBuscarAction
            // 
            this.mBuscarAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBuscarAction.Location = new System.Drawing.Point(512, 96);
            this.mBuscarAction.Name = "mBuscarAction";
            this.mBuscarAction.Size = new System.Drawing.Size(141, 33);
            this.mBuscarAction.TabIndex = 11;
            this.mBuscarAction.Text = "Buscar";
            this.mBuscarAction.UseVisualStyleBackColor = true;
            this.mBuscarAction.Click += new System.EventHandler(this.mBuscarAction_Click);
            // 
            // mSubTotal
            // 
            this.mSubTotal.AutoSize = true;
            this.mSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mSubTotal.Location = new System.Drawing.Point(129, 416);
            this.mSubTotal.Name = "mSubTotal";
            this.mSubTotal.Size = new System.Drawing.Size(111, 24);
            this.mSubTotal.TabIndex = 12;
            this.mSubTotal.Text = "$0.00 pesos";
            this.mSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 416);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "Subtotal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 451);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "IVA";
            // 
            // mIVA
            // 
            this.mIVA.AutoSize = true;
            this.mIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mIVA.Location = new System.Drawing.Point(129, 451);
            this.mIVA.Name = "mIVA";
            this.mIVA.Size = new System.Drawing.Size(111, 24);
            this.mIVA.TabIndex = 14;
            this.mIVA.Text = "$0.00 pesos";
            this.mIVA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 485);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 24);
            this.label11.TabIndex = 17;
            this.label11.Text = "Total";
            // 
            // mTotal
            // 
            this.mTotal.AutoSize = true;
            this.mTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTotal.Location = new System.Drawing.Point(129, 485);
            this.mTotal.Name = "mTotal";
            this.mTotal.Size = new System.Drawing.Size(111, 24);
            this.mTotal.TabIndex = 16;
            this.mTotal.Text = "$0.00 pesos";
            this.mTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(284, 416);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 24);
            this.label13.TabIndex = 18;
            this.label13.Text = "Pago del cliente";
            // 
            // mPagoCliente
            // 
            this.mPagoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mPagoCliente.Location = new System.Drawing.Point(435, 413);
            this.mPagoCliente.Name = "mPagoCliente";
            this.mPagoCliente.Size = new System.Drawing.Size(218, 29);
            this.mPagoCliente.TabIndex = 19;
            // 
            // mConfirmarPagoAction
            // 
            this.mConfirmarPagoAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mConfirmarPagoAction.Location = new System.Drawing.Point(288, 451);
            this.mConfirmarPagoAction.Name = "mConfirmarPagoAction";
            this.mConfirmarPagoAction.Size = new System.Drawing.Size(365, 60);
            this.mConfirmarPagoAction.TabIndex = 20;
            this.mConfirmarPagoAction.Text = "Confirmar Pago";
            this.mConfirmarPagoAction.UseVisualStyleBackColor = true;
            this.mConfirmarPagoAction.Click += new System.EventHandler(this.mConfirmarPagoAction_Click);
            // 
            // VentaViewController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mConfirmarPagoAction);
            this.Controls.Add(this.mPagoCliente);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.mTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mIVA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mSubTotal);
            this.Controls.Add(this.mBuscarAction);
            this.Controls.Add(this.mProductoBuscador);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mDetalleVentaGridView);
            this.Controls.Add(this.mConfirmAction);
            this.Controls.Add(this.mCantidadSelector);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mProductoSelector);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mFecha);
            this.Controls.Add(this.label1);
            this.Name = "VentaViewController";
            this.Size = new System.Drawing.Size(671, 533);
            this.Load += new System.EventHandler(this.VentaViewController_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mDetalleVentaGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox mProductoSelector;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox mCantidadSelector;
        private System.Windows.Forms.Button mConfirmAction;
        private System.Windows.Forms.DataGridView mDetalleVentaGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mProductoBuscador;
        private System.Windows.Forms.Button mBuscarAction;
        private System.Windows.Forms.Label mSubTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label mIVA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label mTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox mPagoCliente;
        private System.Windows.Forms.Button mConfirmarPagoAction;
    }
}
