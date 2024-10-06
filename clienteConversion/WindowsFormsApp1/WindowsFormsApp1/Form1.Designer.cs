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
            this.groupBox1.Location = new System.Drawing.Point(28, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 173);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // ConvertirFaC
            // 
            this.ConvertirFaC.AutoSize = true;
            this.ConvertirFaC.Location = new System.Drawing.Point(140, 89);
            this.ConvertirFaC.Name = "ConvertirFaC";
            this.ConvertirFaC.Size = new System.Drawing.Size(95, 17);
            this.ConvertirFaC.TabIndex = 7;
            this.ConvertirFaC.TabStop = true;
            this.ConvertirFaC.Text = "Convertir F a C";
            this.ConvertirFaC.UseVisualStyleBackColor = true;
            // 
            // ConvertirCaF
            // 
            this.ConvertirCaF.AutoSize = true;
            this.ConvertirCaF.Location = new System.Drawing.Point(140, 66);
            this.ConvertirCaF.Name = "ConvertirCaF";
            this.ConvertirCaF.Size = new System.Drawing.Size(95, 17);
            this.ConvertirCaF.TabIndex = 8;
            this.ConvertirCaF.TabStop = true;
            this.ConvertirCaF.Text = "Convertir C a F";
            this.ConvertirCaF.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Conversor";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(175, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // aconvertir
            // 
            this.aconvertir.Location = new System.Drawing.Point(140, 30);
            this.aconvertir.Name = "aconvertir";
            this.aconvertir.Size = new System.Drawing.Size(164, 20);
            this.aconvertir.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
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
    }
}

