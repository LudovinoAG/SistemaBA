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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load_1(object sender, EventArgs e)
        {
            MiLoading.Image = RecursosBA.loading;
            //MiLoading.Location = new Point(this.Width / 2 - MiLoading.Width / 2, 
            //this.Width / 2 - MiLoading.Width / 2);
        }
    }
}
