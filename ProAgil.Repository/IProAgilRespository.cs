using System.Threading.Tasks;
using ProAgil.Domain;

namespace ProAgil.Repository
{
    public interface IProAgilRespository
    {
        //Geral
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;

        void DeleteRange<T>(T[] entity) where T : class;

        Task<bool> SaveChangesAsync();

        //Evento
        Task<Evento[]> GetAllEventoAsyncByTema(string tema, bool includePalestrantes);
        Task<Evento[]> GetAllEventoAsync(bool includePalestrantes);
        Task<Evento> GetAllEventoAsyncById(int EventoId, bool includePalestrantes);

        //Palestrante
        Task<Palestrante[]> GetAllPalestrantesAsyncByName(string name, bool includeEvento);
        Task<Palestrante> GetPalestrantesAsync(int PalestranteId, bool includeEvento);
    }
}