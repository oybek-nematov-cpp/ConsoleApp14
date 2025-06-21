using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Bird
    {
        public List<int> soni =new List<int> {1, 2, 3, 4, 5 };

        public Bird()
        {
            foreach (int i in soni)
            {
                Console.WriteLine( i);
            }
        }

    }
    
}
