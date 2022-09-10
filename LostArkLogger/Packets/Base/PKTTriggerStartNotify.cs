using System;
using System.Collections.Generic;
using LoggerLinux.Configuration;

namespace LostArkLogger
{
    public partial class PKTTriggerStartNotify
    {
        public PKTTriggerStartNotify(BitReader reader)
        {
            if (Configuration.Region == Region.Steam) SteamDecode(reader);
            if (Configuration.Region == Region.Korea) KoreaDecode(reader);
        }
        public UInt64 TriggerUnitIndex;
        public UInt32 ActorId;
        public UInt32 Signal;
        public List<UInt64> u64list_0;
    }
}
