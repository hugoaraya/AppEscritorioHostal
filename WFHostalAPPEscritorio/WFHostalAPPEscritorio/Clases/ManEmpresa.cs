using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFHostalAPPEscritorio.Clases
{
    public class ManEmpresa
    {

        public DataTable todasEmpresas() //ENVIAR TODOS LOS DATOS DE LOS USUARIOS EMPRESA
        {
            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();
            try
            {
                OracleCommand comando = new OracleCommand("select IDEMPRESA,RUT||'-'||DV as RUT,NOMBRE,DIRECCION,TELEFONO,USUARIO_ID,CORREO from empresa", conexion.con);
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

        public Boolean validarRutEmpresa(String rut)
        {
            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();
            try
            {
                OracleCommand comando = new OracleCommand("select IDEMPRESA,RUT,DV,NOMBRE,DIRECCION,TELEFONO,USUARIO_ID,CORREO from empresa where RUT = :rut", conexion.con);
                comando.Parameters.Add(":rut", rut);
                OracleDataReader lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    lector.Close();
                    conexion.Cerrar();
                    return false;
                }
                else
                {
                    Console.WriteLine("No rows found.");
                    lector.Close();
                    conexion.Cerrar();
                    return true;
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine("ERROR SQL: " + ex);                
                conexion.Cerrar();
                return false;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERROR APP: " + ex);
                conexion.Cerrar();
                return false;
            }
        }

        public DataTable EmpresaXRut(String rut) //ENVIA DATO DE 1 USUARIO X RUT
        {
            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();
            try {
                OracleCommand comando = new OracleCommand("select IDEMPRESA,RUT,DV,NOMBRE,DIRECCION,TELEFONO,USUARIO_ID,CORREO from empresa where RUT = :rut", conexion.con);
                comando.Parameters.Add(":rut", rut);
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

        public int ObtenerIDUsuario(String rut)
        {
            int id_empresa = 0;
            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();
            try
            {
                OracleCommand comando = new OracleCommand("select IDUSUARIO from USUARIO where NOMBRE_USUARIO = :rut", conexion.con);
                comando.Parameters.Add(":rut", rut);
                OracleDataReader lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    dt.Load(lector);
                    DataRow row = dt.Rows[0];
                    id_empresa = int.Parse(row[0].ToString());
                    lector.Close();
                    conexion.Cerrar();
                    return id_empresa;
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

        //public Boolean InsertarEmpresa(int pIDEMPRESA, int pRUT,char pDV,string pNOMBRE, string pDIRECCION, int pTELEFONO, int pUSUARIO_ID, string pCORREO) {

        //    Conectar conexion = new Conectar();
        //    conexion.Abrir();
        //    try
        //    {
        //        // Create the SelectCommand.
        //        OracleDataAdapter datAdap = new OracleDataAdapter();
        //        OracleCommand comando = new OracleCommand("select * from empresa", conexion.con);
        //        datAdap.SelectCommand = comando;

        //        ////Create the InsertCommand.

        //        comando = new OracleCommand("INSERT INTO empresa (IDEMPRESA, RUT, DV, NOMBRE, DIRECCION, TELEFONO, USUARIO_ID, CORREO) VALUES (:pIDEMPRESA, :pRUT, :pDV, :pNOMBRE, :pDIRECCION, :pTELEFONO,:pUSUARIO_ID,:pCORREO)", conexion.con);
        //        comando.Parameters.Add("pIDEMPRESA", OracleDbType.Int32, 38, "IDEMPRESA");
        //        comando.Parameters.Add("pRUT", OracleDbType.Int32, 38, "RUT");
        //        comando.Parameters.Add("pDV", OracleDbType.NChar, 1, "DV");
        //        comando.Parameters.Add("pNOMBRE", OracleDbType.NVarchar2, 50, "NOMBRE");
        //        comando.Parameters.Add("pDIRECCION", OracleDbType.NVarchar2, 50, "DIRECCION");
        //        comando.Parameters.Add("pTELEFONO", OracleDbType.Int32, 38, "TELEFONO");
        //        comando.Parameters.Add("pUSUARIO_ID", OracleDbType.Int32, 38, "USUARIO_ID");
        //        comando.Parameters.Add("pCORREO", OracleDbType.NVarchar2, 50, "CORREO");
        //        datAdap.InsertCommand = comando;
        //        Console.Write("asdasdasd" + comando.Parameters.ToString());
        //        if (datAdap.InsertCommand.ExecuteNonQuery() > 0)
        //        {
        //            conexion.Cerrar();
        //            return true;
        //        }
        //        else {
        //            return false;
        //        }


        //    }
        //    catch (OracleException ex)
        //    {
        //        Console.WriteLine("ERROR SQL: " + ex);
        //        conexion.Cerrar();
        //        return false;
        //    }

        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("ERROR APP: " + ex);
        //        conexion.Cerrar();
        //        return false;
        //    }
        //}


        //public void CreateOracleCommand(OracleConnection connection,
        //                      string queryString, OracleParameter[] myParamArray)
        //{

        //    OracleCommand command = new OracleCommand(queryString, connection);
        //    command.CommandText =
        //        "SELECT * FROM Emp WHERE Job = :pJob AND Sal = :pSal";

        //    for (int j = 0; j < myParamArray.Length; j++)
        //        command.Parameters.Add(myParamArray[j]);

        //    string message = "";

        //    for (int i = 0; i < command.Parameters.Count; i++)
        //        message += command.Parameters[i].ToString() + "\n";

        //    Console.WriteLine(message);

        //    using (OracleDataReader row = command.ExecuteReader())
        //    {
        //        while (row.Read())
        //        {
        //            Console.WriteLine(row.GetValue(0));
        //        }
        //    }
        //}
    }
}