using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitStudBoomer.Strategies
{
    class Laziness : IServices
    {
        void IServices.Action()
        {
            Console.WriteLine("Not today");
        }
    }
}
