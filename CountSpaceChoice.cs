using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountSpaceChoice : IActionItemNotifier
    {
        public void Notify()
        {
            MenuOptions.CountSpaces();
        }
    }
}
