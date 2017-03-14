namespace programform
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
            this.suma = new System.Windows.Forms.Button();
            this.text2 = new System.Windows.Forms.TextBox();
            this.text1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resta = new System.Windows.Forms.Button();
            this.multiplica = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(38, 169);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(24, 22);
            this.suma.TabIndex = 0;
            this.suma.Text = "+";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(150, 110);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(50, 20);
            this.text2.TabIndex = 1;
            this.text2.TextChanged += new System.EventHandler(this.text2_TextChanged);
            // 
            // text1
            // 
            this.text1.BackColor = System.Drawing.SystemColors.Window;
            this.text1.Location = new System.Drawing.Point(38, 110);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(50, 20);
            this.text1.TabIndex = 2;
            this.text1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero 2";
            // 
            // resta
            // 
            this.resta.Location = new System.Drawing.Point(81, 169);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(24, 22);
            this.resta.TabIndex = 5;
            this.resta.Text = "-";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.Click += new System.EventHandler(this.button1_Click);
            // 
            // multiplica
            // 
            this.multiplica.Location = new System.Drawing.Point(121, 169);
            this.multiplica.Name = "multiplica";
            this.multiplica.Size = new System.Drawing.Size(24, 22);
            this.multiplica.TabIndex = 6;
            this.multiplica.Text = "*";
            this.multiplica.UseVisualStyleBackColor = true;
            this.multiplica.Click += new System.EventHandler(this.button2_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(161, 169);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(24, 22);
            this.divide.TabIndex = 7;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(227, 267);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiplica);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.suma);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "CALCULADORA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.Form1_Layout);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button multiplica;
        private System.Windows.Forms.Button divide;
    }
}

