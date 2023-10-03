using ApiCandataCUN.Data.DataAccess;
using ApiCandataCUN.Models;

namespace ApiCandataCUN.Services
{
    public class CandidatoService : ICandidatoService
    {
        private readonly ICandidatoRepository _repository;

        public CandidatoService(ICandidatoRepository repository)
        {
            _repository = repository;
        }

        public void crearCandidato(Candidato candidato)
        {
            _repository.crearCandidato(candidato);
        }
        public Candidato obtenerCandidatoPorId(string id)
        {
            return _repository.obtenerCandidatoPorId(id);
        }
        public IEnumerable<Candidato> obtenerCandidatos()
        {
            return _repository.obtenerCandidatos();
        }

        
    }
}
