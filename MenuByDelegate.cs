using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class MenuByDelegates
    {
        private MainMenu m_MainMenu;

        public void showMenu()
        {
            this.initMainMenu();
            this.m_MainMenu.Show();
        }

        private void initMainMenu()
        {
            this.m_MainMenu = new MainMenu("Delegates Main menu");
            Menu ShowDateTimeMenuItem = new Menu("Show Date/Time");
            MenuActionItem showDateActionItem = new MenuActionItem("Show Date");
            MenuActionItem showTimeActionItem = new MenuActionItem("Show Time");

            showDateActionItem.Chosen += showDate_Chosen;
            showTimeActionItem.Chosen += showTime_Chosen;
            ShowDateTimeMenuItem.AddMenuItemToList(showDateActionItem);
            ShowDateTimeMenuItem.AddMenuItemToList(showTimeActionItem);

            Menu VersionAndSpacesMenuItem = new Menu("Version and Spaces");
            MenuActionItem showVersionActionItem = new MenuActionItem("Show Version");
            MenuActionItem countSpacesActionItem = new MenuActionItem("Count Spaces");

            showVersionActionItem.Chosen += showVersion_Chosen;
            countSpacesActionItem.Chosen += countSpace_Chosen;
            VersionAndSpacesMenuItem.AddMenuItemToList(showVersionActionItem);
            VersionAndSpacesMenuItem.AddMenuItemToList(countSpacesActionItem);

            this.m_MainMenu.AddMenuItemToList(ShowDateTimeMenuItem);
            this.m_MainMenu.AddMenuItemToList(VersionAndSpacesMenuItem);
        }

        private static void countSpace_Chosen(MenuItem i_MenuItem)
        {
            MenuOptions.CountSpaces();
        }

        private static void showTime_Chosen(MenuItem i_MenuItem)
        {
            MenuOptions.ShowTime();
        }

        private static void showVersion_Chosen(MenuItem i_MenuItem)
        {
            MenuOptions.ShowVersion();
        }

        private static void showDate_Chosen(MenuItem i_MenuItem)
        {
            MenuOptions.ShowDate();
        }
    }
}
