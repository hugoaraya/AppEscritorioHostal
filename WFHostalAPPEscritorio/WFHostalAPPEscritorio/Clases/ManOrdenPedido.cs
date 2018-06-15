using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFHostalAPPEscritorio.Clases
{
    public class ManOrdenPedido
    {

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
                                                            "JOIN MARCA M ON(P.MARCA_ID = M.IDMARCA) " +
                                                            "JOIN CODIGO_BARRA C ON(P.CODIGO_BARRA_ID = C.IDCODIGO_BARRA)", conexion.con);
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
                OracleCommand comando = new OracleCommand("select IDORDEN_PEDIDO,NRO_ORDEN,EMPLEADO_ID,FECHA,PROVEEDOR_ID,ESTADO_ORDEN_PEDIDO_ID from ORDEN_PEDIDO", conexion.con);
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
                OracleCommand comando = new OracleCommand("SELECT EO.DESCRIPCION AS ESTADO, OP.NRO_ORDEN as NUMERO_ODP, OP.FECHA, P.RUT as RUT_PROVEEDOR, E.RUT as RUT_EMPLEADO FROM ORDEN_PEDIDO OP JOIN EMPLEADO E ON (OP.EMPLEADO_ID = E.IDEMPLEADO) join PROVEEDOR P ON(OP.PROVEEDOR_ID=P.IDPROVEEDOR) JOIN ESTADO_ORDEN_PEDIDO EO ON (EO.IDESTADO_ORDEN_PEDIDO=OP.ESTADO_ORDEN_PEDIDO_ID) WHERE OP.NRO_ORDEN= :numodp", conexion.con);
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
