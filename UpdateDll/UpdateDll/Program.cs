using System.IO;

namespace TOCTOU
{
    class Program
    {
        static void Main(string[] args)
        {
            const string validSignature = "X6hsu623JHDsjxks893y98hdsjkh983hklsjjSJAiu";
            string signature;

            StreamReader file = new StreamReader(@"dir1\signedDll.dll");
            signature = file.ReadLine();
            file.Close();

            if (signature == validSignature)
                File.Copy(@"dir1\signedDll.dll", @"dir2\signedDll.dll", true);
        }
    }
}