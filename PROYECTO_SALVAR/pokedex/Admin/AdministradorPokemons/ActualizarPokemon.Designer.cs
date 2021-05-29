
namespace pokedex
{
    partial class ActualizarPokemon
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
            this.errorId = new System.Windows.Forms.Label();
            this.legendario = new System.Windows.Forms.ComboBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.generacion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.velocidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.espDefensa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.espAtaque = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.defensa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ataque = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.salud = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.type2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.type1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.indentificador = new System.Windows.Forms.TextBox();
            this.error = new System.Windows.Forms.Label();
            this.success = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // errorId
            // 
            this.errorId.AutoSize = true;
            this.errorId.ForeColor = System.Drawing.Color.Red;
            this.errorId.Location = new System.Drawing.Point(560, 70);
            this.errorId.Name = "errorId";
            this.errorId.Size = new System.Drawing.Size(216, 17);
            this.errorId.TabIndex = 62;
            this.errorId.Text = "El nombre del pokemon ya existe";
            // 
            // legendario
            // 
            this.legendario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.legendario.FormattingEnabled = true;
            this.legendario.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.legendario.Location = new System.Drawing.Point(246, 391);
            this.legendario.Name = "legendario";
            this.legendario.Size = new System.Drawing.Size(302, 24);
            this.legendario.TabIndex = 59;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(84, 449);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(213, 37);
            this.backBtn.TabIndex = 58;
            this.backBtn.Text = "Atras";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(313, 449);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(213, 37);
            this.updateBtn.TabIndex = 57;
            this.updateBtn.Text = "Actualizar Pokemon";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(70, 391);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 17);
            this.label11.TabIndex = 56;
            this.label11.Text = "Legendario";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(70, 363);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 17);
            this.label12.TabIndex = 55;
            this.label12.Text = "Generacion";
            // 
            // generacion
            // 
            this.generacion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.generacion.Location = new System.Drawing.Point(246, 358);
            this.generacion.Name = "generacion";
            this.generacion.Size = new System.Drawing.Size(303, 22);
            this.generacion.TabIndex = 54;
            this.generacion.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(70, 335);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 17);
            this.label13.TabIndex = 53;
            this.label13.Text = "Velocidad";
            // 
            // velocidad
            // 
            this.velocidad.ForeColor = System.Drawing.SystemColors.WindowText;
            this.velocidad.Location = new System.Drawing.Point(246, 330);
            this.velocidad.Name = "velocidad";
            this.velocidad.Size = new System.Drawing.Size(303, 22);
            this.velocidad.TabIndex = 52;
            this.velocidad.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 51;
            this.label6.Text = "Defensa especial";
            // 
            // espDefensa
            // 
            this.espDefensa.ForeColor = System.Drawing.SystemColors.WindowText;
            this.espDefensa.Location = new System.Drawing.Point(246, 298);
            this.espDefensa.Name = "espDefensa";
            this.espDefensa.Size = new System.Drawing.Size(303, 22);
            this.espDefensa.TabIndex = 50;
            this.espDefensa.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 49;
            this.label7.Text = "Ataque especial";
            // 
            // espAtaque
            // 
            this.espAtaque.ForeColor = System.Drawing.SystemColors.WindowText;
            this.espAtaque.Location = new System.Drawing.Point(246, 270);
            this.espAtaque.Name = "espAtaque";
            this.espAtaque.Size = new System.Drawing.Size(303, 22);
            this.espAtaque.TabIndex = 48;
            this.espAtaque.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 47;
            this.label8.Text = "Defensa";
            // 
            // defensa
            // 
            this.defensa.ForeColor = System.Drawing.SystemColors.WindowText;
            this.defensa.Location = new System.Drawing.Point(246, 242);
            this.defensa.Name = "defensa";
            this.defensa.Size = new System.Drawing.Size(303, 22);
            this.defensa.TabIndex = 46;
            this.defensa.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 45;
            this.label9.Text = "Ataque";
            // 
            // ataque
            // 
            this.ataque.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ataque.Location = new System.Drawing.Point(246, 214);
            this.ataque.Name = "ataque";
            this.ataque.Size = new System.Drawing.Size(303, 22);
            this.ataque.TabIndex = 44;
            this.ataque.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(70, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 43;
            this.label10.Text = "Salud";
            // 
            // salud
            // 
            this.salud.ForeColor = System.Drawing.SystemColors.WindowText;
            this.salud.Location = new System.Drawing.Point(246, 186);
            this.salud.Name = "salud";
            this.salud.Size = new System.Drawing.Size(303, 22);
            this.salud.TabIndex = 42;
            this.salud.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "Total";
            // 
            // total
            // 
            this.total.ForeColor = System.Drawing.SystemColors.WindowText;
            this.total.Location = new System.Drawing.Point(246, 154);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(303, 22);
            this.total.TabIndex = 40;
            this.total.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Tipo 2 del pokemon";
            // 
            // type2
            // 
            this.type2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.type2.Location = new System.Drawing.Point(246, 126);
            this.type2.Name = "type2";
            this.type2.Size = new System.Drawing.Size(303, 22);
            this.type2.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Tipo 1 del pokemon";
            // 
            // type1
            // 
            this.type1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.type1.Location = new System.Drawing.Point(246, 98);
            this.type1.Name = "type1";
            this.type1.Size = new System.Drawing.Size(303, 22);
            this.type1.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nombre del pokemon";
            // 
            // name
            // 
            this.name.ForeColor = System.Drawing.SystemColors.WindowText;
            this.name.Location = new System.Drawing.Point(246, 70);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(303, 22);
            this.name.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Identificador del pokemon a modificar";
            // 
            // indentificador
            // 
            this.indentificador.ForeColor = System.Drawing.SystemColors.WindowText;
            this.indentificador.Location = new System.Drawing.Point(269, 12);
            this.indentificador.Name = "indentificador";
            this.indentificador.Size = new System.Drawing.Size(303, 22);
            this.indentificador.TabIndex = 32;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(595, 17);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(213, 17);
            this.error.TabIndex = 61;
            this.error.Text = "Porfavor ingrese todos los datos";
            // 
            // success
            // 
            this.success.AutoSize = true;
            this.success.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.success.Location = new System.Drawing.Point(566, 465);
            this.success.Name = "success";
            this.success.Size = new System.Drawing.Size(206, 17);
            this.success.TabIndex = 63;
            this.success.Text = "Pokemon actualizado con exito!";
            // 
            // ActualizarPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 538);
            this.Controls.Add(this.success);
            this.Controls.Add(this.errorId);
            this.Controls.Add(this.error);
            this.Controls.Add(this.legendario);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.generacion);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.velocidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.espDefensa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.espAtaque);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.defensa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ataque);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.salud);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.type2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.type1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.indentificador);
            this.Name = "ActualizarPokemon";
            this.Text = "ActualizarPokemon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label errorId;
        private System.Windows.Forms.ComboBox legendario;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox generacion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox velocidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox espDefensa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox espAtaque;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox defensa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ataque;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox salud;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox type2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox type1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox indentificador;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Label success;
    }
}