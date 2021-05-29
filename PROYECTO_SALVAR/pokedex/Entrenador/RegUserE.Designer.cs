
namespace pokedex.Entrenador
{
    partial class RegUserE
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
            this.go = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.success = new System.Windows.Forms.Label();
            this.errorName = new System.Windows.Forms.Label();
            this.errorDatos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // go
            // 
            this.go.Location = new System.Drawing.Point(108, 223);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(80, 36);
            this.go.TabIndex = 0;
            this.go.Text = "Registrar";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(283, 223);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(80, 36);
            this.back.TabIndex = 1;
            this.back.Text = "Atras";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(117, 63);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(246, 22);
            this.user.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(117, 124);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(246, 22);
            this.password.TabIndex = 4;
            // 
            // success
            // 
            this.success.AutoSize = true;
            this.success.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.success.Location = new System.Drawing.Point(191, 196);
            this.success.Name = "success";
            this.success.Size = new System.Drawing.Size(80, 17);
            this.success.TabIndex = 6;
            this.success.Text = "Registrado!";
            // 
            // errorName
            // 
            this.errorName.AutoSize = true;
            this.errorName.ForeColor = System.Drawing.Color.Red;
            this.errorName.Location = new System.Drawing.Point(133, 196);
            this.errorName.Name = "errorName";
            this.errorName.Size = new System.Drawing.Size(217, 17);
            this.errorName.TabIndex = 7;
            this.errorName.Text = "Nombre de usuario no disponible";
            // 
            // errorDatos
            // 
            this.errorDatos.AutoSize = true;
            this.errorDatos.ForeColor = System.Drawing.Color.Red;
            this.errorDatos.Location = new System.Drawing.Point(160, 196);
            this.errorDatos.Name = "errorDatos";
            this.errorDatos.Size = new System.Drawing.Size(155, 17);
            this.errorDatos.TabIndex = 8;
            this.errorDatos.Text = "Ingrese todos los datos\r\n";
            // 
            // RegUserE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 322);
            this.Controls.Add(this.errorDatos);
            this.Controls.Add(this.errorName);
            this.Controls.Add(this.success);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user);
            this.Controls.Add(this.back);
            this.Controls.Add(this.go);
            this.Name = "RegUserE";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label success;
        private System.Windows.Forms.Label errorName;
        private System.Windows.Forms.Label errorDatos;
    }
}