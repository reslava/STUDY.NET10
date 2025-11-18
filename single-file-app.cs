/*
https://dev.to/cristiansifuentes/new-features-in-net-10-c-14-the-experts-playbook-2025-2pe5#whats-new-in-c-14
*/

Console.WriteLine("Hello");
Console.WriteLine("".IsEmpty);
Console.WriteLine("Test".AddPipes());
Console.WriteLine(String.Combine("aaa", "bbb"));
Console.WriteLine("aaa" | "bbb");
var g = new Guitar {Name = "Yamaha", Price= -6};

Console.WriteLine(g.Price);

// Null conditionals in objects
Guitar gFender = null;
gFender?.Price = 10000;
Console.WriteLine("no hay error");
// C#14 .NET10 LTS

Console.WriteLine(nameof(List<>)); // nameof for generics
// New Extensions syntax
public static class StringExtensions
{
  extension (string source)
  {
    public bool IsEmpty => source.Length == 0; // Property
    public string AddPipes() => $"|{source}|"; // Method
  }     
  extension (string)
  {
    public static string Combine(string a, string b) => a + b;
    public static string operator|(string a, string b) => a + "|" + b; // Operator
  }  
}

public class Guitar
{
  public string Name { get; set; }
  public int Price { get; set => field = value < 0 ? 0 : value; } // field
}