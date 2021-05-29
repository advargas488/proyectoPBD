
namespace pokedex
{
    partial class menuAdmin
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
            this.movBtn = new System.Windows.Forms.Button();
            this.pokeVerBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cerrarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // movBtn
            // 
            this.movBtn.Location = new System.Drawing.Point(204, 159);
            this.movBtn.Name = "movBtn";
            this.movBtn.Size = new System.Drawing.Size(156, 62);
            this.movBtn.TabIndex = 1;
            this.movBtn.Text = "Gestionar movimientos";
            this.movBtn.UseVisualStyleBackColor = true;
            this.movBtn.Click += new System.EventHandler(this.movBtn_Click);
            // 
            // pokeVerBtn
            // 
            this.pokeVerBtn.Location = new System.Drawing.Point(204, 62);
            this.pokeVerBtn.Name = "pokeVerBtn";
            this.pokeVerBtn.Size = new System.Drawing.Size(156, 62);
            this.pokeVerBtn.TabIndex = 2;
            this.pokeVerBtn.Text = "Pokemons";
            this.pokeVerBtn.UseVisualStyleBackColor = true;
            this.pokeVerBtn.Click += new System.EventHandler(this.pokeVerBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 62);
            this.button1.TabIndex = 3;
            this.button1.Text = "Gestionar entrenadores\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 60);
            this.button2.TabIndex = 4;
            this.button2.Text = "Gestionar usuarios\r\n\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cerrarSesion
            // 
            this.cerrarSesion.Location = new System.Drawing.Point(204, 459);
            this.cerrarSesion.Name = "cerrarSesion";
            this.cerrarSesion.Size = new System.Drawing.Size(156, 67);
            this.cerrarSesion.TabIndex = 5;
            this.cerrarSesion.Text = "Cerrar Sesion";
            this.cerrarSesion.UseVisualStyleBackColor = true;
            this.cerrarSesion.Click += new System.EventHandler(this.cerrarSesion_Click);
            // 
            // menuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 582);
            this.Controls.Add(this.cerrarSesion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pokeVerBtn);
            this.Controls.Add(this.movBtn);
            this.Name = "menuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button movBtn;
        private System.Windows.Forms.Button pokeVerBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cerrarSesion;
    }
}