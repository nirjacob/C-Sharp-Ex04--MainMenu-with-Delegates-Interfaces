using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        private readonly SubMenu m_MainMenu;

        public MainMenu(string i_MenuTitle)
        {
            m_MainMenu = new SubMenu(i_MenuTitle);
            m_MainMenu.m_CurrentMenuLevel = 1;
        }

        public void Show()
        {
            m_MainMenu.Show();
        }

        public void AddOptionsToMainMenu(params MenuItem[] i_OptionsOnMainMenu)
        {
            m_MainMenu.AddOptionsToSubMenu(i_OptionsOnMainMenu);
        }

    }
}
