using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Menu
    {

        private List<MenuItem> menuItems = new List<MenuItem>();
        private DateTime lastUpdated;

        public List<MenuItem> MenuItems { get; }

        public void AddItem(MenuItem item)
        {
            //TODO: this doesn't work. Fix it
            menuItems.Add(item);
            lastUpdated = DateTime.Now.Date;
        }

        public DateTime LastUpdated { get; }

    }
}
