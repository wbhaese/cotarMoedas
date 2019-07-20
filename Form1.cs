using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using CotarMoeda.wsCotacao;

namespace CotarMoeda
{
    public partial class Form1 : Form
    {       
        static string valorDolar = "";
        static string valorEuro = "";
        static string valorLibra = "";

        public Form1()
        {
            InitializeComponent();
            Thread t = new Thread(dadosOnline);
            t.Start();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            // Posicionar na primeira posição da Combobox
            cmbMoeda.SelectedIndex = 0;
        }

        public static void dadosOnline()
        {
            FachadaWSSGSClient ws = new FachadaWSSGSClient();

            //Assim que o programa abre, pega os valores online

            valorDolar = ws.getUltimosValoresSerieVO(10813, 1).valores[0].svalor;
            valorEuro = ws.getUltimosValoresSerieVO(21620, 1).valores[0].svalor;
            valorLibra = ws.getUltimosValoresSerieVO(21624, 1).valores[0].svalor;

            string caption = "Alerta!";
            string message = "Thread iniciada com sucesso!" + "\n" + "\n" +
                " Valor Dólar - " + "R$ " + string.Format("{0:0.00} ", valorDolar) +  "\n" +
                " Valor Euro  - " + "R$ " + string.Format("{0:0.00} ", valorEuro) + "\n" +
                " Valor Libra - " + "R$ " + string.Format("{0:0.00} ", valorLibra);            
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
        }            

        public void btnBuscar_Click(object sender, EventArgs e)
        {

            string codigoMoeda = "";

            // Pega posição do caracter ( -) que separa o código da descrição da moeda
            int posTraco = cmbMoeda.Text.IndexOf(" –");

            //converte a string da quantidade para compra
            float qtdComprar = (float)Convert.ToDouble(boxQtdComprar.Text);
             
            // Caso a posição for maior que -1, atribui o valor a variável codigoMoeda
            if (posTraco > -1)
               codigoMoeda = cmbMoeda.Text.Substring(0, posTraco);

            try
            {                
                if (codigoMoeda == "1")
                {
                    float vlr2 = float.Parse(valorDolar, CultureInfo.InvariantCulture.NumberFormat);

                    // Mostrar na label txtValor o preço unitário
                    lblValor.Text = "R$ " + string.Format("{0:0.00}", vlr2);

                    valorTotal.Text = "R$ " + string.Format("{0:0.00} ", vlr2 * qtdComprar);
                }
                else if (codigoMoeda == "2")
                {

                    float vlr2 = float.Parse(valorEuro, CultureInfo.InvariantCulture.NumberFormat);

                    // Mostrar na label txtValor o preço unitário
                    lblValor.Text = "R$ " + string.Format("{0:0.00}", vlr2);

                    valorTotal.Text = "R$ " + string.Format("{0:0.00} ", vlr2 * qtdComprar);
                }
                else
                {

                    float vlr2 = float.Parse(valorLibra, CultureInfo.InvariantCulture.NumberFormat);

                    // Mostrar na label txtValor o preço unitário
                    lblValor.Text = "R$ " + string.Format("{0:0.00}", vlr2);

                    valorTotal.Text = "R$ " + string.Format("{0:0.00} ", vlr2 * qtdComprar);
                }

            }
            catch (Exception)
            {
                // Caso aconteça alguma excessão, mostra valor zerado
                lblValor.Text = "R$ 0.00";
                valorTotal.Text = "R$ 0.00";

                //exibe mensagem de erro em caso de excessão.
                
                string message = "Ocorreu um erro ao se conectar ao servidor. Por favor tente novamente mais tarde.";
                string caption = "Erro!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);

            }
        }
    }
}
