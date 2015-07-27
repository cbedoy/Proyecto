namespace Proyecto
{
    partial class InventoryViewController
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
            this.mGridInventory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mGridInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // mGridInventory
            // 
            this.mGridInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mGridInventory.Location = new System.Drawing.Point(14, 19);
            this.mGridInventory.Name = "mGridInventory";
            this.mGridInventory.Size = new System.Drawing.Size(697, 438);
            this.mGridInventory.TabIndex = 0;
            // 
            // InventoryViewController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mGridInventory);
            this.Name = "InventoryViewController";
            this.Size = new System.Drawing.Size(734, 480);
            this.Load += new System.EventHandler(this.InventoryViewController_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mGridInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView mGridInventory;
    }
}
