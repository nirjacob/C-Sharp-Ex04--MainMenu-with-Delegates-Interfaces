using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interface;

namespace Ex04.Menus.Test
{
    class CountSpacesInvoker : MenuItem, IActionItem
    {
        public CountSpacesInvoker(string i_ItemText) : base(i_ItemText)
        {
        }
        public void InvokeMethod()
        {
            Show();
        }
        public override void Show()
        {
            ActionMethods.countSpaces();

        }
    }
}
