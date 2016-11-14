using System;
using System.IO;

namespace websitefactory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            GenerateRandomPage();
        }

        private static void GenerateRandomPage()
        {
            Console.WriteLine("Press any key to generate random html website");
            Console.ReadKey();
            Array values = Enum.GetValues(typeof(WebsiteType));
            Random random = new Random();
            Website website;
            WebsiteType type = (WebsiteType)values.GetValue(random.Next(values.Length));
            website = WebsiteFactory.createWebsite(type);
            string code = pageStart(type) + website.pageCode() + pageEnd();
            Console.WriteLine(code);
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //string mydocpath = Environment.CurrentDirectory;
            File.WriteAllText(@"D:\Szkoła\NJPO" + type.ToString() + ".html", code);
            Console.WriteLine(@"D:\Szkoła\NJPO\" + type.ToString() + ".html");
            Console.ReadKey();
            Console.Clear();
            GenerateRandomPage();
        }

        private static string pageStart(WebsiteType webType)
        {
            return "<html>\n<head>\n<title>" + webType.ToString() + "</title>\n</head>\n<body>\n";
        }

        private static string pageEnd()
        {
            return "\n</body>\n</html>";
        }
    }
}