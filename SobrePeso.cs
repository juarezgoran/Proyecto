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
    public partial class SobrePeso : Form
    {
        public SobrePeso()
        {
            InitializeComponent();
        }

        // ---------------  LINK PARA DESCARGAR -----------------------------------------
        private void linkSobrePeso_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkSobrePeso.LinkVisited = true;
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/1nBbVHPXcPYkY_9IpMk11GlLwbD0-x3Xu/view?usp=sharing");
        }

        // -------------------- BOTON CERRAR ---------------------------------
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
