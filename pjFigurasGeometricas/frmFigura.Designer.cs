namespace pjFigurasGeometricas
{
    partial class frmFigura
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
            btnBidimensional = new Button();
            btnTridimensional = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnBidimensional
            // 
            btnBidimensional.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBidimensional.Location = new Point(68, 133);
            btnBidimensional.Name = "btnBidimensional";
            btnBidimensional.Size = new Size(163, 51);
            btnBidimensional.TabIndex = 0;
            btnBidimensional.Text = "Bidimensional";
            btnBidimensional.UseVisualStyleBackColor = true;
            // 
            // btnTridimensional
            // 
            btnTridimensional.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTridimensional.Location = new Point(344, 133);
            btnTridimensional.Name = "btnTridimensional";
            btnTridimensional.Size = new Size(160, 51);
            btnTridimensional.TabIndex = 1;
            btnTridimensional.Text = "Tridimensional";
            btnTridimensional.UseVisualStyleBackColor = true;
            btnTridimensional.Click += btnTridimensional_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(550, 41);
            label1.TabIndex = 2;
            label1.Text = "Seleccione el tipo de figura que desea\r\n";
            // 
            // frmFigura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 235);
            Controls.Add(label1);
            Controls.Add(btnTridimensional);
            Controls.Add(btnBidimensional);
            Name = "frmFigura";
            Text = "frmSelectorDeFiguras";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBidimensional;
        private Button btnTridimensional;
        private Label label1;
    }
}