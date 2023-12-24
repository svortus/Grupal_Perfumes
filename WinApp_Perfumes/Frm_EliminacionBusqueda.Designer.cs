namespace WinApp_Perfumes
{
    partial class Frm_EliminacionBusqueda
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txBxCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 37);
            this.label1.TabIndex = 33;
            this.label1.Text = "Eliminación de Perfume";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(262, 259);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(84, 27);
            this.lblCodigo.TabIndex = 35;
            this.lblCodigo.Text = "Código";
            // 
            // txBxCodigo
            // 
            this.txBxCodigo.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxCodigo.Location = new System.Drawing.Point(499, 262);
            this.txBxCodigo.Name = "txBxCodigo";
            this.txBxCodigo.Size = new System.Drawing.Size(121, 25);
            this.txBxCodigo.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(790, 22);
            this.label2.TabIndex = 36;
            this.label2.Text = "Por favor, introduzca el código correspondiente al perfume que desea eliminar.";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(359, 359);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(136, 43);
            this.btnIngresar.TabIndex = 37;
            this.btnIngresar.Text = "Continuar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // Frm_EliminacionBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 556);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txBxCodigo);
            this.Controls.Add(this.label1);
            this.Name = "Frm_EliminacionBusqueda";
            this.Text = "Frm_Eliminacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txBxCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIngresar;
    }
}