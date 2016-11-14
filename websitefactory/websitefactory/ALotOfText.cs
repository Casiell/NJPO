using System;

namespace websitefactory
{
    internal class ALotOfText : Website
    {
        public string htmlCode;

        public ALotOfText()
        {
            Random rand = new Random();
            switch (rand.Next(6))
            {
                case 1:
                    htmlCode = "<b>Random Text</b>" + Environment.NewLine + "Korzystając ze wzorca SimpleFactory napisz program" + Environment.NewLine + "generujący klasy, które generują losowe strony HTMLowe.";
                    break;

                case 2:
                    htmlCode = "<b>Random Text</b>" + Environment.NewLine + "Galeria zdjęć" + Environment.NewLine + "(kod wrzucający obrazki <img>)";
                    break;

                case 3:
                    htmlCode = "<b>Random Text</b>" + Environment.NewLine + "Strona informacyjna" + Environment.NewLine + "(dużo tekstu – może być losowego)";
                    break;

                case 4:
                    htmlCode = "<b>Random Text</b>" + Environment.NewLine + "Strona kontaktowa" + Environment.NewLine + "(wygeneruj losowe dane teleadresowe)";
                    break;

                case 5:
                    htmlCode = "<b>Random Text</b>" + Environment.NewLine + "Aktualności" + Environment.NewLine + "(podobna do informacyjnej, ale oddzielone sekcje z wiadomościami)";
                    break;

                default:
                    htmlCode = "<b>Random Text</b>" + Environment.NewLine + "Jakiś losowy tekst";
                    break;
            }
        }

        public string pageCode()
        {
            return htmlCode;
        }
    }
}