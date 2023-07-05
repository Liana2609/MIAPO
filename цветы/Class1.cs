using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace цветы
{
    //Биктимирова  Лиана
        // класс - сад
        public class Garden
        {
    
            public string Address { get; set; }
            public string Owner { get; set; }
            public List<Flower> Flowers = new List<Flower>();
            public Garden(string ad, string ow)
            {
                Address = ad;
                Owner = ow;
            }
            public void ShowAll()
            {
                Console.WriteLine($"Сад: адрес = {Address},\n владелец = {Owner}");
            }
        }
    //Биктимирова Лиана
    //  класс цветы
    public class Flower : IComparable<Flower>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Flower(string nm, string dsc)
        {
            Title = nm;
            Description = dsc;
        }
        public void Show()
        {
            Console.WriteLine(
                 $"Цветок: название = {Title},\n описание = {Description}");
        }
        public int CompareTo(Flower other)
        {
            if (this.Title.Length > other.Title.Length) return 1; 
            if (this.Title.Length < other.Title.Length) return -1; 
            else return 0;
        }
    }
}
