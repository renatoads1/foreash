using System;

namespace foreashlendoarray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("for");
            string[] vet = new string[] {"Renato","Isabela","Julia" };
            for (int i = 0; i < vet.Length; i++) {
                Console.WriteLine(vet[i]);
            }
            Console.WriteLine("foreash");
            foreach (string obj in vet) {
                Console.WriteLine(obj);
            }
        }
    }
}
