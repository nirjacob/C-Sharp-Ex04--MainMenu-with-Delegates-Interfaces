using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interface;

namespace Ex04.Menus.Test
{
    class TestInterface
    {

        public void Run()
        {
            MainMenu mainMenu = new MainMenu("Main Menu");

            SubMenu verisonAndSpacesCountSubMenu = new SubMenu("Show current verison or count number of spaces in sentence");
            ShowVersionInvoker showVerison = new ShowVersionInvoker("Show verison");
            CountSpacesInvoker spacesCount = new CountSpacesInvoker("Count spaces");
            verisonAndSpacesCountSubMenu.AddOptionsToSubMenu(showVerison, spacesCount);

            SubMenu dateAndTimeSubMenu = new SubMenu("Show current date or time ");
            ShowDateInvoker showDate = new ShowDateInvoker("Show date");
            ShowTimeInvoker showTime = new ShowTimeInvoker("Show time");
            dateAndTimeSubMenu.AddOptionsToSubMenu(showDate, showTime);

            mainMenu.AddOptionsToMainMenu(verisonAndSpacesCountSubMenu, dateAndTimeSubMenu);

            mainMenu.Show();
        }

    }
}
