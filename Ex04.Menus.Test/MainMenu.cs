using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    class MainMenu
    {
        public readonly List<MenuItem> m_MenuItems = new List<MenuItem>();

        public void addNewMenuItem()
        {
            MenuItem employee = new MenuItem("3-4565776");
            employee.m_ReportSickDelegates += new Action<string>();
            m_MenuItems.Add(employee);
        }

    }
}
