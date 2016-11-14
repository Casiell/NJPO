using System;

namespace websitefactory
{
    internal class Contacts : Website
    {
        public string htmlCode;
        private Random rand;

        public Contacts()
        {
            rand = new Random();
            int howmuch = rand.Next(10);
            htmlCode = "";
            for (int i = 1; i <= howmuch; i++)
            {
                htmlCode += NameAndSurname() + " - " + PhoneNumber().ToString() + Environment.NewLine;
            }
        }

        public string pageCode()
        {
            return htmlCode;
        }

        private string NameAndSurname()
        {
            Array values = Enum.GetValues(typeof(Names));
            Names name = (Names)values.GetValue(rand.Next(values.Length));

            values = Enum.GetValues(typeof(Surnames));
            Surnames surname = (Surnames)values.GetValue(rand.Next(values.Length));

            return name.ToString() + " " + surname.ToString();
        }

        private int PhoneNumber()
        {
            return rand.Next(100000000, 999999999);
        }
    }

    internal enum Names
    {
        John,
        Jenny,
        Kate,
        Donald,
        Hilary
    }

    internal enum Surnames
    {
        Smith,
        Trump,
        Clinton,
        Obama,
        Sanders
    }
}