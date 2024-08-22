using System.Data.SqlClient;
using Dapper;
namespace JJOO.Models;


public static class BD
{
    private static string _connectionString=@"Server=localhost; DataBase=base de datos jjoo; Trusted_Connection=True;";
    static public void AgregarDeportista(Deportista dep)
    {
        string SQL = "INSERT INTO Deportista(idDeportista, Nombre, FechaNacimiento) VALUES (@pIdDeportista, @pNombre, @pFechaNacimiento)";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            db.Execute(SQL, new {pNombre = dep.Nombre, pIdDeportista = dep.IdDeportista, pFechaNacimiento = dep.FechaNacimientop});
        }
    }
    static public void EliminarDeportista(int idDeportista)
    {
        int RegistrosEliminados = 0;
        string sql = "DELETE FROM Deportista WHERE idDeportsita = @pIdDeportista";
        using(SqlConnection db = new SqlConnection(_connectionString) ) 
        {
            RegistrosEliminados = db.Execute(sql, new {pIdDeportista = idDeportista});
        }
        return RegistrosEliminados;
    
    }
    static public Deporte VerInfoDeporte(int idDeporte)
    {
        Deporte deporte=null;
        using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql="Select * from Deporte where idDeporte=@pIdDeporte";
            deporte=db.QueryFirstOrDefault<Deporte>(sql, new {pIdDeporte=idDeporte});
        }
        return deporte;


    }
    static public Pais VerInfoPais(int Pais)
    {
        Deporte pais=null;
        using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql="Select * from Pais where idPais=@pIdPais";
            pais=db.QueryFirstOrDefault<Deporte>(sql, new {pIdPais=idPais});
        }
        return pais;
    }
    static public Deportista VerInfoDeportista(int idDeportista)
    {
        Deporte deportista=null;
        using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql="Select * from Deportista where idDeportista=@pIdDeporte";
            deportista=db.QueryFirstOrDefault<Deporte>(sql, new {pIdDeportista=idDeportista});
        }
        return deportista;
    }
    static public List<Pais> ListarPaises()
    {
        using(SqlConnection db = new SqlConnection(_connectionString) )
        {
            string sql = "SELECT * FROM Pais";
            _ListarPaises = db.Query<Pais>(sql).ToList();
        }
        return _ListarPaises;
    }
    static public List<Deportista> ListarDeportistaxDeporte(int idDeporte)
    {

    }
    static public List<Deportista> ListarDeportistaxPais(int idPais)
    {

    }
    static public List<Deporte> ListarDeportes(int idDeporte)
    {
        using(SqlConnection db = new SqlConnection(_connectionString) )
        {
            string sql = "SELECT * FROM Deporte";
            _ListarDeportes = db.Query<Deporte>(sql).ToList();
        }
        return _ListarDeportes;
    }


}
