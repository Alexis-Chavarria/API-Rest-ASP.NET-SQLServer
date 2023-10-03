using ApiCandataCUN.Models;

namespace ApiCandataCUN.Data.DataAccess
{
    public interface ICandidatoRepository
    {
        Candidato obtenerCandidatoPorId(string id);
        IEnumerable<Candidato> obtenerCandidatos();
        void crearCandidato(Candidato candidato);
    }
}
