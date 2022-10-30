using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Gestión.Modelos;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;

namespace Sistema_de_Gestión.Modelos
{
    class Empleados
    {
        public string Modo { get; set; }
        public int TotalEmpleados { get; set; }

        public int CantidadMostrar { get; set; }


        public void ListarEmpleados(string Filtro, string ValorBuscar, DataGridView dgvEmpleados, int Limite)
        {
            using (BAEmpleadosEntities DB = new BAEmpleadosEntities())
            {
                try
                {
                    //Obtener todos los elementos de la lista
                    this.CantidadMostrar = Limite;
                    var lstEmpleados = DB.VW_ListarEmpleados.OrderBy(t => t.Primer_Nombre).Take(this.CantidadMostrar);
                    var lstNuevoListado = lstEmpleados.ToList();


                    if (ValorBuscar != "")
                    {
                        if (Filtro == "ID")
                        {
                            lstNuevoListado = lstEmpleados.Where(filtro =>
                            filtro.ID.ToString() == ValorBuscar).ToList();

                        }

                        else if (Filtro == "Codigo")
                        {
                            lstNuevoListado = lstEmpleados.Where(filtro => filtro.Codigo.StartsWith(ValorBuscar)).ToList();

                        }

                        else if (Filtro == "Cedula")
                        {
                            lstNuevoListado = lstEmpleados.Where(filtro => filtro.Cedula.StartsWith(ValorBuscar)).ToList();

                        }

                        else if (Filtro == "Primer Nombre")
                        {
                            lstNuevoListado = lstEmpleados.Where(filtro => filtro.Primer_Nombre.StartsWith(ValorBuscar)).ToList();

                        }

                        else if (Filtro == "Segundo Nombre")
                        {
                            lstNuevoListado = lstEmpleados.Where(filtro => filtro.Segundo_Nombre.StartsWith(ValorBuscar)).ToList();

                        }

                        else if (Filtro == "Primer Apellido")
                        {
                            lstNuevoListado = lstEmpleados.Where(filtro => filtro.Primer_Apellido.StartsWith(ValorBuscar)).ToList();

                        }

                        else if (Filtro == "Segundo Apellido")
                        {
                            lstNuevoListado = lstEmpleados.Where(filtro => filtro.Segundo_Apellido.StartsWith(ValorBuscar)).ToList();

                        }

                        else if (Filtro == "Telefono Celular")
                        {
                            lstNuevoListado = lstEmpleados.Where(filtro => filtro.Telefono_Celular.StartsWith(ValorBuscar)).ToList();

                        }

                        else if (Filtro == "Ciudad")
                        {
                            lstNuevoListado = lstEmpleados.Where(filtro => filtro.Ciudad.StartsWith(ValorBuscar)).ToList();

                        }

                    }

                    this.TotalEmpleados = lstNuevoListado.Count();

                    //Cargar el dataGridView
                    dgvEmpleados.DataSource = null;
                    dgvEmpleados.DataSource = lstNuevoListado;

                    dgvEmpleados.Columns["Foto"].Visible = false;

                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible cargar el listado de Empleados. " + ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }


        public bool InsertarEmpleados(string PrimerNombre, string SegundoNombre, string PrimerApellido, string SegundoApellido,
			string Cedula, string TelefonoResidencial, string TelefonoCelular, DateTime FechaNacimiento, string Correo,
			string Calle, int Numero, int Casa, string Sector, int Ciudad, string NombreContacto, string TelefonoContacto,
			int Genero, int TipoSangre, int Puesto, int Departamento, int Sueldo, int Supervisor,
			int EstatusEmpleado, string MotivoEstatus, int SeguroMedico, string CondicionMedica, int CategoriaLicencia,
			DateTime FechaEmisionLicencia, DateTime FechaExpiracionLicencia, int SeguroVehicular, DateTime FechaExpiracionSeguroVehiculo,
			string Observacion, PictureBox FotoEmpleado)
        {
			using (BAEmpleadosEntities EMP = new BAEmpleadosEntities())
            {
                try
                {
                    MemoryStream IMAGEN = new MemoryStream();
                    FotoEmpleado.Image.Save(IMAGEN, ImageFormat.Bmp);


                    EMP.SP_InsertarEmpleados(PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Cedula,
                        TelefonoResidencial, TelefonoCelular, FechaNacimiento, Correo, Calle, Numero, Casa, Sector,
                        Ciudad, NombreContacto, TelefonoContacto, Genero, TipoSangre, Puesto, Departamento, Sueldo,
                        Supervisor, EstatusEmpleado, MotivoEstatus, SeguroMedico, CondicionMedica,
                        CategoriaLicencia, FechaEmisionLicencia, FechaExpiracionLicencia, SeguroVehicular,
                        FechaExpiracionSeguroVehiculo, Observacion, IMAGEN.GetBuffer());

                    MessageBox.Show("Se ha insertado el Empleado correctamente", "Nuevo Empleado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No fue posible insertar el nuevo Empleado " + ex.Message + ex.InnerException, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            return true;
        }


        public bool ActualizarEmpleados(int IDEmpleado,string PrimerNombre, string SegundoNombre, string PrimerApellido, 
            string SegundoApellido,string Cedula, string TelefonoResidencial, string TelefonoCelular, 
            DateTime FechaNacimiento, string Correo,string Calle, int Numero, int Casa, string Sector, int Ciudad, 
            string NombreContacto, string TelefonoContacto,int Genero, int TipoSangre, int Puesto, int Departamento, 
            int Sueldo, int Supervisor,int EstatusEmpleado, string MotivoEstatus, int SeguroMedico, string CondicionMedica, 
            int CategoriaLicencia,DateTime FechaEmisionLicencia, DateTime FechaExpiracionLicencia, int SeguroVehicular, 
            DateTime FechaExpiracionSeguroVehiculo,string Observacion, PictureBox FotoEmpleado)
        {
            using (BAEmpleadosEntities EMP = new BAEmpleadosEntities())
            {
                try
                {
                    MemoryStream IMAGEN = new MemoryStream();
                    FotoEmpleado.Image.Save(IMAGEN, ImageFormat.Bmp);

                    EMP.SP_ActualizarEmpleados(IDEmpleado,IDEmpleado, PrimerNombre, SegundoNombre, PrimerApellido, 
                        SegundoApellido, Cedula,TelefonoResidencial, TelefonoCelular, FechaNacimiento, Correo, Calle, 
                        Numero, Casa, Sector,Ciudad, NombreContacto, TelefonoContacto, Genero, TipoSangre, Puesto,
                        Departamento, Sueldo,Supervisor, EstatusEmpleado, MotivoEstatus, SeguroMedico, CondicionMedica,
                        CategoriaLicencia, FechaEmisionLicencia, FechaExpiracionLicencia, SeguroVehicular,
                        FechaExpiracionSeguroVehiculo, Observacion, IMAGEN.GetBuffer());

                    MessageBox.Show("El Empleado [" + Cedula + "] se actualizó correctamente.", "Empleado actualizado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No fue posible actualizar el Empleado " + ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            return true;
        }


        public bool EliminarEmpleado(int ID)
        {
            using (BAEmpleadosEntities PV = new BAEmpleadosEntities())
            {
                try
                {
                    var resp = MessageBox.Show("¿Realmente desea eliminar el empleado # [" + ID + "] del sistema?", "Eliminando",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resp == DialogResult.Yes)
                    {
                        var EliminarEmpleado = PV.SP_EliminarEmpleado(ID);
                        MessageBox.Show("Se ha eliminado el empleado con la ID [" + ID + "] correctamente", "Empleado Eliminado",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        return false;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("No fue posible eliminar el Empleado " + ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;

                }
            }
            return true;
        }

        public void ListarCiudades(ComboBox cboCiudades)
        {
            using (BAClientesModel Ciudades = new BAClientesModel())
            {
                try
                {
                    cboCiudades.Items.Add("Elegir...");

                    var lstCiudades = Ciudades.VW_ListaCiudades.ToArray();
                    foreach (var item in lstCiudades)
                    {
                        cboCiudades.Items.Add(item.Nom_Ciudad);
                    }

                    cboCiudades.SelectedIndex = 0;

                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible listar las ciudades. " + ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public void ListarGeneros(ComboBox cboGeneros)
        {
            using (BAEmpleadosEntities Genero = new BAEmpleadosEntities())
            {
                try
                {
                    cboGeneros.Items.Add("Elegir...");

                    var lstGenero = Genero.VW_ListaGeneros.ToArray();
                    foreach (var item in lstGenero)
                    {
                        cboGeneros.Items.Add(item.Nom_Genero);
                    }

                    cboGeneros.SelectedIndex = 0;

                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible listar los generos. " + ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public void ListarTipoSangre(ComboBox cboSangre)
        {
            using (BAEmpleadosEntities Sangre = new BAEmpleadosEntities())
            {
                try
                {
                    cboSangre.Items.Add("Elegir...");

                    var lstListado = Sangre.VW_ListaTipoSangre.ToArray();
                    foreach (var item in lstListado)
                    {
                        cboSangre.Items.Add(item.Des_Sangre);
                    }

                    cboSangre.SelectedIndex = 0;

                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible listar los tipos de sangre. " + ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public void ListarPuestos(ComboBox cboPuestos)
        {
            using (BAEmpleadosEntities Puestos = new BAEmpleadosEntities())
            {
                try
                {
                    cboPuestos.Items.Add("Elegir...");

                    var lstListado = Puestos.VW_ListaPuestos.ToArray();
                    foreach (var item in lstListado)
                    {
                        cboPuestos.Items.Add(item.Nom_Puesto);
                    }

                    cboPuestos.SelectedIndex = 0;

                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible listar los puestos. " + ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public void ListarDepartamentos(ComboBox cboDepartamento)
        {
            using (BAEmpleadosEntities Departamento = new BAEmpleadosEntities())
            {
                try
                {
                    cboDepartamento.Items.Add("Elegir...");

                    var lstListado = Departamento.VW_ListaDepartamentos.ToArray();
                    foreach (var item in lstListado)
                    {
                        cboDepartamento.Items.Add(item.Nom_Departamento);
                    }

                    cboDepartamento.SelectedIndex = 0;

                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible listar los departamentos. " + ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public void ListarSueldos(ComboBox cboSueldos)
        {
            using (BAEmpleadosEntities Sueldos = new BAEmpleadosEntities())
            {
                try
                {
                    cboSueldos.Items.Add("Elegir...");

                    var lstListado = Sueldos.VW_ListaSueldos.ToArray();
                    foreach (var item in lstListado)
                    {
                        double SUELDO = double.Parse(item.Can_Sueldo.ToString());
                        cboSueldos.Items.Add(SUELDO.ToString("RD$#0,00", CultureInfo.CurrentCulture));
                    }

                    cboSueldos.SelectedIndex = 0;

                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible listar los Sueldos. " + ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public void ListarSupervisores(ComboBox cboSupervisores)
        {
            using (BAEmpleadosEntities Supervisores = new BAEmpleadosEntities())
            {
                try
                {
                    cboSupervisores.Items.Add("Elegir...");

                    var lstListado = Supervisores.VW_ListaSupervisores.ToArray();
                    foreach (var item in lstListado)
                    {
                        cboSupervisores.Items.Add(item.Ape_Supervisor + ", " + item.Nom_Supervisor);
                    }

                    cboSupervisores.SelectedIndex = 0;

                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible listar los Supervisores. " + ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public void ListarEstatusEmpleados(ComboBox cboEstatusEmpleados)
        {
            using (BAEmpleadosEntities EstatusEmpleados = new BAEmpleadosEntities())
            {
                try
                {
                    cboEstatusEmpleados.Items.Add("Elegir...");

                    var lstListado = EstatusEmpleados.VW_ListaEstatusEmpleados.ToArray();
                    foreach (var item in lstListado)
                    {
                        cboEstatusEmpleados.Items.Add(item.Estatus);
                    }

                    cboEstatusEmpleados.SelectedIndex = 0;

                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible listar los Estatus de Empleados. " + ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public void ListarSeguroMedico(ComboBox cboSeguroMedico)
        {
            using (BAEmpleadosEntities SeguroMedico = new BAEmpleadosEntities())
            {
                try
                {
                    cboSeguroMedico.Items.Add("Elegir...");

                    var lstListado = SeguroMedico.VW_ListaSeguroMedico.ToArray();
                    foreach (var item in lstListado)
                    {
                        cboSeguroMedico.Items.Add(item.Nom_SeguroMedico);
                    }

                    cboSeguroMedico.SelectedIndex = 0;

                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible listar los Seguros Medicos. " + ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public void ListarCategoriaLicencia(ComboBox cboCategoriaLicencia)
        {
            using (BAEmpleadosEntities CategoriaLicencia = new BAEmpleadosEntities())
            {
                try
                {
                    cboCategoriaLicencia.Items.Add("Elegir...");

                    var lstListado = CategoriaLicencia.VW_ListaCategoriaLicencia.ToArray();
                    foreach (var item in lstListado)
                    {
                        cboCategoriaLicencia.Items.Add(item.Categoria);
                    }

                    cboCategoriaLicencia.SelectedIndex = 0;

                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible listar las categorias de licencia. " + ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public void ListarSeguroVehiculo(ComboBox cboSeguroVehiculo)
        {
            using (BAEmpleadosEntities SeguroVehiculo = new BAEmpleadosEntities())
            {
                try
                {
                    cboSeguroVehiculo.Items.Add("Elegir...");

                    var lstListado = SeguroVehiculo.VW_ListaSeguroVehicular.ToArray();
                    foreach (var item in lstListado)
                    {
                        cboSeguroVehiculo.Items.Add(item.Nom_SeguroVehicular);
                    }

                    cboSeguroVehiculo.SelectedIndex = 0;

                }
                catch (Exception ex)
                {

                    MessageBox.Show("No fue posible listar los seguros vehicular. " + ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public void LoadFiltros(ComboBox cboFiltros)
        {
            string[] Filtros = new string[] { "Ninguno", "ID", "Codigo","Cedula","Primer Nombre", "Segundo Nombre", 
                "Primer Apellido", "Segundo Apellido", "Telefono Celular", "Ciudad"};
            cboFiltros.Items.AddRange(Filtros);
            cboFiltros.SelectedIndex = 0;
        }

        public void CargarCantidadVista(ComboBox cboViews)
        {
            object[] RegistroMostrar = new object[] { 5, 10, 15, 20, 25, 30, 50, 100 };
            cboViews.Items.AddRange(RegistroMostrar);
            cboViews.SelectedIndex = 0;
        }
    }
}
