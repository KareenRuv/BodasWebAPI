namespace Eventos.Services.Contracts
{
    public interface IAsistencia
    {
        public void AddAsistencia(Asistencia asistencia);
        Task<IEnumerable<Asistencia>> GetAsistencias();
        Task<Asistencia> GetAsistencia(int id_asistencia);
        public void UpdateAsistencia(Asistencia asistencia);
        public void DeleteAsistencia(int id_asistencia);
    }
}
