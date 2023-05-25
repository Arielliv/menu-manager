namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            MenuByInterface menuByInterface = new MenuByInterface();
            MenuByDelegates menuByDelegates = new MenuByDelegates();
            menuByInterface.showMenu();
            menuByDelegates.showMenu();
        }
    }
}
