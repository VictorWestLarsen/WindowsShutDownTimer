using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SmartMenuLibrary
{
    public class Bindings
    {
        private Dictionary<string, Action> commands;
        public Bindings ()
        {
            commands = new Dictionary<string, Action>();

        }
        public void bind(string menuID, Action action)
        {
            commands[menuID] = action;
        }
        public void Call(String menuId)
        {
            Action v = commands[menuId];
            v();
        }
    }
}
