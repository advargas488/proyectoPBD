
namespace pokedex
{
    partial class MovAdmin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addMoveBtn = new System.Windows.Forms.Button();
            this.actualizarBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.movimiento = new System.Windows.Forms.Label();
            this.Xid = new System.Windows.Forms.TextBox();
            this.errorName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(910, 401);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.update);
            // 
            // addMoveBtn
            // 
            this.addMoveBtn.Location = new System.Drawing.Point(25, 12);
            this.addMoveBtn.Name = "addMoveBtn";
            this.addMoveBtn.Size = new System.Drawing.Size(148, 72);
            this.addMoveBtn.TabIndex = 1;
            this.addMoveBtn.Text = "Crear";
            this.addMoveBtn.UseVisualStyleBackColor = true;
            this.addMoveBtn.Click += new System.EventHandler(this.addMoveBtn_Click);
            // 
            // actualizarBtn
            // 
            this.actualizarBtn.Location = new System.Drawing.Point(25, 107);
            this.actualizarBtn.Name = "actualizarBtn";
            this.actualizarBtn.Size = new System.Drawing.Size(103, 38);
            this.actualizarBtn.TabIndex = 3;
            this.actualizarBtn.Text = "Actualizar";
            this.actualizarBtn.UseVisualStyleBackColor = true;
            this.actualizarBtn.Click += new System.EventHandler(this.actualizarBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(828, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(93, 42);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Atras";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(846, 139);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Eliminar";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // movimiento
            // 
            this.movimiento.AutoSize = true;
            this.movimiento.Location = new System.Drawing.Point(581, 143);
            this.movimiento.Name = "movimiento";
            this.movimiento.Size = new System.Drawing.Size(117, 17);
            this.movimiento.TabIndex = 6;
            this.movimiento.Text = "Id del movimiento";
            // 
            // Xid
            // 
            this.Xid.Location = new System.Drawing.Point(704, 140);
            this.Xid.Name = "Xid";
            this.Xid.Size = new System.Drawing.Size(136, 22);
            this.Xid.TabIndex = 7;
            // 
            // errorName
            // 
            this.errorName.AutoSize = true;
            this.errorName.ForeColor = System.Drawing.Color.Red;
            this.errorName.Location = new System.Drawing.Point(687, 107);
            this.errorName.Name = "errorName";
            this.errorName.Size = new System.Drawing.Size(175, 17);
            this.errorName.TabIndex = 9;
            this.errorName.Text = "Movimiento no encontrado";
            // 
            // MovAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 579);
            this.Controls.Add(this.errorName);
            this.Controls.Add(this.Xid);
            this.Controls.Add(this.movimiento);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.actualizarBtn);
            this.Controls.Add(this.addMoveBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MovAdmin";
            this.Text = "Gestio movimientos";
            this.Load += new System.EventHandler(this.MovAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addMoveBtn;
        private System.Windows.Forms.Button actualizarBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label movimiento;
        private System.Windows.Forms.TextBox Xid;
        private System.Windows.Forms.Label errorName;
    }
}