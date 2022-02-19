using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LiskovSubstitutionUsingTrue.Actions;

namespace LiskovSubstitutionUsingTrue
{
   public class Person
    {
        public class Baby : IBreath , IBlink
        {
            public void Blink()
            {
                Console.WriteLine("Blinked");
            }

            public void Breath()
            {
                Console.WriteLine("Get Breath");
            }
        }

        public class Young : IBreath, IBlink,IGoWork
        {
            public void Blink()
            {
                Console.WriteLine("Blinked");
            }

            public void Breath()
            {
                Console.WriteLine("Get Breath");
            }

            public void GoWork()
            {
                Console.WriteLine("Go Work");
            }
        }

        public class Adult : IBreath, IBlink, IGoWork
        {
            public void Blink()
            {
                Console.WriteLine("Blinked");
            }

            public void Breath()
            {
                Console.WriteLine("Get Breath");
            }

            public void GoWork()
            {
                Console.WriteLine("Go Work");
            }
        }


    }
}
