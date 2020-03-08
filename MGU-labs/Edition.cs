using System;
using System.Collections.Generic;
using System.Text;

namespace MGU_labs
{
  class Edition:IComparable,IComparer<Edition>
    {
        public string Names { get; set; }
        protected DateTime Date_out { get; set; }
        public int Num;
        protected int Nu { 
            get
            {
                return Num;
            }
            set
            {
                if (value < 0) throw new Exception("Номер Тиража не может быть меньше нуля");
                else Num = value;
            }
        }
        public Edition(string name,DateTime date_out,int num)
        {
            Names = name;
            Date_out = date_out;
            Num = num;
            Nu = num;
        }
        public Edition() : this("Первомайское", new DateTime(), 54)
        {

        }
        public override string ToString()
        {
            return $"Название:{Names} Дата выхода:{Date_out} Номер тиража:{Num}";
        }
        public virtual string ToShortString()
        {
            return $"Название:{Names} Номер тиража:{Nu}";
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Edition ed = new Edition();
            if (ed == null) return false;
            else return ed.Names == Names && ed.Date_out == Date_out && ed.Nu == Nu;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

       public int CompareTo(object obj)
        {
            Edition art=obj as Edition;
            if (obj == null) Console.WriteLine("Пусто");
            return Names.CompareTo(art.Names);
        }

        int IComparer<Edition>.Compare(Edition x, Edition y)
        {
            return x.Date_out.CompareTo(y.Date_out);
        }
    }
}
