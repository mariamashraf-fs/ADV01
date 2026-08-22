using Assignment_9.Classes;

namespace Assignment_9;

  internal class Program
  {
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

        #endregion
    }
}
