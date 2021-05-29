
namespace pokedex.AdministradorUsuario
{
    partial class RegistroUsuario
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
            this.backBtn = new System.Windows.Forms.Button();
            this.sendBtn = new System.Windows.Forms.Button();
            this.usuario = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.rol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.success = new System.Windows.Forms.Label();
            this.errorDatos = new System.Windows.Forms.Label();
            this.errorUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(32, 243);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(83, 40);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "Salir";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(244, 243);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(83, 40);
            this.sendBtn.TabIndex = 1;
            this.sendBtn.Text = "Agregar";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(196, 31);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(181, 22);
            this.usuario.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(196, 89);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(181, 22);
            this.password.TabIndex = 3;
            // 
            // rol
            // 
            this.rol.FormattingEnabled = true;
            this.rol.Items.AddRange(new object[] {
            "Administrador",
            "Entrenador",
            "Invitado"});
            this.rol.Location = new System.Drawing.Point(196, 157);
            this.rol.Name = "rol";
            this.rol.Size = new System.Drawing.Size(181, 24);
            this.rol.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rol";
            // 
            // success
            // 
            this.success.AutoSize = true;
            this.success.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.success.Location = new System.Drawing.Point(209, 212);
            this.success.Name = "success";
            this.success.Size = new System.Drawing.Size(168, 17);
            this.success.TabIndex = 8;
            this.success.Text = "Agregado correctamente!";
            // 
            // errorDatos
            // 
            this.errorDatos.AutoSize = true;
            this.errorDatos.ForeColor = System.Drawing.Color.Red;
            this.errorDatos.Location = new System.Drawing.Point(222, 212);
            this.errorDatos.Name = "errorDatos";
            this.errorDatos.Size = new System.Drawing.Size(155, 17);
            this.errorDatos.TabIndex = 9;
            this.errorDatos.Text = "Ingrese todos los datos";
            this.errorDatos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // errorUser
            // 
            this.errorUser.AutoSize = true;
            this.errorUser.ForeColor = System.Drawing.Color.Red;
            this.errorUser.Location = new System.Drawing.Point(383, 36);
            this.errorUser.Name = "errorUser";
            this.errorUser.Size = new System.Drawing.Size(136, 17);
            this.errorUser.TabIndex = 10;
            this.errorUser.Text = "Usuario ya existente";
            // 
            // RegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 305);
            this.Controls.Add(this.errorUser);
            this.Controls.Add(this.errorDatos);
            this.Controls.Add(this.success);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rol);
            this.Controls.Add(this.password);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.backBtn);
            this.Name = "RegistroUsuario";
            this.Text = "Crear Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.ComboBox rol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label success;
        private System.Windows.Forms.Label errorDatos;
        private System.Windows.Forms.Label errorUser;
    }
}