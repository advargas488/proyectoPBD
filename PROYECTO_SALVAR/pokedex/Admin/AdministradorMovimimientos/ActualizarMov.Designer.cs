
namespace pokedex
{
    partial class Form1
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
            this.codigoM = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.tipo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.success = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // codigoM
            // 
            this.codigoM.Location = new System.Drawing.Point(176, 12);
            this.codigoM.Multiline = true;
            this.codigoM.Name = "codigoM";
            this.codigoM.Size = new System.Drawing.Size(293, 52);
            this.codigoM.TabIndex = 0;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(176, 110);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(293, 22);
            this.nombre.TabIndex = 1;
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(176, 154);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(293, 22);
            this.descripcion.TabIndex = 2;
            // 
            // tipo
            // 
            this.tipo.Location = new System.Drawing.Point(176, 199);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(293, 22);
            this.tipo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Codigo del movimiento\r\na modificar\r\n";
            this.label1.UseCompatibleTextRendering = true;
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo";
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(185, 275);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(105, 43);
            this.updateBtn.TabIndex = 8;
            this.updateBtn.Text = "Actualizar";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.UseWaitCursor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(355, 275);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(105, 43);
            this.backBtn.TabIndex = 9;
            this.backBtn.Text = "Salir";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // success
            // 
            this.success.AutoSize = true;
            this.success.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.success.Location = new System.Drawing.Point(3, 288);
            this.success.Name = "success";
            this.success.Size = new System.Drawing.Size(176, 17);
            this.success.TabIndex = 10;
            this.success.Text = "Actualizado correctamente";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(482, 25);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(119, 17);
            this.error.TabIndex = 11;
            this.error.Text = "Codigo incorrecto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 366);
            this.Controls.Add(this.error);
            this.Controls.Add(this.success);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.codigoM);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar movimiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codigoM;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.TextBox tipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label success;
        private System.Windows.Forms.Label error;
    }
}