using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using цветы;

namespace цветы_консоль
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Биктимирова Лиана
            Garden gr = new Garden("г. Москва", "Биктимирова Л.Р.");
            gr.ShowAll();

            Flower f1 = new Flower("Глоксиния", "род растений семейства Геснериевые.\n Назван в честь немецкого или эльзасского ботаника и врача Беньямина Петер\n Глоксина.");
            gr.Flowers.Add(f1);

            Flower f2 = new Flower("Ромашка", "род однолетних цветковых растений\n семейства астровые, или сложноцветные, по современной классификаци\nобъединяет около 70 видовневысоких пахучих трав, цветущих с первого год\n жизни.");
            gr.Flowers.Add(f2);

            Flower f3 = new Flower("Роза", "собирательное название видов и сортов\n представителей рода Шиповник, выращиваемых человеком и растущих в дикой\n природе.");
            gr.Flowers.Add(f3);

            Flower f4 = new Flower("Незабудка", "род травянистых растений семейства Бурачниковые. Некоторые виды культивируют в качестве красивоцветущих садовых растений.");
            gr.Flowers.Add(f4);

            Flower f5 = new Flower("Анютины глазки", "травянистое однолетнее или\n двулетнее растение, распространённое в Европе и умеренных областях Азии;\n вид рода Фиалка семейства Фиалковые.");
            gr.Flowers.Add(f5);

            gr.Flowers.Sort();
            foreach (Flower f in gr.Flowers)
            {
                f.Show();
            }

            Console.ReadKey();
        }
    }
}
