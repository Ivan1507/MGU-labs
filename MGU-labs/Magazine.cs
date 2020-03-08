using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MGU_labs
{
    class Magazine : Edition
    {
       public delegate void MagListHandler(MagazineListHandlerEventArgs eventArgs);
        public enum Frequency
        {
            Weekly = 1, Monthly, Yearly
        }
        public string Name { get; set; }
        public Frequency Freq { get; set; }
        public List<Person> persons = new List<Person>();
        public DateTime D_out { get; set; }
        public int Tirzj { get; set; }
        public double Sr_armf { get; }

        public List<Article> articles = new List<Article>();
        public bool this[Frequency freq] { get
            {
                return Freq==freq;
            } 
        }
        public IEnumerable<double> GetRang(double d)
        {
            var art = new Article();
            for(int i = 0; i < articles.Count; i++)
            {
                if (art.Rang > d)
                    yield return art.Rang; 
            }
        }
        public Magazine(string name,Frequency freq,DateTime d_out,int tirzj)
        {
            Name = name;
            Freq = freq;
            D_out = d_out;
            Tirzj = tirzj;
    
        }
        public Magazine() 
        {
            Name = "Каждый день"; 
        }
        public void AddArticle(Article article)
        {
            articles.Add(article);
        }
        public override string ToShortString()
        {
            return $"Название журнала:{Name} Дата Выхода {D_out} Частота:{Freq}";
        }
        
        public void ShowArticle()
        {
            foreach(var s in articles)
            {
                Console.WriteLine(s);
            }
        }
        public void AddPerson(params Person[] person)
        {
            persons.AddRange(person);
        }
        public override string ToString()
        {
            return $"{Name}-{Freq}-{D_out}-{Tirzj}";
        }
    }
}
