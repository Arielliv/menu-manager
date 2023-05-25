using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    public class MenuActionItem : MenuItem
    {
        public event Action<MenuItem> Chosen;

        public MenuActionItem(string i_Title) : base(i_Title) {}

        public override void OnMenuItemChosen() 
        {
            Console.Clear();
            Chosen?.Invoke(this);
            base.m_ParentMenuItem.Show();
        }
    }
}
