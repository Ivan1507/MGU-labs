using System;
using System.Collections.Generic;
using System.Text;

namespace MGU_labs
{
    class ListEntry
    {
        public string Name { get; set; }
        public string Name_Event { get; set; }
        public int Number { get; set; }
        public ListEntry(string name,string ne, int number) {
            Name = name;
            Name_Event = ne;
            Number = number;
        }
        public override string ToString()
        {
            return $"Нзв коллекции-{Name}Название события-{Name_Event}Номер элемента-{Number}";
        }
    }
}
