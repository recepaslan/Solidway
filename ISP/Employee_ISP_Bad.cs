//Code before Interface Segregation Principle. 

namespace ISPDemoConsole
{
    public interface IPrintTasks
    {
        bool PrintContent(string content);
        bool ScanContent(string content);
        bool FaxContent(string content);
        bool PhotoCopyContent(string content);
        bool PrintDuplexContent(string content);
    }
}

namespace ISPDemoConsole.Client
{
    class HPLaserJet : IPrintTasks
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
    class CannonMG2470 : IPrintTasks
    {
        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("PhotoCopy Done"); return true;
        }
        public bool PrintContent(string content)
        {
            Console.WriteLine("Print Done"); return true;
        }
        public bool ScanContent(string content)
        {
            Console.WriteLine("Scan Done"); return true;
        }
        public bool PrintDuplexContent(string content)
        {
            return false;
        }
        public bool FaxContent(string content)
        {
            return false;
        }
     }
}