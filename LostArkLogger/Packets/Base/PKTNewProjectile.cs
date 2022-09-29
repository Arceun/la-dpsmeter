using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public partial class PKTNewProjectile
    {
        public PKTNewProjectile(BitReader reader)
        {
            if (LostArkLogger.Instance.ConfigurationProvider.Configuration.Region == Region.Steam) SteamDecode(reader);
            if (LostArkLogger.Instance.ConfigurationProvider.Configuration.Region == Region.Korea) KoreaDecode(reader);
        }
        public ProjectileInfo projectileInfo;
    }
}
