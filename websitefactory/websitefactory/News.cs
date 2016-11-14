using System;

namespace websitefactory
{
    internal class News : Website
    {
        public string htmlCode;

        public News()
        {
            htmlCode = "";
            htmlCode += "<b>Tresc zadania</b>" + Environment.NewLine + "Korzystając ze wzorca SimpleFactory napisz program" + Environment.NewLine + "generujący klasy, które generują losowe strony HTMLowe.";
            htmlCode += Environment.NewLine + "<b>Galeria Zdjęć</b>" + Environment.NewLine + "Kod wrzucający obrazki <img>";
            htmlCode += Environment.NewLine + "Strona Informacyjna</b>" + Environment.NewLine + "Dużo tekstu – może być losowego";
            htmlCode += Environment.NewLine + "<b>Strona Kontaktowa</b>" + Environment.NewLine + "Wygeneruj losowe dane teleadresowe";
            htmlCode += Environment.NewLine + "<b>Aktualności</b>" + Environment.NewLine + "Podobna do informacyjnej, ale oddzielone sekcje z wiadomościami";
        }

        public string pageCode()
        {
            return htmlCode;
        }
    }
}