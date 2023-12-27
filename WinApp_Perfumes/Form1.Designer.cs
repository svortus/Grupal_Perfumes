namespace WinApp_Perfumes
{
    partial class Form1
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
            this.Cbx_Mc = new System.Windows.Forms.CheckBox();
            this.LkL_Rsgt = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Clave = new System.Windows.Forms.TextBox();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.Btn_Ingresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cbx_Mc
            // 
            this.Cbx_Mc.AutoSize = true;
            this.Cbx_Mc.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbx_Mc.Location = new System.Drawing.Point(347, 292);
            this.Cbx_Mc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cbx_Mc.Name = "Cbx_Mc";
            this.Cbx_Mc.Size = new System.Drawing.Size(174, 21);
            this.Cbx_Mc.TabIndex = 15;
            this.Cbx_Mc.Text = "Mostrar contraseña";
            this.Cbx_Mc.UseVisualStyleBackColor = true;
            this.Cbx_Mc.CheckedChanged += new System.EventHandler(this.Cbx_Mc_CheckedChanged);
            // 
            // LkL_Rsgt
            // 
            this.LkL_Rsgt.AutoSize = true;
            this.LkL_Rsgt.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LkL_Rsgt.Location = new System.Drawing.Point(365, 400);
            this.LkL_Rsgt.Name = "LkL_Rsgt";
            this.LkL_Rsgt.Size = new System.Drawing.Size(144, 20);
            this.LkL_Rsgt.TabIndex = 14;
            this.LkL_Rsgt.TabStop = true;
            this.LkL_Rsgt.Text = "Registrate aquí";
            this.LkL_Rsgt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LkL_Rsgt_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(343, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Correo Electrónico:";
            // 
            // Txt_Clave
            // 
            this.Txt_Clave.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Clave.Location = new System.Drawing.Point(347, 261);
            this.Txt_Clave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Clave.Name = "Txt_Clave";
            this.Txt_Clave.PasswordChar = '*';
            this.Txt_Clave.Size = new System.Drawing.Size(169, 25);
            this.Txt_Clave.TabIndex = 11;
            this.Txt_Clave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Clave_KeyPress);
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Usuario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Txt_Usuario.Location = new System.Drawing.Point(347, 205);
            this.Txt_Usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(169, 25);
            this.Txt_Usuario.TabIndex = 10;
            this.Txt_Usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Usuario_KeyPress);
            // 
            // Btn_Ingresar
            // 
            this.Btn_Ingresar.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ingresar.Location = new System.Drawing.Point(369, 337);
            this.Btn_Ingresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Ingresar.Name = "Btn_Ingresar";
            this.Btn_Ingresar.Size = new System.Drawing.Size(131, 37);
            this.Btn_Ingresar.TabIndex = 9;
            this.Btn_Ingresar.Text = "Ingresar";
            this.Btn_Ingresar.UseVisualStyleBackColor = true;
            this.Btn_Ingresar.Click += new System.EventHandler(this.Btn_Ingresar_Click);
            this.Btn_Ingresar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Btn_Ingresar_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(217)))), ((int)(((byte)(251)))));
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 44);
            this.label2.TabIndex = 16;
            this.label2.Text = "Bienvenido";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 540);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cbx_Mc);
            this.Controls.Add(this.LkL_Rsgt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Clave);
            this.Controls.Add(this.Txt_Usuario);
            this.Controls.Add(this.Btn_Ingresar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Cbx_Mc;
        private System.Windows.Forms.LinkLabel LkL_Rsgt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Clave;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.Button Btn_Ingresar;
        private System.Windows.Forms.Label label2;
    }
}

