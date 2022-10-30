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
    public partial class frmMantenimientoVehiculos : Form
    {
        VehiculosModel VE = new VehiculosModel();
        DiseñoInterface DI = new DiseñoInterface();
        Funciones FC = new Funciones();
        public frmMantenimientoVehiculos()
        {
            InitializeComponent();
        }

        private void frmMantenimientoVehiculos_Load(object sender, EventArgs e)
        {
            this.ListaGeneralVehiculos(cboFiltrar.Text,txtBuscar.Text);
            VE.LoadFiltros(cboFiltrar);
            VE.estatusVehiculos(cboEstatus);
            VE.seguroVehicular(cboSeguro);
        }

        private void ListaGeneralVehiculos(string Filtro, string ValorBuscar)
        {
            
            dgvVehiculos.DataSource = VE.listaVehiculos(Filtro, ValorBuscar);
            tsslTotalVehiculos.Text = "Total Vehiculos Registrados: " +  VehiculosModel.TotalVehiculos.ToString();
            tsslTotalVehiculosActivos.Text = "Activos: " + VehiculosModel.VehiculosActivos.ToString();
            tsslTotalVehiculosInactivos.Text = "Inactivos: " + VehiculosModel.VehiculosInactivos.ToString();
           
        }

        private void cmdInsertar_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdInsertar, 1);
        }

        private void cmdInsertar_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(cmdInsertar, 0);
        }

        private void cmdInsertar_MouseDown(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdInsertar, 2);
        }

        private void cmdGuardar_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdGuardar, 1);
        }

        private void cmdGuardar_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(cmdGuardar, 0);
        }

        private void cmdGuardar_MouseDown(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdGuardar, 2);
        }

        private void cmdEliminar_MouseMove(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdEliminar, 1);
        }

        private void cmdEliminar_MouseLeave(object sender, EventArgs e)
        {
            DI.BTMouseEvent(cmdEliminar, 0);
        }

        private void cmdEliminar_MouseDown(object sender, MouseEventArgs e)
        {
            DI.BTMouseEvent(cmdEliminar, 2);
        }

        private void cmdInsertar_Click(object sender, EventArgs e)
        {
            if (VE.Modo == "Insertando")
            {
                if (FC.ValidacionCampos(this.Name, Controls))
                {

                    //Insertar Vehiculo
                    VE.InsertarVehiculo(txtMarca.Text, txtModelo.Text, txtDescripcion.Text, txtMatricula.Text, 
                        (int)cboSeguro.SelectedValue, dtpEmisionSeguro.Value, dtpVencimientoSeguro.Value,
                        (int)cboEstatus.SelectedValue,int.Parse(txtCapacidad.Text));

                    //Limpiar y resetear los campos de formulario
                    FC.LimpiarCampos(Controls);

                    //Actualizar listado de vehiculos
                    this.ListaGeneralVehiculos(cboFiltrar.Text, txtBuscar.Text);
                }
            }
            else
            {
                var resp = MessageBox.Show("Se encuentra actualmente en el modo de edición \n" +
                    "¿Desea limpiar los campos y cambiar al modo de Inserción?", "Aviso",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resp == DialogResult.Yes)
                {
                    VE.Modo = "Insertando";
                    FC.LimpiarCampos(Controls);
                }
            }
        }

        private void MostrarEdicion(DataGridViewSelectedRowCollection dgvVehiculos)
        {
            txtMarca.Text = dgvVehiculos[0].Cells["Marca"].Value.ToString();
            txtModelo.Text = dgvVehiculos[0].Cells["Modelo"].Value.ToString();
            txtMatricula.Text = dgvVehiculos[0].Cells["Matricula"].Value.ToString();
            if (dgvVehiculos[0].Cells["Seguro"].Value.ToString()== "PEPIN(LEY)")
            {
                cboSeguro.SelectedValue = 1;
            }
            else if (dgvVehiculos[0].Cells["Seguro"].Value.ToString() == "BANRESERVAS(SUPREMO)")
            {
                cboSeguro.SelectedValue = 2;
            }
            
            dtpEmisionSeguro.Text = dgvVehiculos[0].Cells["Fecha_Emisión_Seguro"].Value.ToString();
            dtpVencimientoSeguro.Text = dgvVehiculos[0].Cells["Fecha_Vencimiento_Seguro"].Value.ToString();
            txtDescripcion.Text = dgvVehiculos[0].Cells["Descripción"].Value.ToString();
            txtCapacidad.Text = dgvVehiculos[0].Cells["Capacidad"].Value.ToString();
            if (dgvVehiculos[0].Cells["Estatus"].Value.ToString() == "ACTIVO")
            {
                cboEstatus.SelectedValue = 1;
            }
            else if (dgvVehiculos[0].Cells["Estatus"].Value.ToString() == "INACTIVO")
            {
                cboEstatus.SelectedValue = 2;
            }

        }

        private void dgvVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarEdicion(dgvVehiculos.SelectedRows);
            VehiculosModel.IDSeleccionado = (int)dgvVehiculos.SelectedRows[0].Cells["ID"].Value;
            VE.Modo = "Editando";
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (VE.Modo == "Editando")
            {
                if (FC.ValidacionCampos(this.Name, Controls))
                {
                    VE.ActualizarVehiculo(VehiculosModel.IDSeleccionado, txtMarca.Text, txtModelo.Text, 
                        txtDescripcion.Text, txtMatricula.Text,(int)cboSeguro.SelectedValue, dtpEmisionSeguro.Value, 
                        dtpVencimientoSeguro.Value,(int)cboEstatus.SelectedValue,int.Parse(txtCapacidad.Text));

                    FC.LimpiarCampos(Controls);
                    VE.Modo = "Insertando";
                    this.ListaGeneralVehiculos(cboFiltrar.Text, txtBuscar.Text);

                }
            }
            else
            {
                MessageBox.Show("Para actualizar debe seleccionar un vehiculo de la tabla.", "Sistema de Gestión",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (VE.Modo == "Editando")
            {

                if (VE.EliminarVehiculo(VehiculosModel.IDSeleccionado))
                {
                    this.ListaGeneralVehiculos(cboFiltrar.Text,txtBuscar.Text);
                    FC.LimpiarCampos(Controls);
                    VE.Modo = "Insertando";
                }

            }
            else
            {
                MessageBox.Show("Para eliminar debe seleccionar un vehiculo de la tabla.", "Sistema de Gestión",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.ListaGeneralVehiculos(cboFiltrar.Text, txtBuscar.Text);
        }

        private void cboFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cambiar el estatus del textbox según la opción marcada
            if (cboFiltrar.SelectedIndex != 0)
            {
                txtBuscar.Enabled = true;
            }
            else
            {
                txtBuscar.Enabled = false;
                //Ejecutar el metodo del textBox
                txtBuscar_TextChanged(sender, e);
            }
            //Limpiar el TextBox
            txtBuscar.Clear();
            FC.LimpiarCampos(Controls);
        }

        private void txtModelo_Leave(object sender, EventArgs e)
        {
            if (VE.Modo != "Editando")
            {
                txtDescripcion.Text = $"{txtMarca.Text} {txtModelo.Text}";
            }
            
        }
    }
}
