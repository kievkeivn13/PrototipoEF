using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorMVentasCC;
using BitacoraUsuario;
using static datosUsuario;

namespace CapaVistaMVentasCC
{
    public partial class frmComisiones : Form
    {
        private Controlador cn = new Controlador();
        Bitacora loggear = new Bitacora();

        public Boolean permisoIngreso = true;  //Valor que debe llegar de seguridad
        public Boolean permisoModificar = true;  //Valor que debe llegar de seguridad
        public Boolean permisoEliminar = true;  //Valor que debe llegar de seguridad
        public Boolean permisoConsultar = true;  //Valor que debe llegar de seguridad
        public Boolean permisoReporteador = true;  //Valor que debe llegar de seguridad
        string permisos = "";
        public frmComisiones()
        {
            InitializeComponent(); SetMyCustomFormat();
            actualizardatagriew();
            txtIdComision.Focus();
            funLlenarComboControl(cbxIdEmpleado, "Empleado", "pkIdEmpleado", "nombre", "estatus");
            funLlenarComboControl(cbxTipoComision, "Comision", "Pkid", "nombre", "estado");
            mensajesAsistencia(); 
           // loggear.guardarEnBitacora(IdUsuario, "3001", "3003", "Acceso a Facturación");
          //  permisos = bloqueo(IdUsuario, "3003");
           // funActualizarPermisos();

        }

        ArrayList referencia0 = new ArrayList();
        ArrayList referencia1 = new ArrayList();
        ArrayList referencia2 = new ArrayList();
        ArrayList referencia3 = new ArrayList();
        ArrayList referencia4 = new ArrayList();


        private string tabla = "comisionasignadaencabezado";
        private string tabla1 = "comisionasignadadetalle";
        void mensajesAsistencia()
        {
            ttMensaje.SetToolTip(txtIdComision, "Ingrese un ID");
            ttMensaje.SetToolTip(cbxIdEmpleado, "Seleccione un empleado");
            ttMensaje.SetToolTip(txtComosionesmes, "La comisión se calcula automaticamente");
            ttMensaje.SetToolTip(dtpFechaComisiones, "Seleccione fecha para el registro");
            ttMensaje.SetToolTip(dtgEncabezado, "Registros ingresados de encabezados de comisión");
            ttMensaje.SetToolTip(dtgDetalle, "Registros ingresados de detalles de las comisiones");
            ttMensaje.SetToolTip(btnAgregarEncabezado, "Ingresa registro de encabezado");
            ttMensaje.SetToolTip(btnModificarEncabezado, "Modifica registro de encabezado");
            ttMensaje.SetToolTip(btnEliminarEncabezado, "Elimina registro de encabezado");
            ttMensaje.SetToolTip(btnCancelarEncabezado, "Cancela toda operación");
            ttMensaje.SetToolTip(dtpFiltroMesAño, "Eliga mes y año del registro de facturas a buscar");
            ttMensaje.SetToolTip(txtIdDetalle, "Ingrese un ID de detalle");
            ttMensaje.SetToolTip(cbxFactura, "Seleccione un registro de factura");
            ttMensaje.SetToolTip(cbxTipoComision, "Seleccione el tipo de comisión");
            ttMensaje.SetToolTip(txtMontoFactura, "Este campo se llena automáticamente");
            ttMensaje.SetToolTip(txtSubTotal, "Este campo se llena automáticamente");
            ttMensaje.SetToolTip(txtTotal, "Este campo se llena automáticamente");
            ttMensaje.SetToolTip(btnAgregarDetalle, "Ingresa registro del detalle");
            ttMensaje.SetToolTip(btnModificarDetalle, "Modifica registro del detalle");
            ttMensaje.SetToolTip(btnEliminarDetalle, "Elimina registro del detalle");
            ttMensaje.SetToolTip(btnLimpiarDetalle, "Limpia los campos de detalle");
            ttMensaje.SetToolTip(btnReporte, "Muestra Reporte de comisiones");
            ttMensaje.SetToolTip(btnAyuda, "Muestra ayuda de comisiones");
        }
        public string bloqueo(string id, string app)
        {
            string cadena = cn.bloqueo(id, app);


            return cadena;
        }
        public void funActualizarPermisos() //Liam Patrick Bernard García 0901-18-10092, Jaime López 0901-18-735
        {

            if (permisos.Length < 5)
            {
                MessageBox.Show("El Usuario no tiene permisos para esta aplicacion.");
                this.Close();
                return;
            }

            if (permisos[0] == '1')
            {
                permisoIngreso = true;
            }
            else
            {
                permisoIngreso = false;
            }

            if (permisos[1] == '1')
            {

            }
            else
            {
                MessageBox.Show("Usted No Tiene Permisos de Lectura");
                this.Close();
            }

            if (permisos[2] == '1')
            {
                permisoReporteador = true;
            }
            else
            {
                permisoReporteador = false;
            }

            if (permisos[3] == '1')
            {
                permisoEliminar = true;
            }
            else
            {
                permisoEliminar = false;
            }

            if (permisos[4] == '1')
            {
                permisoModificar = true;
            }
            else
            {
                permisoModificar = false;
            }

            //btnGuardar.Enabled = false;
            //btnCancelar.Enabled = false;

            //Habilitación de Permisos

            if (permisoIngreso == false)
            {
                //btnValidar.Enabled = false;
               // btnInsertar.Enabled = false;
                //btnModificar.Enabled = false;
            }
            else
            {
              //  btnValidar.Enabled = true;
               // btnInsertar.Enabled = true;
               // btnModificar.Enabled = true;
            }

            if (permisoModificar == false)
            {
                dtgEncabezado.Enabled = false;
                dtgDetalle.Enabled = false;
            }
            else
            {
                dtgEncabezado.Enabled = true;
                dtgDetalle.Enabled = true;
            }

            if (permisoReporteador == false)
            {
                btnReporte.Enabled = false;
            }
            else
            {
                btnReporte.Enabled = true;
            }
        }
        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarDataGrid(tabla);
            dtgEncabezado.DataSource = dt;
            IncluirFechatxt();
        }
        public void actualizardatagriewDetalle()
        {
            DataTable dt1 = cn.llenarDataGridDetalle(tabla1, txtIdComision.Text);
            dtgDetalle.DataSource = dt1;

        }

