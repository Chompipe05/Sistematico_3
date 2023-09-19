namespace pjFigurasGeometricas
{
    partial class frmFiguraTridimensional
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
            btnSalir = new Button();
            gbEsfera = new GroupBox();
            gbResultadoCirculo = new GroupBox();
            textBox8 = new TextBox();
            lblVolumenEsfera = new Label();
            textBox9 = new TextBox();
            lblAreaCirculo = new Label();
            gbValoresCirculo = new GroupBox();
            txtRadio = new TextBox();
            lblRadio = new Label();
            btnCalcularEsfera = new Button();
            gbTetraedro = new GroupBox();
            gbResultadoTriangulo = new GroupBox();
            textBox4 = new TextBox();
            lblVolumenTetraedo = new Label();
            textBox5 = new TextBox();
            lblAreaTriangulo = new Label();
            gbValoresTriangulo = new GroupBox();
            txtBase = new TextBox();
            lblLadoT = new Label();
            btnCalcularTetraedro = new Button();
            gbCubo = new GroupBox();
            gbResultadoCuadrado = new GroupBox();
            textBox3 = new TextBox();
            lblVolumenCubo = new Label();
            textBox2 = new TextBox();
            lblAreaCuadrado = new Label();
            gbValoresCuadrado = new GroupBox();
            txtLado = new TextBox();
            lblLadoC = new Label();
            btnCalcularCubo = new Button();
            gbEsfera.SuspendLayout();
            gbResultadoCirculo.SuspendLayout();
            gbValoresCirculo.SuspendLayout();
            gbTetraedro.SuspendLayout();
            gbResultadoTriangulo.SuspendLayout();
            gbValoresTriangulo.SuspendLayout();
            gbCubo.SuspendLayout();
            gbResultadoCuadrado.SuspendLayout();
            gbValoresCuadrado.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(808, 344);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // gbEsfera
            // 
            gbEsfera.Controls.Add(gbResultadoCirculo);
            gbEsfera.Controls.Add(gbValoresCirculo);
            gbEsfera.Controls.Add(btnCalcularEsfera);
            gbEsfera.Location = new Point(618, 12);
            gbEsfera.Name = "gbEsfera";
            gbEsfera.Size = new Size(284, 317);
            gbEsfera.TabIndex = 10;
            gbEsfera.TabStop = false;
            gbEsfera.Text = "Esfera";
            // 
            // gbResultadoCirculo
            // 
            gbResultadoCirculo.Controls.Add(textBox8);
            gbResultadoCirculo.Controls.Add(lblVolumenEsfera);
            gbResultadoCirculo.Controls.Add(textBox9);
            gbResultadoCirculo.Controls.Add(lblAreaCirculo);
            gbResultadoCirculo.Location = new Point(15, 177);
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
            // lblVolumenEsfera
            // 
            lblVolumenEsfera.AutoSize = true;
            lblVolumenEsfera.Location = new Point(17, 78);
            lblVolumenEsfera.Name = "lblVolumenEsfera";
            lblVolumenEsfera.Size = new Size(70, 20);
            lblVolumenEsfera.TabIndex = 4;
            lblVolumenEsfera.Text = "Volumen:";
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
            gbValoresCirculo.Size = new Size(250, 83);
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
            // btnCalcularEsfera
            // 
            btnCalcularEsfera.Location = new Point(15, 127);
            btnCalcularEsfera.Name = "btnCalcularEsfera";
            btnCalcularEsfera.Size = new Size(94, 29);
            btnCalcularEsfera.TabIndex = 0;
            btnCalcularEsfera.Text = "Calcular";
            btnCalcularEsfera.UseVisualStyleBackColor = true;
            // 
            // gbTetraedro
            // 
            gbTetraedro.Controls.Add(gbResultadoTriangulo);
            gbTetraedro.Controls.Add(gbValoresTriangulo);
            gbTetraedro.Controls.Add(btnCalcularTetraedro);
            gbTetraedro.Location = new Point(315, 12);
            gbTetraedro.Name = "gbTetraedro";
            gbTetraedro.Size = new Size(284, 317);
            gbTetraedro.TabIndex = 9;
            gbTetraedro.TabStop = false;
            gbTetraedro.Text = "Tetraedro";
            // 
            // gbResultadoTriangulo
            // 
            gbResultadoTriangulo.Controls.Add(textBox4);
            gbResultadoTriangulo.Controls.Add(lblVolumenTetraedo);
            gbResultadoTriangulo.Controls.Add(textBox5);
            gbResultadoTriangulo.Controls.Add(lblAreaTriangulo);
            gbResultadoTriangulo.Location = new Point(15, 177);
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
            // lblVolumenTetraedo
            // 
            lblVolumenTetraedo.AutoSize = true;
            lblVolumenTetraedo.Location = new Point(17, 78);
            lblVolumenTetraedo.Name = "lblVolumenTetraedo";
            lblVolumenTetraedo.Size = new Size(70, 20);
            lblVolumenTetraedo.TabIndex = 4;
            lblVolumenTetraedo.Text = "Volumen:";
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
            gbValoresTriangulo.Controls.Add(txtBase);
            gbValoresTriangulo.Controls.Add(lblLadoT);
            gbValoresTriangulo.Location = new Point(15, 26);
            gbValoresTriangulo.Name = "gbValoresTriangulo";
            gbValoresTriangulo.Size = new Size(250, 83);
            gbValoresTriangulo.TabIndex = 3;
            gbValoresTriangulo.TabStop = false;
            gbValoresTriangulo.Text = "Introduzca los valores";
            // 
            // txtBase
            // 
            txtBase.Location = new Point(98, 38);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(125, 27);
            txtBase.TabIndex = 1;
            // 
            // lblLadoT
            // 
            lblLadoT.AutoSize = true;
            lblLadoT.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblLadoT.Location = new Point(17, 38);
            lblLadoT.Name = "lblLadoT";
            lblLadoT.Size = new Size(45, 20);
            lblLadoT.TabIndex = 2;
            lblLadoT.Text = "Lado:";
            // 
            // btnCalcularTetraedro
            // 
            btnCalcularTetraedro.Location = new Point(15, 127);
            btnCalcularTetraedro.Name = "btnCalcularTetraedro";
            btnCalcularTetraedro.Size = new Size(94, 29);
            btnCalcularTetraedro.TabIndex = 0;
            btnCalcularTetraedro.Text = "Calcular";
            btnCalcularTetraedro.UseVisualStyleBackColor = true;
            // 
            // gbCubo
            // 
            gbCubo.Controls.Add(gbResultadoCuadrado);
            gbCubo.Controls.Add(gbValoresCuadrado);
            gbCubo.Controls.Add(btnCalcularCubo);
            gbCubo.Location = new Point(12, 12);
            gbCubo.Name = "gbCubo";
            gbCubo.Size = new Size(284, 317);
            gbCubo.TabIndex = 8;
            gbCubo.TabStop = false;
            gbCubo.Text = "Cubo";
            // 
            // gbResultadoCuadrado
            // 
            gbResultadoCuadrado.Controls.Add(textBox3);
            gbResultadoCuadrado.Controls.Add(lblVolumenCubo);
            gbResultadoCuadrado.Controls.Add(textBox2);
            gbResultadoCuadrado.Controls.Add(lblAreaCuadrado);
            gbResultadoCuadrado.Location = new Point(15, 177);
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
            // lblVolumenCubo
            // 
            lblVolumenCubo.AutoSize = true;
            lblVolumenCubo.Location = new Point(17, 78);
            lblVolumenCubo.Name = "lblVolumenCubo";
            lblVolumenCubo.Size = new Size(70, 20);
            lblVolumenCubo.TabIndex = 4;
            lblVolumenCubo.Text = "Volumen:";
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
            gbValoresCuadrado.Controls.Add(lblLadoC);
            gbValoresCuadrado.Location = new Point(15, 26);
            gbValoresCuadrado.Name = "gbValoresCuadrado";
            gbValoresCuadrado.Size = new Size(250, 83);
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
            // lblLadoC
            // 
            lblLadoC.AutoSize = true;
            lblLadoC.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblLadoC.Location = new Point(17, 38);
            lblLadoC.Name = "lblLadoC";
            lblLadoC.Size = new Size(45, 20);
            lblLadoC.TabIndex = 2;
            lblLadoC.Text = "Lado:";
            // 
            // btnCalcularCubo
            // 
            btnCalcularCubo.Location = new Point(15, 127);
            btnCalcularCubo.Name = "btnCalcularCubo";
            btnCalcularCubo.Size = new Size(94, 29);
            btnCalcularCubo.TabIndex = 0;
            btnCalcularCubo.Text = "Calcular";
            btnCalcularCubo.UseVisualStyleBackColor = true;
            // 
            // frmFiguraTridimensional
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 388);
            Controls.Add(btnSalir);
            Controls.Add(gbEsfera);
            Controls.Add(gbTetraedro);
            Controls.Add(gbCubo);
            Name = "frmFiguraTridimensional";
            Text = "frmFiguraTridimensional";
            gbEsfera.ResumeLayout(false);
            gbResultadoCirculo.ResumeLayout(false);
            gbResultadoCirculo.PerformLayout();
            gbValoresCirculo.ResumeLayout(false);
            gbValoresCirculo.PerformLayout();
            gbTetraedro.ResumeLayout(false);
            gbResultadoTriangulo.ResumeLayout(false);
            gbResultadoTriangulo.PerformLayout();
            gbValoresTriangulo.ResumeLayout(false);
            gbValoresTriangulo.PerformLayout();
            gbCubo.ResumeLayout(false);
            gbResultadoCuadrado.ResumeLayout(false);
            gbResultadoCuadrado.PerformLayout();
            gbValoresCuadrado.ResumeLayout(false);
            gbValoresCuadrado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalir;
        private GroupBox gbEsfera;
        private GroupBox gbResultadoCirculo;
        private TextBox textBox8;
        private Label lblVolumenEsfera;
        private TextBox textBox9;
        private Label lblAreaCirculo;
        private GroupBox gbValoresCirculo;
        private TextBox txtRadio;
        private Label lblRadio;
        private Button btnCalcularEsfera;
        private GroupBox gbTetraedro;
        private GroupBox gbResultadoTriangulo;
        private TextBox textBox4;
        private Label lblVolumenTetraedo;
        private TextBox textBox5;
        private Label lblAreaTriangulo;
        private GroupBox gbValoresTriangulo;
        private TextBox txtBase;
        private Label lblLadoT;
        private Button btnCalcularTetraedro;
        private GroupBox gbCubo;
        private GroupBox gbResultadoCuadrado;
        private TextBox textBox3;
        private Label lblVolumenCubo;
        private TextBox textBox2;
        private Label lblAreaCuadrado;
        private GroupBox gbValoresCuadrado;
        private TextBox txtLado;
        private Label lblLadoC;
        private Button btnCalcularCubo;
    }
}