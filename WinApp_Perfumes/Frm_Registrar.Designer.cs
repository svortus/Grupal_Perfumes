namespace WinApp_Perfumes
{
    partial class Frm_Registrar
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
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Apellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_Cedula = new System.Windows.Forms.TextBox();
            this.Btn_Rsgt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Clave2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Clave = new System.Windows.Forms.TextBox();
            this.Txt_Edad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_Fecha = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_Correo = new System.Windows.Forms.TextBox();
            this.dataSet11 = new WinApp_Perfumes.DataSet1();
            this.label10 = new System.Windows.Forms.Label();
            this.Cbx_Ciudad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar.Location = new System.Drawing.Point(408, 375);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(131, 37);
            this.Btn_Cancelar.TabIndex = 29;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 40);
            this.label2.TabIndex = 28;
            this.label2.Text = "Registro";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(424, 293);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(174, 21);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.Text = "Mostrar contraseña";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Apellido:";
            // 
            // Txt_Apellido
            // 
            this.Txt_Apellido.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Apellido.Location = new System.Drawing.Point(209, 205);
            this.Txt_Apellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Apellido.Name = "Txt_Apellido";
            this.Txt_Apellido.PasswordChar = '*';
            this.Txt_Apellido.Size = new System.Drawing.Size(169, 25);
            this.Txt_Apellido.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(206, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Cedula:";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nombre.Location = new System.Drawing.Point(209, 146);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.PasswordChar = '*';
            this.Txt_Nombre.Size = new System.Drawing.Size(169, 25);
            this.Txt_Nombre.TabIndex = 22;
            // 
            // Txt_Cedula
            // 
            this.Txt_Cedula.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Cedula.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Txt_Cedula.Location = new System.Drawing.Point(206, 88);
            this.Txt_Cedula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Cedula.Name = "Txt_Cedula";
            this.Txt_Cedula.Size = new System.Drawing.Size(169, 25);
            this.Txt_Cedula.TabIndex = 21;
            // 
            // Btn_Rsgt
            // 
            this.Btn_Rsgt.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Rsgt.Location = new System.Drawing.Point(262, 375);
            this.Btn_Rsgt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Rsgt.Name = "Btn_Rsgt";
            this.Btn_Rsgt.Size = new System.Drawing.Size(131, 37);
            this.Btn_Rsgt.TabIndex = 20;
            this.Btn_Rsgt.Text = "Registrarse";
            this.Btn_Rsgt.UseVisualStyleBackColor = true;
            this.Btn_Rsgt.Click += new System.EventHandler(this.Btn_Rsgt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(420, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Confirmar Contraseña:";
            // 
            // Txt_Clave2
            // 
            this.Txt_Clave2.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Clave2.Location = new System.Drawing.Point(423, 264);
            this.Txt_Clave2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Clave2.Name = "Txt_Clave2";
            this.Txt_Clave2.PasswordChar = '*';
            this.Txt_Clave2.Size = new System.Drawing.Size(169, 25);
            this.Txt_Clave2.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(420, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Contraseña:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(423, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Edad:";
            // 
            // Txt_Clave
            // 
            this.Txt_Clave.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Clave.Location = new System.Drawing.Point(423, 205);
            this.Txt_Clave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Clave.Name = "Txt_Clave";
            this.Txt_Clave.PasswordChar = '*';
            this.Txt_Clave.Size = new System.Drawing.Size(169, 25);
            this.Txt_Clave.TabIndex = 31;
            // 
            // Txt_Edad
            // 
            this.Txt_Edad.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Edad.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Txt_Edad.Location = new System.Drawing.Point(423, 88);
            this.Txt_Edad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Edad.Name = "Txt_Edad";
            this.Txt_Edad.Size = new System.Drawing.Size(169, 25);
            this.Txt_Edad.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(206, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Fecha de Nacimiento:";
            // 
            // Txt_Fecha
            // 
            this.Txt_Fecha.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Fecha.Location = new System.Drawing.Point(210, 264);
            this.Txt_Fecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Fecha.Name = "Txt_Fecha";
            this.Txt_Fecha.PasswordChar = '*';
            this.Txt_Fecha.Size = new System.Drawing.Size(169, 25);
            this.Txt_Fecha.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(420, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "Correo Electrónico:";
            // 
            // Txt_Correo
            // 
            this.Txt_Correo.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Correo.Location = new System.Drawing.Point(423, 146);
            this.Txt_Correo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Correo.Name = "Txt_Correo";
            this.Txt_Correo.PasswordChar = '*';
            this.Txt_Correo.Size = new System.Drawing.Size(169, 25);
            this.Txt_Correo.TabIndex = 38;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(206, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "Ciudad:";
            // 
            // Cbx_Ciudad
            // 
            this.Cbx_Ciudad.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbx_Ciudad.FormattingEnabled = true;
            this.Cbx_Ciudad.Location = new System.Drawing.Point(210, 323);
            this.Cbx_Ciudad.Name = "Cbx_Ciudad";
            this.Cbx_Ciudad.Size = new System.Drawing.Size(165, 28);
            this.Cbx_Ciudad.TabIndex = 41;
            // 
            // Frm_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cbx_Ciudad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Txt_Correo);
            this.Controls.Add(this.Txt_Fecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_Clave2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txt_Clave);
            this.Controls.Add(this.Txt_Edad);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Apellido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.Txt_Cedula);
            this.Controls.Add(this.Btn_Rsgt);
            this.Name = "Frm_Registrar";
            this.Text = "Frm_Ingresar";
            this.Load += new System.EventHandler(this.Frm_Registrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Apellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.TextBox Txt_Cedula;
        private System.Windows.Forms.Button Btn_Rsgt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Clave2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Clave;
        private System.Windows.Forms.TextBox Txt_Edad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_Fecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txt_Correo;
        private DataSet1 dataSet11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Cbx_Ciudad;
    }
}