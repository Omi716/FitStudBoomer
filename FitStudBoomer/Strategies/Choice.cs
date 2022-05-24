using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitStudBoomer.Strategies
{
    class Choice
    {
        private readonly string _name;
        private IServices _services;


        public Choice(string name)
        {
            _name = name;
        }

        public void SetServices(IServices services)
        {
            _services = services;
        }

        public void Step()
        {
            Console.WriteLine(">>>");

            if(_services is null)
            {
                Console.WriteLine($"{_name} choose the next step!");
                return;
            }

            Console.WriteLine("Pick up the card");
            _services.Action();

            
        }
    }
}
