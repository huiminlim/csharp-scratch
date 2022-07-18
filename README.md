# C# Scratchpad

Repository containing code snippets used.

## C# Syntax

### Namespaces

Namespaces can be imported using the `using` keyword.

```csharp
using System;
using System.Linq;
```

A `global using` statement can be used to import namespaces globally.

They can reside in a central separate file, e.g. `GlobalNamespaces.cs`.

```csharp
global using System;
global using System.Linq;
```

### Strings

There are 2 types of strings: literal and verbatim strings.

```csharp
// Literal strings
// \t is interpreted as tab
string fp = "Bob\tHello";       // prints "Bob  Hello"
string fp2 = "Bob\\tHello";     // prints "Bob\tHello"

// Verbatim strings
string fp = @"C:\Users\65844\Desktop\citrus";
```

String printing can be formatted using positional arguments.

```csharp
Console.WriteLine(
    format: "{0} apples costs {1:C}",
    arg0: 12,
    arg1: 0.35);
string s4 = $"{s1} {s2}";
Console.WriteLine($"{s4}");
```

### Numbers

Binary and hexadecimal numbers can be more legible and visible using the `_`.

```csharp
// All numbers are equal
int dec = 2_000_000;
int binary = 0b_0001_1110_1000_0100_1000_0000;
int hex = 0x_001E_8480;
```

Printing of values may be formatted with decimal separator.

```csharp
// :N0 represents decimal separator
Console.WriteLine($"Int max, min: {int.MaxValue:N0}, {int.MinValue}");
```

Casting numbers legally can be done with `System.Convert` or traditional cast. But `System.Convert` does correct rounding instead of truncation.

```csharp
double t1 = 1.23;

// Method 1: traditional cast
int t2 = (int)t1;

// Method 2: easier cast
int t3 = Convert.ToInt32(t2);

Console.WriteLine($"{t1} casted to {t2} / {t3}");
```

### Object and dynamic types

The `object` variable can be used to flexibly define type of the variable.

```csharp
object name = "Bob";
object height = 1.54;
float height2 = Convert.ToSingle(height);  // to convert object to float
```

The `dynamic` keyword can be used to define a dynamic type.

```csharp
dynamic x = "Hello";
x = 12;
x = new[] { 1, 2, 3 };
Console.WriteLine($"Dynamic type containing array x: {x.Length}");
```

### Handling Exceptions

Exceptions can be caught and checked.

```csharp
try
{
    int age = int.Parse("hello");
}
catch (Exception ex)
{
    Console.WriteLine($"{ex.GetType()}: {ex.Message}");
}
```

## OOP

### Namespace

Namespaces may be defined in block style.

```csharp
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, world!");
    }
}
```

In C# 10.0 (targeting .NET 6.0) and above, namespace declaration may be simplified.

```csharp
// Class in this file is in this namespace
namespace OOP.Test;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, world!");
    }
}
```
