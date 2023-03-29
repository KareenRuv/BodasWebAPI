namespace Eventos.Services.Contracts
{
    public interface ISexo
    {
        public void AddSexo(Sexo sexo);
        Task<IEnumerable<Sexo>> GetSexos();
        Task<Sexo> GetSexo(int id_sexo);
        public void UpdateSexo(Sexo sexo);
        public void DeleteSexo(int id_sexo);
    }
}