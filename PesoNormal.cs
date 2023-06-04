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
    public partial class PesoNormal : Form
    {
        public PesoNormal()
        {
            InitializeComponent();
        }

        // -----------------------  LINK PARA DESCARGAR -----------------------------------------
        private void linkPesoNormal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkPesoNormal.LinkVisited = true;
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/1GEyUmISPFmO7dIXEVGPMvoOexGegA7Gx/view?usp=sharing");

        }

        // ---------------- BOTON CERRAR ------------------------------
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
