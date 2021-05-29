
namespace pokedex
{
    partial class AddMove
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
            this.codigo = new System.Windows.Forms.TextBox();
            this.tipo = new System.Windows.Forms.TextBox();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.lablexd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idpokemon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.success = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(198, 44);
            this.codigo.Multiline = true;
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(280, 35);
            this.codigo.TabIndex = 0;
            // 
            // tipo
            // 
            this.tipo.Location = new System.Drawing.Point(198, 232);
            this.tipo.Multiline = true;
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(280, 35);
            this.tipo.TabIndex = 1;
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(199, 163);
            this.descripcion.Multiline = true;
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(280, 35);
            this.descripcion.TabIndex = 2;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(198, 102);
            this.nombre.Multiline = true;
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(280, 35);
            this.nombre.TabIndex = 3;
            // 
            // lablexd
            // 
            this.lablexd.AutoSize = true;
            this.lablexd.Location = new System.Drawing.Point(101, 62);
            this.lablexd.Name = "lablexd";
            this.lablexd.Size = new System.Drawing.Size(52, 17);
            this.lablexd.TabIndex = 4;
            this.lablexd.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descripcion (opcional)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo (opcional)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(227, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Asociar a un Pokemon";
            // 
            // idpokemon
            // 
            this.idpokemon.Location = new System.Drawing.Point(198, 333);
            this.idpokemon.Multiline = true;
            this.idpokemon.Name = "idpokemon";
            this.idpokemon.Size = new System.Drawing.Size(280, 35);
            this.idpokemon.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Id pokemon (opcional)";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(198, 409);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(138, 43);
            this.addBtn.TabIndex = 12;
            this.addBtn.Text = "Agregar";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(342, 409);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(138, 43);
            this.exitBtn.TabIndex = 13;
            this.exitBtn.Text = "Salir";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // success
            // 
            this.success.AutoSize = true;
            this.success.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.success.Location = new System.Drawing.Point(44, 422);
            this.success.Name = "success";
            this.success.Size = new System.Drawing.Size(147, 17);
            this.success.TabIndex = 14;
            this.success.Text = "Movimiento agregado!";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(484, 105);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(189, 17);
            this.error.TabIndex = 15;
            this.error.Text = "Ingrese los datos necesarios";
            // 
            // AddMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 464);
            this.Controls.Add(this.error);
            this.Controls.Add(this.success);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idpokemon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lablexd);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.codigo);
            this.Name = "AddMove";
            this.Text = "AddMove";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.TextBox tipo;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label lablexd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idpokemon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label success;
        private System.Windows.Forms.Label error;
    }
}