using System;

namespace FitStudBoomer.Strategies
{
    class Sport : IServices
    {
        void IServices.Action()
        {
            Console.WriteLine("Let's go in for sports!");
        }
    }
}
