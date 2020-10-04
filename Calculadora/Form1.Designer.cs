namespace Calculadora
{
    partial class Form1
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
            this.valor1 = new System.Windows.Forms.TextBox();
            this.valor2 = new System.Windows.Forms.TextBox();
            this.buttoncalcular = new System.Windows.Forms.Button();
            this.operacion = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // valor1
            // 
            this.valor1.Location = new System.Drawing.Point(73, 12);
            this.valor1.Name = "valor1";
            this.valor1.Size = new System.Drawing.Size(100, 20);
            this.valor1.TabIndex = 0;
            this.valor1.Text = "Valor 1";
            this.valor1.TextChanged += new System.EventHandler(this.valor1_TextChanged);
            // 
            // valor2
            // 
            this.valor2.Location = new System.Drawing.Point(73, 96);
            this.valor2.Name = "valor2";
            this.valor2.Size = new System.Drawing.Size(100, 20);
            this.valor2.TabIndex = 1;
            this.valor2.Text = "Valor 2";
            this.valor2.TextChanged += new System.EventHandler(this.valor2_TextChanged);
            // 
            // buttoncalcular
            // 
            this.buttoncalcular.Location = new System.Drawing.Point(48, 154);
            this.buttoncalcular.Name = "buttoncalcular";
            this.buttoncalcular.Size = new System.Drawing.Size(142, 56);
            this.buttoncalcular.TabIndex = 2;
            this.buttoncalcular.Text = "Calcular";
            this.buttoncalcular.UseVisualStyleBackColor = true;
            this.buttoncalcular.Click += new System.EventHandler(this.buttoncalcular_Click);
            // 
            // operacion
            // 
            this.operacion.FormattingEnabled = true;
            this.operacion.Items.AddRange(new object[] {
            "Sumar",
            "Restar",
            "Dividir"});
            this.operacion.Location = new System.Drawing.Point(73, 53);
            this.operacion.Name = "operacion";
            this.operacion.Size = new System.Drawing.Size(100, 21);
            this.operacion.TabIndex = 4;
            this.operacion.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 260);
            this.Controls.Add(this.operacion);
            this.Controls.Add(this.buttoncalcular);
            this.Controls.Add(this.valor2);
            this.Controls.Add(this.valor1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox valor1;
        private System.Windows.Forms.TextBox valor2;
        private System.Windows.Forms.Button buttoncalcular;
        private System.Windows.Forms.ComboBox operacion;
    }
}