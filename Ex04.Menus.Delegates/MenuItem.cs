using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public abstract class MenuItem
    {
        protected string m_ItemText;
        public abstract void Show();
        public int m_CurrentMenuLevel;
        public MenuItem(string i_ItemText)
        {
            m_ItemText = i_ItemText;
        }
        public string ItemText
        {
            get
            {
                return m_ItemText;
            }
            set
            {
                m_ItemText = value;
            }
        }
    }
}
