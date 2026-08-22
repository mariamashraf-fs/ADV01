using Assignment_9.Classes;
using Assignment_9.Interfaces;

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

        #region Question_8

        /* Q8: What is the 'class' constraint? Write an example. */

        // Answer ->
        // The "where T : class" constraint forces T to be a reference type only and it cannot be a value type like int.

        //ClassConstraintExample<string> example1 = new ClassConstraintExample<string>();
        //example1.Value = "Mariam";
        //Console.WriteLine($"Value => {example1.Value}");

        //ClassConstraintExample<int> example2 = new ClassConstraintExample<int>();
        // This compile error, because int is a value type, not a class.

        #endregion

        #region Question_9

        /* Q9: What is the 'new()' constraint? Write an example. */

        // Answer ->
        // The "where T : new()" constraint requires T to have a parameterless constructor, so we can create a new instance
        // of T inside the generic class using "new T()".

        //Factory<Container<int>> factory = new Factory<Container<int>>();
        //Container<int> newContainer = factory.Create();

        //newContainer.Add(100);
        //newContainer.Add(300);
        //Console.WriteLine($"Created container, value inside => {newContainer.Get(0)}");
        //Console.WriteLine($"Created container, value inside => {newContainer.Get(1)}");

        #endregion

        #region Question_10

        /* Q10: What is the interface constraint? Write an example. */

        // Answer ->
        // An interface constraint (where T : ISomeInterface) forces T to implement that interface, so the generic code
        // can safely call the interface's methods on T.

        //Console.Write("Enter first number: ");
        //int a;
        //while (!int.TryParse(Console.ReadLine(), out a))
        //{
        //    Console.Write("Invalid number! Enter first number: ");
        //}

        //Console.Write("Enter second number: ");
        //int b;
        //while (!int.TryParse(Console.ReadLine(), out b))
        //{
        //    Console.Write("Invalid number! Enter second number: ");
        //}

        //InterfaceConstraintExample<int> example = new InterfaceConstraintExample<int>();
        //Console.WriteLine($"Is {a} greater than {b}? => {example.IsGreater(a, b)}");

        #endregion

        #region Question_11

        /* Q11: What is the base class constraint? Write an example. */

        // Answer ->
        // A base class constraint (where T : SomeBaseClass) forces T to be that class or a class derived from it,
        // so the generic code can use members inherited from that base class.

        //Animal animal1 = new Animal { Name = "Cat" };

        //BaseClassConstraintExample<Animal> example = new BaseClassConstraintExample<Animal>();
        //example.Speak(animal1);

        #endregion

        #region Question_12

        /* Q12: How do you apply multiple constraints? Write an example. */

        // Answer ->
        // You list multiple constraints after a single "where", separated by commas.
        // Order rule: class/struct constraint (if any) first, then interfaces, and new() must always come last.

        //Animal cat = new Animal { Name = "Cat", Age = 3 };
        //Animal dog = new Animal { Name = "Dog", Age = 5 };

        //MultipleConstraintsExample<Animal> example = new MultipleConstraintsExample<Animal>();

        //Console.WriteLine($"Is {dog.Name} bigger than {cat.Name}? => {example.IsBigger(dog, cat)}");

        //Animal newAnimal = example.CreateDefaultAnimal();
        //Console.WriteLine($"Created default animal => Name: '{newAnimal.Name}', Age: {newAnimal.Age}");

        #endregion

        #region Question_13
        /* Q13: What does the 'default' keyword do in generics? */

        // Answer ->
        // "default" returns the default value of type T:
        // - 0 / false / '\0' for value types (int, bool, char...)
        // - null for reference types (string, custom classes...)
        // It's used when we don't know if T is a value type or reference type at compile time.

        //Console.WriteLine($"Default int => {default(int)}");
        //Console.WriteLine($"Default bool => {default(bool)}");
        //Console.WriteLine($"Default string => '{default(string)}'");

        #endregion

        #region Question_14

        /* Q14: Write a SafeList<T> that returns default when the index is invalid. */

        //SafeList<string> safeList = new SafeList<string>();
        //safeList.Add("Mariam");
        //safeList.Add("Ali");

        //Console.WriteLine($"Valid index (0) => {safeList.GetAt(0)}");
        //Console.WriteLine($"Invalid index (10) => {safeList.GetAt(10) ?? "null (default)"}");

        #endregion

        #region Question_15

        /* Q15: What is covariance? Explain the 'out' keyword. */

        // Answer ->
        // Covariance lets you use a more derived type than originally specified,
        // example: assign IProducer<Dog> to a variable of type IProducer<Animal>.
        // Marked with "out" on the type parameter, meaning T can only appear in output positions (return values) —
        // never as a method parameter.

        //IProducer<Dog> dogProducer = new DogProducer();
        //IProducer<Animal> animalProducer = dogProducer;

        //Animal result = animalProducer.Produce();
        //Console.WriteLine($"Produced => {result.Name}");


        #endregion

        #region Question_16

        /* Q16: What is contravariance? Explain the 'in' keyword. */

        // Answer ->
        // Contravariance lets you use a less specific (more general) type than originally specified.
        // Marked with "in" on the type parameter, meaning T can only appear in input positions (method parameters),
        // never as a return type.

        //IPrinter<object> generalPrinter = new DocumentPrinter();
        //IPrinter<string> stringPrinter = generalPrinter;

        //stringPrinter.Print("Hello Mariam");

        #endregion

        #region Question_17

        /* Q17: What is the difference between covariance and contravariance? */

        // Answer ->
        // Covariance (out): allows using a more derived type (Derived -> Base direction),
        // used for types that only PRODUCE/return T.

        // Contravariance (in): allows using a less derived type (Base -> Derived direction),
        // used for types that only CONSUME/accept T as a parameter.
        // In short: "out" = safe to widen the return type, "in" = safe to widen the parameter type.

        #endregion

        #region Question_18

        /* Q18: How do static members work in generic types? */

        // Answer ->
        // Each closed generic type gets its own static members. For example, if you have a generic class MyClass<T>,
        // then MyClass<int> and MyClass<string> will each have their own independent copy of static members.
        // They are NOT shared across different T's.

        //new Counter<int>();
        //new Counter<int>();
        //new Counter<string>();

        //Console.WriteLine($"Counter<int>.Count => {Counter<int>.Count}");
        //Console.WriteLine($"Counter<string>.Count => {Counter<string>.Count}");

        #endregion

        #region Question_19

        /* Q19: How can you inherit from a generic class? */

        // Answer ->
        // There are two ways to inherit from a generic class:
        // 1) Close the generic type with a specific type (non-generic subclass).
        // 2) Keep the subclass generic too, passing its own type parameter through.

        //StringContainer sc = new StringContainer();
        //sc.Add("Hello");
        //Console.WriteLine($"StringContainer => {sc.Get(0)}");

        //LoggingContainer<int> lc = new LoggingContainer<int>();
        //lc.Add(42);
        //Console.WriteLine($"LoggingContainer => {lc.Get(0)}");

        #endregion


        #endregion
    }
}
