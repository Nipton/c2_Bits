namespace c2_Bits
{
    internal class Program
    {
        static void Main()
        {
            Bits bits = new Bits(10);
            Console.WriteLine(bits);
            Console.WriteLine(bits[0]);
            Console.WriteLine(bits[1]);
            Console.WriteLine(bits[2]);
            Console.WriteLine(bits[3]);
            bits[2] = true;
            bits[0] = false;
            Console.WriteLine(bits);
            Console.WriteLine(bits[0]);
            Console.WriteLine(bits[1]);
            Console.WriteLine(bits[2]);
            Console.WriteLine(bits[3]);
            Bits bitsLong = new Bits(6L);
            Bits bitsByte = new Bits((byte)6);
            Console.WriteLine(bitsLong);
            Console.WriteLine(bitsByte);

            long longValue = 600000L;
            int intValue = 20;
            byte byteValue = 10;

            Bits bitsByte2 = byteValue;
            Console.WriteLine(bitsByte2);
            Bits bitsLong2 = longValue;
            Console.WriteLine(bitsLong2);
            Bits bitsInt = intValue;
            Console.WriteLine(bitsInt);
        }
    }
}