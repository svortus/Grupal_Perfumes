namespace WinApp_Perfumes
{
    partial class Frm_Reportes
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
            this.label2 = new System.Windows.Forms.Label();
            this.Reporte1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Reporte2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Reporte3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reportes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Perfumes por código y nombre";
            // 
            // Reporte1
            // 
            this.Reporte1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reporte1.Location = new System.Drawing.Point(498, 103);
            this.Reporte1.Name = "Reporte1";
            this.Reporte1.Size = new System.Drawing.Size(100, 29);
            this.Reporte1.TabIndex = 3;
            this.Reporte1.Text = "Ver";
            this.Reporte1.UseVisualStyleBackColor = true;
            this.Reporte1.Click += new System.EventHandler(this.Reporte1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Perfumes por nombre y tipo";
            // 
            // Reporte2
            // 
            this.Reporte2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reporte2.Location = new System.Drawing.Point(498, 152);
            this.Reporte2.Name = "Reporte2";
            this.Reporte2.Size = new System.Drawing.Size(100, 29);
            this.Reporte2.TabIndex = 5;
            this.Reporte2.Text = "Ver";
            this.Reporte2.UseVisualStyleBackColor = true;
            this.Reporte2.Click += new System.EventHandler(this.Reporte2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Perfumes por nombre y precio";
            // 
            // Reporte3
            // 
            this.Reporte3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reporte3.Location = new System.Drawing.Point(498, 200);
            this.Reporte3.Name = "Reporte3";
            this.Reporte3.Size = new System.Drawing.Size(100, 29);
            this.Reporte3.TabIndex = 7;
            this.Reporte3.Text = "Ver";
            this.Reporte3.UseVisualStyleBackColor = true;
            this.Reporte3.Click += new System.EventHandler(this.Reporte3_Click);
            // 
            // Frm_Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Reporte3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Reporte2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Reporte1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Reportes";
            this.Text = "Frm_Reportes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Reporte1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Reporte2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Reporte3;
    }
}