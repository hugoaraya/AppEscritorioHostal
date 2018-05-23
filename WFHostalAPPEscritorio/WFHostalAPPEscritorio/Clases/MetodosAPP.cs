using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data.Entity.Migrations;

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
    }
}
