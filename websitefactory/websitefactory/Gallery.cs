namespace websitefactory
{
    class Gallery : Website
    {
        public string htmlCode;
        public Gallery()
        {
            htmlCode = "<img src = \"C:\\Users\\Student\\Pictures\\photo.jpg\" alt = \"Photo\"/>";
        }
        public string pageCode()
        {
            return htmlCode;
        }
    }
}
