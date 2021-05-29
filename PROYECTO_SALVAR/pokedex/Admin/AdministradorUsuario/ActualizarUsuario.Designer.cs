
namespace pokedex.AdministradorUsuario
{
    partial class ActualizarUsuario
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
            this.success = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rol = new System.Windows.Forms.ComboBox();
            this.password = new System.Windows.Forms.TextBox();
            this.usuario = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // success
            // 
            this.success.AutoSize = true;
            this.success.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.success.Location = new System.Drawing.Point(325, 278);
            this.success.Name = "success";
            this.success.Size = new System.Drawing.Size(179, 17);
            this.success.TabIndex = 19;
            this.success.Text = "Actualizado correctamente!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Rol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre de usuario";
            // 
            // rol
            // 
            this.rol.FormattingEnabled = true;
            this.rol.Items.AddRange(new object[] {
            "Administrador",
            "Entrenador",
            "Invitado"});
            this.rol.Location = new System.Drawing.Point(321, 225);
            this.rol.Name = "rol";
            this.rol.Size = new System.Drawing.Size(181, 24);
            this.rol.TabIndex = 15;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(312, 155);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(181, 22);
            this.password.TabIndex = 14;
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(312, 97);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(181, 22);
            this.usuario.TabIndex = 13;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(360, 309);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(83, 40);
            this.sendBtn.TabIndex = 12;
            this.sendBtn.Text = "Agregar";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(148, 309);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(83, 40);
            this.backBtn.TabIndex = 11;
            this.backBtn.Text = "Salir";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // ActualizarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 450);
            this.Controls.Add(this.success);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rol);
            this.Controls.Add(this.password);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.backBtn);
            this.Name = "ActualizarUsuario";
            this.Text = "ActualizarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label success;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox rol;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button backBtn;
    }
}