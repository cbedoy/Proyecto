namespace Proyecto.vistas
{
    partial class MasterViewController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterViewController));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mFormContainer = new System.Windows.Forms.Panel();
            this.mSalirAction = new System.Windows.Forms.Button();
            this.mInventarioAction = new System.Windows.Forms.Button();
            this.mCorteDelMesAction = new System.Windows.Forms.Button();
            this.mCorteDelDiaAction = new System.Windows.Forms.Button();
            this.mVenderAction = new System.Windows.Forms.Button();
            this.mProductoAction = new System.Windows.Forms.Button();
            this.mModeloAction = new System.Windows.Forms.Button();
            this.mTallaAction = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.mFormContainer);
            this.panel1.Controls.Add(this.mSalirAction);
            this.panel1.Controls.Add(this.mInventarioAction);
            this.panel1.Controls.Add(this.mCorteDelMesAction);
            this.panel1.Controls.Add(this.mCorteDelDiaAction);
            this.panel1.Controls.Add(this.mVenderAction);
            this.panel1.Controls.Add(this.mProductoAction);
            this.panel1.Controls.Add(this.mModeloAction);
            this.panel1.Controls.Add(this.mTallaAction);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 664);
            this.panel1.TabIndex = 0;
            // 
            // mFormContainer
            // 
            this.mFormContainer.BackColor = System.Drawing.Color.Transparent;
            this.mFormContainer.BackgroundImage = global::Proyecto.Properties.Resources.menuprincipal;
            this.mFormContainer.Location = new System.Drawing.Point(9, 4);
            this.mFormContainer.Name = "mFormContainer";
            this.mFormContainer.Size = new System.Drawing.Size(857, 641);
            this.mFormContainer.TabIndex = 8;
            // 
            // mSalirAction
            // 
            this.mSalirAction.BackColor = System.Drawing.Color.White;
            this.mSalirAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mSalirAction.ForeColor = System.Drawing.Color.Red;
            this.mSalirAction.Location = new System.Drawing.Point(891, 462);
            this.mSalirAction.Name = "mSalirAction";
            this.mSalirAction.Size = new System.Drawing.Size(150, 50);
            this.mSalirAction.TabIndex = 7;
            this.mSalirAction.Text = "Salir";
            this.mSalirAction.UseVisualStyleBackColor = false;
            this.mSalirAction.Click += new System.EventHandler(this.mSalirAction_Click);
            // 
            // mInventarioAction
            // 
            this.mInventarioAction.BackColor = System.Drawing.Color.White;
            this.mInventarioAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mInventarioAction.ForeColor = System.Drawing.Color.Green;
            this.mInventarioAction.Location = new System.Drawing.Point(891, 406);
            this.mInventarioAction.Name = "mInventarioAction";
            this.mInventarioAction.Size = new System.Drawing.Size(150, 50);
            this.mInventarioAction.TabIndex = 6;
            this.mInventarioAction.Text = "Inventario";
            this.mInventarioAction.UseVisualStyleBackColor = false;
            this.mInventarioAction.Click += new System.EventHandler(this.mInventarioAction_Click);
            // 
            // mCorteDelMesAction
            // 
            this.mCorteDelMesAction.BackColor = System.Drawing.Color.White;
            this.mCorteDelMesAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mCorteDelMesAction.ForeColor = System.Drawing.Color.Green;
            this.mCorteDelMesAction.Location = new System.Drawing.Point(891, 350);
            this.mCorteDelMesAction.Name = "mCorteDelMesAction";
            this.mCorteDelMesAction.Size = new System.Drawing.Size(150, 50);
            this.mCorteDelMesAction.TabIndex = 5;
            this.mCorteDelMesAction.Text = "Corte del Mes";
            this.mCorteDelMesAction.UseVisualStyleBackColor = false;
            this.mCorteDelMesAction.Click += new System.EventHandler(this.mCorteDelMesAction_Click);
            // 
            // mCorteDelDiaAction
            // 
            this.mCorteDelDiaAction.BackColor = System.Drawing.Color.White;
            this.mCorteDelDiaAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mCorteDelDiaAction.ForeColor = System.Drawing.Color.Green;
            this.mCorteDelDiaAction.Location = new System.Drawing.Point(891, 294);
            this.mCorteDelDiaAction.Name = "mCorteDelDiaAction";
            this.mCorteDelDiaAction.Size = new System.Drawing.Size(150, 50);
            this.mCorteDelDiaAction.TabIndex = 4;
            this.mCorteDelDiaAction.Text = "Corte del Día";
            this.mCorteDelDiaAction.UseVisualStyleBackColor = false;
            this.mCorteDelDiaAction.Click += new System.EventHandler(this.mCorteDelDiaAction_Click);
            // 
            // mVenderAction
            // 
            this.mVenderAction.BackColor = System.Drawing.Color.White;
            this.mVenderAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mVenderAction.ForeColor = System.Drawing.Color.Green;
            this.mVenderAction.Location = new System.Drawing.Point(891, 238);
            this.mVenderAction.Name = "mVenderAction";
            this.mVenderAction.Size = new System.Drawing.Size(150, 50);
            this.mVenderAction.TabIndex = 3;
            this.mVenderAction.Text = "Vender";
            this.mVenderAction.UseVisualStyleBackColor = false;
            this.mVenderAction.Click += new System.EventHandler(this.mVenderAction_Click);
            // 
            // mProductoAction
            // 
            this.mProductoAction.BackColor = System.Drawing.Color.White;
            this.mProductoAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mProductoAction.ForeColor = System.Drawing.Color.Green;
            this.mProductoAction.Location = new System.Drawing.Point(891, 182);
            this.mProductoAction.Name = "mProductoAction";
            this.mProductoAction.Size = new System.Drawing.Size(150, 50);
            this.mProductoAction.TabIndex = 2;
            this.mProductoAction.Text = "Productos";
            this.mProductoAction.UseVisualStyleBackColor = false;
            this.mProductoAction.Click += new System.EventHandler(this.mProductoAction_Click);
            // 
            // mModeloAction
            // 
            this.mModeloAction.BackColor = System.Drawing.Color.White;
            this.mModeloAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mModeloAction.ForeColor = System.Drawing.Color.Green;
            this.mModeloAction.Location = new System.Drawing.Point(891, 126);
            this.mModeloAction.Name = "mModeloAction";
            this.mModeloAction.Size = new System.Drawing.Size(150, 50);
            this.mModeloAction.TabIndex = 1;
            this.mModeloAction.Text = "Modelos";
            this.mModeloAction.UseVisualStyleBackColor = false;
            this.mModeloAction.Click += new System.EventHandler(this.mModeloAction_Click);
            // 
            // mTallaAction
            // 
            this.mTallaAction.BackColor = System.Drawing.Color.White;
            this.mTallaAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTallaAction.ForeColor = System.Drawing.Color.Green;
            this.mTallaAction.Location = new System.Drawing.Point(891, 70);
            this.mTallaAction.Name = "mTallaAction";
            this.mTallaAction.Size = new System.Drawing.Size(150, 50);
            this.mTallaAction.TabIndex = 0;
            this.mTallaAction.Text = "Tallas";
            this.mTallaAction.UseVisualStyleBackColor = false;
            this.mTallaAction.Click += new System.EventHandler(this.mTallaAction_Click);
            // 
            // MasterViewController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1067, 661);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MasterViewController";
            this.Text = "MasterViewController";
            this.Load += new System.EventHandler(this.MasterViewController_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button mSalirAction;
        private System.Windows.Forms.Button mInventarioAction;
        private System.Windows.Forms.Button mCorteDelMesAction;
        private System.Windows.Forms.Button mCorteDelDiaAction;
        private System.Windows.Forms.Button mVenderAction;
        private System.Windows.Forms.Button mProductoAction;
        private System.Windows.Forms.Button mModeloAction;
        private System.Windows.Forms.Button mTallaAction;
        private System.Windows.Forms.Panel mFormContainer;
    }
}