namespace EDDemo.Estructuras_No_Lineales.Forms
{
    partial class Burbuja
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
            this.txtOrdenados = new System.Windows.Forms.TextBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtOrdenados
            // 
            this.txtOrdenados.Location = new System.Drawing.Point(229, 283);
            this.txtOrdenados.Name = "txtOrdenados";
            this.txtOrdenados.Size = new System.Drawing.Size(342, 26);
            this.txtOrdenados.TabIndex = 5;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(229, 197);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(342, 55);
            this.btnOrdenar.TabIndex = 4;
            this.btnOrdenar.Text = "ORDENAR";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(229, 142);
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(342, 26);
            this.txtDatos.TabIndex = 3;
            // 
            // Burbuja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtOrdenados);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.txtDatos);
            this.Name = "Burbuja";
            this.Text = "Burbuja";
     
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrdenados;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.TextBox txtDatos;
    }
}