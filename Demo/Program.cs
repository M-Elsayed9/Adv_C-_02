using System.Collections;
using System.Globalization;

namespace Demo
{
    internal class Program
    {
        public static int SumList(List<int> List)
        {
            if (List is null)
            {
                return 0;
            }

            int sum = 0;
            for (int i = 0; i < List.Count; i++)
            {
                sum += List[i];
            }

            return sum;
        }
        public static int SumArrayList(ArrayList arrayList)
        {
            if(arrayList is null)
            {
                return 0;
            }

            int sum = 0;
            for(int i = 0; i < arrayList.Count; i++)
            {
                if (arrayList[i] is int value) // alternative solution if the list is hetrogenous
                    sum += value;
                //if (arrayList[i] is int)
                //    sum += (int)arrayList[i]; // cast from object to int
                // unboxing, unsafe 
            }

            //foreach (int Num in arrayList)
            //{
            //    sum += Num;

            //}
            return sum;
        }
        static void Main(string[] args)
        {
            #region Non-Generic Collections
            //ArrayList arrayList = new ArrayList();
            ////arraylist => size is dynamic default is 0

            //Console.WriteLine($"Count: {arrayList.Count}, Capacity of arraylist = {arrayList.Capacity}");

            //arrayList.Add(1);
            //// create a new array of size 4 in the heap (default size)


            //Console.WriteLine($"Count: {arrayList.Count}, Capacity of arraylist = {arrayList.Capacity}");
            //arrayList.Add(2);

            //Console.WriteLine($"Count: {arrayList.Count}, Capacity of arraylist = {arrayList.Capacity}");

            //arrayList.AddRange(new int[] { 3, 4, 5, 6, 7, 8, 9, 10 });
            //Console.WriteLine($"Count: {arrayList.Count}, Capacity of arraylist = {arrayList.Capacity}");
            //// create a new array at heap with double size of old array
            //// copy all elements from old array to new array
            //// old array is deleted from heap

            //ArrayList arrayList2 = new ArrayList(100); // size of arraylist is 100
            //ArrayList arrayList3 = new ArrayList(arrayList); // copy all elements from arrayList to arrayList3

            //ArrayList arrayList = new ArrayList(5) { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"Count: {arrayList.Count}, Capacity of arraylist = {arrayList.Capacity}");

            //arrayList.Add(6);
            //// create a new array of size 10 in the heap double of old size

            //// 10 - 6 = 4 elements can be added without creating a new array
            //// 16 unused bytes in the array

            //arrayList.TrimToSize(); // remove unused bytes from array (Deallocate)
            //// create a new array of size 6 in the heap (== to the count of the arraylist)
            //// copy all elements from old array to new array
            //// old array is deleted from heap (unreachable object) will be deleted by the garbage collection

            //Console.WriteLine($"Count: {arrayList.Count}, Capacity of arraylist = {arrayList.Capacity}");

            //arrayList.Add(1); // Casting (1) Value Type to Reference Type (Object)

            ////arrayList.Add("Hello"); // Casting ("Hello") Reference Type to Reference Type (Object)
            //// Hetrogeneous collection

            ////foreach (int item in arrayList) // invalid cast exception
            ////{
            ////    Console.WriteLine(item);
            ////}

            //foreach (object item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(SumArrayList(arrayList));

            //Hashtable hashtable = new Hashtable();
            //hashtable.Add(1, "One");
            //hashtable.Add(2, "Two");
            //hashtable.Add(3, "Three");
            //hashtable.Add(4, "Four");
            //hashtable.Add(5, "Five");

            ////hashtable.Add(1, "One"); // ArgumentException: An item with the same key has already been added. Key: 1
            //// hashtables do not allow duplicate keys

            //hashtable[1] = "One";
            // if key exists, update the value

            // if key does not exist, add the key-value pair

            //hashtable.Add("One", 1); // ArgumentException: The value must be of type 'System.String'. Parameter name: value
            // hashtable keys must be of the same type

            #endregion

            #region Generic Collections
            //List<int> Numbers = new List<int>();
            //Console.WriteLine($"Count: {Numbers.Count}, Capacity of Numbers = {Numbers.Capacity}");
            //// default capacity is 0 without adding any elements 

            //Numbers.Add(1);
            //// default capacity after adding 1 element is 4 

            //Numbers.AddRange(new int[] { 3,4 });
            //Console.WriteLine($"Count: {Numbers.Count}, Capacity of Numbers = {Numbers.Capacity}");

            //Numbers.Add(5);
            //Console.WriteLine("After Adding 5th Element");
            ////Create a new array double the size of the old array

            //// 8-5 = 3 * 4 [int] = 12 bytes [Unused bytes]

            //Numbers.TrimExcess(); // delete unused bytes
            //Console.WriteLine($"Count: {Numbers.Count}, Capacity of Numbers = {Numbers.Capacity}");
            // after trim

            //List<int> Nums = new List<int>(5) { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"Count: {Nums.Count}, Capacity of Numbers = {Nums.Capacity}");

            //Nums.Add(6);
            //Console.WriteLine($"Count: {Nums.Count}, Capacity of Numbers = {Nums.Capacity}");
            // create a new array of size 10 in the heap double of old size

            //foreach(int Num in Nums)
            //{
            //    Console.WriteLine(Num);
            //}

            //for(int i = 0;i < Nums.Count;i++)
            //{
            //    Console.WriteLine(Nums[i]);
            //}

            //Nums[3] = 40;

            //for(int i = 0; i < Nums.Count; i++)
            //{
            //    Console.WriteLine(Nums[i]);
            //}

            //Nums[6] = 100; // ArgumentOutOfRangeException: Index was out of range. Must be non-negative and less than the size of the collection.
            
            //Nums.Insert(3, 4);

            //int Result = SumList(Nums);
            //Console.WriteLine(Result);

            // Nums.Add("Aliaa"); // Compile Time Error: 
            #endregion
        }
    }
}
