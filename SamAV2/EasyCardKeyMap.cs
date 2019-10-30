public class EasyCardKeyMap
{
    public const byte ECC_MK_BASE = 14; //THSRC Mifare Key Base is Key Entry 105.

    /// <summary>
    /// 由 Block number 計算在悠遊卡在 SAM AV2 對應的 KeyNo
    /// </summary>
    /// <param name="BlockNo"> Mifare card block number, 0 ~ 63. </param>
    /// <param name="KeyType"> Key A: 0Ah, Key B: 0Bh </param>
    /// <returns></returns>
    public static byte BlockToKeyNo(byte BlockNo, byte KeyType)
    {
        byte SecNo = (byte)(BlockNo / 4);

        return SectorToKeyNo(SecNo, KeyType);
    }

    /// <summary>
    /// 由 Block number 計算在悠遊卡在 SAM AV2 對應的 KeyVer
    /// 註: 本函式提供的 KeyVer 的算法, 是針對高鐵 SAM AV2的設定特性, 而提供的簡化算法.
    /// 這不是正確的換算方式, 只能算特例, 正確的做法應應該是到 Key Entry 內取得對應的 KeyVer
    /// </summary>
    /// <param name="BlockNo"> Mifare card block number, 0 ~ 63. </param>
    /// <returns></returns>
    public static byte BlockToKeyVer(byte BlockNo) //, byte KeyType)
    {
        byte SecNo = (byte) (BlockNo / 4);

        return SectorToKeyVer(SecNo) ;
    }

    /// <summary>
    /// 由 Sector Number 計算在悠遊卡在 SAM AV2 對應的 KeyNo
    /// </summary>
    /// <param name="SecNo"> Mifare card sector number, 0 ~ 15. </param>
    /// <param name="KeyType"> Key A: 0Ah, Key B: 0Bh </param>
    /// <returns></returns>
    public static byte SectorToKeyNo(byte SecNo, byte KeyType)
    {
        byte KeyOffset = 0;

        switch (SecNo)
        {
            case 0:
                KeyOffset = 0;
                break;
            case 1:
                KeyOffset = 0;
                break;
            case 2:
                if(KeyType == 0x0B)
                    KeyOffset = 6; //Sector2, KeyB
                else
                    KeyOffset = 5; // Sector2, Key A
                break;
            case 3:
                KeyOffset = 0;
                break;
            default:
                KeyOffset = (byte)(((SecNo - 4) / 3) + 1);
                break;
        }

        return (byte)(KeyOffset + ECC_MK_BASE);
    }

    /// <summary>
    /// 由 Sector number 計算在悠遊卡在 SAM AV2 對應的 KeyVer
    /// 註: 本函式提供的 KeyVer 的算法, 是針對高鐵 SAM AV2的設定特性, 而提供的簡化算法.
    /// 這不是正確的換算方式, 只能算特例, 正確的做法應應該是到 Key Entry 內取得對應的 KeyVer
    /// </summary>
    /// <param name="SecNo"> Mifare card sector number, 0 ~ 15. </param>
    /// <returns></returns>
    public static byte SectorToKeyVer(byte SecNo) //, byte KeyType)
    {
        byte KeyVer = 0;

        switch (SecNo)
        {
            case 0:
                KeyVer = 0;
                break;
            case 1:
                KeyVer = 1;
                break;
            case 2:
                KeyVer = 0;
                break;
            case 3:
                KeyVer = 2;
                break;
            default:
                KeyVer = (byte)((SecNo - 4) % 3);
                break;
        }

        return KeyVer;
    }

}
