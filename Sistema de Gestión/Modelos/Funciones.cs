﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Gestión.Modelos;
using Sistema_de_Gestión.Presentacion;
using System.Threading;
using System.Drawing;

namespace Sistema_de_Gestión.Modelos
{
    class Funciones
    {
        public string Modo { get; set; }

        public void LimpiarCampos(Control.ControlCollection control)
        {
            var CamposTXT = control.OfType<TextBox>().OrderBy(t => t.TabIndex);
            var ListasCBO = control.OfType<ComboBox>().OrderBy(t => t.TabIndex);
            var DataPicker = control.OfType<DateTimePicker>().OrderBy(t => t.TabIndex);
            var PictureBx = control.OfType<PictureBox>().Where(t => t.Name == "pbFotoEmpleado").SingleOrDefault();
            var LBL = control.OfType<Label>().Where(t => t.Name == "LblID").SingleOrDefault();
            var lblCodigo = control.OfType<Label>().Where(t => t.Name == "lblCodigo").SingleOrDefault();
            var DataGrid = control.OfType<DataGridView>().ToList();
            var BarraEstado = control.OfType<ToolStrip>().ToList();

            //Limpiar todos los TextBox
            foreach (var Camp in CamposTXT)
            {
                Camp.Clear();
            }

            //Restablecer la seleccion de los ComboBox a 0
            foreach (var Lst in ListasCBO)
            {
                if (Lst.SelectedIndex != -1)
                {
                    Lst.SelectedIndex = 0;
                }

            }

            //Restablecer los DateTimePicker
            foreach (var Dat in DataPicker)
            {
                Dat.ResetText();
            }

            //Limpiar LabelID
            if (LBL!=null)
            {
                LBL.Text = "";
            }

            //Reset Codigo Empleado
            if (lblCodigo!=null)
            {
                lblCodigo.Text = "";
            }
  
            //Reset Imagen
            if (PictureBx != null)
            {
                PictureBx.Image = RecursosBA.DefaultImage;
                this.Modo = "Insertando";
            }

            //DataGridViews del formulario Proforma
            if (DataGrid.Count!=0)
            {
                foreach (var elemento in DataGrid)
                {
                    switch (elemento.Name)
                    {
                        case "dgvPedidos":
                        case "dgvConduceProforma":
                            elemento.DataSource = null;
                            break;

                    }
                }
            }

            //Barra de estados de los formularios
            if (BarraEstado.Count!=0)
            {
                foreach (var elemento in BarraEstado)
                {
                    switch (elemento.Name)
                    {
                        case "StatusBarProforma":
                            elemento.Items["toolProformaPedidosRegistrados"].Text = "Pedidos registrados: 0";
                            elemento.Items["toolProformaConducesRegistrados"].Text = "Conduces: 0";
                            break;

                    }
                }
            }

        }

