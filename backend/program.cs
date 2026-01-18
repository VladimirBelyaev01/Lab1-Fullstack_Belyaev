// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Serialization;
using System.Text;

Console.WriteLine("Hello, World!");
Console.WriteLine("Меня зовут Беляев В.А.");
Console.WriteLine($"Сейчас: {DateTime.Now}");
Console.Write("Введите имя ");
string Name = Console.ReadLine();
Console.WriteLine($"Привет {Name}");