namespace Ejercicio2_Desktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            tbNTarjeta = new TextBox();
            tbTelefono = new TextBox();
            tbNombre = new TextBox();
            tbCUIT = new TextBox();
            tbPrecio = new TextBox();
            cmbDestino = new ComboBox();
            cmbTransporte = new ComboBox();
            btnGenerar = new Button();
            btnResumen = new Button();
            btnSalir = new Button();
            btnEjemplo = new Button();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(52, 17);
            label1.TabIndex = 0;
            label1.Text = "Destino";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 1;
            label2.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 127);
            label3.Name = "label3";
            label3.Size = new Size(71, 17);
            label3.TabIndex = 2;
            label3.Text = "Transporte";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 32);
            label5.Name = "label5";
            label5.Size = new Size(77, 17);
            label5.TabIndex = 4;
            label5.Text = "CUIT / CUIL:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 74);
            label6.Name = "label6";
            label6.Size = new Size(60, 17);
            label6.TabIndex = 5;
            label6.Text = "Nombre:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 157);
            label7.Name = "label7";
            label7.Size = new Size(66, 17);
            label7.TabIndex = 6;
            label7.Text = "N° Tarjeta";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 116);
            label8.Name = "label8";
            label8.Size = new Size(61, 17);
            label8.TabIndex = 7;
            label8.Text = "Teléfono:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbNTarjeta);
            groupBox1.Controls.Add(tbTelefono);
            groupBox1.Controls.Add(tbNombre);
            groupBox1.Controls.Add(tbCUIT);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(12, 185);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(362, 199);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Pasajero";
            // 
            // tbNTarjeta
            // 
            tbNTarjeta.Location = new Point(138, 154);
            tbNTarjeta.Name = "tbNTarjeta";
            tbNTarjeta.Size = new Size(121, 25);
            tbNTarjeta.TabIndex = 11;
            // 
            // tbTelefono
            // 
            tbTelefono.Location = new Point(138, 108);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(121, 25);
            tbTelefono.TabIndex = 10;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(138, 66);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(121, 25);
            tbNombre.TabIndex = 9;
            // 
            // tbCUIT
            // 
            tbCUIT.Location = new Point(138, 29);
            tbCUIT.Name = "tbCUIT";
            tbCUIT.Size = new Size(121, 25);
            tbCUIT.TabIndex = 8;
            // 
            // tbPrecio
            // 
            tbPrecio.Location = new Point(150, 61);
            tbPrecio.Name = "tbPrecio";
            tbPrecio.Size = new Size(121, 25);
            tbPrecio.TabIndex = 12;
            // 
            // cmbDestino
            // 
            cmbDestino.FormattingEnabled = true;
            cmbDestino.Location = new Point(150, 9);
            cmbDestino.Name = "cmbDestino";
            cmbDestino.Size = new Size(121, 25);
            cmbDestino.TabIndex = 13;
            // 
            // cmbTransporte
            // 
            cmbTransporte.FormattingEnabled = true;
            cmbTransporte.Location = new Point(150, 124);
            cmbTransporte.Name = "cmbTransporte";
            cmbTransporte.Size = new Size(121, 25);
            cmbTransporte.TabIndex = 14;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(299, 41);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(75, 23);
            btnGenerar.TabIndex = 15;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnResumen
            // 
            btnResumen.Location = new Point(299, 131);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(75, 23);
            btnResumen.TabIndex = 16;
            btnResumen.Text = "Resumen";
            btnResumen.UseVisualStyleBackColor = true;
            btnResumen.Click += btnResumen_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(299, 400);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEjemplo
            // 
            btnEjemplo.Location = new Point(12, 400);
            btnEjemplo.Name = "btnEjemplo";
            btnEjemplo.Size = new Size(75, 23);
            btnEjemplo.TabIndex = 18;
            btnEjemplo.Text = "Ejemplo";
            btnEjemplo.UseVisualStyleBackColor = true;
            btnEjemplo.Click += btnEjemplo_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 437);
            Controls.Add(btnEjemplo);
            Controls.Add(btnSalir);
            Controls.Add(btnResumen);
            Controls.Add(btnGenerar);
            Controls.Add(cmbTransporte);
            Controls.Add(cmbDestino);
            Controls.Add(tbPrecio);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Venta Pasajes";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox groupBox1;
        private TextBox tbNTarjeta;
        private TextBox tbTelefono;
        private TextBox tbNombre;
        private TextBox tbCUIT;
        private TextBox tbPrecio;
        private ComboBox cmbDestino;
        private ComboBox cmbTransporte;
        private Button btnGenerar;
        private Button btnResumen;
        private Button btnSalir;
        private Button btnEjemplo;
        private OpenFileDialog openFileDialog1;
    }
}
