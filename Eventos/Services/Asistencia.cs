using Eventos.Data;
using Eventos.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Eventos.Services
{
    public class Asistencia : IAsistencia
    {
        private readonly EventosContext _eventosContext;
        public Asistencia(EventosContext eventosContext)
        {
            this._eventosContext = eventosContext;
        }
        public void AddAsistencia(Asistencia asistencia)
        {
            this._eventosContext.Asistencia.Add(asistencia);
            this.Save();
        }
        public async Task<Asistencia> GetAsistencia(int id_asistencia)
        {
            return await _eventosContext.Asistencia.FirstOrDefaultAsync(x => x.Id_Asistencia.Equals(id_asistencia));
        }
        public async Task<IEnumerable<Asistencia>> GetAsistencias()
        {
            return await _eventosContext.Asistencia.ToListAsync();
        } 
        public void UpdateAsistencia(Asistencia asistencia)
        {
             this._eventosContext.Entry<Asistencia>(asistencia).State = EntityState.Modified;
             this.Save();
        }
        public void DeleteAsistencia(int id_asistencia)
        {
        Asistencia asistencia = this._eventosContext.Asistencia.FirstOrDefault(x => x.Id_Asistencia.Equals(id_asistencia));

        this._eventosContext.Asistencia.Remove(asistencia);
        this.Save();
        }
        public void Save()
        {
        this._eventosContext.SaveChanges();
        }
        
    }
}
