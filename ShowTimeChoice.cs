using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowTimeChoice : IActionItemNotifier
    {
        public void Notify()
        {
            MenuOptions.ShowTime();
        }
    }
}
