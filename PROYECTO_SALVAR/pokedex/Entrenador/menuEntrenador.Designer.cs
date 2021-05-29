
namespace pokedex.Entrenador
{
    partial class menuEntrenador
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
            this.button1 = new System.Windows.Forms.Button();
            this.bitacora = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.end = new System.Windows.Forms.Button();
            this.RegUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gestion pokemon";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bitacora
            // 
            this.bitacora.Location = new System.Drawing.Point(98, 121);
            this.bitacora.Name = "bitacora";
            this.bitacora.Size = new System.Drawing.Size(186, 78);
            this.bitacora.TabIndex = 1;
            this.bitacora.Text = "Bitacora";
            this.bitacora.UseVisualStyleBackColor = true;
            this.bitacora.Click += new System.EventHandler(this.bitacora_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(98, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 78);
            this.button2.TabIndex = 2;
            this.button2.Text = "Tus pokemon";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(98, 373);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(186, 78);
            this.end.TabIndex = 3;
            this.end.Text = "Cerrar Sesion";
            this.end.UseVisualStyleBackColor = true;
            this.end.Click += new System.EventHandler(this.end_Click);
            // 
            // RegUser
            // 
            this.RegUser.Location = new System.Drawing.Point(98, 289);
            this.RegUser.Name = "RegUser";
            this.RegUser.Size = new System.Drawing.Size(186, 78);
            this.RegUser.TabIndex = 4;
            this.RegUser.Text = "Registrar un usuario";
            this.RegUser.UseVisualStyleBackColor = true;
            this.RegUser.Click += new System.EventHandler(this.RegUser_Click);
            // 
            // menuEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 484);
            this.Controls.Add(this.RegUser);
            this.Controls.Add(this.end);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bitacora);
            this.Controls.Add(this.button1);
            this.Name = "menuEntrenador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Entrenador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bitacora;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button end;
        private System.Windows.Forms.Button RegUser;
    }
}