﻿namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Mayusculas = new System.Windows.Forms.RadioButton();
            this.Palindromo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.alturaBox = new System.Windows.Forms.TextBox();
            this.Altura = new System.Windows.Forms.RadioButton();
            this.Longitud = new System.Windows.Forms.RadioButton();
            this.Bonito = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.contLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(174, 48);
            this.nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(244, 26);
            this.nombre.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 366);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.Mayusculas);
            this.groupBox1.Controls.Add(this.Palindromo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.alturaBox);
            this.groupBox1.Controls.Add(this.Altura);
            this.groupBox1.Controls.Add(this.Longitud);
            this.groupBox1.Controls.Add(this.Bonito);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Location = new System.Drawing.Point(18, 175);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(549, 440);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // Mayusculas
            // 
            this.Mayusculas.AutoSize = true;
            this.Mayusculas.Location = new System.Drawing.Point(174, 325);
            this.Mayusculas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mayusculas.Name = "Mayusculas";
            this.Mayusculas.Size = new System.Drawing.Size(308, 24);
            this.Mayusculas.TabIndex = 13;
            this.Mayusculas.TabStop = true;
            this.Mayusculas.Text = "Devuélveme mi nombre en mayúsculas";
            this.Mayusculas.UseVisualStyleBackColor = true;
            // 
            // Palindromo
            // 
            this.Palindromo.AutoSize = true;
            this.Palindromo.Location = new System.Drawing.Point(174, 289);
            this.Palindromo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Palindromo.Name = "Palindromo";
            this.Palindromo.Size = new System.Drawing.Size(267, 24);
            this.Palindromo.TabIndex = 12;
            this.Palindromo.TabStop = true;
            this.Palindromo.Text = "Dime si mi nombre es palíndromo";
            this.Palindromo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Altura";
            // 
            // alturaBox
            // 
            this.alturaBox.Location = new System.Drawing.Point(174, 114);
            this.alturaBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.alturaBox.Name = "alturaBox";
            this.alturaBox.Size = new System.Drawing.Size(244, 26);
            this.alturaBox.TabIndex = 10;
            // 
            // Altura
            // 
            this.Altura.AutoSize = true;
            this.Altura.Location = new System.Drawing.Point(174, 255);
            this.Altura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(144, 24);
            this.Altura.TabIndex = 9;
            this.Altura.TabStop = true;
            this.Altura.Text = "Dime si soy alto";
            this.Altura.UseVisualStyleBackColor = true;
            // 
            // Longitud
            // 
            this.Longitud.AutoSize = true;
            this.Longitud.Location = new System.Drawing.Point(174, 220);
            this.Longitud.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Longitud.Name = "Longitud";
            this.Longitud.Size = new System.Drawing.Size(247, 24);
            this.Longitud.TabIndex = 7;
            this.Longitud.TabStop = true;
            this.Longitud.Text = "Dime la longitud de mi nombre";
            this.Longitud.UseVisualStyleBackColor = true;
            // 
            // Bonito
            // 
            this.Bonito.AutoSize = true;
            this.Bonito.Location = new System.Drawing.Point(174, 185);
            this.Bonito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bonito.Name = "Bonito";
            this.Bonito.Size = new System.Drawing.Size(233, 24);
            this.Bonito.TabIndex = 8;
            this.Bonito.TabStop = true;
            this.Bonito.Text = "Dime si mi nombre es bonito";
            this.Bonito.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 52);
            this.button1.TabIndex = 7;
            this.button1.Text = "Conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 658);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 52);
            this.button3.TabIndex = 8;
            this.button3.Text = "Desconectar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(659, 252);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(195, 52);
            this.button4.TabIndex = 9;
            this.button4.Text = "¿Cuántos servicios?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // contLbl
            // 
            this.contLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contLbl.Location = new System.Drawing.Point(659, 333);
            this.contLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contLbl.Name = "contLbl";
            this.contLbl.Size = new System.Drawing.Size(195, 112);
            this.contLbl.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 865);
            this.Controls.Add(this.contLbl);
            this.Controls.Add(this.button4);
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

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Longitud;
        private System.Windows.Forms.RadioButton Bonito;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox alturaBox;
        private System.Windows.Forms.RadioButton Altura;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton Palindromo;
        private System.Windows.Forms.RadioButton Mayusculas;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label contLbl;
    }
}

