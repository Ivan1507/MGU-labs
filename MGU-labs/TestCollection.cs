using System;
using System.Collections.Generic;
using System.Text;

namespace MGU_labs
{
    class TestCollection
    {
        public List<Edition> editions = new List<Edition>();
        private List<string> strings = new List<string>();
        private Dictionary<Edition, Magazine> Ed_Mag_Dic = new Dictionary<Edition, Magazine>();
        private Dictionary<string, Magazine> str_Mag_dic = new Dictionary<string, Magazine>();
        public static Magazine Rnd(int value)
        {
            Magazine mag = new Magazine();
            mag.Tirzj = value;
            return mag;
        }
        public TestCollection(int value)
        {
            for(int i = 0; i < value; i++)
            {
                editions.Add(new Edition());
                strings.Add("");
                Ed_Mag_Dic.Add(new Edition(), new Magazine());
                str_Mag_dic.Add("", new Magazine());
            }
        }
    }
}
