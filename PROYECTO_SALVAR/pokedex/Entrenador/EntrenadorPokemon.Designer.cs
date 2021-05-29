
namespace pokedex.Entrenador
{
    partial class EntrenadorPokemon
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
            this.idp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.ComboBox();
            this.agregar = new System.Windows.Forms.Button();
            this.userEntrenador = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.error = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.errorPokemon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // idp
            // 
            this.idp.Location = new System.Drawing.Point(156, 44);
            this.idp.Name = "idp";
            this.idp.Size = new System.Drawing.Size(241, 22);
            this.idp.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id Pokemon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estado";
            // 
            // estado
            // 
            this.estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estado.FormattingEnabled = true;
            this.estado.Items.AddRange(new object[] {
            "En equipo",
            "En reserva",
            "Liberado"});
            this.estado.Location = new System.Drawing.Point(156, 85);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(241, 24);
            this.estado.TabIndex = 6;
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(426, 76);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(93, 41);
            this.agregar.TabIndex = 7;
            this.agregar.Text = "Agregar ";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // userEntrenador
            // 
            this.userEntrenador.Location = new System.Drawing.Point(156, 16);
            this.userEntrenador.Name = "userEntrenador";
            this.userEntrenador.Size = new System.Drawing.Size(241, 22);
            this.userEntrenador.TabIndex = 8;
            this.userEntrenador.TextChanged += new System.EventHandler(this.userEntrenador_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(412, 306);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(153, 121);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(204, 17);
            this.error.TabIndex = 10;
            this.error.Text = "No tienes espacio en tu equipo";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(444, 519);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 11;
            this.back.Text = "Atras";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // errorPokemon
            // 
            this.errorPokemon.AutoSize = true;
            this.errorPokemon.ForeColor = System.Drawing.Color.Red;
            this.errorPokemon.Location = new System.Drawing.Point(153, 121);
            this.errorPokemon.Name = "errorPokemon";
            this.errorPokemon.Size = new System.Drawing.Size(178, 17);
            this.errorPokemon.TabIndex = 12;
            this.errorPokemon.Text = "Ingrese un pokemon valido";
            // 
            // EntrenadorPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 554);
            this.Controls.Add(this.errorPokemon);
            this.Controls.Add(this.back);
            this.Controls.Add(this.error);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.userEntrenador);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idp);
            this.Name = "EntrenadorPokemon";
            this.Text = "EntrenadorPokemon";
            this.Load += new System.EventHandler(this.EntrenadorPokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox estado;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.TextBox userEntrenador;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label errorPokemon;
    }
}