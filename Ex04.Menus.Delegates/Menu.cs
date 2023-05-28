namespace Ex04.Menus.Delegates
{
    public class Menu : MenuItem
    {
        private const string k_BackTitle = "Back";

        public Menu(string i_Title) : base(i_Title)
        {
            this.setRootMenuItem();
        }

        private void setRootMenuItem()
        {
            base.m_RootMenuIteam = new MenuItem(k_BackTitle);
        }
    }
}
