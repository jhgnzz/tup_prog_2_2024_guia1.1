using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace valuar_motos
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string marca = tbMarca.Text;
            int modelo = Convert.ToInt32(nupModelo.Value);
            int añoACalcular = Convert.ToInt32(nupAño.Value);
            int valorFabricacion = Convert.ToInt32(tbValorFabricacion.Text);
            double tasaDepreciacion = Convert.ToDouble(tbDepreciacion.Text);
            int vidaUtil = Convert.ToInt32(tbVidaUtil.Text);

            if (marca == "" || marca == null || modelo == 0 || valorFabricacion == 0.0)
            {
                MessageBox.Show("Error: moto invalida");
                return;
            }


            Moto moto = new Moto(valorFabricacion, modelo, marca);

            if (añoACalcular == 0 || vidaUtil == 0)
            {
                MessageBox.Show("Error: formulario invalido");
                return;

            }

            FormResultados formResultados = new FormResultados();

            formResultados.lbResultados.Items.Add(moto.verDescripcion());
            formResultados.lbResultados.Items.Add($"Depreciacion lineal: $ {moto.calcularDepreciacionLineal(añoACalcular, vidaUtil),10:f2}");
            formResultados.lbResultados.Items.Add($"Depreciacion anual: $ {moto.calcularDepreciacionAnual(añoACalcular, tasaDepreciacion):f2}");
   

            formResultados.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
