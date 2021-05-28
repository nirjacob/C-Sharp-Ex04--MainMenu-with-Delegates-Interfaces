using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interface;

namespace Ex04.Menus.Test
{
    class ShowVersionInvoker : MenuItem, IActionItem
    {
        public ShowVersionInvoker(string i_ItemText) : base(i_ItemText)
        {
        }
        public void InvokeMethod()
        {
            Show();
        }
        public override void Show()
        {
            ActionMethods.showVerison();

        }
    }
}
