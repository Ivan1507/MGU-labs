using System;
using System.Collections.Generic;
using System.Text;

namespace MGU_labs
{
    class MagazineListHandlerEventArgs:System.EventArgs
    {
        public string Col_Name { get; set; }
        public string Type { get; set; }
        public int Numer { get; set; }
        public MagazineListHandlerEventArgs(string Col,string type,int numer)
        {
            Col_Name = Col;
            Type = type;
            Numer = numer;
        }
        public MagazineListHandlerEventArgs()
        {
            Numer = 2;
        }
        public override string ToString()
        {
            return $"Название-{Col_Name}, Тип-{Type}, Номер элемента-{Numer}";
        }
    }
}
