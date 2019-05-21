namespace BitmonsForms
{
    partial class GeneradorMapa
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
            this.components = new System.ComponentModel.Container();
            this.tablaForm = new System.Windows.Forms.TableLayoutPanel();
            this.tablaMapa = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.botonInicioSimulacion = new System.Windows.Forms.Button();
            this.BotonAtras = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxTipoTerreno = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTipoBitmon = new System.Windows.Forms.ComboBox();
            this.BotonAgregarBitmon = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tablaForm.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaForm
            // 
            this.tablaForm.AutoSize = true;
            this.tablaForm.ColumnCount = 4;
            this.tablaForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablaForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablaForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tablaForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tablaForm.Controls.Add(this.tablaMapa, 2, 1);
            this.tablaForm.Controls.Add(this.flowLayoutPanel1, 2, 3);
            this.tablaForm.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.tablaForm.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tablaForm.Controls.Add(this.botonLimpiar, 1, 3);
            this.tablaForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaForm.Location = new System.Drawing.Point(0, 0);
            this.tablaForm.Name = "tablaForm";
            this.tablaForm.RowCount = 4;
            this.tablaForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablaForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tablaForm.Size = new System.Drawing.Size(792, 431);
            this.tablaForm.TabIndex = 0;
            // 
            // tablaMapa
            // 
            this.tablaMapa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tablaMapa.AutoSize = true;
            this.tablaMapa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tablaMapa.ColumnCount = 2;
            this.tablaMapa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaMapa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaMapa.Location = new System.Drawing.Point(470, 200);
            this.tablaMapa.Name = "tablaMapa";
            this.tablaMapa.RowCount = 2;
            this.tablaForm.SetRowSpan(this.tablaMapa, 2);
            this.tablaMapa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaMapa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaMapa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablaMapa.Size = new System.Drawing.Size(0, 0);
            this.tablaMapa.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.botonInicioSimulacion);
            this.flowLayoutPanel1.Controls.Add(this.BotonAtras);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(173, 383);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(594, 45);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // botonInicioSimulacion
            // 
            this.botonInicioSimulacion.Location = new System.Drawing.Point(478, 3);
            this.botonInicioSimulacion.Name = "botonInicioSimulacion";
            this.botonInicioSimulacion.Size = new System.Drawing.Size(113, 42);
            this.botonInicioSimulacion.TabIndex = 0;
            this.botonInicioSimulacion.Text = "Iniciar Simulación";
            this.botonInicioSimulacion.UseVisualStyleBackColor = true;
            this.botonInicioSimulacion.Click += new System.EventHandler(this.botonInicioSimulacion_Click);
            // 
            // BotonAtras
            // 
            this.BotonAtras.Location = new System.Drawing.Point(359, 3);
            this.BotonAtras.Name = "BotonAtras";
            this.BotonAtras.Size = new System.Drawing.Size(113, 42);
            this.BotonAtras.TabIndex = 1;
            this.BotonAtras.Text = "Atras";
            this.BotonAtras.UseVisualStyleBackColor = true;
            this.BotonAtras.Click += new System.EventHandler(this.BotonAtras_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.comboBoxTipoTerreno, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(144, 174);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // comboBoxTipoTerreno
            // 
            this.comboBoxTipoTerreno.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxTipoTerreno.Enabled = false;
            this.comboBoxTipoTerreno.FormattingEnabled = true;
            this.comboBoxTipoTerreno.Location = new System.Drawing.Point(3, 90);
            this.comboBoxTipoTerreno.Name = "comboBoxTipoTerreno";
            this.comboBoxTipoTerreno.Size = new System.Drawing.Size(138, 21);
            this.comboBoxTipoTerreno.TabIndex = 2;
            this.comboBoxTipoTerreno.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoTerreno_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(3, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Escoja tipo de terreno";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxTipoBitmon, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.BotonAgregarBitmon, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(23, 203);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(144, 174);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Bitmon";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxTipoBitmon
            // 
            this.comboBoxTipoBitmon.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxTipoBitmon.Enabled = false;
            this.comboBoxTipoBitmon.FormattingEnabled = true;
            this.comboBoxTipoBitmon.Location = new System.Drawing.Point(3, 37);
            this.comboBoxTipoBitmon.Name = "comboBoxTipoBitmon";
            this.comboBoxTipoBitmon.Size = new System.Drawing.Size(138, 21);
            this.comboBoxTipoBitmon.TabIndex = 1;
            this.comboBoxTipoBitmon.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoBitmon_SelectedIndexChanged);
            // 
            // BotonAgregarBitmon
            // 
            this.BotonAgregarBitmon.Dock = System.Windows.Forms.DockStyle.Top;
            this.BotonAgregarBitmon.Enabled = false;
            this.BotonAgregarBitmon.Location = new System.Drawing.Point(3, 106);
            this.BotonAgregarBitmon.Name = "BotonAgregarBitmon";
            this.BotonAgregarBitmon.Size = new System.Drawing.Size(138, 39);
            this.BotonAgregarBitmon.TabIndex = 4;
            this.BotonAgregarBitmon.Text = "Agregar";
            this.BotonAgregarBitmon.UseVisualStyleBackColor = true;
            this.BotonAgregarBitmon.Click += new System.EventHandler(this.BotonAgregarBitmon_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botonLimpiar.Location = new System.Drawing.Point(23, 383);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(144, 45);
            this.botonLimpiar.TabIndex = 4;
            this.botonLimpiar.Text = "Limpiar celda";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // GeneradorMapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(792, 431);
            this.Controls.Add(this.tablaForm);
            this.Name = "GeneradorMapa";
            this.Text = "GeneradorMapa";
            this.Load += new System.EventHandler(this.GeneradorMapa_Load);
            this.tablaForm.ResumeLayout(false);
            this.tablaForm.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tablaForm;
        private System.Windows.Forms.TableLayoutPanel tablaMapa;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button botonInicioSimulacion;
        private System.Windows.Forms.Button BotonAtras;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBoxTipoTerreno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BotonAgregarBitmon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTipoBitmon;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}