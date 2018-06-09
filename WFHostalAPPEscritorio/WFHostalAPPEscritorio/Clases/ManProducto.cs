using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFHostalAPPEscritorio.Clases
{
    public class ManProducto
    {
        public DataTable TodosProductos()
        {

            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();
            try
            {
                OracleCommand comando = new OracleCommand("select C.CODIGO, T.DESCRIPCION AS TIPO, F.DESCRIPCION AS FAMILIA, M.DESCRIPCION AS MARCA, P.STOCK, P.STOCK_CRITICO, P.FECHA_VENCIMIENTO, P.PRECIO " +
                                                            "from PRODUCTO P JOIN TIPO_PRODUCTO T ON(P.TIPO_PRODUCTO_ID = T.IDTIPO_PRODUCTO) " +
                                                            "JOIN FAMILIA_PRODUCTO F ON(P.FAMILIA_PRODUCTO_ID = F.IDFAMILIA_PRODUCTO) "+
                                                            "JOIN MARCA M ON(P.MARCA_ID = M.IDMARCA) "+
                                                            "JOIN CODIGO_BARRA C ON(P.CODIGO_BARRA_ID = C.IDCODIGO_BARRA) ", conexion.con);
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



    }
}
