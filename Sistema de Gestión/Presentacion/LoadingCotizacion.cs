using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gestión.Presentacion
{
    public partial class LoadingCotizacion : Form
    {
        public LoadingCotizacion()
        {
            InitializeComponent();
        }

        private void LoadingCotizacion_Load(object sender, EventArgs e)
        {
            MiLoading.Image = RecursosBA.loading;
        }
    }
}
