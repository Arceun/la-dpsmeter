using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public partial class subPKTNewNpc5
    {
        public subPKTNewNpc5(BitReader reader)
        {
            if (Properties.Settings.Default.Region == Region.Steam) SteamDecode(reader);
        }
        public UInt32 num;
        public List<Byte> b = new List<Byte>();
    }
}
