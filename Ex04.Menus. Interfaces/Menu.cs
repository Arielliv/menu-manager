using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class Menu : MenuItem
    {
        private const string k_BackTitle = "Back";

        public Menu(string i_Title) : base(i_Title) 
        {
            this.addRootMenuItem();
        }

        private void addRootMenuItem()
        {
            base.r_ChildrenMenuItems.Add(new MenuItem(k_BackTitle));
        }
    }
}
