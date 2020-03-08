using System;
using System.Collections.Generic;
using System.Text;

namespace MGU_labs
{
    class Listener
    {
        public List<ListEntry> listEntries = new List<ListEntry>();
        public void MagListHandelr(MagazineListHandlerEventArgs args)
        {
            listEntries.Add(new ListEntry(args.Col_Name, args.Type, args.Numer));
        }
        public override string ToString()
        {
            string str = "";
            foreach(var k in listEntries)
            {
                str+= k.ToString() + "/n";
            }
            return str;
        }
    }
}
