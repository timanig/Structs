using System;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            var carClass = new CarClass();

            carClass.Print();

            CarStruct carStruct;

            carStruct.Print();
        }
    }
}
