using System;
using System.Collections.Generic;
using System.Text;

namespace MGU_labs
{
    class Article:Person,IRateAndCopy,IComparable,IComparer<Article>
    {
        public Person Person { get; set; }
        public string Name { get; set; }
        public double Rang { get; set; }
        public Article(Person person,string name,double rang)
        {
            Person = person;
            Name = name;
            Rang = rang;
        }
        public Article()
        {
             
        }
        public override string ToString()
        {
            return $"{Person} название статьи:{Name} рейтинг:{Rang}";
        }
        public override object DeepCopy()
        {
            return new Article(this.Person, this.Name,this.Rang);
        }

        public int CompareTo(object obj)
        {
            var k = obj as Article;
            return Name.CompareTo(k.Name);
        }

        int IComparer<Article>.Compare(Article x, Article y)
        {
            return x.Person.Female.CompareTo(y.Person.Female);
        }
    }
}
