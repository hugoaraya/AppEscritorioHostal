using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data.Entity.Migrations;
using System.Text.RegularExpressions;

namespace WFHostalAPPEscritorio.Clases
{
    public class MetodosAPP
    {
        public string GenerarDV(string r)
        {
            int suma = 0;
            for (int x = r.Length - 1; x >= 0; x--)
                suma += int.Parse(char.IsDigit(r[x]) ? r[x].ToString() : "0") * (((r.Length - (x + 1)) % 6) + 2);
            int numericDigito = (11 - suma % 11);
            string digito = numericDigito == 11 ? "0" : numericDigito == 10 ? "K" : numericDigito.ToString();
            return digito;
        }

        public void InsertEmpresa(EMPRESA em)
        { 
            using (EntitiesHostal con = new EntitiesHostal())
            {   
                con.EMPRESA.Add(em);
                con.SaveChanges();
            }

        }

        public void InsertEmpleado(EMPLEADO emple)
        {
            using (EntitiesHostal ins = new EntitiesHostal())
            {
                ins.EMPLEADO.Add(emple);
                ins.SaveChanges();
            }
        }

        public Boolean validarRut(string rut)
        {

            Boolean validacion = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));

                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception)
            {
                Console.Write("ERROR RUUTTT");
            }
            return validacion;
        }

        public string ObtenerRut(string rut)
        {

            string validacion = "";
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));
                validacion = rutAux.ToString();
                return validacion;            
            }
            catch (Exception)
            {
                Console.Write("ERROR RUUTTT");
            }
            return validacion;
        }
        public Boolean ValidacionEmail(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public string GenerarClave(string pNombre, string pRut)
        {
            string clave = (pNombre.Substring(0, 4 ) + pRut.Substring(0, 4));
            return clave;
        }
    }
}