        public bool ValidacionCampos(string formName, Control.ControlCollection control)
        {
            var CamposTXT = control.OfType<TextBox>().OrderBy(t => t.TabIndex);
            var ListasCBO = control.OfType<ComboBox>().OrderBy(t => t.TabIndex);

            switch (formName)
            {
                case "frmMantenimientoProductos":
                    foreach (var item in CamposTXT)
                    {
                        if (!string.IsNullOrEmpty(item.Text))
                        {
                            if (item.Name == "txtProducto")
                            {
                                if (item.TextLength > 5 || !string.IsNullOrEmpty(item.Text))
                                {

                                    foreach (var itemCBO in ListasCBO)
                                    {
                                        if (itemCBO.Text == "Elegir...")
                                        {
                                            MessageBox.Show("Debe indicar una opción valida en [" + itemCBO.Tag + "] para continuar.",
                                               "Sistema de Gestión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            return false;
                                        }
                                    }

                                }
                                else
                                {
                                    return false;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("El campo [" + item.Tag + "] no puede estar vacio.", "Sistema de Gestión",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                    }
                    break;

                case "frmMantenimientoCategorias":
                    foreach (var item in CamposTXT)
                    {
                        if (string.IsNullOrEmpty(item.Text))
                        {
                            MessageBox.Show("El campo [" + item.Tag + "] no puede estar vacio.", "Sistema de Gestión",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                    }

                    break;


                case "frmMantenimientoProveedores":
                    foreach (var item in CamposTXT)
                    {
                        if (string.IsNullOrEmpty(item.Text))
                        {
                            MessageBox.Show("El campo [" + item.Tag + "] no puede estar vacio.", "Sistema de Gestión",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                    }

                    break;

                case "frmMantenimientoClientes":
                    foreach (var item in CamposTXT)
                    {
                        var CboClientes = control.OfType<ComboBox>().Where(t => t.Name=="cboTipoClientes").SingleOrDefault();
                        var MaskCedula = control.OfType<MaskedTextBox>().Where(t => t.Name =="txtCedula").SingleOrDefault();
                        var MaskRNC = control.OfType<MaskedTextBox>().Where(t => t.Name == "txtRNC").SingleOrDefault();

                        if (CboClientes.SelectedIndex == 0)
                        {
                            MessageBox.Show("Debe indicar una opción valida en [" + CboClientes.Tag + "] para continuar.",
                                      "Sistema de Gestión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }

                        else if (CboClientes.SelectedIndex!=1)
                        {


                            if (MaskRNC.MaskFull)
                            {
                                if (string.IsNullOrEmpty(item.Text))
                                {
                                    MessageBox.Show("El campo [" + item.Tag + "] no puede estar vacio.", "Sistema de Gestión",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("El campo [" + MaskRNC.Tag + "] debe contener todos los digitos requeridos.", "Sistema de Gestión",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return false;
                            }

                            foreach (var itemCBO in ListasCBO)
                            {
                                if (itemCBO.Text == "Elegir...")
                                {
                                    MessageBox.Show("Debe indicar una opción valida en [" + itemCBO.Tag + "] para continuar.",
                                       "Sistema de Gestión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return false;
                                }
                            }
                        }
                       
                        else
                        {
                            if ((item.Name!="txtEmpresa") && (item.Name!= "txtRNC") && (item.Name!="txtProyecto"))
                            {
                                if (MaskCedula.MaskFull)
                                {
                                    if (string.IsNullOrEmpty(item.Text))
                                    {
                                        MessageBox.Show("El campo [" + item.Tag + "] no puede estar vacio.", "Sistema de Gestión",
                                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        return false;
                                    }
                                }

                                else
                                {
                                MessageBox.Show("El campo [" + MaskCedula.Tag + "] debe contener todos los digitos requeridos.", "Sistema de Gestión",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return false;
                                }


                            }
                           
                        }

                       
                    }

                    break;


                case "frmMantenimientoEmpleados":
                    foreach (var item in CamposTXT)
                    {
                        if ((item.Name!="txtMotivoEstatus") && (item.Name!= "txtCondicionMedica") && 
                            (item.Name != "txtObservacion"))
                        {
                            if (string.IsNullOrEmpty(item.Text))
                            {
                                MessageBox.Show("El campo [" + item.Tag + "] no puede estar vacio.", "Sistema de Gestión",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return false;
                            }
                        }
                       

                        foreach (var itemCBO in ListasCBO)
                        {
                            if (itemCBO.Text == "Elegir...")
                            {
                                MessageBox.Show("Debe indicar una opción valida en [" + itemCBO.Tag + "] para continuar.",
                                   "Sistema de Gestión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return false;
                            }
                        }
                    }

                    break;

                case "frmConfiguraciones":
                    foreach (var item in CamposTXT)
                    {
                        if (string.IsNullOrEmpty(item.Text))
                        {
                            MessageBox.Show("El campo [" + item.Tag + "] no puede estar vacio.", "Sistema de Gestión",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }

                        foreach (var itemCBO in ListasCBO)
                        {
                            if (itemCBO.Text == "Elegir...")
                            {
                                MessageBox.Show("Debe indicar una opción valida en [" + itemCBO.Tag + "] para continuar.",
                                   "Sistema de Gestión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return false;
                            }
                        }
                    }

                    break;

                case "frmCambiarClave":
                    foreach (var item in CamposTXT)
                    {
                        if (string.IsNullOrEmpty(item.Text))
                        {
                            MessageBox.Show("El campo [" + item.Tag + "] no puede estar vacio.", "Sistema de Gestión",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                    }

                    break;


                case "frmMantenimientoVehiculos":
                    foreach (var item in CamposTXT)
                    {
                        if (string.IsNullOrEmpty(item.Text))
                        {
                            MessageBox.Show("El campo [" + item.Tag + "] no puede estar vacio.", "Sistema de Gestión",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }

                        foreach (var itemCBO in ListasCBO)
                        {
                            if (itemCBO.Text == "Elegir...")
                            {
                                MessageBox.Show("Debe indicar una opción valida en [" + itemCBO.Tag + "] para continuar.",
                                   "Sistema de Gestión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return false;
                            }
                        }
                    }

                    break;

            }

            return true;


        }

        public bool ValidarVentanaAbierta(string formName)
        {
            Form formulario = Application.OpenForms.OfType<Form>().SingleOrDefault(t => t.Text == formName);
            frmPrincipal Principal = new frmPrincipal();

              if (formulario != null)
              {
                MessageBox.Show($"El reporte [{formulario.Text}] ya esta abierto.", "Aviso", MessageBoxButtons.OK, 
                     MessageBoxIcon.Exclamation);
                formulario.Focus();
                return true;
              }
                 
            return false;
        }

        public bool SoloTexto(KeyPressEventArgs Tecla)
        {
            if((Tecla.KeyChar >= 97 && Tecla.KeyChar <= 122 || Tecla.KeyChar==32 || Tecla.KeyChar==08)
                || Tecla.KeyChar>=65 && Tecla.KeyChar <= 90)
            {
                return Tecla.Handled = false;
            }
            else
            {
                return Tecla.Handled = true;
            }
        }

        public bool SoloNumeros(KeyPressEventArgs Tecla)
        {
            if ((Tecla.KeyChar >= 48 && Tecla.KeyChar <= 57 || Tecla.KeyChar == 08 || Tecla.KeyChar==44 
                || Tecla.KeyChar==46))
            {
                return Tecla.Handled = false;
            }
            else
            {
                return Tecla.Handled = true;
            }
        }


        public void Cargando()
        {
            Thread.Sleep(2000);
        }

        public void Mostrar(Form Formulario)
        {
            Formulario.Show();
            Formulario.TopMost = true;
        }

        public void Cerrar(Form Formulario)
        {
            if (Formulario != null)
            {
                Formulario.Close();
            }
        }
        
        public async void Ejecutar(Form FormularioVista, Form FormularioLoading, string Cliente)
        {
            Mostrar(FormularioLoading);
            Task otaskProforma = new Task(Cargando);
            otaskProforma.Start();
            FormularioVista.Text += " - " + Cliente;
            FormularioVista.Show();
            await otaskProforma;
            Cerrar(FormularioLoading);
        }

        public async Task<List<SP_BuscarClienteProforma_Result>> EjecutarAccion(ProformaFactura PF, string cliente, 
            ToolStripLabel msg, Button Boton)
        {
            Boton.Enabled = false;
            msg.Text = "Buscando...";
            Task otaskProforma = new Task(Cargando);
            otaskProforma.Start();
            msg.BackColor = Color.Brown;
            msg.ForeColor = Color.White;
            
            PF.VerClienteProforma(cliente);
            
            msg.BackColor = Color.Transparent;
            msg.ForeColor = Color.Black;
            Boton.Enabled = true;
            msg.Text = "Listo";
            await otaskProforma;
                
            return PF.ClienteProforma;


        }

        public async Task<List<SP_ProformaBuscarPedidosPendientesCliente_Result>> EjecutarAccion(ProformaFactura PF, 
           ToolStripLabel msg, Button Boton, int idCliente,int pedido, string modoreporte, int estatus, 
           DateTime FechaInicio, DateTime FechaFin)
        {
            Boton.Enabled = false;
            msg.Text = "Buscando...";
            msg.BackColor = Color.Brown;
            msg.ForeColor = Color.White;
            Task otaskProforma = new Task(Cargando);
            otaskProforma.Start();

            PF.VerPedidoProforma(idCliente, pedido, modoreporte, estatus, FechaInicio, FechaFin);

            msg.BackColor = Color.Transparent;
            msg.ForeColor = Color.Black;
            Boton.Enabled = true;
            msg.Text = "Listo";
            await otaskProforma;

            return PF.PedidoProforma;


        }

    }
}
