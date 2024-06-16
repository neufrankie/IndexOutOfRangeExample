using System;
using System.Collections.Generic;

namespace IndexOutOfRangeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<char> characters = new List<char>();
                characters.InsertRange(0, new char[] { 'a', 'b', 'c', 'd', 'e', 'f' });
                int value = characters[6]; 
                Console.WriteLine($"Gia tri cua phan tu thu 6 la: {value}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Da xay ra loi: " + ex.Message);
            }
            Console.WriteLine("Chuong trinh da ket thuc.");
        }
    }
}
