namespace WinApp_Perfumes
{
    partial class Frm_Insercion
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
            this.txBxIva = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rchtxtBxDescripcion = new System.Windows.Forms.RichTextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.CboxE_entrega = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txBxFactura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txBxCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txBxPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txBxNombre = new System.Windows.Forms.TextBox();
            this.lblTipos = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CboxTipos = new System.Windows.Forms.ComboBox();
            this.txBxCodigo = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txBxIva
            // 
            this.txBxIva.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxIva.Location = new System.Drawing.Point(352, 385);
            this.txBxIva.Name = "txBxIva";
            this.txBxIva.Size = new System.Drawing.Size(121, 25);
            this.txBxIva.TabIndex = 55;
            this.txBxIva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txBxIva_KeyPress);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(347, 436);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(24, 27);
            this.lblTotal.TabIndex = 54;
            this.lblTotal.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(115, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 27);
            this.label6.TabIndex = 53;
            this.label6.Text = "Iva";
            // 
            // rchtxtBxDescripcion
            // 
            this.rchtxtBxDescripcion.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchtxtBxDescripcion.Location = new System.Drawing.Point(681, 218);
            this.rchtxtBxDescripcion.Name = "rchtxtBxDescripcion";
            this.rchtxtBxDescripcion.Size = new System.Drawing.Size(205, 92);
            this.rchtxtBxDescripcion.TabIndex = 52;
            this.rchtxtBxDescripcion.Text = "";
            this.rchtxtBxDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rchtxtBxDescripcion_KeyPress);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(760, 505);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(126, 76);
            this.btnBorrar.TabIndex = 51;
            this.btnBorrar.Text = "Borrar Campos";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(115, 544);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 27);
            this.label9.TabIndex = 50;
            this.label9.Text = "Estado de Entrega";
            // 
            // CboxE_entrega
            // 
            this.CboxE_entrega.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboxE_entrega.FormattingEnabled = true;
            this.CboxE_entrega.Items.AddRange(new object[] {
            "Entregado",
            "Pendiente"});
            this.CboxE_entrega.Location = new System.Drawing.Point(352, 543);
            this.CboxE_entrega.Name = "CboxE_entrega";
            this.CboxE_entrega.Size = new System.Drawing.Size(121, 28);
            this.CboxE_entrega.TabIndex = 49;
            this.CboxE_entrega.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CboxE_entrega_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(115, 436);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 27);
            this.label8.TabIndex = 48;
            this.label8.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(115, 488);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 27);
            this.label7.TabIndex = 47;
            this.label7.Text = "N° Factura";
            // 
            // txBxFactura
            // 
            this.txBxFactura.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxFactura.Location = new System.Drawing.Point(352, 491);
            this.txBxFactura.Name = "txBxFactura";
            this.txBxFactura.Size = new System.Drawing.Size(121, 25);
            this.txBxFactura.TabIndex = 46;
            this.txBxFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txBxFactura_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(115, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 27);
            this.label5.TabIndex = 45;
            this.label5.Text = "Cantidad";
            // 
            // txBxCantidad
            // 
            this.txBxCantidad.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxCantidad.Location = new System.Drawing.Point(352, 330);
            this.txBxCantidad.Name = "txBxCantidad";
            this.txBxCantidad.Size = new System.Drawing.Size(121, 25);
            this.txBxCantidad.TabIndex = 44;
            this.txBxCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txBxCantidad_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 27);
            this.label4.TabIndex = 43;
            this.label4.Text = "Precio";
            // 
            // txBxPrecio
            // 
            this.txBxPrecio.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxPrecio.Location = new System.Drawing.Point(352, 273);
            this.txBxPrecio.Name = "txBxPrecio";
            this.txBxPrecio.Size = new System.Drawing.Size(121, 25);
            this.txBxPrecio.TabIndex = 42;
            this.txBxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txBxPrecio_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(531, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 27);
            this.label3.TabIndex = 41;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 27);
            this.label2.TabIndex = 40;
            this.label2.Text = "Nombre";
            // 
            // txBxNombre
            // 
            this.txBxNombre.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxNombre.Location = new System.Drawing.Point(352, 166);
            this.txBxNombre.Name = "txBxNombre";
            this.txBxNombre.Size = new System.Drawing.Size(121, 25);
            this.txBxNombre.TabIndex = 39;
            this.txBxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txBxNombre_KeyPress);
            // 
            // lblTipos
            // 
            this.lblTipos.AutoSize = true;
            this.lblTipos.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipos.Location = new System.Drawing.Point(115, 218);
            this.lblTipos.Name = "lblTipos";
            this.lblTipos.Size = new System.Drawing.Size(72, 27);
            this.lblTipos.TabIndex = 38;
            this.lblTipos.Text = "Tipos";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(115, 109);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(84, 27);
            this.lblCodigo.TabIndex = 37;
            this.lblCodigo.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 37);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ingreso de Datos";
            // 
            // CboxTipos
            // 
            this.CboxTipos.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboxTipos.FormattingEnabled = true;
            this.CboxTipos.Items.AddRange(new object[] {
            "Floral",
            "Amaderado",
            "Cítrico",
            "Oriental",
            "Unisex"});
            this.CboxTipos.Location = new System.Drawing.Point(352, 221);
            this.CboxTipos.Name = "CboxTipos";
            this.CboxTipos.Size = new System.Drawing.Size(121, 28);
            this.CboxTipos.TabIndex = 35;
            this.CboxTipos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CboxTipos_KeyPress);
            // 
            // txBxCodigo
            // 
            this.txBxCodigo.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxCodigo.Location = new System.Drawing.Point(352, 112);
            this.txBxCodigo.Name = "txBxCodigo";
            this.txBxCodigo.Size = new System.Drawing.Size(121, 25);
            this.txBxCodigo.TabIndex = 34;
            this.txBxCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txBxCodigo_KeyPress);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(760, 436);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(126, 43);
            this.btnIngresar.TabIndex = 33;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // Frm_Insercion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(217)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(979, 641);
            this.Controls.Add(this.txBxIva);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rchtxtBxDescripcion);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CboxE_entrega);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txBxFactura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txBxCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txBxPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txBxNombre);
            this.Controls.Add(this.lblTipos);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboxTipos);
            this.Controls.Add(this.txBxCodigo);
            this.Controls.Add(this.btnIngresar);
            this.Name = "Frm_Insercion";
            this.Text = "Frm_Insercion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txBxIva;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rchtxtBxDescripcion;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CboxE_entrega;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txBxFactura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txBxCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txBxPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txBxNombre;
        private System.Windows.Forms.Label lblTipos;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboxTipos;
        private System.Windows.Forms.TextBox txBxCodigo;
        private System.Windows.Forms.Button btnIngresar;
    }
}