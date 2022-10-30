using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Gestión.Modelos;
using System.Windows.Forms;
using System.Data;

namespace Sistema_de_Gestión.Modelos
{
    public class EntrarLogin
    {
        //Declaracion de atributos de la clase Login
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Perfil { get; set; }

        public int ID { get; set; }

        public int Estatus { get; set; }

        public string Modo { get; set; }

        //Atributos del tipo estaticos
        static public string UsuarioActual { get; set; }
        static public string PerfilActual { get; set; }
        static public int IDActual { get; set; }

        //Metodo para validar el usuario y contraseña en la base de datos
        public bool Acceso(string User, string pass)
        {
            //Modelo BoteAgregados para manipular la base de datos por EntityFramework
            using (BoteAgregadosEntities db = new BoteAgregadosEntities())
            {
                if (!string.IsNullOrEmpty(User) && !string.IsNullOrEmpty(pass))
                {
                    //Llamada al procedimiento almacenado SP_ObtenerUsuario y pasadole el parametro Usuario
                    if (db.SP_ObtenerUsuario(User).Count()>0)
                    {
                        //Si encuentra el usuario asigna el resultado de cada columna en los atributos
                        this.Usuario = db.SP_ObtenerUsuario(User).ToList().Single().Nombre;
                        this.Contraseña = db.SP_ObtenerUsuario(User).ToList().Single().Clave;
                        this.Perfil = db.SP_ObtenerUsuario(User).ToList().Single().Rol;
                        this.Estatus = (int)db.SP_ObtenerUsuario(User).ToList().Single().Estado;
                        this.ID = (int)db.SP_ObtenerUsuario(User).ToList().Single().ID;

                        if (User == this.Usuario && pass == this.Contraseña)
                        {
                            if (this.Estatus!=0)
                            {
                                //Devolver verdadero si el usuario y contraseña es el mismo de la base de datos
                                UsuarioActual = this.Usuario;
                                PerfilActual = this.Perfil;
                                IDActual = this.ID;
                                db.SP_ActualizarAccesoLogin(User);
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("El usuario indicado esta desactivado", "Acceso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return false;
                            }
                        }
                       
                    }

                }
            }
            MessageBox.Show("El nombre de usuario o contraseña son incorrectos", "Acceso", 
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }

        public void ListarUsuarios(DataGridView dgvUsuarios)
        {
            using (BoteAgregadosEntities BA = new BoteAgregadosEntities())
            {
                try
                {
                    var Usuarios = BA.VW_VerUsuarios.ToList();
                    dgvUsuarios.DataSource = Usuarios;

                  

                    dgvUsuarios.Columns["ID"].Visible = false;
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("No fue posible listar los usuarios. " + Ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public void ListarPerfiles(ComboBox cboPerfiles)
        {
            using (BoteAgregadosEntities BA = new BoteAgregadosEntities())
            {
                try
                {
                    var Perfiles = BA.VW_VerRolesUsuario.ToList();

                    cboPerfiles.DisplayMember = "Perfil";
                    cboPerfiles.ValueMember = "ID";
                    cboPerfiles.DataSource = Perfiles;
                    cboPerfiles.SelectedValue = 2;



                }
                catch (Exception Ex)
                {
                    MessageBox.Show("No fue posible listar los perfiles de usuario. " + Ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public void ListarEstatus(ComboBox cboEstatus)
        {
            string[] Estatus = new string[] { "Activado", "Desactivado" };
            cboEstatus.Items.AddRange(Estatus);
            cboEstatus.SelectedIndex = 0;
        }

        public void InsertarUsuarios(string Nombre, string Clave, string Email, int Perfil, DateTime UltimoAcceso)
        {
            using (BoteAgregadosEntities BA = new BoteAgregadosEntities())
            {
                try
                {
                    BA.SP_InsertarUsuarios(Nombre, Clave, Perfil, UltimoAcceso, Email);
                    MessageBox.Show($"El usuario {Nombre} se ha insertado correctamente.", "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("No fue posible insertar el nuevo usuario. " + Ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public void ActualizarUsuario(int ID, string Nombre, int Perfil, string Email, int Estatus)
        {
            using (BoteAgregadosEntities BA = new BoteAgregadosEntities())
            {
                try
                {
                    BA.SP_ActualizarUsuario(ID, Nombre, Perfil, Email, Estatus);
                    MessageBox.Show($"El usuario {Nombre} ha sido actualizado correctamente.", "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show($"No fue posible actualizar el usuario {Nombre}. " + Ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public void DesactivarUsuario(int ID, string Nombre)
        {
            using (BoteAgregadosEntities BA = new BoteAgregadosEntities())
            {
                try
                {
                    DialogResult Usuario = MessageBox.Show($"Realmente desea desactivar al usuario [ {Nombre} ]?", "Eliminando",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Usuario == DialogResult.Yes)
                    {
                        BA.SP_DesactivarUsuario(ID);
                        MessageBox.Show($"El usuario [ {Nombre} ] se ha desactivado correctamente.", "Sistema de Gestión",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                   
                }
                catch (Exception Ex)
                {
                    MessageBox.Show($"No fue posible actualizar el usuario [ {Nombre} ]. " + Ex.Message, "Sistema de Gestión",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public int CambiarClave(int ID, string ClaveActual, string ClaveNueva)
        {
            using (BoteAgregadosEntities ba = new BoteAgregadosEntities())
            {
                try
                {
                    return ba.SP_CambiarClaveUsuario(ID, ClaveActual, ClaveNueva);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("No fue posible cambiar la clave de usuario. " + Ex.Message, "Cambio de Contraseña",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return 0;
                }
            }
        }




    }
}
