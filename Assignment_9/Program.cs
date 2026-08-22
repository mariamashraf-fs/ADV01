using Assignment_9.Classes;

namespace Assignment_9;

  internal class Program
  {
    //Q4
     public static void Swap<T>(ref T a, ref T b)
     {
        T temp = a;
        a = b;
        b = temp;
     }

    //Q5
    public static T? FindMax<T>(List<T> items) where T : IComparable<T>
    {
        if (items.Count == 0)
        {
            Console.WriteLine("List is empty.");
            return default;
        }

        T max = items[0];
        foreach (var item in items)
        {
            if (item.CompareTo(max) > 0)
                max = item;
        }
        return max;
    }


    static void Main(string[] args)
        {
        #region Assignment_9

        #region Question_1
        /* Q1: What is a generic class? Why use generics? */

        // Answer ->
        // A generic class is a class that allows us to define type parameter instead of specifying a specific data type.
        // It allows the same class to work with different data types, where the actual data type is specified when the class is used.

        // Why?
        // 1-> Type Safety: Errors are caught at compile time instead of runtime.
        // 2-> Code Reusability: One implementation can work with many different types.
        // 3-> Better Performance: Avoids boxing and unboxing for value types.
        // 4-> Cleaner Code: Reduces code duplication.


        #endregion

        #region Question_2

        /* Q2: Write a generic class Container<T> with Add and Get methods. */

        //Container<int> myContainer = new Container<int>();
        //myContainer.Add(100);
        //myContainer.Add(200);

        //Console.WriteLine($"The value => {myContainer.Get(0)}");
        //Console.WriteLine($"The value => {myContainer.Get(1)}");

        #endregion

        #region Question_3

        /* Q3: What are multiple type parameters? Write Pair<TKey, TValue>. */

        // Answer ->
        // Multiple type parameters allow a generic class or method to work with more than one type parameter
        // at the same time and they are useful when a class or method needs to work with different types.

        //Pair<int, string> myPair = new Pair<int, string>(1, "Mariam");

        //Console.WriteLine($"Key => {myPair.Key}");
        //Console.WriteLine($"Value => {myPair.Value}");

        #endregion

        #region Question_4

        /* Q4: What is a generic method? Write Swap<T> method. */

        // Answer ->
        // A generic method is a method that has its own type parameter, separate from the class.
        // This lets one method work with different data types without rewriting it for each type, and the type T is
        // only decided when the method is called.

        //int x = 10;
        //int y = 20;

        //Console.WriteLine($"Before Swap -> X: {x}, Y: {y}");

        //Swap(ref x, ref y);

        //Console.WriteLine($"After Swap -> X: {x}, Y: {y}");

        #endregion

        #region Question_5

        /* Q5: Write a generic method FindMax<T> that finds maximum value */

        //Console.Write("How many numbers do you want to enter? ");
        //int count;
        //while (!int.TryParse(Console.ReadLine(), out count) || count <= 0)
        //{
        //    Console.Write("Please enter a valid positive number: ");
        //}

        //List<int> numbers = new List<int>();

        //for (int i = 0; i < count; i++)
        //{
        //    Console.Write($"Enter number {i + 1}: ");
        //    int num;
        //    while (!int.TryParse(Console.ReadLine(), out num))
        //    {
        //        Console.Write("Please enter a valid number: ");
        //    }
        //    numbers.Add(num);
        //}

        //Console.WriteLine($"Max => {FindMax(numbers)}");


        #endregion

        #region Question_6

        /* Q6: What is a generic interface? Write IRepository<T>. */

        // Answer ->
        // A generic interface is an interface that uses a type parameter <T> instead of a specific type.
        // Any class that implements it can choose its own type.


        #endregion

        #region Question_7

        /* Q7: What is the 'struct' constraint? Write an example. */

        // Answer ->
        // The "where T : struct" constraint forces T to be a value type only and it cannot be a reference type like string or a class.

        //StructConstraintExample<int> example1 = new StructConstraintExample<int>();
        //example1.Value = 10;
        //Console.WriteLine($"Value => {example1.Value}");

        //StructConstraintExample<string> example2 = new StructConstraintExample<string>();
        // This compile error, because string is a reference type, not a struct.

        #endregion

        #endregion
    }
}
