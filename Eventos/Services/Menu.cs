using Eventos.Data;
using Eventos.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Eventos.Services
{
    public class Menu : IMenu
    {
        private readonly EventosContext _eventosContext;
        public Menu(EventosContext eventosContext)
        {
            this._eventosContext = eventosContext;
        }
        public void AddMenu(Menu menu)
        {
            this._eventosContext.Menu.Add(menu);
            this.Save();
        }
        public async Task<Menu> GetMenu(int id_menu)
        {
            return await _eventosContext.Menu.FirstOrDefaultAsync(x => x.Id_Menu.Equals(id_menu));
        }
        public async Task<IEnumerable<Menu>> GetMenus()
        {
            return await _eventosContext.Menu.ToListAsync();
        }
        public void UpdateMenu(Menu menu)
        {
            this._eventosContext.Entry<Menu>(menu).State = EntityState.Modified;
            this.Save();
        }
        public void DeleteMenu(int id_menu)
        {
            Menu menu = this._eventosContext.Menu.FirstOrDefault(x => x.Id_Menu.Equals(id_menu));

            this._eventosContext.Menu.Remove(menu);
            this.Save();
        }
        public void Save()
        {
            this._eventosContext.SaveChanges();
        }
    }
}
