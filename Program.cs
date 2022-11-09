using System;

namespace publicAndpribate
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector3 V1 = new Vector3();
            V1.SetX(3.4f);
            V1.SetY(3.2f);
            V1.SetZ(5.2f);
            Console.WriteLine(V1.Length());
        }
    }
}
