namespace LostArkLogger
{
    public partial class PKTRemoveObject
    {
        public void SteamDecode(BitReader reader)
        {
            blist_0 = reader.ReadList<Byte>();
        }
    }
}
