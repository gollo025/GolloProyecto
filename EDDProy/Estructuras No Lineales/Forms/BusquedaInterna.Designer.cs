namespace EDDemo.Estructuras_No_Lineales.Forms
{
    partial class BusquedaInterna
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
            this.txtDato = new System.Windows.Forms.TextBox();
            this.txtInsertar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDatoBuscado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(175, 212);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(120, 26);
            this.txtDato.TabIndex = 0;
            this.txtDato.TextChanged += new System.EventHandler(this.txtDato_TextChanged);
            // 
            // txtInsertar
            // 
            this.txtInsertar.Location = new System.Drawing.Point(175, 99);
            this.txtInsertar.Name = "txtInsertar";
            this.txtInsertar.Size = new System.Drawing.Size(517, 26);
            this.txtInsertar.TabIndex = 1;
            this.txtInsertar.TextChanged += new System.EventHandler(this.txtInsertar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "INSERTAR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "BUSCAR:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(175, 145);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 55);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtDatoBuscado
            // 
            this.txtDatoBuscado.Location = new System.Drawing.Point(326, 166);
            this.txtDatoBuscado.Name = "txtDatoBuscado";
            this.txtDatoBuscado.Size = new System.Drawing.Size(366, 26);
            this.txtDatoBuscado.TabIndex = 5;
            this.txtDatoBuscado.TextChanged += new System.EventHandler(this.txtDatoBuscado_TextChanged);
            // 
            // BusquedaInterna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 255);
            this.Controls.Add(this.txtDatoBuscado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInsertar);
            this.Controls.Add(this.txtDato);
            this.Name = "BusquedaInterna";
            this.Text = "BusquedaInterna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.TextBox txtInsertar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDatoBuscado;
    }
}