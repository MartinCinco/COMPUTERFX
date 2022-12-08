using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms.Clases
{
    public class Materia
    {
        // Atributos de la clase
        private int _noMateria;
        private string _nombre;
        private string _semestre;
        private string _aula;

        // Metodos de acceso
        public int NoMateria { get => _noMateria; set => _noMateria = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Semestre { get => _semestre; set => _semestre = value; }
        public string Aula { get => _aula; set => _aula = value; }

        // Constructor
        public Materia(int noMateria, string nombre, string semestre, string aula)
        {
            _noMateria = noMateria;
            _nombre = nombre;
            _semestre = semestre;
            _aula = aula;
        }

        // Metodos de manipulacion
        public static void Registrar(Materia m)
        {
            Conexion cn = new Conexion();
            string sql =
                "INSERT INTO Materias (NoMateria, Nombre, Semestre, Aula) " +
                $"VALUES ({m.NoMateria}, '{m.Nombre}', '{m.Semestre}', '{m.Aula}')";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn.Conectar());
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw new Exception("Error al registrar la materia");
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

        public static void Eliminar(int noMateria)
        {
            Conexion cn = new Conexion();
            string sql =
                "DELETE FROM Inscritos " +
                $"WHERE (NoMateria = {noMateria}) " +
                "DELETE FROM Materias " +
                $"WHERE (NoMateria = {noMateria})";

            Console.WriteLine(sql);

            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn.Conectar());
                cmd.ExecuteNonQuery();
            }
            catch (SqlException )
            {
                throw new Exception("Error al eliminar la materia");
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

        public static void Actualizar(Materia m)
        {
            Conexion cn = new Conexion();
            string sql =
                "UPDATE Materias " +
                "SET " +
                $"   Nombre = '{m.Nombre}', " +
                $"   Semestre = '{m.Semestre}', " +
                $"   Aula = '{m.Aula}' " +
                $"WHERE (NoMateria = {m.NoMateria})";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn.Conectar());
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw new Exception("Error al actualizar la materia");
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

        public static DataTable Consultar(int noMateria)
        {
            Conexion cn = new Conexion();
            string sql =
                "SELECT" +
                "   * " +
                "FROM Materias" +
                $"WHERE (NoMateria = {noMateria})";

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
                throw new Exception("Error al consultar la materia");
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
                "FROM Materias";

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
                throw new Exception("Error al consultar las materias");
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
