namespace ExampleApp
{
    class ExampleClass
    {
        public static void Main()
        {
            //Indicate path to your EFI Application
            string PathToEfiApp = null;
            string[] Arch;
            
            try
            {
                //Reading EFI application bytes and searching architecture
                byte[] data = File.ReadAllBytes(PathToEfiApp);
                switch (BitConverter.ToUInt16(data, BitConverter.ToInt32(data, 0x3c) + 4))
                {
                    case 0x8664: Arch = new string[] { "x64", "AMD x64 Processor" }; break;
                    case 0x0200: Arch = new string[] { "x64", "Intel x64 Processor" }; break;
                    case 0x014c: Arch = new string[] { "ia32", "Intel x32 or i386 Processor" }; break;
                    case 0xaa64: Arch = new string[] { "aa64", "Advanced RISC Machine x64 Processor" }; break;
                }
            }
            catch { }
            
            //Output
            Console.WriteLine("EFI application architecture : {0},", Arch[0]);
            Console.WriteLine(arch[1]);
        }
    }
}
