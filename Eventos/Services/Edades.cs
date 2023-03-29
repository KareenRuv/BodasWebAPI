using Eventos.Data;
using Eventos.Models;
using Eventos.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Eventos.Services
{
    public class Edad : IEdades
    {
        private readonly EventosContext _eventosContext;
        public Edad(EventosContext eventosContext)
        {
            this._eventosContext = eventosContext;
        }
        public void AddEdades(Edad edad)
        {
            this._eventosContext.Edades.Add(edad);
            this.Save();
        }
        public async Task<Edad> GetEdades(int id_edad)
        { 
            return await _eventosContext.Edades.FirstOrDefaultAsync(x => x.Id_Edad.Equals(id_edad));
        }
        public async Task<IEnumerable<Edad>> GetEdades()
        {
            return await _eventosContext.Edades.ToListAsync();
        }
        public void UpdateEdades(Edad edad)
        {
            this._eventosContext.Entry<Edad>(edad).State = EntityState.Modified;
            this.Save();
        }
        public void DeleteEdades(int id_edad)
        {
            Edad edad = this._eventosContext.Edades.FirstOrDefault(x => x.Id_Edad.Equals(id_edad));

            this._eventosContext.Edades.Remove(edad);
            this.Save();
        }
        public void Save()
        {
            this._eventosContext.SaveChanges();
        }
    }
}
