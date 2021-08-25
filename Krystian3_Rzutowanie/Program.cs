using System;

namespace Krystian3_Rzutowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass nowy_obiekt = new BaseClass();
            DerivedClass drugi_obiekt = (DerivedClass)nowy_obiekt;
            NextDerivedClass trzeci_obiekt = (NextDerivedClass)drugi_obiekt;


        }
    }
}
