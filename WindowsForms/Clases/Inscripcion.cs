using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms.Clases
{
    public class Inscripcion
    {
        // Atributos de la clase
        private int _noControl;
        private int _noMateria;
        private int _calificacion;

        // Metodos de acceso
        public int NoControl { get => _noControl; set => _noControl = value; }
        public int NoMateria { get => _noMateria; set => _noMateria = value; }
        public int Calificacion { get => _calificacion; set => _calificacion = value; }

        // Constructor
        public Inscripcion(int noControl, int noMateria, int calificacion)
        {
            NoControl = noControl;
            NoMateria = noMateria;
            Calificacion = calificacion;
        }

        // Metodos de manipulacion
        public static void Registrar(Inscripcion i)
        {
            Conexion cn = new Conexion();
            string sql = 
                "INSERT INTO Inscritos (NoControl, NoMateria, Calificacion) " +
                $"VALUES ({i.NoControl}, {i.NoMateria}, {i.Calificacion})";

            Console.WriteLine(sql);

            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn.Conectar());
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Error al registrar la inscripción");
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

        public static void Eliminar(int noControl, int noMateria)
        {
            Conexion cn = new Conexion();
            string sql = 
                "DELETE FROM Inscritos " +
                $"WHERE ((NoControl = {noControl}) AND (NoMateria = {noMateria}))";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn.Conectar());
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw new Exception("Error al eliminar la inscripción");
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

        public static void Actualizar(Inscripcion i)
        {
            Conexion cn = new Conexion();
            string sql = 
                "UPDATE Inscritos " +
                "SET " +
                $"   Calificacion = {i.Calificacion}" +
                $"WHERE ((NoControl = {i.NoControl}) AND (NoMateria = {i.NoMateria}))";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn.Conectar());
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw new Exception("Error al actualizar la inscripción");
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

        public static DataTable Consultar(int noControl, int noMateria)
        {
            Conexion cn = new Conexion();
            string sql =
                "SELECT " +
                "   * " +
                "FROM Inscritos " +
                $"WHERE ((NoControl = {noControl}) AND (NoMateria = {noMateria}))";

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
                throw new Exception("Error al consultar la inscripción");
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
                "SELECT " +
                "   * " +
                "FROM Inscritos";

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
                throw new Exception("Error al actualizar las inscripciones");
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
