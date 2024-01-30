using System;

namespace MethodInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            IlkClass oIlkClass = new IlkClass();
            IkinciClass oIkinciClass = new IkinciClass();
            oIkinciClass.MesajiGoster(oIlkClass, "İkinci class'tan mesaj");
            Console.ReadLine();
        }
    }
}