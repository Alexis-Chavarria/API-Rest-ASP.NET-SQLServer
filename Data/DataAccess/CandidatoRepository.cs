using ApiCandataCUN.Models;

namespace ApiCandataCUN.Data.DataAccess
{
    public class CandidatoRepository : ICandidatoRepository
    {
        // Inyeccion de dependencia que permite realizar las operaciones CRUD en la Base de Datos
        private readonly ConexionSQLserver conexionSQLServer;

        public CandidatoRepository(ConexionSQLserver conexionSQLServer)
        {
            this.conexionSQLServer = conexionSQLServer;
        }

        // crear un nuevo candidato en la base de datos.
        public void crearCandidato(Candidato candidato)
        {
            conexionSQLServer.Candidatos.Add(candidato);
            conexionSQLServer.SaveChanges();
        }

        // permite obtener un candidato por su ID.
        public Candidato obtenerCandidatoPorId(string id)
        {
            return conexionSQLServer.Candidatos.FirstOrDefault(candidato => candidato.id == id);
        }

        // devuelve una lista de todos los candidatos persistidos en la base de datos.
        public IEnumerable<Candidato> obtenerCandidatos()
        {
            return conexionSQLServer.Candidatos.ToList();
        }
    }
}
