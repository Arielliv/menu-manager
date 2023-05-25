using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MenuActionItem : MenuItem
    {
        private readonly List<IActionItemNotifier> r_ActionItemNotifiers;

        public MenuActionItem(string i_Title) : base(i_Title)
        {
            this.r_ActionItemNotifiers = new List<IActionItemNotifier>();
        }

        public void AddActionItemNotifier(IActionItemNotifier i_ActionItemNotifier)
        {
            this.r_ActionItemNotifiers.Add(i_ActionItemNotifier);
        }

        public void RemoveActionItemNotifier(IActionItemNotifier i_ActionItemNotifier)
        {
            this.r_ActionItemNotifiers.Remove(i_ActionItemNotifier);
        }  

        public override void OnMenuItemChosen() 
        {
            Console.Clear();
            this.notifyAllListeners();
            base.m_ParentMenuItem.Show();
        }

        private void notifyAllListeners()
        {
            foreach(IActionItemNotifier actionItemNotifier in this.r_ActionItemNotifiers)
            {
                actionItemNotifier.Notify();
            }
        }
    }
}
