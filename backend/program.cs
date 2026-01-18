// See https://aka.ms/new-console-template for more information
using System.Collections.Concurrent;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Reflection;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Serialization;
using System.Text;

Console.WriteLine("Hello, World!");
Console.WriteLine("Меня зовут Беляев В.А.");
Console.WriteLine($"Сейчас: {DateTime.Now}");
Console.Write("Введите имя ");
string Name = Console.ReadLine();
Console.WriteLine($"Привет {Name}");

string day = DateTime.Now.DayOfWeek.ToString();
Console.WriteLine($"Сегодня: {day}");

Console.Write("Хочешь продолжить? (y/n)");
string prod = Console.ReadLine().ToLower();

if (prod=="y" || prod == "yes" || prod == "da")
{
    Console.WriteLine("Продолжим..");
    Console.WriteLine($"Твое имя состоит из {Name.Length} букв");
}
else
{
    Console.WriteLine("Прога заверешна");
}