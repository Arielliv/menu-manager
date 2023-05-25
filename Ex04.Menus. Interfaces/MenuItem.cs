using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem : IMenuItem
    {
        protected string m_Title { get; set; }
        protected MenuItem m_ParentMenuItem { get; set; }
        protected readonly List<MenuItem> r_ChildrenMenuItems;

        public MenuItem(string i_Title)
        {
            this.m_Title = i_Title;
            this.m_ParentMenuItem = null;
            this.r_ChildrenMenuItems = new List<MenuItem>();
        }

        public override string ToString()
        {
            return this.m_Title;
        }

        public virtual void OnMenuItemChosen()
        {
            this.Show();
        }

        public void setRootMenuItemTitle(string i_Title)
        {
            this.r_ChildrenMenuItems[0].m_Title = i_Title;
        }

        public void AddMenuItemToList(MenuItem i_NewMenuItem)
        {
            this.r_ChildrenMenuItems.Add(i_NewMenuItem);
        }

        private void showMenu()
        {
            int menuItemCounter = 0;

            foreach (MenuItem currentMenueItem in this.r_ChildrenMenuItems)
            {
                Console.WriteLine($"{menuItemCounter} -> {currentMenueItem}");
                menuItemCounter++;
            }
        }

        private int getUserChoice()
        {
            bool isValidChoice = false;
            string requestInput;
            int request = 0;

            while (!isValidChoice)
            {
                requestInput = Console.ReadLine();

                if (int.TryParse(requestInput, out request) && (request >= 0 || request <= this.r_ChildrenMenuItems.Count))
                {
                    isValidChoice = true;
                }
                else
                {
                    Console.WriteLine("Your choice is invalid. please try again..");
                }
            }

            return request;
        }

        public void Show()
        {
            int userChoice;

            Console.WriteLine($"**{this.m_Title}**");
            Console.WriteLine("-------------------");
            showMenu();
            Console.WriteLine("-------------------");
            Console.WriteLine($"Enter your request: (Between 0 to {this.r_ChildrenMenuItems.Count})");
            userChoice = this.getUserChoice();
            Console.Clear();
            if(userChoice == 0)
            {
                if(this.m_ParentMenuItem != null)
                {
                    this.m_ParentMenuItem.OnMenuItemChosen();
                }
            }
            else
            {
                this.r_ChildrenMenuItems[userChoice].m_ParentMenuItem = this;
                this.r_ChildrenMenuItems[userChoice].OnMenuItemChosen();
            }
        }
    }
}
