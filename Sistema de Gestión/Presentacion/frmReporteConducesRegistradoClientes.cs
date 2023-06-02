using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Gestión.Modelos;

namespace Sistema_de_Gestión.Presentacion
{
    public partial class frmReporteConducesRegistradoClientes : Form
    {
        ReportesModel RM = new ReportesModel();
        Funciones FC = new Funciones();
        DiseñoInterface DI = new DiseñoInterface();
        public frmReporteConducesRegistradoClientes()
        {
            InitializeComponent();
        }

        private async void BuscarPedidos()
        {
            if (cboClientes.SelectedIndex != 0)
            {
                if (txtCliente.Text != "")
                {
                    EvaluarCriterios();

                    Task tarea = Task.Run(() =>
                    {
                        RM.VerConducesRegistrados(RM.Cliente, RM.ModoReporte, dtpFechaInicio.Value, dtpFechaFin.Value);
                    });

                    LblConducesRegistrados.Text = "Buscando conduces...";
                    LblConducesRegistrados.BackColor = Color.Brown;
                    await tarea;

                    if (RM.ConducesRegistrados.Count != 0)
                    {
                        dgvConducesRegistrados.DataSource = RM.ConducesRegistrados.ToList();
                    }
                    else
                    {
                        MessageBox.Show($"No existen conduces registrados para el cliente [{txtCliente.Text}]", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                else
                {
                    MessageBox.Show($"Debe buscar un cliente para consultar", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                EvaluarCriterios();

                Task tarea = Task.Run(() =>
                {
                    RM.VerConducesRegistrados(RM.Cliente, RM.ModoReporte, dtpFechaInicio.Value, dtpFechaFin.Value);
                });
                

                LblConducesRegistrados.Text = "Buscando conduces...";
                LblConducesRegistrados.BackColor = Color.Brown;
                await tarea;

                if (RM.ConducesRegistrados.Count!=0)
                {
                    dgvConducesRegistrados.DataSource = RM.ConducesRegistrados.ToList();
                }
                else
                {
                    MessageBox.Show($"No existen conduces registrados para el cliente [{txtCliente.Text}]", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                

            }

            LblConducesRegistrados.Text = "Conduces Registrados: 0";
            LblConducesRegistrados.BackColor = Color.Transparent;
            CountRegistroConduces();
            lblTotalConduces.Text = RM.ConducesRegistrados.Sum(t => t.SubTotal).Value.ToString("C2");
            RM.FormatoColumnasConduces(dgvConducesRegistrados.Columns);
        }

        private void cmdBuscarPedido_Click(object sender, EventArgs e)
        {
            BuscarPedidos();
        }

        private void CountRegistroConduces()
        {
            LblConducesRegistrados.Text = "Conduces Registrados: " + dgvConducesRegistrados.RowCount.ToString();
        }

        private void EvaluarCriterios()
        {
            if (cboClientes.SelectedIndex!=0)
            {
                RM.Cliente = int.Parse(txtCodigoCliente.Text);
            }
            else
            {
                RM.Cliente = 0;
            }


            RM.ModoReporte = cboModoReporte.Text;
            
            
        }

        private void ResetCriterios()
        {
            txtCodigoCliente.Text = "";
            cboClientes.SelectedIndex = 0;
            cboModoReporte.SelectedIndex = 0;
            txtCliente.Text = "";
            txtTelefonos.Text = "";
            txtProyecto.Text = "";
            TxtRNC.Text = "";
        }

        private void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvConducesRegistrados.DataSource = null;

            if (cboClientes.SelectedIndex==0)
            {
                RM.Cliente = 0;
                txtCodigoCliente.Enabled = false;
                cmdBuscarCliente.Enabled = false;
            }
            else
            {
                txtCodigoCliente.Enabled = true;
                cmdBuscarCliente.Enabled = true;

                if (txtCliente.Text!="")
                {
                    RM.Cliente = int.Parse(txtCodigoCliente.Text);
                }
                
            }

            txtCliente.Text = "";
            txtTelefonos.Text = "";
            txtProyecto.Text = "";
            TxtRNC.Text = "";

        }

        private void cboModoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboModoReporte.SelectedIndex==0)
            {
                dtpFechaInicio.Enabled = false;
                dtpFechaFin.Enabled = false;
            }
            else
            {
                dtpFechaInicio.Enabled = true;
                dtpFechaFin.Enabled = true;
            }

            RM.ModoReporte = cboModoReporte.Text;

        }

        private void frmReporteConducesRegistradoClientes_Load(object sender, EventArgs e)
        {
            ResetCriterios();
        }

        private void cmdBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private async void BuscarCliente()
        {
            string NuevoCodigo = $"C{ txtCodigoCliente.Text.PadLeft(6, '0')}";
            Task Cliente = Task.Run(() => {
                RM.BuscarClientes(NuevoCodigo);
            });

            LblConducesRegistrados.Text = "Buscando Cliente...";
            LblConducesRegistrados.BackColor = Color.Brown;

            await Cliente;

            txtCliente.Text = RM.Clientes.SingleOrDefault().Cliente;
            TxtRNC.Text = RM.Clientes.SingleOrDefault().RNC;
            txtProyecto.Text = RM.Clientes.SingleOrDefault().Proyecto;
            txtTelefonos.Text = RM.Clientes.SingleOrDefault().Telefonos;

            LblConducesRegistrados.Text = "Conduces Registrados: 0";
            LblConducesRegistrados.BackColor = Color.Transparent;
        }

        private void cmdBuscarPedido_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdBuscarPedido, 1);
        }

        private void cmdVerConduces_Click(object sender, EventArgs e)
        {
            if (!FC.ValidarVentanaAbierta($"Vista Conduces - {txtCliente.Text}"))
            {
                if (dgvConducesRegistrados.RowCount != 0)
                {

                    frmVistaRegistroConduces VistaConduces = new frmVistaRegistroConduces();
                    LoadingReportes VentanaCarga = new LoadingReportes();
                    frmVistaRegistroConduces.Cliente = RM.Cliente;
                    frmVistaRegistroConduces.ModoReporte = RM.ModoReporte;
                    frmVistaRegistroConduces.FechaInicio = dtpFechaInicio.Value;
                    frmVistaRegistroConduces.FechaFin = dtpFechaFin.Value;
                    EvaluarCriterios();

                    FC.Ejecutar(VistaConduces, VentanaCarga, txtCliente.Text);

                }
                else
                {
                    MessageBox.Show("Debe buscar los conduces del cliente que desea mostrar", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Ya se esta visualizando el reporte de conduces indicado", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }




        }

        private void cmdBuscarPedido_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(cmdBuscarPedido, 3);
        }

        private void cmdBuscarPedido_MouseDown(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdBuscarPedido, 2);
        }

        private void cmdResetCriterios_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdResetCriterios, 1);
        }

        private void cmdResetCriterios_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(cmdResetCriterios, 3);
        }

        private void cmdResetCriterios_MouseDown(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdResetCriterios, 2);
        }

        private void cmdVerConduces_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdVerConduces, 1);
        }

        private void cmdVerConduces_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(cmdVerConduces, 3);
        }

        private void cmdVerConduces_MouseDown(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdVerConduces, 2);
        }

        private void cmdResetCriterios_Click(object sender, EventArgs e)
        {
            ResetCriterios();
        }
    }
}
