public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    public static implicit operator int(MyClass obj)
    {
        return obj.MyProperty;
    }

    public static implicit operator MyClass(int value)
    {
        return new MyClass(value);
    }

    // Add operator overloading for other operations as needed
    public static MyClass operator +(MyClass a, MyClass b)
    {
        return new MyClass(a.MyProperty + b.MyProperty);
    }
    public static MyClass operator +(MyClass a, int b)
    {
        return new MyClass(a.MyProperty + b);
    }
    public static MyClass operator +(int a, MyClass b)
    {
        return new MyClass(a + b.MyProperty);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        MyClass obj1 = 10; 
        int value1 = obj1; 
        Console.WriteLine(value1); // Output: 10

        MyClass obj2 = new MyClass(20);
        int value2 = obj2 + 5; 
        Console.WriteLine(value2); // Output: 25

        MyClass obj3 = obj2 + 5; 
        Console.WriteLine(obj3.MyProperty); // Output: 25

        int value3 = 5 + obj2; 
        Console.WriteLine(value3); //Output: 25

        MyClass obj4 = new MyClass(10);
        MyClass obj5 = new MyClass(5);
        MyClass obj6 = obj4 + obj5;
        Console.WriteLine(obj6.MyProperty); //Output: 15
    }
}
