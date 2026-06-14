
using Reflection;
using System.Reflection;


Console.WriteLine("Please choose an option: ");

//Product product = new Product(2, "Generic Product", 29.99);
//Type type = product.GetType();

//foreach (PropertyInfo pi in type.GetProperties())
//    Console.WriteLine(pi);

Type t = typeof(Product);

Assembly a = Assembly.GetExecutingAssembly();
Type[] types = a.GetTypes();

List<Type> childs = types.Where(type => type.IsSubclassOf(t)).ToList();

for (int i = 1; i <= childs.Count; i++)
{
    Console.WriteLine($"{i}) {childs[i - 1].Name}");
}

//Console.WriteLine("1) Book ");
//Console.WriteLine("2) Camera ");

string choice = Console.ReadLine();

if(choice.Equals("1"))
{
    var book = new Book(1, "C# program", 120.70);
    Console.WriteLine($"Original Price {book.Price}");
    Console.WriteLine($"DiscountedPtice (10% off): {book.GetDiscountedPrice(20)}");
}
else if(choice.Equals("2"))
{
    var camera = new Camera(1, "DSLR Camera", 230.26);
    Console.WriteLine($"Original Price: {camera.Price}");
    Console.WriteLine($"Discount Price: {camera.GetDiscountedPrice(10)}");
}
else
{
    Console.WriteLine("Invalid choice");
}


Console.WriteLine("Completed");