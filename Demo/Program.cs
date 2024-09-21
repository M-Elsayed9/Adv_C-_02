using System.Collections;

namespace Demo
{
    internal class Program
    {

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

            ArrayList arrayList = new ArrayList(5) { 1, 2, 3, 4, 5 };
            Console.WriteLine($"Count: {arrayList.Count}, Capacity of arraylist = {arrayList.Capacity}");

            arrayList.Add(6);
            // create a new array of size 10 in the heap double of old size

            // 10 - 6 = 4 elements can be added without creating a new array
            // 16 unused bytes in the array

            arrayList.TrimToSize(); // remove unused bytes from array (Deallocate)
            // create a new array of size 6 in the heap (== to the count of the arraylist)
            // copy all elements from old array to new array
            // old array is deleted from heap (unreachable object) will be deleted by the garbage collection

            Console.WriteLine($"Count: {arrayList.Count}, Capacity of arraylist = {arrayList.Capacity}");

            arrayList.Add(1); // Casting (1) Value Type to Reference Type (Object)

            //arrayList.Add("Hello"); // Casting ("Hello") Reference Type to Reference Type (Object)
            // Hetrogeneous collection

            //foreach (int item in arrayList) // invalid cast exception
            //{
            //    Console.WriteLine(item);
            //}

            foreach (object item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(SumArrayList(arrayList));
            #endregion
        }
    }
}
