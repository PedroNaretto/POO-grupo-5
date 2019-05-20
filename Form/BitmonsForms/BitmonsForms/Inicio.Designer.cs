namespace BitmonsForms
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumeroFilas = new System.Windows.Forms.NumericUpDown();
            this.NumeroColumnas = new System.Windows.Forms.NumericUpDown();
            this.botonInicioSimulacion = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.botonSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumeroFilas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumeroColumnas)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "¡Bienvenido a Bitmonlandia!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(203, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tamaño del mapa:\r\n\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(366, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Filas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Location = new System.Drawing.Point(341, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 101);
            this.label4.TabIndex = 3;
            this.label4.Text = "Columnas:";
            // 
            // NumeroFilas
            // 
            this.NumeroFilas.Dock = System.Windows.Forms.DockStyle.Left;
            this.NumeroFilas.Location = new System.Drawing.Point(403, 171);
            this.NumeroFilas.Name = "NumeroFilas";
            this.NumeroFilas.Size = new System.Drawing.Size(120, 20);
            this.NumeroFilas.TabIndex = 4;
            // 
            // NumeroColumnas
            // 
            this.NumeroColumnas.Location = new System.Drawing.Point(403, 198);
            this.NumeroColumnas.Name = "NumeroColumnas";
            this.NumeroColumnas.Size = new System.Drawing.Size(120, 20);
            this.NumeroColumnas.TabIndex = 5;
            // 
            // botonInicioSimulacion
            // 
            this.botonInicioSimulacion.Dock = System.Windows.Forms.DockStyle.Left;
            this.botonInicioSimulacion.Location = new System.Drawing.Point(403, 299);
            this.botonInicioSimulacion.Name = "botonInicioSimulacion";
            this.botonInicioSimulacion.Size = new System.Drawing.Size(120, 45);
            this.botonInicioSimulacion.TabIndex = 6;
            this.botonInicioSimulacion.Text = "Iniciar Simulación";
            this.botonInicioSimulacion.UseVisualStyleBackColor = true;
            this.botonInicioSimulacion.Click += new System.EventHandler(this.InicioSimulacion_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.NumeroColumnas, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.botonInicioSimulacion, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.NumeroFilas, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.botonSalir, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.222222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.55556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // botonSalir
            // 
            this.botonSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.botonSalir.Location = new System.Drawing.Point(277, 299);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(120, 45);
            this.botonSalir.TabIndex = 7;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Inicio";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumeroFilas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumeroColumnas)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NumeroFilas;
        private System.Windows.Forms.NumericUpDown NumeroColumnas;
        private System.Windows.Forms.Button botonInicioSimulacion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button botonSalir;
    }
}

