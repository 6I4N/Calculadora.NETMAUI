namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        //Variables
        string operador = "";
        double num1 = 0;
        double num2 = 0;
        private void ButtonCE_Clicked(object sender, EventArgs e)
        {
            txtScreen.Text = "0";
            num1 = 0;
            num2 = 0;
            operador = "";
        }

        private void BtnDEL_Clicked(object sender, EventArgs e)
        {
            if (txtScreen.Text.Length == 1) txtScreen.Text = "0";
            else txtScreen.Text = txtScreen.Text.Substring(0, txtScreen.Text.Length - 1);
        }

        private void BtnUno_Clicked(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "1";
        }

        private void BtnDos_Clicked(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "2";
        }

        private void BtnTres_Clicked(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "3";
        }

        private void BtnCuatro_Clicked(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "4";
        }

        private void BtnCinco_Clicked(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "5";
        }

        private void BtnSeis_Clicked(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "6";
        }

        private void BtnSiete_Clicked(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "7";
        }

        private void BtnOcho_Clicked(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "8";
        }

        private void BtnNueve_Clicked(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "9";
        }

        private void BtnCero_Clicked(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "0";
        }

        private void BtnSuma_Clicked(object sender, EventArgs e)
        {
            operador = "+";
            num1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";
        }

        private void BtnResta_Clicked(object sender, EventArgs e)
        {
            operador = "-";
            num1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";
        }

        private void BtnMultiplicacion_Clicked(object sender, EventArgs e)
        {
            operador = "*";
            num1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";
        }

        private void BtnDivison_Clicked(object sender, EventArgs e)
        {
            operador = "/";
            num1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";
        }

        private void BtnPunto_Clicked(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + ".";
        }

        private void BtnIgual_Clicked(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtScreen.Text);

            switch (operador)
            {
                case "+":
                    txtScreen.Text = $"{num1 + num2}";
                    break;
                case "-":
                    txtScreen.Text = $"{num1 - num2}";
                    break;
                case "*":
                    txtScreen.Text = $"{num1 * num2}";
                    break;
                case "/":
                    txtScreen.Text = $"{num1 / num2}";
                    break;
            }
        }
        
    }

}