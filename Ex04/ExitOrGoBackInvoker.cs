using System;
using System.Collections.Generic;
using System.Text;


namespace Ex04.Menus.Interface
{
    class ExitOrGoBackInvoker:MenuItem, IActionItem
    {
        public ExitOrGoBackInvoker(string i_ItemText) : base (i_ItemText)
        {
        }
        public override void Show()
        {
        }
        public void InvokeMethod()
        {
            Show();
        }
    }
}