        public void funLlenarComboControl(ComboBox cbx, string tabla, string value, string display, string estatus)
        {
            referencia1.Add(tabla);
            referencia2.Add(value);
            referencia3.Add(display);
            referencia4.Add(estatus);
            referencia0.Add(cbx);
            cn.funLlenarComboControl(cbx, tabla, value, display, estatus);

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // cn.metodoLlenarComboControlFecha(cbxFactura, "facturacionencabezado", "Pkid", "Fkidempleado", "estatus", txtFiltroFecha.Text);
        }

        private void txtIdComision_TextChanged(object sender, EventArgs e)
        {
            txtIDC.Text = txtIdComision.Text;

        }

        private void dtpFechaComisiones_ValueChanged(object sender, EventArgs e)
        {
            IncluirFechatxt();

        }
        void IncluirFechatxt()
        {
            txtFecha.Text = dtpFechaComisiones.Value.ToString("yyyy-MM-dd");

        }

        private void cbxIdEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string tablaid = "Empleado";
                txtIdEmplead.Text = cn.consultaID(cbxIdEmpleado.Text.ToString(), tablaid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }
        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dtpFiltroMesAño.Format = DateTimePickerFormat.Custom;
            dtpFiltroMesAño.CustomFormat = "MM/yyyy";
            dtpFiltroMesAño.ShowUpDown = true;

        }

        private void cbxFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string tablaid = "facturacionencabezado";
                string tablacambio = "tipocambio";
                txtIDF.Text = cn.consultaFacturaID(cbxFactura.Text.ToString(), tablaid);
                txtSubTotal.Text = "0.00"; txtTotal.Text = "0.00";
                txtMontoFactura.Text = cn.consultaTotal(cbxFactura.Text.ToString(), tablaid);
                txtIdCambio.Text = cn.consultaIdCambio(cbxFactura.Text.ToString(), tablaid);
                txtCambio.Text = cn.consultaCambio(txtIdCambio.Text.ToString(), tablacambio);
                               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
            try
            {
                float montofactura = 0, cambiomoneda = 0, montofactura2 = 0;
                montofactura = float.Parse(txtMontoFactura.Text);
                cambiomoneda = float.Parse(txtCambio.Text);
                montofactura2 = montofactura * cambiomoneda;
                txtMontoFactura.Text = montofactura2.ToString();
            }
            catch
            {

            }
        }

        private void cbxTipoComision_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string tablaid = "Comision";
                txtPorcentaje.Text = cn.consultaPorcentaje(cbxTipoComision.Text.ToString(), tablaid);
                txtIdTipoComision.Text = cn.consultaIDComision(cbxTipoComision.Text.ToString(), tablaid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
            // TotalComision();
            try
            {
                float montofactura = 0, porcentajecomision = 0, comisiontotalfactura=0, comisiontotal=0;
                montofactura = float.Parse(txtMontoFactura.Text);
                porcentajecomision = float.Parse(txtPorcentaje.Text);
                comisiontotalfactura = montofactura * porcentajecomision;
                txtSubTotal.Text = comisiontotalfactura.ToString();
                comisiontotal = comisiontotalfactura + float.Parse(txtComosionesmes.Text);
                txtTotal.Text = comisiontotal.ToString();

            }
            catch
            {

            }

        }
        private void TotalComision()
        {
            try
            {
                float valor1 = 0, saldoanterior = 0, valor2 = 0, subtotal = 0, total = 0, cambio = 0;
                valor1 = float.Parse(txtMontoFactura.Text); cambio = float.Parse(txtCambio.Text);
                valor2 = float.Parse(txtPorcentaje.Text);
                valor1 = valor1 * cambio;
                txtMontoFactura.Text = valor1.ToString();
                saldoanterior = float.Parse(txtComosionesmes.Text);
                subtotal = valor1 * valor2;
                decimal dec = Convert.ToDecimal(subtotal);
                txtSubTotal.Text = dec.ToString("0.00");
                total = saldoanterior + subtotal;
                decimal dec2 = Convert.ToDecimal(total);
                txtTotal.Text = dec2.ToString("0.00");
            }
            catch /*(Exception ex)*/
            {
                //MessageBox.Show (ex + "");
            }
        }
        void funLimpiarEnacabezado()
        {
            txtIdComision.Text = "";
            cbxIdEmpleado.SelectedIndex = 0;
            txtComosionesmes.Text = "0.00";
            dtpFechaComisiones.Value = DateTime.Now;
            funHabilitarAgregar();
        }
        void funDeshabilitaAgregar()
        {
            txtIdComision.Enabled = false;
            cbxIdEmpleado.Enabled = false;
            dtpFechaComisiones.Enabled = false;
            btnAgregarEncabezado.Enabled = false;
            btnModificarEncabezado.Enabled = false;
            btnEliminarEncabezado.Enabled = false;
            btnCancelarEncabezado.Enabled = true;
        }
        void funHabilitarAgregar()
        {
            txtIdComision.Enabled = true;
            cbxIdEmpleado.Enabled = true;
            dtpFechaComisiones.Enabled = true;
            btnAgregarEncabezado.Enabled = true;
            btnModificarEncabezado.Enabled = false;
            btnEliminarEncabezado.Enabled = false;
            btnCancelarEncabezado.Enabled = true;
        }
        void funhabilitarDetalle()
        {
            dtgEncabezado.Enabled = false;
            dtgDetalle.Enabled = true;
            dtpFiltroMesAño.Enabled = true;
            txtIdDetalle.Enabled = true;
            cbxFactura.Enabled = true;
            cbxTipoComision.Enabled = true;
            btnAgregarDetalle.Enabled = true;
            btnLimpiarDetalle.Enabled = true;
        }
        void funDeshabilitarDetalle()
        {
            dtgEncabezado.Enabled = true;
            dtgDetalle.Enabled = false;
            dtpFiltroMesAño.Enabled = false;
            txtIdDetalle.Enabled = false;
            cbxFactura.Enabled = false;
            cbxTipoComision.Enabled = false;
            btnAgregarDetalle.Enabled = false;
            btnLimpiarDetalle.Enabled = false;
        }
        void funModificar()
        {
            txtIdComision.Enabled = true;
            cbxIdEmpleado.Enabled = true;
            dtpFechaComisiones.Enabled = true;
            btnAgregarEncabezado.Enabled = false;
            btnModificarEncabezado.Enabled = true;
            btnEliminarEncabezado.Enabled = true;
            btnCancelarEncabezado.Enabled = true;
        }
        private void dtpFiltroMesAño_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtFiltroFecha.Text = dtpFiltroMesAño.Value.ToString("yyyy-MM");
                cn.metodoLlenarComboControlFecha(cbxFactura, "facturacionencabezado", "Pkid", "Fkidempleado", "estatus", txtFiltroFecha.Text);
                //txtMontoFactura.Text = "0.00";

            }
            catch 
            { 

            }
        }

        private void btnAgregarEncabezado_Click(object sender, EventArgs e)
        {
     
            if (txtIdComision.Text == "")
            {
                MessageBox.Show("Debe ingresar un ID para agregar una comisión.", "Error al ingresar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtIdComision.Focus();
            }
            else if (txtIdEmplead.Text == "")
            {
                MessageBox.Show("Debe seleccionar un empleado.", "Error al ingresar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbxIdEmpleado.Focus();
            }
            else if (txtFecha.Text == "")
            {
                MessageBox.Show("Debe seleccionar una fecha de registro para añadir.", "Error al ingresar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtpFechaComisiones.Focus();
            }
            else
            {
                try
                {
                    //loggear.guardarEnBitacora(IdUsuario, "3001", "3502", "Inserción realizada de encabezado cotizacion ID: "+txtIdComision.Text);
                    cn.llamarInsertaEncabezado(txtIdComision.Text, txtIdEmplead.Text, txtComosionesmes.Text, txtFecha.Text);
                    MessageBox.Show("Insercion realizada");
                    actualizardatagriewDetalle(); funDeshabilitaAgregar();funhabilitarDetalle();actualizardatagriew();

                }
                catch (Exception ex)
                {
                    //  loggear.guardarEnBitacora(IdUsuario, "1", "0003", "Error al realizar Inserción");
                    MessageBox.Show("Error: " + ex, "Error al ingresar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
               
            }
        }

        private void btnModificarEncabezado_Click(object sender, EventArgs e)
        {
            if (txtIdComision.Text == "")
            {
                MessageBox.Show("Debe ingresar un ID para agregar una comisión.", "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtIdComision.Focus();
            }
            else if (txtIdEmplead.Text == "")
            {
                MessageBox.Show("Debe seleccionar un empleado.", "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbxIdEmpleado.Focus();
            }
            else if (txtFecha.Text == "")
            {
                MessageBox.Show("Debe seleccionar una fecha de registro para añadir.", "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtpFechaComisiones.Focus();
            }
            else 
            {
                try
                {
                    //loggear.guardarEnBitacora(IdUsuario, "3001", "3502", "Modificación realizada de encabezado cotizacion ID: "+txtIdComision.Text");
                    cn.llamarModificarEncabezado(txtIdComision.Text, txtIdEmplead.Text, txtComosionesmes.Text, txtFecha.Text);
                    MessageBox.Show("Modificacion realizada");
                    actualizardatagriewDetalle();actualizardatagriew(); funhabilitarDetalle();
                }
                catch (Exception ex)
                {
                    //loggear.guardarEnBitacora(IdUsuario, "3001", "3502", "Error al modificar");
                    MessageBox.Show("Error: "+ex, "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                  
                }
            }
        }

        private void btnEliminarEncabezado_Click(object sender, EventArgs e)
        {
            if (txtIdComision.Text != "")
            {
                try
                {
                    //loggear.guardarEnBitacora(IdUsuario, "3001", "3502", "Eliminación realizada de encabezado cotizacion ID: "+txtIdComision.Text");
                    cn.llamarEliminarDetalleE(txtIdComision.Text);
                    cn.llamarEliminarEnacabezado(txtIdComision.Text);
                    MessageBox.Show("Eliminacion realizada");
                    funLimpiarEnacabezado();
                    actualizardatagriew();
                }
                catch (Exception ex)
                {
                    //loggear.guardarEnBitacora(IdUsuario, "3001", "3502", "Error al eliminar");
                    MessageBox.Show("Error: No has ingresado Id del registro a eliminar", "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Error: No has ingresado Id del registro a eliminar", "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelarEncabezado_Click(object sender, EventArgs e)
        {
            funLimpiarEnacabezado(); funHabilitarAgregar(); funLimpiarDetalle();funDeshabilitarDetalle();
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            if (txtIdDetalle.Text == "")
            {
                MessageBox.Show("Debe ingresar un ID para agregar una comisión detalle.", "Error al ingresar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtIdDetalle.Focus();
            }
            else if (cbxFactura.SelectedIndex==0)
            {
                MessageBox.Show("Debe seleccionar una factura.", "Error al ingresar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbxFactura.Focus();
            }
            else if (txtSubTotal.Text == "0.00")
            {
                MessageBox.Show("Debe seleccionar un tipo de comisión.", "Error al ingresar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbxTipoComision.Focus();
            }
            else
            {

                try
                {
                    //loggear.guardarEnBitacora(IdUsuario, "1", "0003", "Inserción realizada");
                    cn.llamarInsertaDetalle(txtIdDetalle.Text, txtIDC.Text, cbxFactura.Text, txtIdTipoComision.Text, txtMontoFactura.Text, txtSubTotal.Text);
                    cn.llamarModificarComisionmes(txtIdComision.Text, txtTotal.Text); txtComosionesmes.Text = txtTotal.Text;
                    MessageBox.Show("Insercion realizada");
                    actualizardatagriewDetalle(); funLimpiarDetalle(); actualizardatagriew();

                }
                catch (Exception ex)
                {
                    //  loggear.guardarEnBitacora(IdUsuario, "1", "0003", "Error al realizar Inserción");
                    MessageBox.Show("Error: " + ex, "Error al ingresar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnModificarDetalle_Click(object sender, EventArgs e)
        {
            if (txtIdDetalle.Text == "")
            {
                MessageBox.Show("Debe ingresar un ID para agregar una comisión detalle.", "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtIdDetalle.Focus();
            }
            else if (cbxFactura.SelectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar una factura.", "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbxFactura.Focus();
            }
            else if (txtSubTotal.Text == "0.00")
            {
                MessageBox.Show("Debe seleccionar un tipo de comisión.", "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbxTipoComision.Focus();
            }
            else
            {
                try
                {
                    //loggear.guardarEnBitacora(IdUsuario, "1", "0003", "Modificación Exitosa");
                    cn.llamarModificarDetalle(txtIdDetalle.Text, txtIDC.Text, cbxFactura.Text, txtIdTipoComision.Text, txtMontoFactura.Text, txtSubTotal.Text);
                    MessageBox.Show("Modificacion realizada");
                    actualizardatagriewDetalle(); funLimpiarDetalle(); actualizardatagriew();
                }
                catch (Exception ex)
                {
                    //loggear.guardarEnBitacora(IdUsuario, "1", "0003", "Error al modificar");
                    MessageBox.Show("Error: " + ex, "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {

            if (txtIdComision.Text != "")
            {
                try
                {
                    //loggear.guardarEnBitacora(IdUsuario, "1", "0003", "Eliminar");
                    cn.llamarEliminarDetalle(txtIdDetalle.Text);
                    MessageBox.Show("Eliminacion realizada");
                    actualizardatagriewDetalle(); funLimpiarDetalle();actualizardatagriew();

                }
                catch (Exception ex)
                {
                    //loggear.guardarEnBitacora(IdUsuario, "1", "0003", "Error al eliminar");
                    MessageBox.Show("Error: No has ingresado Id del registro a eliminar", "Error aleliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Error: No has ingresado Id del registro a eliminar", "Error aleliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        void funLimpiarDetalle()
        {
            SetMyCustomFormat();
            txtIdDetalle.Text = "";
            cbxFactura.SelectedIndex = 0;
            cbxTipoComision.SelectedIndex = 0;
            txtMontoFactura.Text = "0.00";
            txtSubTotal.Text = "0.00";
            txtTotal.Text = "0.00";

        }
        private void btnLimpiarDetalle_Click(object sender, EventArgs e)
        {
            funLimpiarDetalle();
        }

        private void dtgEncabezado_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtIdComision.Text = dtgEncabezado.CurrentRow.Cells[0].Value.ToString();
                txtsacarid.Text = dtgEncabezado.CurrentRow.Cells[1].Value.ToString();
                txtComosionesmes.Text = dtgEncabezado.CurrentRow.Cells[2].Value.ToString();
                txtFecha.Text = dtgEncabezado.CurrentRow.Cells[3].Value.ToString();
                cbxIdEmpleado.SelectedIndex = int.Parse(txtsacarid.Text) - 1;
                dtpFechaComisiones.Text = txtFecha.Text;
                actualizardatagriewDetalle();
                funModificar();
            }
            catch
            {

            }
        }

        private void dtgDetalle_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtIdDetalle.Text = dtgEncabezado.CurrentRow.Cells[0].Value.ToString();
                txtsacarid.Text = dtgEncabezado.CurrentRow.Cells[1].Value.ToString();
                cbxFactura.Items.Add(dtgEncabezado.CurrentRow.Cells[2].Value.ToString());
                cbxFactura.SelectedIndex=int.Parse(dtgEncabezado.CurrentRow.Cells[3].Value.ToString())-1;
                txtMontoFactura.Text = dtgEncabezado.CurrentRow.Cells[4].Value.ToString();
                txtSubTotal.Text= dtgEncabezado.CurrentRow.Cells[5].Value.ToString();
               
                actualizardatagriewDetalle();
                funModificar();
            }
            catch
            {

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
            actualizardatagriewDetalle();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            //loggear.guardarEnBitacora(IdUsuario, "3001", "3502", "Consulta ayuda de la aplicación.");
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            //loggear.guardarEnBitacora(IdUsuario, "3001", "3502", "Consulta reportes de la aplicación. ");
        }
    }
}
