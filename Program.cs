using Arrays.Array;
using Microsoft.VisualBasic;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace Arrays
{
    public class Program
    {

        public static void ShiftArray(string[] arr1)
        {
            for (int i = arr1.Length - 2; i >= 0; i--)
            {
                arr1[i + 1] = arr1[i];
            }
        }
        static void Main(string[] args)
        {
            StaticArray<int> array = new StaticArray<int>(10);
            
            array.InsertLast(1);
            array.InsertFirst(2);
            array.InsertAtIndex(1, 3);
            Console.WriteLine("Static array");
            Console.WriteLine("Count: " + array.Count);
            Console.WriteLine("Data at index 1: " + array.GetData(1));
            Console.WriteLine("Data at index 2: " + array.GetData(2));
            Console.WriteLine("Deleted item: " + array.DeleteLast());
            Console.WriteLine("Count: " + array.Count);
            Console.WriteLine("Deleted item: " + array.Delete(0));
            Console.WriteLine("Count: " + array.Count);
            Console.WriteLine();

            DynamicArray<int> numbers = new DynamicArray<int>();

            numbers.InsertLast(10);
            numbers.InsertFirst(20);
            numbers.InsertAtIndex(1, 30);
            Console.WriteLine("Dynamic array");
            Console.WriteLine("Count: " + numbers.Count);
            Console.WriteLine("Data at index 1: " + numbers.GetData(1));
            Console.WriteLine("Data at index 2: " + numbers.GetData(2));
            Console.WriteLine("Deleted item: " + numbers.DeleteLast());
            Console.WriteLine("Count: " + numbers.Count);
            Console.WriteLine("Deleted item: " + numbers.Delete(0));
            Console.WriteLine("Count: " + numbers.Count);

            Console.ReadKey();

        }
    }
}