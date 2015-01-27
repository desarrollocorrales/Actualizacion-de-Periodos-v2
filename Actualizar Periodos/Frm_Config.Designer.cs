namespace Actualizar_Periodos
{
    partial class Frm_Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Config));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnltitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbServidor = new System.Windows.Forms.TextBox();
            this.txbBaseDeDatos = new System.Windows.Forms.TextBox();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.txbContrasenia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudPuerto = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnltitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuerto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(138, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(203, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Configurar Conexion";
            // 
            // pnltitulo
            // 
            this.pnltitulo.Controls.Add(this.lblTitulo);
            this.pnltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltitulo.Location = new System.Drawing.Point(0, 0);
            this.pnltitulo.Name = "pnltitulo";
            this.pnltitulo.Size = new System.Drawing.Size(479, 50);
            this.pnltitulo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Servidor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Base de datos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Contraseña:";
            // 
            // txbServidor
            // 
            this.txbServidor.Location = new System.Drawing.Point(143, 62);
            this.txbServidor.Name = "txbServidor";
            this.txbServidor.Size = new System.Drawing.Size(250, 27);
            this.txbServidor.TabIndex = 6;
            // 
            // txbBaseDeDatos
            // 
            this.txbBaseDeDatos.Location = new System.Drawing.Point(143, 95);
            this.txbBaseDeDatos.Name = "txbBaseDeDatos";
            this.txbBaseDeDatos.Size = new System.Drawing.Size(310, 27);
            this.txbBaseDeDatos.TabIndex = 7;
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(143, 128);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(185, 27);
            this.txbUsuario.TabIndex = 8;
            // 
            // txbContrasenia
            // 
            this.txbContrasenia.Location = new System.Drawing.Point(143, 161);
            this.txbContrasenia.Name = "txbContrasenia";
            this.txbContrasenia.PasswordChar = '*';
            this.txbContrasenia.Size = new System.Drawing.Size(185, 27);
            this.txbContrasenia.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Puerto:";
            // 
            // nudPuerto
            // 
            this.nudPuerto.Location = new System.Drawing.Point(143, 194);
            this.nudPuerto.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.nudPuerto.Name = "nudPuerto";
            this.nudPuerto.Size = new System.Drawing.Size(120, 27);
            this.nudPuerto.TabIndex = 11;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardar.Location = new System.Drawing.Point(189, 240);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Frm_Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 282);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.nudPuerto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbContrasenia);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.txbBaseDeDatos);
            this.Controls.Add(this.txbServidor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnltitulo);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(495, 320);
            this.MinimumSize = new System.Drawing.Size(495, 320);
            this.Name = "Frm_Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.Frm_Config_Load);
            this.pnltitulo.ResumeLayout(false);
            this.pnltitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuerto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnltitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbServidor;
        private System.Windows.Forms.TextBox txbBaseDeDatos;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.TextBox txbContrasenia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudPuerto;
        private System.Windows.Forms.Button btnGuardar;
    }
}