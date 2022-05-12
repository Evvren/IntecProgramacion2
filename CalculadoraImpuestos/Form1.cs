using System;
using System.Windows.Forms;

namespace CalculadoraImpuestos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            Double SueldoBruto, Reducciones, SueldoNeto, Afp, Seguro, Isr, RedAfp, RedSeguro, RedIsr;
            Afp = double.Parse(txtAfp.Text) / 100;
            Isr = double.Parse(txtIsr.Text) / 100;
            Seguro = double.Parse(txtSeguro.Text) / 100; //Inicializacion de Variables
            SueldoBruto = double.Parse(txtCalcular.Text);

            RedAfp = SueldoBruto * Afp;
            RedIsr = SueldoBruto * Isr;
            RedSeguro = SueldoBruto * Seguro; //Se guardan los impuestos para ser mostrados luego en pantalla

            Reducciones = RedSeguro + RedIsr + RedAfp;
            SueldoNeto = SueldoBruto - RedAfp - RedIsr - RedSeguro; //Se guarda el total de todos los impuestos juntos y el Sueldo Neto

            labelSueldoBruto.Text = SueldoBruto.ToString(); //Se muestran los valores
            LabelReducciones.Text = Reducciones.ToString();
            LabelSueldoNeto.Text = SueldoNeto.ToString();
            LabelIsrRed.Text = RedIsr.ToString();
            LabelAfpRed.Text = RedAfp.ToString();
            LabelSeguroRed.Text = RedSeguro.ToString();

            if ((Afp + Isr + Seguro) >= 1)  //Error en caso de pasar el 100% en Reducciones
            {
                SueldoNeto = 00000000;
                SueldoBruto = 00000000;
                Reducciones = 00000000;
                TxtError.Text = "El porcentaje es mayor al 100%. Intente de nuevo.";
                LabelIsrRed.Text = "";
                LabelAfpRed.Text = "";
                LabelSeguroRed.Text = "";
            }
            else if ((Afp + Isr + Seguro) < 1)
            {
                TxtError.Text = "";
            }


        }
        private void txtCalcular_TextChanged(object sender, EventArgs e)
        {

        }                  //No se como borrar esto de abajo sin que se me borren todos los botones :\


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
