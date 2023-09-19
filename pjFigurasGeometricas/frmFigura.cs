using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjFigurasGeometricas
{
    public partial class frmFigura : Form
    {
        public frmFigura()
        {
            InitializeComponent();
        }

        private void btnBidimensional_Click(object sender, EventArgs e)
        {
            frmFiguraBidimensional frmFB = new frmFiguraBidimensional();
            frmFB.ShowDialog();
        }

        private void btnTridimensional_Click(object sender, EventArgs e)
        {
            frmFiguraTridimensional frmFT = new frmFiguraTridimensional();
            frmFT.ShowDialog();
        }
    }
}
