namespace NumeroEhPerfeito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            long numero;
            long metade;
            long SomaDivisores = 1;

            numero = Convert.ToInt64(NumVerificacao.Value);
            metade = numero / 2;

            for (long Divisor = 2; Divisor  <= metade; Divisor++)
            {
                if (numero % Divisor == 0)
                {
                    SomaDivisores = SomaDivisores + Divisor;

                }
            }

            if (numero == SomaDivisores)
                MessageBox.Show("É número perfeito!");
            else
                MessageBox.Show("Não é número perfeito!");


        }
    }
}
