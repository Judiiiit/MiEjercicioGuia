namespace WindowsFormsApp1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ConvertirFaC = new System.Windows.Forms.RadioButton();
            this.ConvertirCaF = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.aconvertir = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.ConvertirFaC);
            this.groupBox1.Controls.Add(this.ConvertirCaF);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.aconvertir);
            this.groupBox1.Location = new System.Drawing.Point(42, 122);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(614, 266);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // ConvertirFaC
            // 
            this.ConvertirFaC.AutoSize = true;
            this.ConvertirFaC.Location = new System.Drawing.Point(210, 137);
            this.ConvertirFaC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConvertirFaC.Name = "ConvertirFaC";
            this.ConvertirFaC.Size = new System.Drawing.Size(139, 24);
            this.ConvertirFaC.TabIndex = 7;
            this.ConvertirFaC.TabStop = true;
            this.ConvertirFaC.Text = "Convertir F a C";
            this.ConvertirFaC.UseVisualStyleBackColor = true;
            // 
            // ConvertirCaF
            // 
            this.ConvertirCaF.AutoSize = true;
            this.ConvertirCaF.Location = new System.Drawing.Point(210, 102);
            this.ConvertirCaF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConvertirCaF.Name = "ConvertirCaF";
            this.ConvertirCaF.Size = new System.Drawing.Size(139, 24);
            this.ConvertirCaF.TabIndex = 8;
            this.ConvertirCaF.TabStop = true;
            this.ConvertirCaF.Text = "Convertir C a F";
            this.ConvertirCaF.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Conversor";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(262, 192);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // aconvertir
            // 
            this.aconvertir.Location = new System.Drawing.Point(210, 46);
            this.aconvertir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aconvertir.Name = "aconvertir";
            this.aconvertir.Size = new System.Drawing.Size(244, 26);
            this.aconvertir.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 48);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(42, 433);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 35);
            this.button3.TabIndex = 10;
            this.button3.Text = "Desconectar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ConvertirFaC;
        private System.Windows.Forms.RadioButton ConvertirCaF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox aconvertir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

