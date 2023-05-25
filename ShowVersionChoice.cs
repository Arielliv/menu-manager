using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowVersionChoice : IActionItemNotifier
    {
        public void Notify()
        {
            MenuOptions.ShowVersion();
        }
    }
}
