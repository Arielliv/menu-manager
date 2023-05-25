using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowDateChoice : IActionItemNotifier
    {
        public void Notify()
        {
            MenuOptions.ShowDate();
        }
    }
}
