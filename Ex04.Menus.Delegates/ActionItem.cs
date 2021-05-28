using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class ActionItem : MenuItem
    {
        public event MethodToInvoke ActionChoose;
        public delegate void MethodToInvoke();
        public ActionItem(string i_NameItem) : base(i_NameItem)
        {
        }
        protected virtual void InvokeItemAction()
        {
            if (ActionChoose != null)
            {
                ActionChoose.Invoke();
            }
        }
        public override void Show()
        {
            Console.Clear();
            InvokeItemAction();

        }
    }
}
