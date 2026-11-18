using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library_TrainSet.Intheface
{
    public interface ILocomotiveControl
    {
        void Accelerate(); // газуємо 
        void Brake(); // гальмуємо
    }
}
