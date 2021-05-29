
namespace pokedex
{
    partial class pokeForm
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
            this.pokeData = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.actualizarInfo = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.XId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pokeData)).BeginInit();
            this.SuspendLayout();
            // 
            // pokeData
            // 
            this.pokeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pokeData.Location = new System.Drawing.Point(12, 163);
            this.pokeData.Name = "pokeData";
            this.pokeData.RowHeadersWidth = 51;
            this.pokeData.RowTemplate.Height = 24;
            this.pokeData.Size = new System.Drawing.Size(1395, 402);
            this.pokeData.TabIndex = 0;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(12, 22);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(139, 62);
            this.add.TabIndex = 1;
            this.add.Text = "Nuevo";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // actualizarInfo
            // 
            this.actualizarInfo.Location = new System.Drawing.Point(12, 126);
            this.actualizarInfo.Name = "actualizarInfo";
            this.actualizarInfo.Size = new System.Drawing.Size(139, 31);
            this.actualizarInfo.TabIndex = 2;
            this.actualizarInfo.Text = "Actualizar";
            this.actualizarInfo.UseVisualStyleBackColor = true;
            this.actualizarInfo.Click += new System.EventHandler(this.actualizarInfo_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(179, 22);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(139, 62);
            this.editBtn.TabIndex = 3;
            this.editBtn.Text = "Buscar y Editar";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(1277, 19);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(129, 64);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Salir";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(1331, 130);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 5;
            this.delete.Text = "Eliminar";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // XId
            // 
            this.XId.Location = new System.Drawing.Point(1144, 130);
            this.XId.Name = "XId";
            this.XId.Size = new System.Drawing.Size(181, 22);
            this.XId.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1056, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id Pokemon";
            // 
            // errorName
            // 
            this.errorName.AutoSize = true;
            this.errorName.ForeColor = System.Drawing.Color.Red;
            this.errorName.Location = new System.Drawing.Point(1151, 99);
            this.errorName.Name = "errorName";
            this.errorName.Size = new System.Drawing.Size(163, 17);
            this.errorName.TabIndex = 8;
            this.errorName.Text = "Pokemon no encontrado";
            // 
            // pokeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 577);
            this.Controls.Add(this.errorName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.XId);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.actualizarInfo);
            this.Controls.Add(this.add);
            this.Controls.Add(this.pokeData);
            this.Name = "pokeForm";
            this.Text = "Pokemons";
            this.Load += new System.EventHandler(this.Pokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pokeData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView pokeData;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button actualizarInfo;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox XId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errorName;
    }
}