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
using System.IO;
using System.Globalization;

namespace Sistema_de_Gestión.Presentacion
{
    public partial class frmMantenimientoEmpleados : Form
    {
        Empleados Emp = new Empleados();
        Funciones FC = new Funciones();
        DiseñoInterface DI = new DiseñoInterface();
        public frmMantenimientoEmpleados()
        {
            InitializeComponent();
            Emp.ListarCiudades(cboCiudades);
            Emp.ListarGeneros(cboGenero);
            Emp.ListarPuestos(cboPuesto);
            Emp.ListarDepartamentos(cboDepartamento);
            Emp.ListarCategoriaLicencia(cboCategoriaLicencia);
            Emp.ListarEstatusEmpleados(cboEstatus);
            Emp.ListarSeguroMedico(cboSeguroMedico);
            Emp.ListarSeguroVehiculo(cboSeguroVehiculo);
            Emp.ListarSueldos(cboSueldos);
            Emp.ListarSupervisores(cboSupervisor);
            Emp.ListarTipoSangre(cboTipoSangre);
            Emp.LoadFiltros(cboFiltrar);
            Emp.CargarCantidadVista(cboViewRecord);
            LoadEmpleados("Ninguno", "", 5);
            Emp.Modo = "Insertando";

        }

        private void LoadEmpleados(string Filtro, string ValorBuscar, int Limite)
        {
            Emp.ListarEmpleados(Filtro, ValorBuscar, dgvEmpleados, Limite);
            lblTotalEmpleados.Text = "Total Empleados: " + Emp.TotalEmpleados.ToString();
        }

        private void LoadEmpleados(string Filtro, string ValorBuscar)
        {
            Emp.ListarEmpleados(Filtro, ValorBuscar, dgvEmpleados, 5);
            lblTotalEmpleados.Text = "Total Empleados: " + Emp.TotalEmpleados.ToString();
        }

