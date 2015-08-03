namespace Proyecto.vistas
{
    partial class TipoViewController
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
            this.button1 = new System.Windows.Forms.Button();
            this.mAceptar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mIdentificador = new System.Windows.Forms.TextBox();
            this.mNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mDescripcion = new System.Windows.Forms.RichTextBox();
            this.mGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(234, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mAceptar
            // 
            this.mAceptar.BackColor = System.Drawing.Color.Transparent;
            this.mAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mAceptar.Location = new System.Drawing.Point(360, 453);
            this.mAceptar.Name = "mAceptar";
            this.mAceptar.Size = new System.Drawing.Size(120, 32);
            this.mAceptar.TabIndex = 1;
            this.mAceptar.Text = "Añadir";
            this.mAceptar.UseVisualStyleBackColor = false;
            this.mAceptar.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(108, 453);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 32);
            this.button3.TabIndex = 5;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Identificador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre";
            // 
            // mIdentificador
            // 
            this.mIdentificador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mIdentificador.Location = new System.Drawing.Point(189, 22);
            this.mIdentificador.Name = "mIdentificador";
            this.mIdentificador.Size = new System.Drawing.Size(289, 29);
            this.mIdentificador.TabIndex = 8;
            // 
            // mNombre
            // 
            this.mNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mNombre.Location = new System.Drawing.Point(190, 70);
            this.mNombre.Name = "mNombre";
            this.mNombre.Size = new System.Drawing.Size(288, 29);
            this.mNombre.TabIndex = 9;
            this.mNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mNombre_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Descripcion";
            // 
            // mDescripcion
            // 
            this.mDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mDescripcion.Location = new System.Drawing.Point(190, 128);
            this.mDescripcion.Name = "mDescripcion";
            this.mDescripcion.Size = new System.Drawing.Size(288, 68);
            this.mDescripcion.TabIndex = 11;
            this.mDescripcion.Text = "";
            this.mDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mDescripcion_KeyPress);
            // 
            // mGridView
            // 
            this.mGridView.AllowUserToAddRows = false;
            this.mGridView.AllowUserToDeleteRows = false;
            this.mGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mGridView.Location = new System.Drawing.Point(22, 217);
            this.mGridView.Name = "mGridView";
            this.mGridView.ReadOnly = true;
            this.mGridView.Size = new System.Drawing.Size(456, 221);
            this.mGridView.TabIndex = 12;
            this.mGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mGridView_CellClick);
            this.mGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mGridView_CellContentClick);
            // 
            // TipoViewController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.mGridView);
            this.Controls.Add(this.mDescripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mNombre);
            this.Controls.Add(this.mIdentificador);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.mAceptar);
            this.Controls.Add(this.button1);
            this.Name = "TipoViewController";
            this.Size = new System.Drawing.Size(500, 500);
            this.Load += new System.EventHandler(this.TipoViewController_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button mAceptar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mIdentificador;
        private System.Windows.Forms.TextBox mNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox mDescripcion;
        private System.Windows.Forms.DataGridView mGridView;
    }
}
