namespace Actualizar_Periodos
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbModulos = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblPeriodoInventarios = new System.Windows.Forms.Label();
            this.lblPeriodoCxC = new System.Windows.Forms.Label();
            this.lblPeriodoVentas = new System.Windows.Forms.Label();
            this.lblPeriodoCxP = new System.Windows.Forms.Label();
            this.lblPeriodoCompras = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbModulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(135, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(242, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Actualizador de Periodos";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.pictureBox1);
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(512, 50);
            this.pnlTitulo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Actualizar_Periodos.Properties.Resources.config;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // gbModulos
            // 
            this.gbModulos.Controls.Add(this.btnActualizar);
            this.gbModulos.Controls.Add(this.label12);
            this.gbModulos.Controls.Add(this.label11);
            this.gbModulos.Controls.Add(this.lblPeriodoInventarios);
            this.gbModulos.Controls.Add(this.lblPeriodoCxC);
            this.gbModulos.Controls.Add(this.lblPeriodoVentas);
            this.gbModulos.Controls.Add(this.lblPeriodoCxP);
            this.gbModulos.Controls.Add(this.lblPeriodoCompras);
            this.gbModulos.Controls.Add(this.label5);
            this.gbModulos.Controls.Add(this.label4);
            this.gbModulos.Controls.Add(this.label3);
            this.gbModulos.Controls.Add(this.label2);
            this.gbModulos.Controls.Add(this.label1);
            this.gbModulos.Location = new System.Drawing.Point(12, 56);
            this.gbModulos.Name = "gbModulos";
            this.gbModulos.Size = new System.Drawing.Size(488, 254);
            this.gbModulos.TabIndex = 2;
            this.gbModulos.TabStop = false;
            this.gbModulos.Text = "Modulos Microsip";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(194, 218);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 30);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(206, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 19);
            this.label12.TabIndex = 11;
            this.label12.Text = "Periodo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(122, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "Modulo";
            // 
            // lblPeriodoInventarios
            // 
            this.lblPeriodoInventarios.AutoSize = true;
            this.lblPeriodoInventarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.lblPeriodoInventarios.Location = new System.Drawing.Point(201, 150);
            this.lblPeriodoInventarios.Name = "lblPeriodoInventarios";
            this.lblPeriodoInventarios.Size = new System.Drawing.Size(102, 19);
            this.lblPeriodoInventarios.TabIndex = 9;
            this.lblPeriodoInventarios.Text = "XX-XXX-XXXX";
            // 
            // lblPeriodoCxC
            // 
            this.lblPeriodoCxC.AutoSize = true;
            this.lblPeriodoCxC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.lblPeriodoCxC.Location = new System.Drawing.Point(201, 131);
            this.lblPeriodoCxC.Name = "lblPeriodoCxC";
            this.lblPeriodoCxC.Size = new System.Drawing.Size(102, 19);
            this.lblPeriodoCxC.TabIndex = 8;
            this.lblPeriodoCxC.Text = "XX-XXX-XXXX";
            // 
            // lblPeriodoVentas
            // 
            this.lblPeriodoVentas.AutoSize = true;
            this.lblPeriodoVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.lblPeriodoVentas.Location = new System.Drawing.Point(201, 169);
            this.lblPeriodoVentas.Name = "lblPeriodoVentas";
            this.lblPeriodoVentas.Size = new System.Drawing.Size(102, 19);
            this.lblPeriodoVentas.TabIndex = 7;
            this.lblPeriodoVentas.Text = "XX-XXX-XXXX";
            // 
            // lblPeriodoCxP
            // 
            this.lblPeriodoCxP.AutoSize = true;
            this.lblPeriodoCxP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.lblPeriodoCxP.Location = new System.Drawing.Point(201, 92);
            this.lblPeriodoCxP.Name = "lblPeriodoCxP";
            this.lblPeriodoCxP.Size = new System.Drawing.Size(245, 19);
            this.lblPeriodoCxP.TabIndex = 6;
            this.lblPeriodoCxP.Text = "Del XX-XXX-XXXX al XX-XXX-XXXX";
            // 
            // lblPeriodoCompras
            // 
            this.lblPeriodoCompras.AutoSize = true;
            this.lblPeriodoCompras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.lblPeriodoCompras.Location = new System.Drawing.Point(201, 73);
            this.lblPeriodoCompras.Name = "lblPeriodoCompras";
            this.lblPeriodoCompras.Size = new System.Drawing.Size(245, 19);
            this.lblPeriodoCompras.TabIndex = 5;
            this.lblPeriodoCompras.Text = "Del XX-XXX-XXXX al XX-XXX-XXXX";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ventas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cuentas por Cobrar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Inventarios:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cuentas por Pagar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compras:";
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 322);
            this.Controls.Add(this.gbModulos);
            this.Controls.Add(this.pnlTitulo);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(528, 360);
            this.MinimumSize = new System.Drawing.Size(528, 360);
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Actualizar Periodos";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbModulos.ResumeLayout(false);
            this.gbModulos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.GroupBox gbModulos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPeriodoInventarios;
        private System.Windows.Forms.Label lblPeriodoCxC;
        private System.Windows.Forms.Label lblPeriodoVentas;
        private System.Windows.Forms.Label lblPeriodoCxP;
        private System.Windows.Forms.Label lblPeriodoCompras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

