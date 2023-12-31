namespace WinApp_Perfumes
{
    partial class Frm_BuscarEditar
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
            this.BuscarBt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txBxCodigo = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataSet11 = new WinApp_Perfumes.DataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // BuscarBt
            // 
            this.BuscarBt.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarBt.Location = new System.Drawing.Point(490, 232);
            this.BuscarBt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BuscarBt.Name = "BuscarBt";
            this.BuscarBt.Size = new System.Drawing.Size(131, 37);
            this.BuscarBt.TabIndex = 62;
            this.BuscarBt.Text = "Buscar";
            this.BuscarBt.UseVisualStyleBackColor = true;
            this.BuscarBt.Click += new System.EventHandler(this.BuscarBt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(202, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(348, 27);
            this.label5.TabIndex = 61;
            this.label5.Text = "Buscar perfume a editar por:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(173, 241);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(84, 27);
            this.lblCodigo.TabIndex = 60;
            this.lblCodigo.Text = "Código";
            // 
            // txBxCodigo
            // 
            this.txBxCodigo.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxCodigo.Location = new System.Drawing.Point(291, 244);
            this.txBxCodigo.Name = "txBxCodigo";
            this.txBxCodigo.Size = new System.Drawing.Size(121, 25);
            this.txBxCodigo.TabIndex = 59;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Frm_BuscarEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 510);
            this.Controls.Add(this.BuscarBt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txBxCodigo);
            this.Name = "Frm_BuscarEditar";
            this.Text = "Frm_BuscarEditar";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuscarBt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txBxCodigo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataSet1 dataSet11;
    }
}