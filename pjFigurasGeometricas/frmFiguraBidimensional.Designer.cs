namespace pjFigurasGeometricas
{
    partial class frmFiguraBidimensional
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
            gbCuadrado = new GroupBox();
            gbResultadoCuadrado = new GroupBox();
            textBox3 = new TextBox();
            lblPerimetroCuadrado = new Label();
            textBox2 = new TextBox();
            lblAreaCuadrado = new Label();
            gbValoresCuadrado = new GroupBox();
            txtLado = new TextBox();
            lblLadoCuadrado = new Label();
            btnCalcularCuadrado = new Button();
            gbTriangulo = new GroupBox();
            gbResultadoTriangulo = new GroupBox();
            textBox4 = new TextBox();
            lblPerimetroTriangulo = new Label();
            textBox5 = new TextBox();
            lblAreaTriangulo = new Label();
            gbValoresTriangulo = new GroupBox();
            textBox1 = new TextBox();
            lblLadoTriangulo = new Label();
            txtAltura = new TextBox();
            lblAltura = new Label();
            txtBase = new TextBox();
            lblBase = new Label();
            btnCalcularTriangulo = new Button();
            gbCirculo = new GroupBox();
            gbResultadoCirculo = new GroupBox();
            textBox8 = new TextBox();
            lblPerimetroCirculo = new Label();
            textBox9 = new TextBox();
            lblAreaCirculo = new Label();
            gbValoresCirculo = new GroupBox();
            txtRadio = new TextBox();
            lblRadio = new Label();
            btnCalcularCirculo = new Button();
            btnSalir = new Button();
            gbCuadrado.SuspendLayout();
            gbResultadoCuadrado.SuspendLayout();
            gbValoresCuadrado.SuspendLayout();
            gbTriangulo.SuspendLayout();
            gbResultadoTriangulo.SuspendLayout();
            gbValoresTriangulo.SuspendLayout();
            gbCirculo.SuspendLayout();
            gbResultadoCirculo.SuspendLayout();
            gbValoresCirculo.SuspendLayout();
            SuspendLayout();
            // 
            // gbCuadrado
            // 
            gbCuadrado.Controls.Add(gbResultadoCuadrado);
            gbCuadrado.Controls.Add(gbValoresCuadrado);
            gbCuadrado.Controls.Add(btnCalcularCuadrado);
            gbCuadrado.Location = new Point(12, 12);
            gbCuadrado.Name = "gbCuadrado";
            gbCuadrado.Size = new Size(284, 360);
            gbCuadrado.TabIndex = 0;
            gbCuadrado.TabStop = false;
            gbCuadrado.Text = "Cuadrado";
            // 
            // gbResultadoCuadrado
            // 
            gbResultadoCuadrado.Controls.Add(textBox3);
            gbResultadoCuadrado.Controls.Add(lblPerimetroCuadrado);
            gbResultadoCuadrado.Controls.Add(textBox2);
            gbResultadoCuadrado.Controls.Add(lblAreaCuadrado);
            gbResultadoCuadrado.Location = new Point(15, 221);
            gbResultadoCuadrado.Name = "gbResultadoCuadrado";
            gbResultadoCuadrado.Size = new Size(250, 125);
            gbResultadoCuadrado.TabIndex = 4;
            gbResultadoCuadrado.TabStop = false;
            gbResultadoCuadrado.Text = "Resultados";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(119, 75);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 5;
            // 
            // lblPerimetroCuadrado
            // 
            lblPerimetroCuadrado.AutoSize = true;
            lblPerimetroCuadrado.Location = new Point(17, 78);
            lblPerimetroCuadrado.Name = "lblPerimetroCuadrado";
            lblPerimetroCuadrado.Size = new Size(76, 20);
            lblPerimetroCuadrado.TabIndex = 4;
            lblPerimetroCuadrado.Text = "Perimetro:";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(119, 26);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // lblAreaCuadrado
            // 
            lblAreaCuadrado.AutoSize = true;
            lblAreaCuadrado.Location = new Point(17, 29);
            lblAreaCuadrado.Name = "lblAreaCuadrado";
            lblAreaCuadrado.Size = new Size(43, 20);
            lblAreaCuadrado.TabIndex = 2;
            lblAreaCuadrado.Text = "Area:";
            // 
            // gbValoresCuadrado
            // 
            gbValoresCuadrado.Controls.Add(txtLado);
            gbValoresCuadrado.Controls.Add(lblLadoCuadrado);
            gbValoresCuadrado.Location = new Point(15, 26);
            gbValoresCuadrado.Name = "gbValoresCuadrado";
            gbValoresCuadrado.Size = new Size(250, 125);
            gbValoresCuadrado.TabIndex = 3;
            gbValoresCuadrado.TabStop = false;
            gbValoresCuadrado.Text = "Introduzca los valores";
            // 
            // txtLado
            // 
            txtLado.Location = new Point(96, 35);
            txtLado.Name = "txtLado";
            txtLado.Size = new Size(125, 27);
            txtLado.TabIndex = 1;
            // 
            // lblLadoCuadrado
            // 
            lblLadoCuadrado.AutoSize = true;
            lblLadoCuadrado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblLadoCuadrado.Location = new Point(17, 38);
            lblLadoCuadrado.Name = "lblLadoCuadrado";
            lblLadoCuadrado.Size = new Size(45, 20);
            lblLadoCuadrado.TabIndex = 2;
            lblLadoCuadrado.Text = "Lado:";
            // 
            // btnCalcularCuadrado
            // 
            btnCalcularCuadrado.Location = new Point(15, 171);
            btnCalcularCuadrado.Name = "btnCalcularCuadrado";
            btnCalcularCuadrado.Size = new Size(94, 29);
            btnCalcularCuadrado.TabIndex = 0;
            btnCalcularCuadrado.Text = "Calcular";
            btnCalcularCuadrado.UseVisualStyleBackColor = true;
            btnCalcularCuadrado.Click += btnCalcularCuadrado_Click;
            // 
            // gbTriangulo
            // 
            gbTriangulo.Controls.Add(gbResultadoTriangulo);
            gbTriangulo.Controls.Add(gbValoresTriangulo);
            gbTriangulo.Controls.Add(btnCalcularTriangulo);
            gbTriangulo.Location = new Point(315, 12);
            gbTriangulo.Name = "gbTriangulo";
            gbTriangulo.Size = new Size(284, 381);
            gbTriangulo.TabIndex = 5;
            gbTriangulo.TabStop = false;
            gbTriangulo.Text = "Triangulo";
            // 
            // gbResultadoTriangulo
            // 
            gbResultadoTriangulo.Controls.Add(textBox4);
            gbResultadoTriangulo.Controls.Add(lblPerimetroTriangulo);
            gbResultadoTriangulo.Controls.Add(textBox5);
            gbResultadoTriangulo.Controls.Add(lblAreaTriangulo);
            gbResultadoTriangulo.Location = new Point(15, 243);
            gbResultadoTriangulo.Name = "gbResultadoTriangulo";
            gbResultadoTriangulo.Size = new Size(250, 125);
            gbResultadoTriangulo.TabIndex = 4;
            gbResultadoTriangulo.TabStop = false;
            gbResultadoTriangulo.Text = "Resultados";
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(119, 75);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 5;
            // 
            // lblPerimetroTriangulo
            // 
            lblPerimetroTriangulo.AutoSize = true;
            lblPerimetroTriangulo.Location = new Point(17, 78);
            lblPerimetroTriangulo.Name = "lblPerimetroTriangulo";
            lblPerimetroTriangulo.Size = new Size(76, 20);
            lblPerimetroTriangulo.TabIndex = 4;
            lblPerimetroTriangulo.Text = "Perimetro:";
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(119, 26);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 3;
            // 
            // lblAreaTriangulo
            // 
            lblAreaTriangulo.AutoSize = true;
            lblAreaTriangulo.Location = new Point(17, 29);
            lblAreaTriangulo.Name = "lblAreaTriangulo";
            lblAreaTriangulo.Size = new Size(43, 20);
            lblAreaTriangulo.TabIndex = 2;
            lblAreaTriangulo.Text = "Area:";
            // 
            // gbValoresTriangulo
            // 
            gbValoresTriangulo.Controls.Add(textBox1);
            gbValoresTriangulo.Controls.Add(lblLadoTriangulo);
            gbValoresTriangulo.Controls.Add(txtAltura);
            gbValoresTriangulo.Controls.Add(lblAltura);
            gbValoresTriangulo.Controls.Add(txtBase);
            gbValoresTriangulo.Controls.Add(lblBase);
            gbValoresTriangulo.Location = new Point(15, 26);
            gbValoresTriangulo.Name = "gbValoresTriangulo";
            gbValoresTriangulo.Size = new Size(250, 164);
            gbValoresTriangulo.TabIndex = 3;
            gbValoresTriangulo.TabStop = false;
            gbValoresTriangulo.Text = "Introduzca los valores";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            // 
            // lblLadoTriangulo
            // 
            lblLadoTriangulo.AutoSize = true;
            lblLadoTriangulo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblLadoTriangulo.Location = new Point(22, 38);
            lblLadoTriangulo.Name = "lblLadoTriangulo";
            lblLadoTriangulo.Size = new Size(42, 20);
            lblLadoTriangulo.TabIndex = 6;
            lblLadoTriangulo.Text = "lado:";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(103, 122);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(125, 27);
            txtAltura.TabIndex = 3;
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAltura.Location = new Point(22, 122);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(52, 20);
            lblAltura.TabIndex = 4;
            lblAltura.Text = "Altura:";
            // 
            // txtBase
            // 
            txtBase.Location = new Point(103, 80);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(125, 27);
            txtBase.TabIndex = 1;
            // 
            // lblBase
            // 
            lblBase.AutoSize = true;
            lblBase.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblBase.Location = new Point(22, 80);
            lblBase.Name = "lblBase";
            lblBase.Size = new Size(43, 20);
            lblBase.TabIndex = 2;
            lblBase.Text = "Base:";
            // 
            // btnCalcularTriangulo
            // 
            btnCalcularTriangulo.Location = new Point(15, 208);
            btnCalcularTriangulo.Name = "btnCalcularTriangulo";
            btnCalcularTriangulo.Size = new Size(94, 29);
            btnCalcularTriangulo.TabIndex = 0;
            btnCalcularTriangulo.Text = "Calcular";
            btnCalcularTriangulo.UseVisualStyleBackColor = true;
            // 
            // gbCirculo
            // 
            gbCirculo.Controls.Add(gbResultadoCirculo);
            gbCirculo.Controls.Add(gbValoresCirculo);
            gbCirculo.Controls.Add(btnCalcularCirculo);
            gbCirculo.Location = new Point(618, 12);
            gbCirculo.Name = "gbCirculo";
            gbCirculo.Size = new Size(284, 360);
            gbCirculo.TabIndex = 6;
            gbCirculo.TabStop = false;
            gbCirculo.Text = "Circulo";
            // 
            // gbResultadoCirculo
            // 
            gbResultadoCirculo.Controls.Add(textBox8);
            gbResultadoCirculo.Controls.Add(lblPerimetroCirculo);
            gbResultadoCirculo.Controls.Add(textBox9);
            gbResultadoCirculo.Controls.Add(lblAreaCirculo);
            gbResultadoCirculo.Location = new Point(15, 221);
            gbResultadoCirculo.Name = "gbResultadoCirculo";
            gbResultadoCirculo.Size = new Size(250, 125);
            gbResultadoCirculo.TabIndex = 4;
            gbResultadoCirculo.TabStop = false;
            gbResultadoCirculo.Text = "Resultados";
            // 
            // textBox8
            // 
            textBox8.Enabled = false;
            textBox8.Location = new Point(119, 75);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(125, 27);
            textBox8.TabIndex = 5;
            // 
            // lblPerimetroCirculo
            // 
            lblPerimetroCirculo.AutoSize = true;
            lblPerimetroCirculo.Location = new Point(17, 78);
            lblPerimetroCirculo.Name = "lblPerimetroCirculo";
            lblPerimetroCirculo.Size = new Size(76, 20);
            lblPerimetroCirculo.TabIndex = 4;
            lblPerimetroCirculo.Text = "Perimetro:";
            // 
            // textBox9
            // 
            textBox9.Enabled = false;
            textBox9.Location = new Point(119, 26);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(125, 27);
            textBox9.TabIndex = 3;
            // 
            // lblAreaCirculo
            // 
            lblAreaCirculo.AutoSize = true;
            lblAreaCirculo.Location = new Point(17, 29);
            lblAreaCirculo.Name = "lblAreaCirculo";
            lblAreaCirculo.Size = new Size(43, 20);
            lblAreaCirculo.TabIndex = 2;
            lblAreaCirculo.Text = "Area:";
            // 
            // gbValoresCirculo
            // 
            gbValoresCirculo.Controls.Add(txtRadio);
            gbValoresCirculo.Controls.Add(lblRadio);
            gbValoresCirculo.Location = new Point(15, 26);
            gbValoresCirculo.Name = "gbValoresCirculo";
            gbValoresCirculo.Size = new Size(250, 125);
            gbValoresCirculo.TabIndex = 3;
            gbValoresCirculo.TabStop = false;
            gbValoresCirculo.Text = "Introduzca los valores";
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(98, 38);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(125, 27);
            txtRadio.TabIndex = 1;
            // 
            // lblRadio
            // 
            lblRadio.AutoSize = true;
            lblRadio.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblRadio.Location = new Point(17, 38);
            lblRadio.Name = "lblRadio";
            lblRadio.Size = new Size(51, 20);
            lblRadio.TabIndex = 2;
            lblRadio.Text = "Radio:";
            // 
            // btnCalcularCirculo
            // 
            btnCalcularCirculo.Location = new Point(15, 171);
            btnCalcularCirculo.Name = "btnCalcularCirculo";
            btnCalcularCirculo.Size = new Size(94, 29);
            btnCalcularCirculo.TabIndex = 0;
            btnCalcularCirculo.Text = "Calcular";
            btnCalcularCirculo.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(808, 386);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmFiguraBidimensional
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 427);
            Controls.Add(btnSalir);
            Controls.Add(gbCirculo);
            Controls.Add(gbTriangulo);
            Controls.Add(gbCuadrado);
            Name = "frmFiguraBidimensional";
            Text = "frmFiguraBidimensional";
            gbCuadrado.ResumeLayout(false);
            gbResultadoCuadrado.ResumeLayout(false);
            gbResultadoCuadrado.PerformLayout();
            gbValoresCuadrado.ResumeLayout(false);
            gbValoresCuadrado.PerformLayout();
            gbTriangulo.ResumeLayout(false);
            gbResultadoTriangulo.ResumeLayout(false);
            gbResultadoTriangulo.PerformLayout();
            gbValoresTriangulo.ResumeLayout(false);
            gbValoresTriangulo.PerformLayout();
            gbCirculo.ResumeLayout(false);
            gbResultadoCirculo.ResumeLayout(false);
            gbResultadoCirculo.PerformLayout();
            gbValoresCirculo.ResumeLayout(false);
            gbValoresCirculo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbCuadrado;
        private Label lblLadoCuadrado;
        private TextBox txtLado;
        private Button btnCalcularCuadrado;
        private GroupBox gbResultadoCuadrado;
        private GroupBox gbValoresCuadrado;
        private TextBox textBox3;
        private Label lblPerimetroCuadrado;
        private TextBox textBox2;
        private Label lblAreaCuadrado;
        private GroupBox gbTriangulo;
        private GroupBox gbResultadoTriangulo;
        private TextBox textBox4;
        private Label lblPerimetroTriangulo;
        private TextBox textBox5;
        private Label lblAreaTriangulo;
        private GroupBox gbValoresTriangulo;
        private TextBox txtAltura;
        private Label lblAltura;
        private TextBox txtBase;
        private Label lblBase;
        private Button btnCalcularTriangulo;
        private GroupBox gbCirculo;
        private GroupBox gbResultadoCirculo;
        private TextBox textBox8;
        private Label lblPerimetroCirculo;
        private TextBox textBox9;
        private Label lblAreaCirculo;
        private GroupBox gbValoresCirculo;
        private TextBox txtRadio;
        private Label lblRadio;
        private Button btnCalcularCirculo;
        private Button btnSalir;
        private TextBox textBox1;
        private Label lblLadoTriangulo;
    }
}