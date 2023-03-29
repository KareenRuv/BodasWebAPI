using Eventos.Services.Contracts;

namespace Eventos.Services
{
    public class Boda : IBoda
    {
        private readonly EventosContext _eventosContext;
        public Boda(EventosContext eventosContext)
        {
            this._eventosContext = eventosContext;
        }
        public void AddBoda(Boda boda)
        {
            this._eventosContext.Boda.Add(boda);
            this.Save();
        }
        public async Task<Boda> GetBoda(int id_boda)
        {
            return await _eventosContext.Boda.FirstOrDefaultAsync(x => x.Id_Boda.Equals(id_boda));
        }
        public async Task<IEnumerable<Boda>> GetBodas()
        {
            return await _eventosContext.Boda.ToListAsync();
        }
        public void UpdateBoda(Boda boda)
        {
            this._eventosContext.Entry<Boda>(boda).State = EntityState.Modified;
            this.Save();
        }
        public void DeleteBoda(int id_boda)
        {
            Boda boda = this._eventosContext.Boda.FirstOrDefault(x => x.Id_Boda.Equals(id_boda));

            this._eventosContext.Boda.Remove(boda);
            this.Save();
        }
        public void Save()
        {
            this._eventosContext.SaveChanges();
        }
    }
}
