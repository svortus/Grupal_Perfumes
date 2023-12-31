namespace WinApp_Perfumes
{
    partial class Frm_Editar
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
            this.CancelarBt = new System.Windows.Forms.Button();
            this.EditarBt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.rchtxtBxDescripcion = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txBxPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txBxNombre = new System.Windows.Forms.TextBox();
            this.lblTipos = new System.Windows.Forms.Label();
            this.CboxTipos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelarBt
            // 
            this.CancelarBt.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarBt.Location = new System.Drawing.Point(483, 409);
            this.CancelarBt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelarBt.Name = "CancelarBt";
            this.CancelarBt.Size = new System.Drawing.Size(131, 37);
            this.CancelarBt.TabIndex = 68;
            this.CancelarBt.Text = "Cancelar";
            this.CancelarBt.UseVisualStyleBackColor = true;
            this.CancelarBt.Click += new System.EventHandler(this.CancelarBt_Click);
            // 
            // EditarBt
            // 
            this.EditarBt.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarBt.Location = new System.Drawing.Point(315, 409);
            this.EditarBt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditarBt.Name = "EditarBt";
            this.EditarBt.Size = new System.Drawing.Size(131, 37);
            this.EditarBt.TabIndex = 67;
            this.EditarBt.Text = "Editar";
            this.EditarBt.UseVisualStyleBackColor = true;
            this.EditarBt.Click += new System.EventHandler(this.EditarBt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(394, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 27);
            this.label6.TabIndex = 66;
            this.label6.Text = "Editar:";
            // 
            // rchtxtBxDescripcion
            // 
            this.rchtxtBxDescripcion.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchtxtBxDescripcion.Location = new System.Drawing.Point(399, 278);
            this.rchtxtBxDescripcion.Name = "rchtxtBxDescripcion";
            this.rchtxtBxDescripcion.Size = new System.Drawing.Size(205, 92);
            this.rchtxtBxDescripcion.TabIndex = 65;
            this.rchtxtBxDescripcion.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(246, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 27);
            this.label4.TabIndex = 64;
            this.label4.Text = "Precio:";
            // 
            // txBxPrecio
            // 
            this.txBxPrecio.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxPrecio.Location = new System.Drawing.Point(483, 228);
            this.txBxPrecio.Name = "txBxPrecio";
            this.txBxPrecio.Size = new System.Drawing.Size(121, 25);
            this.txBxPrecio.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 27);
            this.label3.TabIndex = 62;
            this.label3.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 27);
            this.label2.TabIndex = 61;
            this.label2.Text = "Nombre:";
            // 
            // txBxNombre
            // 
            this.txBxNombre.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxNombre.Location = new System.Drawing.Point(483, 134);
            this.txBxNombre.Name = "txBxNombre";
            this.txBxNombre.Size = new System.Drawing.Size(121, 25);
            this.txBxNombre.TabIndex = 60;
            // 
            // lblTipos
            // 
            this.lblTipos.AutoSize = true;
            this.lblTipos.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipos.Location = new System.Drawing.Point(270, 176);
            this.lblTipos.Name = "lblTipos";
            this.lblTipos.Size = new System.Drawing.Size(72, 27);
            this.lblTipos.TabIndex = 59;
            this.lblTipos.Text = "Tipo:";
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
            this.CboxTipos.Location = new System.Drawing.Point(483, 179);
            this.CboxTipos.Name = "CboxTipos";
            this.CboxTipos.Size = new System.Drawing.Size(121, 28);
            this.CboxTipos.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 37);
            this.label1.TabIndex = 57;
            this.label1.Text = "Editar Perfume";
            // 
            // Frm_Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 522);
            this.Controls.Add(this.CancelarBt);
            this.Controls.Add(this.EditarBt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rchtxtBxDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txBxPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txBxNombre);
            this.Controls.Add(this.lblTipos);
            this.Controls.Add(this.CboxTipos);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Editar";
            this.Text = "Frm_Editar";
            this.Load += new System.EventHandler(this.Frm_Editar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelarBt;
        private System.Windows.Forms.Button EditarBt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rchtxtBxDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txBxPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txBxNombre;
        private System.Windows.Forms.Label lblTipos;
        private System.Windows.Forms.ComboBox CboxTipos;
        private System.Windows.Forms.Label label1;
    }
}