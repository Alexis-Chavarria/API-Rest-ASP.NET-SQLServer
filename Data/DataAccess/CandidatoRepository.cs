using ApiCandataCUN.Models;

namespace ApiCandataCUN.Data.DataAccess
{
    public class CandidatoRepository : ICandidatoRepository
    {
        private readonly ConexionSQLserver conexionSQLServer;

        public CandidatoRepository(ConexionSQLserver conexionSQLServer)
        {
            this.conexionSQLServer = conexionSQLServer;
        }

        public void crearCandidato(Candidato candidato)
        {
            conexionSQLServer.Pruebas.Add(candidato);
            conexionSQLServer.SaveChanges();
        }

        public Candidato obtenerCandidatoPorId(string id)
        {
            return conexionSQLServer.Pruebas.FirstOrDefault(candidato => candidato.id == id);
        }

        public IEnumerable<Candidato> obtenerCandidatos()
        {
            return conexionSQLServer.Pruebas.ToList();
        }
    }
}
