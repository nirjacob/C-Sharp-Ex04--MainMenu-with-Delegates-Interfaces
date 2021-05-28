using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    class TestDelegate
    {
       public void Run()
        {
            Console.WriteLine("|Delegate Test|");

            MainMenu mainMenu = new MainMenu("Main Menu");
            ActionMethods actionMethods = new ActionMethods();

            SubMenu verisonAndSpacesCountSubMenu = new SubMenu("Show current verison or count number of spaces in sentence");
            ActionItem showVerison = new ActionItem("Show verison");
            showVerison.ActionChoose+= ActionMethods.showVerison;
            ActionItem spacesCount = new ActionItem("Count spaces");
            spacesCount.ActionChoose += ActionMethods.countSpaces;
            verisonAndSpacesCountSubMenu.AddOptionsToSubMenu(showVerison, spacesCount);

            SubMenu dateAndTimeSubMenu = new SubMenu("Show current date or time ");
            ActionItem showDate = new ActionItem ("Show date");
            showDate.ActionChoose += ActionMethods.showDate;
            ActionItem showTime = new ActionItem("Show time");
            showTime.ActionChoose += ActionMethods.showTime;
            dateAndTimeSubMenu.AddOptionsToSubMenu(showDate, showTime);

            mainMenu.AddOptionsToMainMenu(verisonAndSpacesCountSubMenu, dateAndTimeSubMenu);

            mainMenu.Show();

        }
    }
}
