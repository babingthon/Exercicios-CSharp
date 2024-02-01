namespace NumeroEhPerfeito
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
            NumVerificacao = new NumericUpDown();
            BtnVerificar = new Button();
            ((System.ComponentModel.ISupportInitialize)NumVerificacao).BeginInit();
            SuspendLayout();
            // 
            // NumVerificacao
            // 
            NumVerificacao.Location = new Point(12, 12);
            NumVerificacao.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            NumVerificacao.Name = "NumVerificacao";
            NumVerificacao.Size = new Size(72, 23);
            NumVerificacao.TabIndex = 0;
            NumVerificacao.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // BtnVerificar
            // 
            BtnVerificar.Location = new Point(103, 12);
            BtnVerificar.Name = "BtnVerificar";
            BtnVerificar.Size = new Size(94, 23);
            BtnVerificar.TabIndex = 1;
            BtnVerificar.Text = "Verificar";
            BtnVerificar.UseVisualStyleBackColor = true;
            BtnVerificar.Click += BtnVerificar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(225, 49);
            Controls.Add(BtnVerificar);
            Controls.Add(NumVerificacao);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)NumVerificacao).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown NumVerificacao;
        private Button BtnVerificar;
    }
}
