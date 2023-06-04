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
    public partial class Obeso : Form
    {
        public Obeso()
        {
            InitializeComponent();
        }

        // ---------------  LINK PARA DESCARGAR -----------------------------------------
        private void linkObeso_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkObeso.LinkVisited = true;
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/1nJPi3ziYx6mYcfEIVFdS1cNyuEW4G60Q/view?usp=share_link");

        }

        // --------------------- BOTON CERRAR --------------------------
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
