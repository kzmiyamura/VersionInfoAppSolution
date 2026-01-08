using System;
using System.Reflection;

namespace VersionInfoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var version = assembly.GetName().Version?.ToString() ?? "unknown";
            var infoVersion = assembly
                .GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                ?.InformationalVersion ?? "unknown";

            Console.WriteLine("=== Version Info ===");
            Console.WriteLine($"Assembly Version           : {version}");
            Console.WriteLine($"Assembly InformationalVersion (Git Hash) : {infoVersion}");
        }
    }
}
