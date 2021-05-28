using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    class MenuItem
    {
        private string m_ItemText;
        private int level;
        bool m_IsClicked = false;

        /// holding a reference to the pre-defined Action<T> delegate, definining it to be an Action<string>
        /// which makes it a delegate void Action(string s)
        public event Action<string> m_ReportSickDelegates;

        public MenuItem(string i_ItemExt)
        {
            this.m_ItemText = i_ItemExt;
        }
        private void doWhenClicked()
        {
            m_IsClicked = true;
            notifyClicked();
        }

        private void notifyClicked()
        {
            if (m_ReportSickDelegates != null)
            {
                m_ReportSickDelegates.Invoke(m_ItemText);
            }
        }
    }
}
