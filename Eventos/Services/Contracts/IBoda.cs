namespace Eventos.Services.Contracts
{
    public interface IBoda
    {
        public void AddBoda(Boda boda);
        Task<IEnumerable<Boda>> GetBodas();
        Task<Boda> GetBodas(int id_boda);
        public void UpdateBoda(Boda boda);
        public void DeleteBoda(int id_boda);

    }
}
