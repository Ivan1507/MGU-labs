using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MGU_labs
{
    public class Person:IRateAndCopy
    {
        public enum Freq
        {
            Weekly=1,Montly,Yearly
        }
        public double Rating { get; }
        private string Name { get; set; }
        public string Female { get; set; }
        private DateTime B_day { get; set; }
         
        public Person(string name,string female,DateTime b_day)
        {
            Name = name;
            Female = female;
            B_day = b_day;
        }
        public Person()
        {
            B_day=new DateTime(1575, 3, 5);
        }
        public override string ToString()
        {
            return $"Имя:{Name} Фамилия:{Female} Дата Рождения:{B_day}";
        }
        public virtual string ToShortString()
        {
            return $"Имя:{Name} Фамилия:{Female}";
        }
        public override bool Equals(object obj)
        {
            if (obj == null )
                return false;
            Person p = (Person)obj;
            return p.B_day == B_day && p.Name == Name && p.Female == Female; 
        }
        public override int GetHashCode()
        {
            int hashcode = 0;
            char[] NameChar = Name.ToCharArray();

            foreach (char ch in NameChar)
            {
                hashcode += Convert.ToInt32(ch);
            }
            char[] SurnameChar = Female.ToCharArray();
            foreach (char ch in SurnameChar)
            {
                hashcode += Convert.ToInt32(ch);
            }
            hashcode += B_day.Year * B_day.Month;
            return hashcode;
        }
        public virtual object DeepCopy()
        {
           return new Person(this.Name, this.Female, this.B_day);
        }
    }
}
