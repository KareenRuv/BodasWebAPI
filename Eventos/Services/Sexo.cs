using Eventos.Data;
using Eventos.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Eventos.Services
{
    public class Sexo : ISexo
    {
        private readonly EventosContext _eventosContext;
        public Sexo(EventosContext eventosContext)
        {
            this._eventosContext = eventosContext;
        }
        public void AddSexo(Sexo sexo)
        {
            this._eventosContext.Sexo.Add(sexo);
            this.Save();
        }
        public async Task<Sexo>GetSexo(int id_sexo)
        {
            return await _eventosContext.Sexo.FirstOrDefaultAsync(x => x.Id_Sexo.Equals(id_sexo));
        }
        public async Task<IEnumerable<Sexo>>GetSexos()
        {
            return await _eventosContext.Sexo.ToListAsync();
        }
        public void UpdateSexo(Sexo sexo)
        {
            this._eventosContext.Entry<Sexo>(sexo).State = EntityState.Modified;
            this.Save();
        }
        public void DeleteSexo(int id_sexo)
        {
            Sexo sexo = this._eventosContext.Sexo.FirstOrDefault(x => x.Id_Sexo.Equals(id_sexo));
            this._eventosContext.Sexo.Remove(sexo);
            this.Save();
        }
        public void Save()
        {
            this._eventosContext.SaveChanges();
        }
    }
}
