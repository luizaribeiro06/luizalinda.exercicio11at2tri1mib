using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio11AT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Pontes:
            // Peso máximo Golden Gate: 61500kg
            // Altura máxima Golden Gate: 67m
            // Peso máximo Brooklyn Bridge: 6000kg
            // Altura máxima Brooklyn Bridge: 42m
            // Peso máximo Tower Bridge: 145000kg
            // Altura máxima Tower Bridge: 84m

            double peso, altura;

            peso = Convert.ToDouble(txtPesoTotal);
            altura = Convert.ToDouble(txtAlturaTotal);

            if (altura > 67 && peso <= 6000)
            {
                MessageBox.Show("O seu veículo tem acesso livre somente na Tower Bridge");
            }
                   
            if (altura > 42 && peso <= 6000)
            {
                MessageBox.Show("O seu veículo tem acesso livre na Golden Gate e Tower Bridge");
            }

            if (altura > 42 && peso > 61500)
            {
                MessageBox.Show("O seu veículo tem acesso livre somente na Tower Bridge");
            }

            if (altura > 42 && peso > 145000)
            {
                MessageBox.Show("O seu veículo não tem acesso livre em todas as pontes");
            }

            if (altura <= 42 && peso <= 6000)
            {
                MessageBox.Show("O seu veículo tem acesso livre na Golden Gate, Brooklyn Bridge e Tower Bridge");
            }

            if (altura <= 42 && peso > 6000)
            {
                MessageBox.Show("O seu veículo tem acesso livre na Golden Gate e Tower Bridge");
            }

            if (altura <= 42 && peso > 61500)
            {
                MessageBox.Show("O seu veículo tem acesso livre somente na Tower Bridge");
            }

            if (altura <= 42 && peso > 145000)
            {
                MessageBox.Show("O seu veículo não tem acesso livre em todas as pontes");
                    
            }



        }
    }
}
