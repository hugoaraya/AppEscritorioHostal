using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFHostalAPPEscritorio.Clases
{
    public class ManOrdenPedido
    {
        
        public int GetIdEmpleado(int IdUsu)
        {
            int id_Empleado = 0;
            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();
            try
            {
                OracleCommand comando = new OracleCommand("SELECT EM.IDEMPLEADO from USUARIO US JOIN EMPLEADO EM ON (US.IDUSUARIO = EM.USUARIO_ID) WHERE US.IDUSUARIO = :IdUsua ", conexion.con);
                comando.Parameters.Add(":IdUsua", IdUsu);
                OracleDataReader lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    dt.Load(lector);
                    DataRow row = dt.Rows[0];
                    id_Empleado = int.Parse(row[0].ToString());
                    lector.Close();
                    conexion.Cerrar();
                    return id_Empleado;
                }
                else
                {
                    Console.WriteLine("No rows found.");
                    lector.Close();
                    conexion.Cerrar();
                    return 0;
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine("ERROR SQL: " + ex);
                conexion.Cerrar();
                return 0;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERROR APP: " + ex);
                conexion.Cerrar();
                return 0;
            }

        }


        public DataTable OPXEstado(int estado)
        {
            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();
            try
            {
                OracleCommand comando = new OracleCommand("SELECT OP.ESTADO_ORDEN_PEDIDO_ID AS ESTADO, EO.DESCRIPCION, OP.IDORDEN_PEDIDO AS ID_ODP, OP.NRO_ORDEN, OP.EMPLEADO_ID, E.NOMBRE AS EMPLEADO, OP.FECHA, OP.PROVEEDOR_ID, P.RUT , P.DV, P.NOMBRE AS PROVEEDOR, OP.COMENTARIO " +
                                                            "FROM ORDEN_PEDIDO OP JOIN EMPLEADO E ON(OP.EMPLEADO_ID = E.IDEMPLEADO) JOIN PROVEEDOR P ON(OP.PROVEEDOR_ID = P.IDPROVEEDOR) " +
                                                            "JOIN ESTADO_ORDEN_PEDIDO EO ON(EO.IDESTADO_ORDEN_PEDIDO = OP.ESTADO_ORDEN_PEDIDO_ID) WHERE OP.ESTADO_ORDEN_PEDIDO_ID = :numEstado ", conexion.con);
                comando.Parameters.Add(":numEstado", estado);
                OracleDataReader lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    dt.Load(lector);
                    lector.Close();
                    conexion.Cerrar();
                    return dt;
                }
                else
                {
                    Console.WriteLine("No rows found.");
                    conexion.Cerrar();
                    return null;
                }

            }
            catch (OracleException ex)
            {
                Console.WriteLine("ERROR SQL: " + ex);
                conexion.Cerrar();
                return null;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERROR APP: " + ex);
                conexion.Cerrar();
                return null;
            }

        }
        public int GetIdCodBarra(Int64 CodigoBarra)
        {
            int id_CodigoBarra = 0;
            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();
            try
            {
                OracleCommand comando = new OracleCommand("SELECT IDCODIGO_BARRA from CODIGO_BARRA WHERE CODIGO = :codBarra ", conexion.con);
                comando.Parameters.Add(":codBarra", CodigoBarra);
                OracleDataReader lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    dt.Load(lector);
                    DataRow row = dt.Rows[0];
                    id_CodigoBarra = int.Parse(row[0].ToString());
                    lector.Close();
                    conexion.Cerrar();
                    return id_CodigoBarra;
                }
                else
                {
                    Console.WriteLine("No rows found.");
                    lector.Close();
                    conexion.Cerrar();
                    return 0;
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine("ERROR SQL: " + ex);
                conexion.Cerrar();
                return 0;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERROR APP: " + ex);
                conexion.Cerrar();
                return 0;
            }

        }


        public string SetCodigoBarra( String IdRecep)
        {
            //int 
            string codigoBarra;
            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();
            try
            {
                OracleCommand comando = new OracleCommand("SELECT  1||replace(to_char(SUBSTR(OP.PROVEEDOR_ID,1,3),'000')|| TO_CHAR(SUBSTR(PR.FAMILIA_PRODUCTO_ID,1,3),'000')|| TO_CHAR(PR.FECHA_VENCIMIENTO, 'DDMMYYYY')|| TO_CHAR(SUBSTR(PR.TIPO_PRODUCTO_ID,1,3),'000'),' ','') " +
                                                            "FROM RECEPCION_PRODUCTO RP JOIN ORDEN_PEDIDO OP ON(RP.ORDEN_PEDIDO_ID = OP.IDORDEN_PEDIDO) JOIN PRODUCTO PR ON(RP.PRODUCTO_ID = PR.IDPRODUCTO) WHERE RP.IDRECEPCION_PRODUCTO = :IdRP ", conexion.con);
                comando.Parameters.Add(":IdRP", IdRecep);
                OracleDataReader lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    dt.Load(lector);
                    DataRow row = dt.Rows[0];
                    Console.WriteLine("row[0].ToString() :::::: " + row[0].ToString());
                    codigoBarra = row[0].ToString();
                    lector.Close();
                    conexion.Cerrar();
                    return codigoBarra;
                }
                else
                {
                    Console.WriteLine("No rows found.");
                    lector.Close();
                    conexion.Cerrar();
                    return null;
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine("ERROR SQL: " + ex);
                conexion.Cerrar();
                return null;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERROR APP: " + ex);
                conexion.Cerrar();
                return null;
            }

        }

        public DataTable  GetRecepcionProdXidPedido(String idPedido)
        {
            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();
            try
            {
                OracleCommand comando = new OracleCommand("SELECT ER.DESCRIPCION AS ESTADO,CB.CODIGO AS CODIGO_BARRA,P.IDPRODUCTO AS ID_PROD, TP.DESCRIPCION,RP.CANTIDAD_P,RP.NRO_RECEPCION,RP.IDRECEPCION_PRODUCTO AS ID_RECEP, RP.ESTADO_RECEPCION_ID " +
                                                            "FROM RECEPCION_PRODUCTO RP JOIN PRODUCTO P ON(RP.PRODUCTO_ID = P.IDPRODUCTO) JOIN TIPO_PRODUCTO TP ON(P.TIPO_PRODUCTO_ID = TP.IDTIPO_PRODUCTO) " +
                                                            "JOIN CODIGO_BARRA CB ON(P.CODIGO_BARRA_ID = CB.IDCODIGO_BARRA) " +
                                                            "JOIN ESTADO_RECEPCION ER ON(RP.ESTADO_RECEPCION_ID = ER.IDESTADO_RECEPCION) JOIN ORDEN_PEDIDO OP ON(RP.ORDEN_PEDIDO_ID = OP.IDORDEN_PEDIDO) " +
                                                            "WHERE OP.IDORDEN_PEDIDO = :idOdp ORDER BY ER.IDESTADO_RECEPCION ASC", conexion.con);
                comando.Parameters.Add(":idOdp", idPedido);
                OracleDataReader lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    dt.Load(lector);
                    lector.Close();
                    conexion.Cerrar();
                    return dt;
                }
                else
                {
                    Console.WriteLine("No rows found.");
                    conexion.Cerrar();
                    return null;
                }

            }
            catch (OracleException ex)
            {
                Console.WriteLine("ERROR SQL: " + ex);
                conexion.Cerrar();
                return null;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERROR APP: " + ex);
                conexion.Cerrar();
                return null;
            }


        }



        public int GetIdOrdenPedido(String numero)
        {
            int id_OrdenPedido = 0;
            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();
            try
            {
                OracleCommand comando = new OracleCommand("SELECT IDORDEN_PEDIDO from ORDEN_PEDIDO WHERE NRO_ORDEN =:numPed ", conexion.con);
                comando.Parameters.Add(":numPed", numero);
                OracleDataReader lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    dt.Load(lector);
                    DataRow row = dt.Rows[0];
                    id_OrdenPedido = int.Parse(row[0].ToString());
                    lector.Close();
                    conexion.Cerrar();
                    return id_OrdenPedido;
                }
                else
                {
                    Console.WriteLine("No rows found.");
                    lector.Close();
                    conexion.Cerrar();
                    return 0;
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine("ERROR SQL: " + ex);
                conexion.Cerrar();
                return 0;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERROR APP: " + ex);
                conexion.Cerrar();
                return 0;
            }

        }



        public int get_NRO_RECEPCION_Nuevo()
        {
            int nro_recep = 0;
            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();
            try
            {
                OracleCommand comando = new OracleCommand("SELECT MAX(NRO_RECEPCION) + 1  from RECEPCION_PRODUCTO ", conexion.con);
                OracleDataReader lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    dt.Load(lector);
                    DataRow row = dt.Rows[0];
                    nro_recep = int.Parse(row[0].ToString());
                    lector.Close();
                    conexion.Cerrar();
                    return nro_recep;
                }
                else
                {
                    Console.WriteLine("No rows found.");
                    lector.Close();
                    conexion.Cerrar();
                    return 0;
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine("ERROR SQL: " + ex);
                conexion.Cerrar();
                return 0;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERROR APP: " + ex);
                conexion.Cerrar();
                return 0;
            }
        }
        public int get_NRO_ORDEN_Nuevo()
        {
            int nro_orden = 0;
            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();
            try
            {
                OracleCommand comando = new OracleCommand("SELECT MAX(NRO_ORDEN) + 1  from ORDEN_PEDIDO ", conexion.con);
                OracleDataReader lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    dt.Load(lector);
                    DataRow row = dt.Rows[0];
                    nro_orden = int.Parse(row[0].ToString());
                    lector.Close();
                    conexion.Cerrar();
                    return nro_orden;
                }
                else
                {
                    Console.WriteLine("No rows found.");
                    lector.Close();
                    conexion.Cerrar();
                    return 0;
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine("ERROR SQL: " + ex);
                conexion.Cerrar();
                return 0;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERROR APP: " + ex);
                conexion.Cerrar();
                return 0;
            }
        }
        
        public DataTable getEstructuraProducto()
        {

            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();
            try
            {
                OracleCommand comando = new OracleCommand("select T.DESCRIPCION AS TIPO, F.DESCRIPCION AS FAMILIA, M.DESCRIPCION AS MARCA, P.STOCK, P.STOCK_CRITICO " +
                                                            "from PRODUCTO P JOIN TIPO_PRODUCTO T ON(P.TIPO_PRODUCTO_ID = T.IDTIPO_PRODUCTO) " +
                                                            "JOIN FAMILIA_PRODUCTO F ON(P.FAMILIA_PRODUCTO_ID = F.IDFAMILIA_PRODUCTO) " +
                                                            "JOIN MARCA M ON(P.MARCA_ID = M.IDMARCA) " +
                                                            "JOIN CODIGO_BARRA C ON(P.CODIGO_BARRA_ID = C.IDCODIGO_BARRA) "+
                                                            "WHERE T.DESCRIPCION = DESCRIPCION ", conexion.con);
                OracleDataReader lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    Console.WriteLine("dt");
                    dt.Load(lector);
                    conexion.Cerrar();
                    return dt;
                }
                else
                {
                    Console.WriteLine("No rows found.");
                    conexion.Cerrar();
                    return null;
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine("ERROR SQL: " + ex);
                conexion.Cerrar();
                return null;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERROR APP: " + ex);
                conexion.Cerrar();
                return null;
            }

        }


        public DataTable ListaProductos()
        {
            
            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();
            try
            {
                OracleCommand comando = new OracleCommand("select T.DESCRIPCION AS TIPO, F.DESCRIPCION AS FAMILIA, M.DESCRIPCION AS MARCA, P.STOCK, P.STOCK_CRITICO, P.IDPRODUCTO " +
                                                            "from PRODUCTO P JOIN TIPO_PRODUCTO T ON(P.TIPO_PRODUCTO_ID = T.IDTIPO_PRODUCTO) " +
                                                            "JOIN FAMILIA_PRODUCTO F ON(P.FAMILIA_PRODUCTO_ID = F.IDFAMILIA_PRODUCTO) " +
                                                            "JOIN MARCA M ON(P.MARCA_ID = M.IDMARCA) " , conexion.con);
                OracleDataReader lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    Console.WriteLine("dt");
                    dt.Load(lector);
                    conexion.Cerrar();
                    return dt;
                }
                else
                {
                    Console.WriteLine("No rows found.");
                    conexion.Cerrar();
                    return null;
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine("ERROR SQL: " + ex);
                conexion.Cerrar();
                return null;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERROR APP: " + ex);
                conexion.Cerrar();
                return null;
            }

        }



        public DataTable ListaProveedor()
        {
            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();
            try
            {
                OracleCommand comando = new OracleCommand("select P.NOMBRE,F.DESCRIPCION AS RUBRO,P.RUT,P.DV from PROVEEDOR P JOIN RUBRO F ON (P.RUBRO_ID = F.IDRUBRO)", conexion.con);
                OracleDataReader lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    dt.Load(lector);
                    conexion.Cerrar();
                    return dt;
                }
                else
                {
                    Console.WriteLine("No rows found.");
                    conexion.Cerrar();
                    return null;
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine("ERROR SQL: " + ex);
                conexion.Cerrar();
                return null;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERROR APP: " + ex);
                conexion.Cerrar();
                return null;
            }
        }



       //revisar


        public DataTable todasOPedido() 
        {
            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();
            try
            {
                OracleCommand comando = new OracleCommand("SELECT OP.ESTADO_ORDEN_PEDIDO_ID AS ESTADO, EO.DESCRIPCION, OP.IDORDEN_PEDIDO AS ID_ODP, OP.NRO_ORDEN, OP.EMPLEADO_ID, E.NOMBRE AS EMPLEADO, OP.FECHA, OP.PROVEEDOR_ID, P.RUT , P.DV, P.NOMBRE AS PROVEEDOR, OP.COMENTARIO " +
                                                          "FROM ORDEN_PEDIDO OP JOIN EMPLEADO E ON(OP.EMPLEADO_ID = E.IDEMPLEADO) JOIN PROVEEDOR P ON(OP.PROVEEDOR_ID = P.IDPROVEEDOR) " +
                                                          "JOIN ESTADO_ORDEN_PEDIDO EO ON(EO.IDESTADO_ORDEN_PEDIDO = OP.ESTADO_ORDEN_PEDIDO_ID) ", conexion.con);
                OracleDataReader lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    dt.Load(lector);
                    conexion.Cerrar();
                    return dt;
                }
                else
                {
                    Console.WriteLine("No rows found.");
                    conexion.Cerrar();
                    return null;
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine("ERROR SQL: " + ex);
                conexion.Cerrar();
                return null;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERROR APP: " + ex);
                conexion.Cerrar();
                return null;
            }
        }

        public DataTable OPXNumero(String numero) 
        {
            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();
            try
            {
                OracleCommand comando = new OracleCommand("SELECT OP.ESTADO_ORDEN_PEDIDO_ID AS ESTADO, EO.DESCRIPCION, OP.IDORDEN_PEDIDO AS ID_ODP, OP.NRO_ORDEN, OP.EMPLEADO_ID, E.NOMBRE AS EMPLEADO, OP.FECHA, OP.PROVEEDOR_ID, P.RUT , P.DV, P.NOMBRE AS PROVEEDOR, OP.COMENTARIO "+
                                                            "FROM ORDEN_PEDIDO OP JOIN EMPLEADO E ON(OP.EMPLEADO_ID = E.IDEMPLEADO) JOIN PROVEEDOR P ON(OP.PROVEEDOR_ID = P.IDPROVEEDOR) "+
                                                            "JOIN ESTADO_ORDEN_PEDIDO EO ON(EO.IDESTADO_ORDEN_PEDIDO = OP.ESTADO_ORDEN_PEDIDO_ID) WHERE OP.NRO_ORDEN = :numodp ", conexion.con);
                comando.Parameters.Add(":numodp", numero);
                OracleDataReader lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    dt.Load(lector);
                    lector.Close();
                    conexion.Cerrar();
                    return dt;
                }
                else
                {
                    Console.WriteLine("No rows found.");
                    conexion.Cerrar();
                    return null;
                }

            }
            catch (OracleException ex)
            {
                Console.WriteLine("ERROR SQL: " + ex);
                conexion.Cerrar();
                return null;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERROR APP: " + ex);
                conexion.Cerrar();
                return null;
            }

        }


    }
}
