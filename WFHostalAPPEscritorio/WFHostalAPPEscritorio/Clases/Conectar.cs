﻿using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFHostalAPPEscritorio.Clases
{
    public class Conectar
    {
        public  OracleConnection con = new OracleConnection("DATA SOURCE=XE; PASSWORD= 1234; USER ID= Hostal;");

        public void Abrir()
        {
            try
            {
                con.Open();
                Console.WriteLine("Conexión ORACLE Existosa! ");
            }
            catch (Exception e)
            {
                Console.WriteLine("No se puede conectar ! " + e);
            }
        }

        public void Cerrar()
        {
            try
            {
                con.Close();
                Console.WriteLine("Conexión ORACLE Cerrada! ");
            }
            catch (Exception e)
            {
                Console.WriteLine("No se puede cerrar ! " + e);
            }
        }

    }
}