        private void cmdInsertar_Click(object sender, EventArgs e)
        {
                if (Emp.Modo == "Insertando")
                {
                    if (FC.ValidacionCampos(this.Name, Controls))
                    {
                        int Edad = DateTime.Now.Year - dtpFechaNacimiento.Value.Year;
                        if (Edad >= 18)
                        {
                            //Insertar los productos
                            if (Emp.InsertarEmpleados(txtPrimerNombre.Text, txtSegundoNombre.Text, txtPrimerApellido.Text,
                                txtSegundoApellido.Text, txtCedula.Text, txtTelefonoPrincipal.Text, txtTelefonoSecundario.Text,
                                dtpFechaNacimiento.Value, txtCorreo.Text, txtCalle.Text, int.Parse(txtNumero.Text), int.Parse(txtCasa.Text), txtSector.Text,
                                cboCiudades.SelectedIndex, txtContactoEmergencia.Text, txtTelefonoEmergencia.Text, cboGenero.SelectedIndex,
                                cboTipoSangre.SelectedIndex, cboPuesto.SelectedIndex, cboDepartamento.SelectedIndex, cboSueldos.SelectedIndex,
                                cboSupervisor.SelectedIndex, cboEstatus.SelectedIndex, txtMotivoEstatus.Text, cboSeguroMedico.SelectedIndex,
                                txtCondicionMedica.Text, cboCategoriaLicencia.SelectedIndex, dtpFechaEmisionLicencia.Value,
                                dtpFechaExpiracionLicencia.Value, cboSeguroVehiculo.SelectedIndex, dtpExpiracionSeguroVehiculo.Value,
                                txtObservacion.Text, pbFotoEmpleado))
                            {

                                //Limpiar y resetear los campos de formulario
                                FC.LimpiarCampos(Controls);

                                //Actualizar listado de clientes
                                LoadEmpleados(cboFiltrar.Text, txtBuscar.Text, int.Parse(cboViewRecord.Text));
                                Emp.Modo = "Insertando";
                            }


                        }
                        else
                        {
                        MessageBox.Show("El empleado debe ser mayor de edad, verfique la fecha de nacimiento", "Edad",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                   
                }
                else
                {
                    var resp = MessageBox.Show("Se encuentra actualmente en el modo de edición \n" +
                        "¿Desea limpiar los campos y cambiar al modo de Inserción?", "Aviso",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resp == DialogResult.Yes)
                    {
                        FC.LimpiarCampos(Controls);
                        Emp.Modo = FC.Modo;
                    }
                }

            
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                LoadEmpleados(cboFiltrar.Text, txtBuscar.Text);
            }
            else
            {
                LoadEmpleados(cboFiltrar.Text, txtBuscar.Text, int.Parse(cboViewRecord.Text));
            }

        }

        private void MostrarEdicion(DataGridViewSelectedRowCollection dgvEmpleados)
        {
            double SUELDO = double.Parse(dgvEmpleados[0].Cells["Sueldo"].Value.ToString());
            txtCedula.Text = dgvEmpleados[0].Cells["Cedula"].Value.ToString();
            txtPrimerNombre.Text = dgvEmpleados[0].Cells["Primer_Nombre"].Value.ToString();
            txtSegundoNombre.Text = dgvEmpleados[0].Cells["Segundo_Nombre"].Value.ToString();
            txtPrimerApellido.Text = dgvEmpleados[0].Cells["Primer_Apellido"].Value.ToString();
            txtSegundoApellido.Text = dgvEmpleados[0].Cells["Segundo_Apellido"].Value.ToString();
            txtTelefonoPrincipal.Text = dgvEmpleados[0].Cells["Telefono_Residencial"].Value.ToString();
            txtTelefonoSecundario.Text = dgvEmpleados[0].Cells["Telefono_Celular"].Value.ToString();
            txtCalle.Text = dgvEmpleados[0].Cells["Calle"].Value.ToString();
            txtNumero.Text = dgvEmpleados[0].Cells["Numero"].Value.ToString();
            txtCasa.Text = dgvEmpleados[0].Cells["Casa"].Value.ToString();
            cboCiudades.SelectedItem = dgvEmpleados[0].Cells["Ciudad"].Value.ToString();
            txtCorreo.Text = dgvEmpleados[0].Cells["Correo"].Value.ToString();
            dtpFechaNacimiento.Text = dgvEmpleados[0].Cells["Fecha_Nacimiento"].Value.ToString();
            txtSector.Text = dgvEmpleados[0].Cells["Sector"].Value.ToString();
            txtContactoEmergencia.Text = dgvEmpleados[0].Cells["Nombre_Contacto_Emergencia"].Value.ToString();
            txtTelefonoEmergencia.Text = dgvEmpleados[0].Cells["Telefono_Contacto"].Value.ToString();
            cboGenero.SelectedItem = dgvEmpleados[0].Cells["Genero"].Value.ToString();
            cboTipoSangre.SelectedItem = dgvEmpleados[0].Cells["Tipo_Sangre"].Value.ToString();
            cboPuesto.SelectedItem = dgvEmpleados[0].Cells["Puesto"].Value.ToString();
            cboDepartamento.SelectedItem = dgvEmpleados[0].Cells["Departamento"].Value.ToString();
            cboSueldos.SelectedItem = SUELDO.ToString("RD$#0,00", CultureInfo.CurrentCulture);
            cboSupervisor.SelectedItem = dgvEmpleados[0].Cells["Supervisor"].Value.ToString();
            cboEstatus.SelectedItem = dgvEmpleados[0].Cells["Estatus"].Value.ToString();
            cboSeguroMedico.SelectedItem = dgvEmpleados[0].Cells["Seguro_Medico"].Value.ToString();
            cboCategoriaLicencia.SelectedItem = dgvEmpleados[0].Cells["Categoria"].Value;
            cboSeguroVehiculo.SelectedItem = dgvEmpleados[0].Cells["Seguro_Vehicular"].Value.ToString();
            txtObservacion.Text = dgvEmpleados[0].Cells["Observación"].Value.ToString();
            txtMotivoEstatus.Text = dgvEmpleados[0].Cells["Motivo_Estatus"].Value.ToString();
            txtCondicionMedica.Text = dgvEmpleados[0].Cells["Condicion_Medica"].Value.ToString();
            lblCodigo.Text = dgvEmpleados[0].Cells["Codigo"].Value.ToString();
            dtpExpiracionSeguroVehiculo.Text = dgvEmpleados[0].Cells["Fecha_Expiracion_Seguro"].Value.ToString();
            dtpFechaEmisionLicencia.Text = dgvEmpleados[0].Cells["Fecha_Emision_Licencia"].Value.ToString();
            dtpFechaExpiracionLicencia.Text = dgvEmpleados[0].Cells["Fecha_Expiracion_Licencia"].Value.ToString();
            LblID.Text = dgvEmpleados[0].Cells["ID"].Value.ToString();

            //Cargar la imagen
            Byte[] archivo = (byte[])dgvEmpleados[0].Cells["Foto"].Value;
            Stream IMAGEN = new MemoryStream(archivo);
            pbFotoEmpleado.Image = Image.FromStream(IMAGEN);
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                MostrarEdicion(dgvEmpleados.SelectedRows);
                Emp.Modo = "Editando";
            }

        }

        private void pbFotoEmpleado_DoubleClick(object sender, EventArgs e)
        {
            var Resultado = MessageBox.Show("¿Desea cambiar la foto del empleado?", "Cambiar Foto",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Resultado == DialogResult.Yes)
            {
                OpenFileDialog Dialogo = new OpenFileDialog();
                DialogResult Archivo = Dialogo.ShowDialog();

                if (Archivo == DialogResult.OK)
                {
                    pbFotoEmpleado.Image = Image.FromFile(Dialogo.FileName);
                }
            }

           
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (Emp.Modo == "Editando")
            {
                if (FC.ValidacionCampos(this.Name, Controls))
                {
                    if (Emp.ActualizarEmpleados(int.Parse(LblID.Text), txtPrimerNombre.Text, txtSegundoNombre.Text, 
                        txtPrimerApellido.Text,txtSegundoApellido.Text, txtCedula.Text, txtTelefonoPrincipal.Text, 
                        txtTelefonoSecundario.Text,dtpFechaNacimiento.Value, txtCorreo.Text, txtCalle.Text, 
                        int.Parse(txtNumero.Text), int.Parse(txtCasa.Text), txtSector.Text,cboCiudades.SelectedIndex, 
                        txtContactoEmergencia.Text, txtTelefonoEmergencia.Text, cboGenero.SelectedIndex,
                        cboTipoSangre.SelectedIndex, cboPuesto.SelectedIndex, cboDepartamento.SelectedIndex, cboSueldos.SelectedIndex,
                        cboSupervisor.SelectedIndex, cboEstatus.SelectedIndex, txtMotivoEstatus.Text, cboSeguroMedico.SelectedIndex,
                        txtCondicionMedica.Text, cboCategoriaLicencia.SelectedIndex, dtpFechaEmisionLicencia.Value,
                        dtpFechaExpiracionLicencia.Value, cboSeguroVehiculo.SelectedIndex, dtpExpiracionSeguroVehiculo.Value,
                        txtObservacion.Text, pbFotoEmpleado))
                    {
                        FC.LimpiarCampos(Controls);

                        LoadEmpleados(cboFiltrar.Text, txtBuscar.Text, int.Parse(cboViewRecord.Text));

                        Emp.Modo = "Insertando";
                    }

                }
            }
            else
            {
                MessageBox.Show("Para actualizar debe seleccionar un empleado de la tabla.", "Sistema de Gestión",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (Emp.Modo == "Editando")
            {

                if (Emp.EliminarEmpleado(int.Parse(LblID.Text)))
                {
                    LoadEmpleados(cboFiltrar.Text, txtBuscar.Text, int.Parse(cboViewRecord.Text));
                    FC.LimpiarCampos(Controls);
                    Emp.Modo = "Insertando";
                }

            }
            else
            {
                MessageBox.Show("Para eliminar debe seleccionar un empleado de la tabla.", "Sistema de Gestión",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = FC.SoloNumeros(e);
        }

        private void txtCasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = FC.SoloNumeros(e);
        }

        private void cboViewRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadEmpleados(cboFiltrar.Text, txtBuscar.Text, int.Parse(cboViewRecord.Text));
        }
    }
}
