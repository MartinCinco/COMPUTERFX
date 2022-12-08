using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms.Clases
{
   
    public class Conexion
    {
        private SqlConnection cn;

        public Conexion()
        {
            this.cn = new SqlConnection("Data Source=DESKTOP-M0N5VU6\\MARTIN;Initial Catalog=ESCUELA;Integrated Security=True");
        }

        public SqlConnection Conectar()
        {
            try {
                this.cn.Open();
                return this.cn;
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public SqlConnection Desconectar()
        {
            try {
                this.cn.Close();
                return this.cn;
            }
            catch(Exception e) 
            { throw new Exception(e.Message); 
            }
            

        }
    }
}
