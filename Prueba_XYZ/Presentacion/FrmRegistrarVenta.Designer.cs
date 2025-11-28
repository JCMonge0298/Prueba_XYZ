namespace Prueba_XYZ.Presentacion
{
    partial class FrmRegistrarVenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.cboTipoPago = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscarP = new System.Windows.Forms.TextBox();
            this.btnBuscarP = new System.Windows.Forms.Button();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.brnAgregarP = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnLimpiarD = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORMULARIO POS - REGISTRO DE VENTAS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNuevoCliente);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.cboTipoPago);
            this.groupBox1.Controls.Add(this.cboCliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1188, 88);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS GENERALES DE LA VENTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "CLIENTE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "TIPO DE PAGO:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(897, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "FECHA:";
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(87, 32);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(295, 29);
            this.cboCliente.TabIndex = 3;
            // 
            // cboTipoPago
            // 
            this.cboTipoPago.FormattingEnabled = true;
            this.cboTipoPago.Location = new System.Drawing.Point(651, 35);
            this.cboTipoPago.Name = "cboTipoPago";
            this.cboTipoPago.Size = new System.Drawing.Size(170, 29);
            this.cboTipoPago.TabIndex = 4;
            this.cboTipoPago.SelectedIndexChanged += new System.EventHandler(this.cboTipoPago_SelectedIndexChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Location = new System.Drawing.Point(963, 35);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 29);
            this.dtpFecha.TabIndex = 5;
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.BackColor = System.Drawing.Color.LightGreen;
            this.btnNuevoCliente.Location = new System.Drawing.Point(388, 31);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(108, 35);
            this.btnNuevoCliente.TabIndex = 6;
            this.btnNuevoCliente.Text = "NUEVO";
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.brnAgregarP);
            this.groupBox2.Controls.Add(this.dgvProducto);
            this.groupBox2.Controls.Add(this.btnBuscarP);
            this.groupBox2.Controls.Add(this.txtBuscarP);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(28, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 380);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PRODUCTOS";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "FILTRAR:";
            // 
            // txtBuscarP
            // 
            this.txtBuscarP.Location = new System.Drawing.Point(86, 35);
            this.txtBuscarP.Name = "txtBuscarP";
            this.txtBuscarP.Size = new System.Drawing.Size(250, 29);
            this.txtBuscarP.TabIndex = 8;
            this.txtBuscarP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarP_KeyDown);
            // 
            // btnBuscarP
            // 
            this.btnBuscarP.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBuscarP.Location = new System.Drawing.Point(352, 31);
            this.btnBuscarP.Name = "btnBuscarP";
            this.btnBuscarP.Size = new System.Drawing.Size(108, 35);
            this.btnBuscarP.TabIndex = 7;
            this.btnBuscarP.Text = "BUSCAR";
            this.btnBuscarP.UseVisualStyleBackColor = false;
            this.btnBuscarP.Click += new System.EventHandler(this.btnBuscarP_Click);
            // 
            // dgvProducto
            // 
            this.dgvProducto.AllowUserToAddRows = false;
            this.dgvProducto.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Location = new System.Drawing.Point(14, 92);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.ReadOnly = true;
            this.dgvProducto.Size = new System.Drawing.Size(495, 206);
            this.dgvProducto.TabIndex = 9;
            this.dgvProducto.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducto_CellContentDoubleClick);
            this.dgvProducto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducto_CellDoubleClick);
            // 
            // brnAgregarP
            // 
            this.brnAgregarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.brnAgregarP.Location = new System.Drawing.Point(86, 313);
            this.brnAgregarP.Name = "brnAgregarP";
            this.brnAgregarP.Size = new System.Drawing.Size(280, 35);
            this.brnAgregarP.TabIndex = 10;
            this.brnAgregarP.Text = "AGREGAR PRODUCTO AL CARRITO";
            this.brnAgregarP.UseVisualStyleBackColor = false;
            this.brnAgregarP.Click += new System.EventHandler(this.brnAgregarP_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnQuitar);
            this.groupBox3.Controls.Add(this.btnLimpiarD);
            this.groupBox3.Controls.Add(this.dgvDetalles);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(579, 157);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(637, 380);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DETALLES DE LA VENTA";
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Location = new System.Drawing.Point(17, 35);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.Size = new System.Drawing.Size(472, 320);
            this.dgvDetalles.TabIndex = 11;
            this.dgvDetalles.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellEndEdit);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnQuitar.Location = new System.Drawing.Point(495, 74);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(127, 75);
            this.btnQuitar.TabIndex = 11;
            this.btnQuitar.Text = "QUITAR PRODUCTO";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnLimpiarD
            // 
            this.btnLimpiarD.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnLimpiarD.Location = new System.Drawing.Point(495, 174);
            this.btnLimpiarD.Name = "btnLimpiarD";
            this.btnLimpiarD.Size = new System.Drawing.Size(127, 75);
            this.btnLimpiarD.TabIndex = 12;
            this.btnLimpiarD.Text = "LIMPIAR TODOS";
            this.btnLimpiarD.UseVisualStyleBackColor = false;
            this.btnLimpiarD.Click += new System.EventHandler(this.btnLimpiarD_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(155, 563);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "TOTAL A PAGAR:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(333, 559);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(88, 37);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "$0.00";
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.BackColor = System.Drawing.Color.LightGreen;
            this.btnRegistrarVenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarVenta.Location = new System.Drawing.Point(555, 553);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(199, 58);
            this.btnRegistrarVenta.TabIndex = 10;
            this.btnRegistrarVenta.Text = "REGISTRAR VENTA";
            this.btnRegistrarVenta.UseVisualStyleBackColor = false;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Salmon;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(791, 553);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(199, 58);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1240, 634);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmRegistrarVenta";
            this.Text = "REGISTRO DE VENTAS DIARIAS";
            this.Load += new System.EventHandler(this.FrmRegistrarVenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboTipoPago;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarP;
        private System.Windows.Forms.TextBox txtBuscarP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button brnAgregarP;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnLimpiarD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.Button btnCancelar;
    }
}