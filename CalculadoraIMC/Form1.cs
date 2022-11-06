namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso, altura, imc;
            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);
            imc = peso / (altura * altura);

            if (imc < 20)
                lblResultado.Text = "Abaixo do peso\nSeu IMC: " + imc.ToString("F2");
            else
                if (imc >= 20 && imc < 25)
                lblResultado.Text = "Peso normal\nSeu IMC:" + imc.ToString("F2");
            else
            if (imc >= 25 && imc < 30)
                lblResultado.Text = "Acima do peso\nSeu IMC:" + imc.ToString("F2");
            else
                if (imc >= 30 && imc < 40)
                lblResultado.Text = "Obeso\nSeu IMC:" + imc.ToString("F2");
            else
                lblResultado.Text = "Obeso Mórbido\nSeu IMC:" + imc.ToString("F2");



        }

        private void button1_Click(object sender, EventArgs e)
        {
          this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}