namespace Proyecto.vistas
{
    partial class LoginViewController
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mUsername = new System.Windows.Forms.TextBox();
            this.mPassword = new System.Windows.Forms.TextBox();
            this.mLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::Proyecto.Properties.Resources.cODICE_LOGIN;
            this.pictureBox1.InitialImage = global::Proyecto.Properties.Resources.cODICE_LOGIN;
            this.pictureBox1.Location = new System.Drawing.Point(15, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 160);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Huarachería Codice";
            // 
            // mUsername
            // 
            this.mUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mUsername.Location = new System.Drawing.Point(203, 52);
            this.mUsername.Name = "mUsername";
            this.mUsername.Size = new System.Drawing.Size(176, 29);
            this.mUsername.TabIndex = 2;
            // 
            // mPassword
            // 
            this.mPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mPassword.Location = new System.Drawing.Point(203, 89);
            this.mPassword.Name = "mPassword";
            this.mPassword.Size = new System.Drawing.Size(176, 29);
            this.mPassword.TabIndex = 3;
            // 
            // mLogin
            // 
            this.mLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLogin.Location = new System.Drawing.Point(203, 138);
            this.mLogin.Name = "mLogin";
            this.mLogin.Size = new System.Drawing.Size(176, 38);
            this.mLogin.TabIndex = 4;
            this.mLogin.Text = "Entrar";
            this.mLogin.UseVisualStyleBackColor = true;
            this.mLogin.Click += new System.EventHandler(this.mLogin_Click);
            // 
            // LoginViewController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mLogin);
            this.Controls.Add(this.mPassword);
            this.Controls.Add(this.mUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LoginViewController";
            this.Size = new System.Drawing.Size(402, 194);
            this.Load += new System.EventHandler(this.LoginViewController_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mUsername;
        private System.Windows.Forms.TextBox mPassword;
        private System.Windows.Forms.Button mLogin;
    }
}
