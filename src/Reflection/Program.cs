
using Reflection;
using System.Reflection;

Console.WriteLine("Please choose an option: ");

Type t = typeof(Product);

Assembly executing = Assembly.GetExecutingAssembly();
Type[] types = executing.GetTypes();

#region reflection callinf process

List<Type> childs = types.Where(type => type.IsSubclassOf(t)).ToList();

for (int i = 1; i <= childs.Count; i++)
{
    Console.WriteLine($"{i}) {childs[i - 1].Name}");
}

string choice = Console.ReadLine();

bool found = false;

for(int i = 0; i < childs.Count; i++)
{
    if(choice == childs[i].Name)
    {
        found = true;
        ConstructorInfo constructor = childs[i].GetConstructor(new Type[] { typeof(int), 
            typeof(string), typeof(double) });

        if(constructor is not null)
        {
            object obj = constructor.Invoke(new object[] { 1, "sample product", 1600.00 });
            MethodInfo method = childs[i].GetMethod("GetDiscountedPrice", 
                BindingFlags.Public | BindingFlags.Instance, new Type[] { typeof(double) });

            PropertyInfo property = childs[i].GetProperty("Price");
            object price = property.GetValue(obj);

            Console.WriteLine($"Original price: {price}");
            object result = method.Invoke(obj, new object[] { 20 });
            Console.WriteLine($"Discount price (20% off): {result}");
        }
        break;
    }        
}
Console.WriteLine();
 
if(!found)
{
    Console.WriteLine("Invalid choice");
}

#endregion

#region other reflection calling

foreach(var item in types)
{
    Console.WriteLine();
    Console.WriteLine($"--> Class -->: {item.Name}");
    MethodInfo[] methods = item.GetMethods();
    foreach(var method in methods)
    {
        Console.WriteLine($"-->Method: {method.Name}");
        ParameterInfo[] parameter = method.GetParameters();
        foreach( var param in parameter)
        {
            Console.WriteLine($"--->Parameter: {param.Name}, Type: {param.ParameterType}");
        }
    }
}

#endregion

Console.WriteLine("Completed");