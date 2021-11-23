using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModeloMVentasCC;


namespace CapaControladorMVentasCC
{
    public class Controlador
	{
        Sentencias sn = new Sentencias();

        //Mantenimiento Clientes Kevin Flores 9959-18-17632
        public void llamarInsertCliente(string id, string nit, string nombre, string apellido, string direccion, string telefono, string estado)
        {

            sn.funInsertarCliente(id, nit, nombre, apellido, direccion, telefono, estado);
        }

        public void llamarModifCliente(string id, string nit, string nombre, string apellido, string direccion, string telefono, string estado)
        {

            sn.funModifCliente(id, nit, nombre, apellido, direccion, telefono, estado);
        }

        public void llamarElimCliente(string id)
        {

            sn.funElimCliente(id);
        }
        public DataTable llenarCliente(string tabla1)
        {
            OdbcDataAdapter dt = sn.llenarCliente(tabla1);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Mantenimiento Fraccionamiento  Kevin Flores 9959-18-17632

        //Mantenimiento inventarios Heydi Quemé 9959-18-5335
        public void llamarInsertProducto(string id, string nombre, string costo, string precio, string existencias, string estado)
        {

            sn.funInsertarProducto(id, nombre, costo, precio, existencias, estado);
        }

        public void llamarModifProducto(string id, string nombre, string costo, string precio, string existencias, string estado)
        {

            sn.funModifProducto(id, nombre, costo, precio, existencias, estado);
        }

        public void llamarElimProducto(string id)
        {

            sn.funElimProducto(id);
        }
        public DataTable llenarProducto(string tabla1)
        {
            OdbcDataAdapter dt = sn.llenarProducto(tabla1);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Comisiones
        public DataTable llenarDataGrid(string tabla1)
        {
            DataTable table = new DataTable();
            table = sn.llenarTabla(tabla1);
            return table;
        }
        public DataTable llenarDataGridDetalle(string tabla1,string id)
        {
            DataTable table = new DataTable();
            table = sn.llenarTablaDetalle(tabla1,id);
            return table;
        }
        public void funLlenarComboControl(ComboBox cbx, string tabla, string value, string display, string estatus)
        {
            sn.funLlenarCombo(cbx, tabla, value, display, estatus);
        }
        public string consultaID(string nombre, string tabla)
        {
            string id = sn.consultaID(nombre, tabla);
            return id;
        }
        public string consultaFacturaID(string nombre, string tabla)
        {
            string id = sn.consultaFacturaID(nombre, tabla);
            return id;
        }
        public string consultaTotal(string nombre, string tabla)
        {
            string total = sn.consultaTotal(nombre, tabla);
            return total;
        }
        public string consultaPorcentaje(string nombre, string tabla)
        {
            string porcentaje = sn.consultaPorcentaje(nombre, tabla);
            return porcentaje;
        }
        public string consultaIDComision(string nombre, string tabla)
        {
            string id = sn.consultaIDComision(nombre, tabla);
            return id;
        }
        public void metodoLlenarComboControlFecha(ComboBox cbx, string tabla, string value, string display, string estatus,string fecha)
        {
            sn.funLlenarComboFecha(cbx, tabla, value, display, estatus,fecha);
        }
        public string consultaIdCambio(string nombre, string tabla)
        {
            string idcambio = sn.consultaIdCambio(nombre, tabla);
            return idcambio;
        }
        public string consultaCambio(string nombre, string tabla)
        {
            string cambio = sn.consultaCambio(nombre, tabla);
            return cambio;
        }

        public void llamarInsertaEncabezado(string id, string idempleado, string cotizacionmes, string fecha)
        {
            sn.metodoInsertarEncabezado(id, idempleado, cotizacionmes, fecha);
        }

        public void llamarModificarEncabezado(string id, string idempleado, string cotizacionmes, string fecha)
        {
            sn.metodoModifarEncabezado(id, idempleado, cotizacionmes, fecha);
        }

        public void llamarEliminarEnacabezado(string id)
        {
            sn.metodoEliminarEncabezado(id);
        }

        public void llamarInsertaDetalle(string id, string idencabezado, string idfactura, string idComision, string montofactura, string Cantidadcomision)
        {
            sn.metodoInsertarDetalle(id, idencabezado, idfactura, idComision, montofactura, Cantidadcomision);
        }

        public void llamarModificarDetalle(string id, string idencabezado, string idfactura, string idComision, string montofactura, string Cantidadcomision)
        {
            sn.metodoModifarDetalle(id, idencabezado, idfactura, idComision, montofactura, Cantidadcomision);
        }

        public void llamarEliminarDetalle(string id)
        {
            sn.metodoEliminarDetalle(id);
        }
        public void llamarEliminarDetalleE(string id)
        {
            sn.metodoEliminarDetalleE(id);
        }
        public string bloqueo(string id, string app)
        {
            string cadena = sn.llenarpermisos(id, app);

            return cadena;

        }
        public void llamarModificarComisionmes(string id, string comisionmes)
        {

            sn.metodoModifarComisionmes(id, comisionmes);
        }

    }
}
