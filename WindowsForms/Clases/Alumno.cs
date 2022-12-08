using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.Clases
{
    public class Alumno
    {
        // Atributos de la clase
        private int _noControl;
        private string _nombre;
        private string _direccion;
        private string _telefono;
        private byte _edad;
        private string _sexo;

        // Metodos de acceso
        public int NoControl { get => _noControl; set => _noControl = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public byte Edad { get => _edad; set => _edad = value; }
        public string Sexo { get => _sexo; set => _sexo = value; }

        // Constructor
        public Alumno(int noControl, string nombre, string direccion, string telefono, byte edad, string sexo)
        {
            _noControl = noControl;
            _nombre = nombre;
            _direccion = direccion;
            _telefono = telefono;
            _edad = edad;
            _sexo = sexo;
        }

        // Metodos de manipulacion
        public static void Registrar(Alumno a)
        {
            Conexion cn = new Conexion();
            string sql =
                "INSERT INTO Alumnos (NoControl, Nombre, Direccion, Telefono, Edad, Sexo) " +
                $"VALUES({a.NoControl}, '{a.Nombre}', '{a.Direccion}', '{a.Telefono}', {a.Edad}, '{a.Sexo}')";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn.Conectar());
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw new Exception("Error al registrar el alumno");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                cn.Desconectar();
            }
        }

        public static void Eliminar(int noControl)
        {
            Conexion cn = new Conexion();
            string sql =
                "DELETE FROM Inscritos " +
                $"WHERE (NoControl = {noControl}) " +
                $"DELETE FROM Alumnos " +
                $"WHERE (NoControl = {noControl})";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn.Conectar());
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw new Exception("Error al eliminar el alumno");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                cn.Desconectar();
            }
        }

        public static void Actualizar(Alumno a)
        {
            Conexion cn = new Conexion();
            string sql =
                "UPDATE Alumnos " +
                $"SET " +
                $"  Nombre = '{a.Nombre}', " +
                $"  Direccion = '{a.Direccion}', " +
                $"  Telefono = '{a.Telefono}', " +
                $"  Edad = {a.Edad}, " +
                $"  Sexo = '{a.Sexo}'" +
                $"WHERE (NoControl = {a.NoControl})";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn.Conectar());
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw new Exception("Error al actualizar el alumno");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                cn.Desconectar();
            }
        }

        public static DataTable Consultar(int noControl)
        {
            Conexion cn = new Conexion();
            string sql =
                "SELECT " +
                "   * " +
                "FROM Alumnos " +
                $"WHERE (NoControl = {noControl})";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn.Conectar());
                SqlDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);

                return dt;
            }
            catch (SqlException)
            {
                throw new Exception("Error al consultar el alumno");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                cn.Desconectar();
            }
        }

        public static DataTable ListarTodos()
        {
            Conexion cn = new Conexion();
            string sql = 
                "SELECT" +
                "   * " +
                "FROM Alumnos";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn.Conectar());
                SqlDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);

                return dt;
            }
            catch (SqlException)
            {
                throw new Exception("Error al consultar los alumnos");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                cn.Desconectar();
            }
        }
    }
}
