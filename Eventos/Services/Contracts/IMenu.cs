namespace Eventos.Services.Contracts
{
    public interface IMenu
    {
        public void AddMenu(Menu menu);
        Task<IEnumerable<Menu>> GetMenus();
        Task<Menu> GetMenu(int id_menu);
        public void UpdateMenu(Menu menu);
        public void DeleteMenu(int id_menu);
    }
}
