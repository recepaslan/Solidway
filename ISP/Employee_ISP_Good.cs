//Code after Implementing Interface Segregation Principle.

namespace ISPDemoConsole
{
    interface IPrintScanContent
    {
        bool PrintContent(string content);
        bool ScanContent(string content);
        bool PhotoCopyContent(string content);
    }

    interface IFaxContent
    {
        bool FaxContent(string content);
    }

    interface IPrintDuplex
    {
        bool PrintDuplexContent(string content);
    }
} 

namespace ISPDemoConsole.Client
{
    class HPLaserJet : IPrintScanContent, IFaxContent, IPrintDuplex
    {
        public bool FaxContent(string content)
        {
            Console.WriteLine("Fax Done"); return true;
        }
        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("PhotoCopy Done"); return true;
        }
        public bool PrintContent(string content)
        {
            Console.WriteLine("Print Done"); return true;
        }
        public bool PrintDuplexContent(string content)
        {
            Console.WriteLine("Print Duplex Done"); return true;
        }
        public bool ScanContent(string content)
        {
            Console.WriteLine("Scan Done"); return true;
        }
    }
}

namespace ISPDemoConsole.Client
{
    class CannonMG2470 : IPrintScanContent
    {
        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("PhotoCopy Done");
            return true;
        }
        public bool PrintContent(string content)
        {
            Console.WriteLine("Print Done");
            return true;
        }
        public bool ScanContent(string content)
        {
            Console.WriteLine("Scan Done");
            return true;
        }
    }
}