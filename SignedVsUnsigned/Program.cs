using System;

namespace SignedVsUnsigned
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("For signed values type 's', for unsigned type 'u'.");
            var userValue = Console.ReadLine().ToLower();

            if (userValue == "s")
            {
                Console.WriteLine($"byte: {SByte.MinValue} - {SByte.MaxValue}");
                Console.WriteLine($"short: {short.MinValue} - {short.MaxValue}");
                Console.WriteLine($"int: {int.MinValue} - {int.MaxValue}");
                Console.WriteLine($"long: {long.MinValue} - {long.MaxValue}");
            }
            if (userValue == "u")
            {
                Console.WriteLine($"byte: {Byte.MinValue} - {Byte.MaxValue}");
                Console.WriteLine($"short: {ushort.MinValue} - {ushort.MaxValue}");
                Console.WriteLine($"int: {uint.MinValue} - {uint.MaxValue}");
                Console.WriteLine($"long: {ulong.MinValue} - {ulong.MaxValue}");
            }
        }
    }
}
