using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public class MenuActionService
    {
        private List<MenuAction> menuActions;
        public MenuActionService()
        {
            menuActions = new List<MenuAction>();
        }
        public void AddNewAction(int id, string actionName, string menuName)
        {
            MenuAction menuaction = new MenuAction();
            menuActions.Add(menuaction);
        }
        public List<MenuAction> GetMenuActionsByMenuName(string menuName)
        {
            List<MenuAction> result = new List<MenuAction>();
            foreach (var menuAction in menuActions)
            {
                if (menuAction.MenuName == menuName)
                {
                    result.Add(menuAction);
                }
            }
            return result;
        }
    }
}
