using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        // -------------------------    BOTON CALCULAR     ---------------------------
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calcular();
        }


        // ------------------------     FUNCION CALCULAR     -------------------------
        private void Calcular ()
        {
            // ------- DECLARACION DE VARIABLES INTERNOS ----------
            String Nombre = "", Alias = "", Mensaje = "";
            int Edad;
            double CM, Lbs, Altura, Peso, IMC;

            Nombre = txtNombre.Text;
            Alias = txtAlias.Text;
            Edad = int.Parse(txtEdad.Text);
            CM = double.Parse(txtAltura.Text);
            Lbs = double.Parse(txtPeso.Text);

            // ECUACION: CONVERTIR DATOS
            Peso = Lbs / 2.2046244;
            Altura = CM / 100;

            // FORMULA PARA IMC
            IMC = (Peso / (Math.Pow(Altura, 2)));


            // -------------- CONDICION IF  ----------------------------------------
            // --------------------------- BAJO PESO ---------------------------------------------------
            if (IMC < 18.5)
            {
                Mensaje = "Bajo Peso";
                imgAtencion.Visible = true;
                lblRecomendacion.Visible = true;
                btnBP.Visible = true;
                imgBP.Visible = true;

            }


            // ------------------------- PESO NORMAL --------------------------------------------------
            else if (IMC >= 18.5 && IMC <= 24.9)
            {
                Mensaje = "Peso Normal";
                imgAtencion.Visible = true;
                lblRecomendacion.Visible = true;
                btnPN.Visible = true;
                imgPN.Visible = true;

            }


            // --------------------- SOBREPESO --------------------------------------------------------
            else if (IMC >= 25.0 && IMC <= 29.9)
            {
                Mensaje = "Sobre Peso";
                imgAtencion.Visible = true;
                lblRecomendacion.Visible = true;
                btnSP.Visible = true;
                imgSP.Visible = true;

            }


            // -------------------- OBESO -------------------------------------------------------------
            else if (IMC >= 30.0)
            {
                Mensaje = "Obeso";
                imgAtencion.Visible = true;
                lblRecomendacion.Visible = true;
                btnOb.Visible = true;
                imgOb.Visible = true;

            }


            // --------------------   OPCION DE ERROR !!! ----------------------------------------------
            else
            {
                Mensaje = "Error!!!";
            }


            // -------------------- MOSTRAR EL RESULTADO  ------------------------------
            lblResultado.Text = Nombre + "  " + "Tu IMC es: " + IMC.ToString("N2");
            txtResultado.Text = Mensaje;

            // ------------------  ACTIVAR LOS LABEL
            lblResultado.Visible = true;
            lblRes.Visible = true;
            txtResultado.Visible = true;

            
        }// FIN FUNCION CALCULAR *******************



        // --------------------------- BOTON CERRAR --------------------------------------------
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //  ----------  BOTON BAJO PESO ------------------------
        private void btnBP_Click(object sender, EventArgs e)
        {
            Hide();
            BajoPeso formMain = new BajoPeso();
            formMain.ShowDialog(this);
            Show();
        }


        // -------------------------  BOTON PESO NORMAL ---------------------------------------
        private void btnPN_Click(object sender, EventArgs e)
        {
            Hide();
            PesoNormal formMain = new PesoNormal();
            formMain.ShowDialog(this);
            Show();
        }



        // ------------------ BOTON SOBREPESO -----------------------
        private void btnSP_Click(object sender, EventArgs e)
        {
            Hide();
            SobrePeso formMain = new SobrePeso();
            formMain.ShowDialog(this);
            Show();
        }


        // ------------------- BOTON OBESO ----------------------------
        private void btnOb_Click(object sender, EventArgs e)
        {
            Hide();
            Obeso formMain = new Obeso();
            formMain.ShowDialog(this);
            Show();
        }


        // ***************** BOTON LIMPIAR -------------------------------
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtAlias.Clear();
            txtEdad.Clear();
            txtResultado.Clear();
            txtPeso.Clear();
            txtAltura.Clear();
            lblRecomendacion.Visible = false;
            lblResultado.Visible = false;
            lblRes.Visible = false;
            imgAtencion.Visible = false;
            imgBP.Visible = false;
            imgPN.Visible = false;
            imgSP.Visible = false;
            btnBP.Visible = false;
            btnPN.Visible = false;
            btnSP.Visible = false;
            txtResultado.Visible = false;
            imgOb.Visible = false;
            btnOb.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
