using System;

namespace MGU_labs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person("Елена", "Краснушкина", new DateTime(1961, 08, 25));
            //Console.WriteLine(person);
            //Article article = new Article(person, "Красный дом", 56.7);
            //Console.WriteLine(article.ToString());
            //Article article1 = new Article(person, "Djekelbe", 58.9);
            Console.WriteLine("-------------");
            Magazine magazine = new Magazine("123", Magazine.Frequency.Monthly, new DateTime(), 4);
            Magazine mag1 = new Magazine();
            Magazine mag2 = new Magazine("ANya", Magazine.Frequency.Weekly, new DateTime(2018, 03, 08), 7);
            var mag3 = new Magazine("Ivan", Magazine.Frequency.Yearly, new DateTime(2020, 12, 03), 5);
            MagazineCollection magcol = new MagazineCollection();
            magcol.AddMagazines(magazine,mag2);
            var magcol2 = new MagazineCollection();
            magcol2.AddMagazines(mag1, mag3);
            var listener1 = new Listener();
            var listener2 = new Listener();
            magcol.MagazineAdded += listener1.MagListHandelr;
            magcol.MagazineReplaced += listener1.MagListHandelr;
            magcol2.MagazineAdded += listener2.MagListHandelr;
            magcol.AddDefault();
            magcol2.AddMagazines(magazine);
            Console.WriteLine(listener1);







        }
    }
}
