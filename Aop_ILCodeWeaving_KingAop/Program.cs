using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aop_ILCodeWeaving_KingAop
{
    class Program
    {
        static void Main(string[] args)
        {            
            dynamic basketballPlayer = new BasketballPlayer();
            basketballPlayer.Shoot(30);
            basketballPlayer.MakeAssist();
            Console.ReadKey();
        }
    }
}
