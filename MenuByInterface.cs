using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class MenuByInterface
    {
        private MainMenu m_MainMenu;

        public void ShowMenu()
        {
            this.initMainMenu();
            this.m_MainMenu.Show();
        }

        private void initMainMenu()
        {
            this.m_MainMenu = new MainMenu("Interface Main menu");
            Menu ShowDateTimeMenuItem = new Menu("Show Date/Time");
            MenuActionItem showDateActionItem = new MenuActionItem("Show Date");
            MenuActionItem showTimeActionItem = new MenuActionItem("Show Time");

            showDateActionItem.AddActionItemNotifier(new ShowDateChoice());
            showTimeActionItem.AddActionItemNotifier(new ShowTimeChoice());
            ShowDateTimeMenuItem.AddMenuItemToList(showDateActionItem);
            ShowDateTimeMenuItem.AddMenuItemToList(showTimeActionItem);
            Menu VersionAndSpacesMenuItem = new Menu("Version and Spaces");
            MenuActionItem showVersionActionItem = new MenuActionItem("Show Version");
            MenuActionItem countSpacesActionItem = new MenuActionItem("Count Spaces");

            showVersionActionItem.AddActionItemNotifier(new ShowVersionChoice());
            countSpacesActionItem.AddActionItemNotifier(new CountSpaceChoice());
            VersionAndSpacesMenuItem.AddMenuItemToList(showVersionActionItem);
            VersionAndSpacesMenuItem.AddMenuItemToList(countSpacesActionItem);
            this.m_MainMenu.AddMenuItemToList(ShowDateTimeMenuItem);
            this.m_MainMenu.AddMenuItemToList(VersionAndSpacesMenuItem);
        }
    }
}
