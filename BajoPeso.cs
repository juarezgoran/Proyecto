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
    public partial class BajoPeso : Form
    {
        public BajoPeso()
        {
            InitializeComponent();
        }

        // ---------------  LINK PARA DESCARGAR -----------------------------------------
        private void linkBajoPeso_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkBajoPeso.LinkVisited = true;
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/17hJpjj6OplljsdVKai_Yp1zQjnyhMQMI/view?usp=sharing");

        }

        // ---------------- BOTON CERRAR ------------------------------
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
