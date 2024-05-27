namespace Lab5Final
{
    class WiredHeadphonesFactory : IHeadphonesFactory
    {
        public IHeadphones CreateHeadphones()
        {
            return new WiredHeadphones();
        }
    }
}
