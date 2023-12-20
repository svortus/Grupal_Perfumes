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
            this.rchtxtBxDescripcion = new System.Windows.Forms.RichTextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
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
            // rchtxtBxDescripcion
            // 
            this.rchtxtBxDescripcion.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchtxtBxDescripcion.Location = new System.Drawing.Point(457, 348);
            this.rchtxtBxDescripcion.Name = "rchtxtBxDescripcion";
            this.rchtxtBxDescripcion.Size = new System.Drawing.Size(205, 92);
            this.rchtxtBxDescripcion.TabIndex = 41;
            this.rchtxtBxDescripcion.Text = "";
            this.rchtxtBxDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rchtxtBxDescripcion_KeyPress);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(426, 533);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(126, 76);
            this.btnBorrar.TabIndex = 40;
            this.btnBorrar.Text = "Borrar Campos";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(304, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 27);
            this.label4.TabIndex = 39;
            this.label4.Text = "Precio";
            // 
            // txBxPrecio
            // 
            this.txBxPrecio.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxPrecio.Location = new System.Drawing.Point(541, 283);
            this.txBxPrecio.Name = "txBxPrecio";
            this.txBxPrecio.Size = new System.Drawing.Size(121, 25);
            this.txBxPrecio.TabIndex = 38;
            this.txBxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txBxPrecio_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 27);
            this.label3.TabIndex = 37;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 27);
            this.label2.TabIndex = 36;
            this.label2.Text = "Nombre";
            // 
            // txBxNombre
            // 
            this.txBxNombre.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxNombre.Location = new System.Drawing.Point(541, 176);
            this.txBxNombre.Name = "txBxNombre";
            this.txBxNombre.Size = new System.Drawing.Size(121, 25);
            this.txBxNombre.TabIndex = 35;
            this.txBxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txBxNombre_KeyPress);
            // 
            // lblTipos
            // 
            this.lblTipos.AutoSize = true;
            this.lblTipos.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipos.Location = new System.Drawing.Point(304, 228);
            this.lblTipos.Name = "lblTipos";
            this.lblTipos.Size = new System.Drawing.Size(72, 27);
            this.lblTipos.TabIndex = 34;
            this.lblTipos.Text = "Tipos";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(304, 119);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(84, 27);
            this.lblCodigo.TabIndex = 33;
            this.lblCodigo.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 37);
            this.label1.TabIndex = 32;
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
            this.CboxTipos.Location = new System.Drawing.Point(541, 231);
            this.CboxTipos.Name = "CboxTipos";
            this.CboxTipos.Size = new System.Drawing.Size(121, 28);
            this.CboxTipos.TabIndex = 31;
            this.CboxTipos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CboxTipos_KeyPress);
            // 
            // txBxCodigo
            // 
            this.txBxCodigo.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxCodigo.Location = new System.Drawing.Point(541, 122);
            this.txBxCodigo.Name = "txBxCodigo";
            this.txBxCodigo.Size = new System.Drawing.Size(121, 25);
            this.txBxCodigo.TabIndex = 30;
            this.txBxCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txBxCodigo_KeyPress);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(426, 469);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(126, 43);
            this.btnIngresar.TabIndex = 29;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // Frm_Insercion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 641);
            this.Controls.Add(this.rchtxtBxDescripcion);
            this.Controls.Add(this.btnBorrar);
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

        private System.Windows.Forms.RichTextBox rchtxtBxDescripcion;
        private System.Windows.Forms.Button btnBorrar;
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