using KingAOP;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Aop_ILCodeWeaving_KingAop
{
    public class BasketballPlayer : IBasketballPlayer, IDynamicMetaObjectProvider
    {
        public DynamicMetaObject GetMetaObject(Expression parameter)
        {
            return new AspectWeaver(parameter, this);
        }

        [BasketballLoggingAspect]
        public void MakeAssist()
        {           
        }

        [BasketballLoggingAspect]
        public void Shoot(int distance)
        {
            Console.WriteLine("Shoot from distance " + distance);
        }
    }
}
