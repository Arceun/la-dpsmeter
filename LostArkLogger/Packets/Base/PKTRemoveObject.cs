using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public partial class PKTRemoveObject
    {
        public PKTRemoveObject(BitReader reader)
        {
            if (LostArkLogger.Instance.ConfigurationProvider.Configuration.Region == Region.Steam) SteamDecode(reader);
            if (LostArkLogger.Instance.ConfigurationProvider.Configuration.Region == Region.Korea) KoreaDecode(reader);
        }
        public List<Byte> blist_0;
    }
}
