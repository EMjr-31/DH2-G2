namespace DH2_G2
{
    partial class Calculo
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
            this.Calculos = new System.Windows.Forms.Label();
            this.rbtnTemperatura = new System.Windows.Forms.RadioButton();
            this.rbtnLongitud = new System.Windows.Forms.RadioButton();
            this.rbtnMasa = new System.Windows.Forms.RadioButton();
            this.txtDato1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbDato1 = new System.Windows.Forms.Label();
            this.txtDato2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calculos
            // 
            this.Calculos.AutoSize = true;
            this.Calculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculos.Location = new System.Drawing.Point(231, 21);
            this.Calculos.Name = "Calculos";
            this.Calculos.Size = new System.Drawing.Size(90, 24);
            this.Calculos.TabIndex = 0;
            this.Calculos.Text = "Calculos";
            this.Calculos.Click += new System.EventHandler(this.Calculos_Click);
            // 
            // rbtnTemperatura
            // 
            this.rbtnTemperatura.AutoSize = true;
            this.rbtnTemperatura.Location = new System.Drawing.Point(63, 91);
            this.rbtnTemperatura.Name = "rbtnTemperatura";
            this.rbtnTemperatura.Size = new System.Drawing.Size(85, 17);
            this.rbtnTemperatura.TabIndex = 1;
            this.rbtnTemperatura.TabStop = true;
            this.rbtnTemperatura.Text = "Temperatura";
            this.rbtnTemperatura.UseVisualStyleBackColor = true;
            // 
            // rbtnLongitud
            // 
            this.rbtnLongitud.AutoSize = true;
            this.rbtnLongitud.Location = new System.Drawing.Point(255, 91);
            this.rbtnLongitud.Name = "rbtnLongitud";
            this.rbtnLongitud.Size = new System.Drawing.Size(66, 17);
            this.rbtnLongitud.TabIndex = 2;
            this.rbtnLongitud.TabStop = true;
            this.rbtnLongitud.Text = "Longitud";
            this.rbtnLongitud.UseVisualStyleBackColor = true;
            // 
            // rbtnMasa
            // 
            this.rbtnMasa.AutoSize = true;
            this.rbtnMasa.Location = new System.Drawing.Point(454, 91);
            this.rbtnMasa.Name = "rbtnMasa";
            this.rbtnMasa.Size = new System.Drawing.Size(51, 17);
            this.rbtnMasa.TabIndex = 3;
            this.rbtnMasa.TabStop = true;
            this.rbtnMasa.Text = "Masa";
            this.rbtnMasa.UseVisualStyleBackColor = true;
            // 
            // txtDato1
            // 
            this.txtDato1.Location = new System.Drawing.Point(49, 44);
            this.txtDato1.Name = "txtDato1";
            this.txtDato1.Size = new System.Drawing.Size(100, 20);
            this.txtDato1.TabIndex = 4;
            this.txtDato1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(42, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 77);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione la unidad";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtDato2);
            this.groupBox2.Controls.Add(this.lbDato1);
            this.groupBox2.Controls.Add(this.lbDescripcion);
            this.groupBox2.Controls.Add(this.btnConvertir);
            this.groupBox2.Controls.Add(this.txtDato1);
            this.groupBox2.Location = new System.Drawing.Point(42, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 94);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(204, 44);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 5;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(37, 21);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(35, 13);
            this.lbDescripcion.TabIndex = 6;
            this.lbDescripcion.Text = "label1";
            // 
            // lbDato1
            // 
            this.lbDato1.AutoSize = true;
            this.lbDato1.Location = new System.Drawing.Point(155, 47);
            this.lbDato1.Name = "lbDato1";
            this.lbDato1.Size = new System.Drawing.Size(44, 13);
            this.lbDato1.TabIndex = 7;
            this.lbDato1.Text = "lbDato1";
            // 
            // txtDato2
            // 
            this.txtDato2.Location = new System.Drawing.Point(285, 46);
            this.txtDato2.Name = "txtDato2";
            this.txtDato2.Size = new System.Drawing.Size(100, 20);
            this.txtDato2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label1";
            // 
            // Calculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 270);
            this.Controls.Add(this.rbtnMasa);
            this.Controls.Add(this.rbtnLongitud);
            this.Controls.Add(this.rbtnTemperatura);
            this.Controls.Add(this.Calculos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Calculo";
            this.Text = "Calculos";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Calculos;
        private System.Windows.Forms.RadioButton rbtnTemperatura;
        private System.Windows.Forms.RadioButton rbtnLongitud;
        private System.Windows.Forms.RadioButton rbtnMasa;
        private System.Windows.Forms.TextBox txtDato1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDato2;
        private System.Windows.Forms.Label lbDato1;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label label2;
    }
}

