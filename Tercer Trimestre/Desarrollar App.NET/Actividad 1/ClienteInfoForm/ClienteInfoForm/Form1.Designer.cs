namespace ClienteInfoForm
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
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClienteEdad = new System.Windows.Forms.TextBox();
            this.txtClienteApellido = new System.Windows.Forms.TextBox();
            this.txtClienteNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtClienteId
            // 
            this.txtClienteId.Location = new System.Drawing.Point(385, 46);
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.Size = new System.Drawing.Size(138, 21);
            this.txtClienteId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(128, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtClienteEdad
            // 
            this.txtClienteEdad.Location = new System.Drawing.Point(385, 209);
            this.txtClienteEdad.Name = "txtClienteEdad";
            this.txtClienteEdad.Size = new System.Drawing.Size(138, 21);
            this.txtClienteEdad.TabIndex = 2;
            // 
            // txtClienteApellido
            // 
            this.txtClienteApellido.Location = new System.Drawing.Point(385, 156);
            this.txtClienteApellido.Name = "txtClienteApellido";
            this.txtClienteApellido.Size = new System.Drawing.Size(138, 21);
            this.txtClienteApellido.TabIndex = 3;
            // 
            // txtClienteNombre
            // 
            this.txtClienteNombre.Location = new System.Drawing.Point(385, 95);
            this.txtClienteNombre.Name = "txtClienteNombre";
            this.txtClienteNombre.Size = new System.Drawing.Size(138, 21);
            this.txtClienteNombre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(128, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Edad";
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txt.Location = new System.Drawing.Point(128, 150);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(79, 24);
            this.txt.TabIndex = 6;
            this.txt.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(128, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(257, 275);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(115, 41);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "BUSCAR INFORMACION";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 389);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClienteNombre);
            this.Controls.Add(this.txtClienteApellido);
            this.Controls.Add(this.txtClienteEdad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClienteId);
            this.Font = new System.Drawing.Font("Operator Mono Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClienteId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClienteEdad;
        private System.Windows.Forms.TextBox txtClienteApellido;
        private System.Windows.Forms.TextBox txtClienteNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscar;
    }
}

