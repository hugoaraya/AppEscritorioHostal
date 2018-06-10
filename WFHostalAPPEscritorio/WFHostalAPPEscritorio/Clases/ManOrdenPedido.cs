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
                OracleCommand comando = new OracleCommand("SELECT OP.NRO_ORDEN, OP.FECHA, E.NOMBRE as NOMBRE_EMPLEADO,E.RUT as RUT_EMPLEADO,P.NOMBRE as NOMBRE_PROVEEDOR, P.RUT as RUT_PROVEEDOR,EO.DESCRIPCION AS ESTADO_ODP FROM ORDEN_PEDIDO OP JOIN EMPLEADO E ON (OP.EMPLEADO_ID = E.IDEMPLEADO) join PROVEEDOR P ON(OP.PROVEEDOR_ID=P.IDPROVEEDOR) JOIN ESTADO_ORDEN_PEDIDO EO ON (EO.IDESTADO_ORDEN_PEDIDO=OP.ESTADO_ORDEN_PEDIDO_ID) WHERE OP.NRO_ORDEN= :numodp order by fecha", conexion.con);
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
