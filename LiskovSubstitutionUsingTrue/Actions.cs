using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionUsingTrue
{
    public class Actions
    {
        public interface IBreath
        {             
            void Breath();    
        }

        public interface IBlink
        {
            void Blink();
        }

        public interface IGoWork
        {
            void GoWork();
        }
    }
}
