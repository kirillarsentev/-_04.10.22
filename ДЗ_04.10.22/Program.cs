using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_04._10._22
{

    public class Boris { }
    class Rashid : Boris { } //finance director
    class Lukas : Rashid { }
    class Buh : Lukas { }
    class OIlham : Boris { } // automatisation director
    class Orcadiy : OIlham { }
    class Volodya : Orcadiy { }
    class Ilshat : Volodya { } // system
    class Ivanich : Ilshat { }
    class Ilya : Ivanich { }
    class Vitya : Ivanich { }
    class Jeka : Ivanich { }
    class Sergey : Volodya { }// development
    class Lyaisan : Sergey { }
    class Marat : Lyaisan { }
    class Dina : Lyaisan { }
    class Ildar : Lyaisan { }
    class Anton : Lyaisan { }
    internal class Program
    {
        static void Otvet(Type a,Type b)
        {
            if (b.IsSubclassOf(a)) { Console.WriteLine("Yes"); } // проверяем является ли классы наследниками друг друга
            else { Console.WriteLine("No"); }
            //Boris boris = a as b;
            //if(boris != null)
            //{
            //    Console.WriteLine("ДА");

            //}
            // else
            //{
            //    Console.WriteLine("НЕТ");
            //}
        }
        static void Main(string[] args)
        {
            string a = Console.ReadLine(); 
            string b = Console.ReadLine();
            Type A = Type.GetType("ДЗ_04._10._22" + "." + a, false, true);
            Type B = Type.GetType("ДЗ_04._10._22" + "." + b, false, true);   
            Otvet(B,A);


        }
    }
}
