namespace Ex04.Menus.Interfaces
{
    public class MainMenu : MenuItem
    {
        private const string k_ExitTitle = "Exit";

        public MainMenu(string i_Title): base(i_Title)
        {
            this.addRootMenuItem();
        }

        private void addRootMenuItem()
        {
            base.r_ChildrenMenuItems.Add(new MenuItem(k_ExitTitle));
        }
    }
}
