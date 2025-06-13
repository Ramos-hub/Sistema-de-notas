using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_de_promedio
{
    public partial class frmSistema : Form
    {
        double nota_1, nota_2, nota_3, promedio;

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            txtNota1.ReadOnly = true;
            txtNota2.ReadOnly = true;
            txtNota3.ReadOnly = true;
            if (string.IsNullOrEmpty(txtNota1.Text) || string.IsNullOrEmpty(txtNota2.Text) || string.IsNullOrEmpty(lblNota3.Text))
            {
                lblError.Text = "Existe un campo vacio\npor favor ingrese el dato que falta";
            }
            else { 
                double.TryParse(txtNota1.Text, out nota_1);
                double.TryParse(txtNota2.Text, out nota_2);
                double.TryParse(txtNota3.Text, out nota_3);
                if ((nota_1 < 0 || nota_1 > 10) || (nota_2 < 0 || nota_2 > 10) || (nota_1 < 0 || nota_1 > 10))
                {
                    lblError.Text = "Por favor ingresa un valor entre 0 y 10";
                   
                }
                else
                {
                    promedio = (nota_1 + nota_2 + nota_3) / 3;
                    txtPromedio.Text = promedio.ToString("N2");
                    lblError.Text = string.Empty;
                }
            }
           
        }

        public frmSistema()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtPromedio.Clear();
            txtNota1.ReadOnly = false;
            txtNota2.ReadOnly = false;
            txtNota3.ReadOnly = false;
        }
    }
}
