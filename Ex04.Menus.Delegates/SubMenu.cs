using System;
using System.Collections.Generic;
using System.Text;
namespace Ex04.Menus.Delegates
{
    public class SubMenu : MenuItem
    {
        private List<MenuItem> m_SubMenuOptions;
        private int m_NumberOfOptions;
        private bool m_GoBack = false;
        public int NumberOfOptions
        {
            get
            {
                return m_NumberOfOptions;
            }
            set
            {
                m_NumberOfOptions = value;
            }
        }
        private List<MenuItem> SubMenuOptions
        {
            get
            {
                return m_SubMenuOptions;
            }
        }
        public SubMenu(string i_MenuTitle) : base(i_MenuTitle)
        {
            m_ItemText = i_MenuTitle;
            m_SubMenuOptions = new List<MenuItem>();
        }
        private MenuItem StartingMenuItem()
        {
            ActionItem itemToAdd;
            if (m_CurrentMenuLevel == 1)
            {
                itemToAdd = new ActionItem("Exit");
            }
            else
            {
                itemToAdd = new ActionItem("Go Back");
            }
            return itemToAdd;
        }
        public override void Show()
        {
            Console.Clear();
            m_GoBack = false;
            while (!quit())
            {
                printSubMenuLevelAndText();
                printSubMenuOptions();
                int userChoice = readInputFromUser();
                updateCurrentLevel(userChoice);
                m_SubMenuOptions[userChoice].Show();
            }
        }
        private void printSubMenuLevelAndText()
        {
            string msg = string.Format(@"
-----------------------------------------------------------------------------
The current level is: {0}
{1}:
", m_CurrentMenuLevel, m_ItemText);
            Console.WriteLine(msg);
        }
        private void printSubMenuOptions()
        {
            int optionIndex = 0;
            foreach (MenuItem option in m_SubMenuOptions)
            {
                Console.WriteLine("{0}. {1}", optionIndex, option.ItemText);
                optionIndex++;
            }
            Console.WriteLine("-----------------------------------------------------------------------------");
        }
        private void updateCurrentLevel(int i_UserChoice)
        {
            if (m_SubMenuOptions[i_UserChoice] is SubMenu)
            {
                m_GoBack = false;
            }
            if (i_UserChoice == 0)
            {
                m_GoBack = true;
            }
        }

        private bool quit()
        {
            return m_GoBack ? true : false;
        }
        public void AddOptionsToSubMenu(params MenuItem[] i_OptionsOnSubMenu)
        {
            m_SubMenuOptions.Add(StartingMenuItem());

            foreach (MenuItem option in i_OptionsOnSubMenu)
            {

                m_NumberOfOptions++;
                m_SubMenuOptions.Add(option);
                if (option is SubMenu)
                {
                    option.m_CurrentMenuLevel = m_CurrentMenuLevel + 1;
                }
            }
        }
        private int readInputFromUser()
        {
            string inputFromUser = string.Empty;
            int userChoice = 0;
            bool isValidInput = false;
            while (!isValidInput)
            {
                Console.Write("Please enter your choice: ");
                inputFromUser = Console.ReadLine();
                try
                {
                    userChoice = checkInputValidity(inputFromUser, ref isValidInput);
                }
                catch (ValueOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Please enter a number");
                }
            }
            return userChoice;
        }
        private int checkInputValidity(string i_UserInput, ref bool io_isValidInput)
        {
            int userInput = int.Parse(i_UserInput);
            if (userInput > m_NumberOfOptions || userInput < 0)
            {
                throw new ValueOutOfRangeException(0, m_NumberOfOptions);
            }
            else
            {
                io_isValidInput = true;
                return userInput;
            }
        }
    }
}
