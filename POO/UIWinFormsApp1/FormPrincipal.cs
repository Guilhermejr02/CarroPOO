using POO;
using System.Linq.Expressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace UIWinFormsApp1
{
    public partial class Form1 : Form
    {
        Carro carro;
        public Form1()
        {
            InitializeComponent();
            carro = new Carro("Honda", "Civic", "Preto", 2023, "CPR2250", 50, 100, 240);
        }

        private void textBoxExibir_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Exibir();
        }

        private void Exibir()
        {
            textBoxExibir.Text = "Marca: " + carro.Marca;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nModelo: " + carro.Modelo;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nCor: " + carro.Cor;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nAno: " + carro.Ano;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nPlaca: " + carro.Placa;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nCapacidade Do Tanque: " + carro.CapacidadeDoTanque;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nPercentual De Combustível : " + carro.PercentualDeCombustivel + "%";
            textBoxExibir.Text = textBoxExibir.Text + "\r\nLigado: " + carro.Ligado;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nVelocidade Atual: " + carro.VelocidadeAtual;
            textBoxExibir.Text = textBoxExibir.Text + "\r\nVelocidade Máxima: " + carro.VelocidadeMaxima;

            ExibirPneu(carro.PneuDianteiroDireito, textBoxPneuDianteiroDireito);
            ExibirPneu(carro.PneuDianteiroEsquerdo, textBoxPneuDianteiroEsquerdo);
            ExibirPneu(carro.PneuTraseiroDireito, textBoxPneuTraseiroDireito);
            ExibirPneu(carro.PneuTraseiroEsquerdo, textBoxPneuTraseiroEsquerdo);
            ExibirPneu(carro.PneuDeEstepe, textBoxPneuEstepe);

            if (carro.Ligado)
                buttonLigar.Text = "Desligar";  
            else
                buttonLigar.Text = "Ligar";

        }

        private void ExibirPneu(Pneu _pneu, TextBox _textBox)
        {
            _textBox.Text = "Aro: " + _pneu.Aro;
            _textBox.Text = _textBox.Text + "\r\nMarca: " + _pneu.Marca;
            _textBox.Text = _textBox.Text + "\r\nPSI: " + _pneu.PSI;
            _textBox.Text = _textBox.Text + "\r\nPSIMaximo: " + _pneu.PSIMaximo;
            _textBox.Text = _textBox.Text + "\r\nPSIMinimo: " + _pneu.PSIMinimo;
            _textBox.Text = _textBox.Text + "\r\nLargura: " + _pneu.Largura;
            _textBox.Text = _textBox.Text + "\r\nPercentualDeBorracha: " + _pneu.PercentualDeBorracha;
            _textBox.Text = _textBox.Text + "\r\nVelocidadeMaxima: " + _pneu.VelocidadeMaxima;
            _textBox.Text = _textBox.Text + "\r\nCargaAtual: " + _pneu.CargaAtual;
            _textBox.Text = _textBox.Text + "\r\nCargaMaxima: " + _pneu.CargaMaxima;
            _textBox.Text = _textBox.Text + "\r\nEstourado: " + _pneu.Estourado;
            _textBox.Text = _textBox.Text + "\r\nFurado: " + _pneu.Furado;
            _textBox.Text = _textBox.Text + "\r\nVelocidadeAtual: " + _pneu.VelocidadeAtual;
            _textBox.Text = _textBox.Text + "\r\nEstepe: " + _pneu.Estepe;

            _textBox.BackColor = Color.Thistle;
            if (_pneu.Estourado)
            {
                _textBox.BackColor = Color.Red;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonLigar_Click(object sender, EventArgs e)
        {
            if (carro.Ligado)
                carro.Desligar();
            else
                carro.Ligar();

            Exibir();
        }

        private void buttonAcelerar_Click(object sender, EventArgs e)
        {
            carro.Acelerar(Convert.ToInt32(textBoxImpulso.Text));
            Exibir();
        }

        private void buttonFrear_Click(object sender, EventArgs e)
        {
            carro.Frear(Convert.ToInt32(textBoxImpulso.Text));
            Exibir();
        }

        private void buttonTrocarPneu_Click(object sender, EventArgs e)
        {
            try
            {
                Pneu pneu = null;

                switch (comboBoxPneu.SelectedIndex)
                {
                    case 0:
                        pneu = carro.PneuDianteiroDireito;
                        carro.PneuDianteiroDireito = carro.PneuDeEstepe;
                        break;
                    case 1:
                        pneu = carro.PneuDianteiroEsquerdo;
                        carro.PneuDianteiroEsquerdo = carro.PneuDeEstepe;
                        break;
                    case 2:
                        pneu = carro.PneuTraseiroDireito;
                        carro.PneuTraseiroEsquerdo = carro.PneuDeEstepe;
                        break;
                    case 3:
                        pneu = carro.PneuTraseiroEsquerdo;
                        carro.PneuTraseiroEsquerdo = carro.PneuDeEstepe;
                        break;
                    default:
                        break;
                }

                if (pneu != null)
                    carro.PneuDeEstepe = pneu;

                Exibir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxPneu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxImpulso_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}