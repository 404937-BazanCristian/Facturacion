namespace Facturacion.Vistas
{
    partial class FormRegistrarFacturas
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
            this.label_numero = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_formasPago = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.dgv_facturacion = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_articulos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_accion = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_facturacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label_numero
            // 
            this.label_numero.AutoSize = true;
            this.label_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numero.Location = new System.Drawing.Point(12, 9);
            this.label_numero.Name = "label_numero";
            this.label_numero.Size = new System.Drawing.Size(86, 17);
            this.label_numero.TabIndex = 0;
            this.label_numero.Text = "Factura N°";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Forma de Pago:";
            // 
            // cbo_formasPago
            // 
            this.cbo_formasPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_formasPago.FormattingEnabled = true;
            this.cbo_formasPago.Location = new System.Drawing.Point(93, 65);
            this.cbo_formasPago.Name = "cbo_formasPago";
            this.cbo_formasPago.Size = new System.Drawing.Size(121, 21);
            this.cbo_formasPago.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cliente:";
            // 
            // txt_cliente
            // 
            this.txt_cliente.Location = new System.Drawing.Point(93, 92);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(457, 20);
            this.txt_cliente.TabIndex = 6;
            // 
            // dgv_facturacion
            // 
            this.dgv_facturacion.AllowUserToAddRows = false;
            this.dgv_facturacion.AllowUserToDeleteRows = false;
            this.dgv_facturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_facturacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_articulo,
            this.col_pUnitario,
            this.col_cantidad,
            this.col_accion});
            this.dgv_facturacion.Location = new System.Drawing.Point(10, 164);
            this.dgv_facturacion.Name = "dgv_facturacion";
            this.dgv_facturacion.ReadOnly = true;
            this.dgv_facturacion.Size = new System.Drawing.Size(540, 165);
            this.dgv_facturacion.TabIndex = 7;
            this.dgv_facturacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_facturacion_CellClick);
            this.dgv_facturacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_facturacion_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Articulo:";
            // 
            // cbo_articulos
            // 
            this.cbo_articulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_articulos.FormattingEnabled = true;
            this.cbo_articulos.Location = new System.Drawing.Point(93, 118);
            this.cbo_articulos.Name = "cbo_articulos";
            this.cbo_articulos.Size = new System.Drawing.Size(211, 21);
            this.cbo_articulos.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cantidad:";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(369, 118);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_cantidad.TabIndex = 11;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_agregar.Location = new System.Drawing.Point(475, 118);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 39);
            this.btn_agregar.TabIndex = 12;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(203, 335);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 13;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(284, 335);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 14;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(93, 39);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(121, 20);
            this.dtp_fecha.TabIndex = 15;
            // 
            // col_id
            // 
            this.col_id.HeaderText = "Id";
            this.col_id.Name = "col_id";
            this.col_id.ReadOnly = true;
            this.col_id.Visible = false;
            // 
            // col_articulo
            // 
            this.col_articulo.HeaderText = "Articulo";
            this.col_articulo.Name = "col_articulo";
            this.col_articulo.ReadOnly = true;
            this.col_articulo.Width = 197;
            // 
            // col_pUnitario
            // 
            this.col_pUnitario.HeaderText = "Precio Unitario";
            this.col_pUnitario.Name = "col_pUnitario";
            this.col_pUnitario.ReadOnly = true;
            // 
            // col_cantidad
            // 
            this.col_cantidad.HeaderText = "Cantidad";
            this.col_cantidad.Name = "col_cantidad";
            this.col_cantidad.ReadOnly = true;
            // 
            // col_accion
            // 
            this.col_accion.HeaderText = "Accion";
            this.col_accion.Name = "col_accion";
            this.col_accion.ReadOnly = true;
            // 
            // FormRegistrarFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 366);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbo_articulos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_facturacion);
            this.Controls.Add(this.txt_cliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbo_formasPago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_numero);
            this.Name = "FormRegistrarFacturas";
            this.Text = "Registrar Facturas";
            this.Load += new System.EventHandler(this.FormRegistrarFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_facturacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_numero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_formasPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.DataGridView dgv_facturacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_articulos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cantidad;
        private System.Windows.Forms.DataGridViewButtonColumn col_accion;
    }
}