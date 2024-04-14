namespace Lab5Final
{
    class WirelessHeadphonesFactory : IHeadphonesFactory
    {
        public IHeadphones CreateHeadphones()
        {
            return new WirelessHeadphones();
        }
    }
}
