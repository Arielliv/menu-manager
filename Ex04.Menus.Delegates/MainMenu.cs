namespace Ex04.Menus.Delegates
{
    public class MainMenu : MenuItem
    {
        private const string k_ExitTitle = "Exit";

        public MainMenu(string i_Title) : base(i_Title)
        {
            this.setRootMenuItem();
        }

        private void setRootMenuItem()
        {
            base.m_RootMenuIteam = new MenuItem(k_ExitTitle);
        }
    }
}