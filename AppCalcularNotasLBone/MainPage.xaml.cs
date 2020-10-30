using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCalcularNotasLBone
{
    public partial class MainPage : ContentPage
    {
        public MainPage(String user)
        {
            InitializeComponent();
            lblTitulo.Text = "Bienvenido " + user;
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            try
            {
                Double nota = Convert.ToDouble(txtNota1.Text);
                Double examen = Convert.ToDouble(txtExamen1.Text);
                Double notaParcial2 = Convert.ToDouble(txtParcial2.Text);

                Double result = (nota*0.3) + (examen*0.2);

                Double resultFinal = result + notaParcial2;

                if(resultFinal >= 7)
                {
                    txtEstado.Text = "APROBADO";
                } else
                {
                    txtEstado.Text = "REPROBADO";
                }

                txtParcial1.Text = result.ToString();

                txtNotaFinal.Text = resultFinal.ToString();

            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje", "ERROR " + ex.Message, "ok");
            }
        }

        private void btnParcial2_Clicked(object sender, EventArgs e)
        {
            try
            {
                Double nota = Convert.ToDouble(txtNota2.Text);
                Double examen = Convert.ToDouble(txtExamen2.Text);
                Double notaParcial1 = Convert.ToDouble(txtParcial1.Text);

                Double result = (nota*0.3) + (examen*0.2);

                Double resultFinal = result + notaParcial1;

                if (resultFinal >= 7)
                {
                    txtEstado.Text = "APROBADO";
                }
                else
                {
                    txtEstado.Text = "REPROBADO";
                }

                txtParcial2.Text = result.ToString();

                txtNotaFinal.Text = resultFinal.ToString();

            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje", "ERROR " + ex.Message, "ok");
            }
        }
    }
}
