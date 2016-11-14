namespace websitefactory
{
    class WebsiteFactory
    {
        public static Website createWebsite(WebsiteType type)
        {
            switch(type)
            {
                case WebsiteType.aLotOfText:
                    return new ALotOfText();

                case WebsiteType.contacts:
                    return new Contacts();

                case WebsiteType.news:
                    return new News();

                case WebsiteType.photoGallery:
                    return new Gallery();

                default:
                    break;
            }
            return null;
        }
    }
}
