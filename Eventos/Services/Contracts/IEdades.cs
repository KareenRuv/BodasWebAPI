namespace Eventos.Services.Contracts
{
    public interface IEdades
    {
        public void AddEdades(Edad edad);
        Task<IEnumerable<Edad>> GetEdades();
        Task<Edad> GetEdades(int id_edad);
        public void UpdateEdades(Edad edad);
        public void DeleteEdades(int id_edad);

    }
}
