using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    public class MenuItem
    {
        protected string m_Title;
        protected MenuItem m_ParentMenuItem;
        protected readonly List<MenuItem> r_ChildrenMenuItems;
        protected MenuItem m_RootMenuIteam;

        public MenuItem(string i_Title)
        {
            this.m_Title = i_Title;
            this.m_ParentMenuItem = null;
            this.r_ChildrenMenuItems = new List<MenuItem>();
        }

        protected string Title
        {
            get { return this.m_Title; }
            set { this.m_Title = value; }
        }

        protected MenuItem ParentMenuItem
        {
            get { return this.m_ParentMenuItem; }
            set { this.m_ParentMenuItem = value; }
        }

        public override string ToString()
        {
            return this.m_Title;
        }

        public virtual void OnMenuItemChosen()
        {
            this.Show();
        }

        public void AddMenuItemToList(MenuItem i_NewMenuItem)
        {
            this.r_ChildrenMenuItems.Add(i_NewMenuItem);
        }

        private void showMenu()
        {
            int menuItemCounter = 1;

            foreach (MenuItem currentMenueItem in this.r_ChildrenMenuItems)
            {
                Console.WriteLine($"{menuItemCounter} -> {currentMenueItem}");
                menuItemCounter++;
            }

            if(this.m_RootMenuIteam != null)
            {
                Console.WriteLine($"0 -> {this.m_RootMenuIteam}");
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
            if (userChoice == 0)
            {
                if (this.m_ParentMenuItem != null)
                {
                    this.m_ParentMenuItem.OnMenuItemChosen();
                }
            }
            else
            {
                this.r_ChildrenMenuItems[userChoice - 1].m_ParentMenuItem = this;
                this.r_ChildrenMenuItems[userChoice - 1].OnMenuItemChosen();
            }
        }
    }
}
