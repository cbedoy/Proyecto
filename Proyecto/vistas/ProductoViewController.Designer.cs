namespace Proyecto.vistas
{
    partial class ProductoViewController
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
            this.mNombre = new System.Windows.Forms.TextBox();
            this.mIdentificador = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.mProductoSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mCosto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mPrecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mTipoSelector = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mModeloSelector = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mTieneTalla = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // mNombre
            // 
            this.mNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mNombre.Location = new System.Drawing.Point(286, 105);
            this.mNombre.Name = "mNombre";
            this.mNombre.Size = new System.Drawing.Size(288, 29);
            this.mNombre.TabIndex = 21;
            // 
            // mIdentificador
            // 
            this.mIdentificador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mIdentificador.Location = new System.Drawing.Point(285, 57);
            this.mIdentificador.Name = "mIdentificador";
            this.mIdentificador.Size = new System.Drawing.Size(289, 29);
            this.mIdentificador.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Identificador";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(206, 419);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 32);
            this.button3.TabIndex = 17;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // mProductoSelector
            // 
            this.mProductoSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mProductoSelector.FormattingEnabled = true;
            this.mProductoSelector.Location = new System.Drawing.Point(286, 13);
            this.mProductoSelector.Name = "mProductoSelector";
            this.mProductoSelector.Size = new System.Drawing.Size(288, 32);
            this.mProductoSelector.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Seleccione Producto";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(458, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 32);
            this.button2.TabIndex = 13;
            this.button2.Text = "Añadir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(332, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mStock
            // 
            this.mStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mStock.Location = new System.Drawing.Point(286, 153);
            this.mStock.Name = "mStock";
            this.mStock.Size = new System.Drawing.Size(142, 29);
            this.mStock.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Stock";
            // 
            // mCosto
            // 
            this.mCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mCosto.Location = new System.Drawing.Point(286, 202);
            this.mCosto.Name = "mCosto";
            this.mCosto.Size = new System.Drawing.Size(288, 29);
            this.mCosto.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "Costo";
            // 
            // mPrecio
            // 
            this.mPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mPrecio.Location = new System.Drawing.Point(286, 253);
            this.mPrecio.Name = "mPrecio";
            this.mPrecio.Size = new System.Drawing.Size(288, 29);
            this.mPrecio.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 24);
            this.label7.TabIndex = 26;
            this.label7.Text = "Precio";
            // 
            // mTipoSelector
            // 
            this.mTipoSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTipoSelector.FormattingEnabled = true;
            this.mTipoSelector.Location = new System.Drawing.Point(286, 308);
            this.mTipoSelector.Name = "mTipoSelector";
            this.mTipoSelector.Size = new System.Drawing.Size(288, 32);
            this.mTipoSelector.TabIndex = 29;
            this.mTipoSelector.SelectedIndexChanged += new System.EventHandler(this.mTipoSelector_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 24);
            this.label8.TabIndex = 28;
            this.label8.Text = "Seleccione Tipo";
            // 
            // mModeloSelector
            // 
            this.mModeloSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mModeloSelector.FormattingEnabled = true;
            this.mModeloSelector.Location = new System.Drawing.Point(286, 358);
            this.mModeloSelector.Name = "mModeloSelector";
            this.mModeloSelector.Size = new System.Drawing.Size(288, 32);
            this.mModeloSelector.TabIndex = 31;
            this.mModeloSelector.SelectedIndexChanged += new System.EventHandler(this.mModeloSelector_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 24);
            this.label9.TabIndex = 30;
            this.label9.Text = "Seleccione Modelo";
            // 
            // mTieneTalla
            // 
            this.mTieneTalla.AutoSize = true;
            this.mTieneTalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTieneTalla.Location = new System.Drawing.Point(451, 153);
            this.mTieneTalla.Name = "mTieneTalla";
            this.mTieneTalla.Size = new System.Drawing.Size(123, 28);
            this.mTieneTalla.TabIndex = 33;
            this.mTieneTalla.Text = "Tiene Talla";
            this.mTieneTalla.UseVisualStyleBackColor = true;
            // 
            // ProductoViewController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mTieneTalla);
            this.Controls.Add(this.mModeloSelector);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mTipoSelector);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mPrecio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mCosto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mStock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mNombre);
            this.Controls.Add(this.mIdentificador);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.mProductoSelector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ProductoViewController";
            this.Size = new System.Drawing.Size(600, 466);
            this.Load += new System.EventHandler(this.ProductoViewController_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mNombre;
        private System.Windows.Forms.TextBox mIdentificador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox mProductoSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox mStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mCosto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mPrecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox mTipoSelector;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox mModeloSelector;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox mTieneTalla;
    }
}
