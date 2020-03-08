using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MGU_labs
{
    class MagazineCollection:Magazine, IEnumerable
    {
        public event MagListHandler MagazineAdded;
        public event MagListHandler MagazineReplaced;
        public string Name_of_Col { get; set; }
        private List<Magazine> Magazines=new List<Magazine>();
        public double Max_sr
        {
            get
            {
                var k=Magazines.Max(x=>x.Tirzj);
                return Convert.ToDouble(k);
            }
        }
        public IEnumerable<Magazine> Monty
        {
            get
            {
                IEnumerable<Magazine> k = Magazines.Where(x => x.Freq == Frequency.Monthly);
                return k;
            }
        }
        public void AddDefault()
        {
            Magazines.Add(new Magazine());
            MagazineAdded(new MagazineListHandlerEventArgs(this.Name_of_Col, "Коллекция добавлена", Magazines.Count - 1));
        }
        public void AddMagazines(params Magazine[] magazines)
        {
            Magazines.AddRange(magazines);
            MagazineAdded(new MagazineListHandlerEventArgs(this.Name_of_Col,"Коллекция добавлена",Magazines.Count-1));
        }
        public override string ToString()
        {
            return $"Журнал:{Magazines} Редакторы:{persons} Статьи:{articles} Оценка:{Sr_armf}";
        }
        public override string ToShortString()
        {
            return $"Журнал:{Magazines} Оценка:{Sr_armf} Тираж:{Tirzj}";
        }
        public void SortByName()
        {
            Magazines.Sort((x, y) => x.Name.CompareTo(y.Name));
        }
        public void SortbyD_out()
        {
            Magazines.Sort((x, y) => x.D_out.CompareTo(y.D_out));
        }
        public void SortbyTir()
        {
            Magazines.Sort((x, y) => x.Tirzj.CompareTo(y.Tirzj));
        }
        public bool Replace(int j,Magazine mg)
        {
            if (j <= Magazines.Count)
            {
                Magazines.RemoveAt(j);
                Magazines.Insert(j, mg);
                MagazineReplaced(new MagazineListHandlerEventArgs(this.Name_of_Col, "Элемент коллекции заменен", Magazines.Count - 1));
                return true;
            }
            else return false;
        }
        public Magazine this[int index]
        {
            get
            {
                return Magazines[index];
            }
            set
            {
                Magazines[index]= value;
                MagazineReplaced(new MagazineListHandlerEventArgs(this.Name_of_Col, "Элемент коллекции заменен", Magazines.Count - 1));
            }
        }
        public List<Magazine> RatingGroup(int value)
        {
            IEnumerable<IGrouping<int, Magazine>> sort = Magazines.GroupBy(x=>x.persons.Count);

            foreach(IGrouping<int,Magazine> ter in sort)
            {
                if (ter.Key == value)
                {
                    return ter.ToList<Magazine>();
                }

            }
            return null;
            
        }

        public IEnumerator GetEnumerator()
        {
            return Magazines.GetEnumerator();
        }
    }
}
