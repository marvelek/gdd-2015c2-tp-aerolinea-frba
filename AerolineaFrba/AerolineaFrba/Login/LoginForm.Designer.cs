namespace AerolineaFrba.Login
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.entrar = new System.Windows.Forms.Button();
            this.alta_usuario = new System.Windows.Forms.Button();
            this.cambiar_password = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(137, 62);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(100, 20);
            this.usuario.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(137, 110);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 3;
            // 
            // entrar
            // 
            this.entrar.Location = new System.Drawing.Point(186, 206);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(75, 23);
            this.entrar.TabIndex = 4;
            this.entrar.Text = "Entrar";
            this.entrar.UseVisualStyleBackColor = true;
            // 
            // alta_usuario
            // 
            this.alta_usuario.Location = new System.Drawing.Point(39, 206);
            this.alta_usuario.Name = "alta_usuario";
            this.alta_usuario.Size = new System.Drawing.Size(75, 23);
            this.alta_usuario.TabIndex = 5;
            this.alta_usuario.Text = "Alta usuario";
            this.alta_usuario.UseVisualStyleBackColor = true;
            // 
            // cambiar_password
            // 
            this.cambiar_password.AutoSize = true;
            this.cambiar_password.Location = new System.Drawing.Point(58, 148);
            this.cambiar_password.Name = "cambiar_password";
            this.cambiar_password.Size = new System.Drawing.Size(112, 17);
            this.cambiar_password.TabIndex = 6;
            this.cambiar_password.Text = "Cambiar password";
            this.cambiar_password.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cambiar_password);
            this.Controls.Add(this.alta_usuario);
            this.Controls.Add(this.entrar);
            this.Controls.Add(this.password);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button entrar;
        private System.Windows.Forms.Button alta_usuario;
        private System.Windows.Forms.CheckBox cambiar_password;
    }
}