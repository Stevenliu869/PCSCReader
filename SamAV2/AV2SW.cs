using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Explain responsed SW with text.
/// </summary>
public class AV2SW
{
    public static string ToString(UInt16 uSW) 
    {
        string strDesc = "(Uknown)";

        switch (uSW)
        {
            case 0x6400:
                strDesc = "EEPROM busy, access collision, memory range cannot be mapped...";
                break;
            case 0x6401:
                strDesc = "RC52x/RC663 interface error";
                break;
            case 0x6502:
                strDesc = "SAM key reference number invalid";
                break;
            case 0x6503:
                strDesc = "SAM key usage counter number invalid";
                break;
            case 0x6581:
                strDesc = "Memory failure; EEPROM high voltage failure; SAM permanently disabled";
                break;
            case 0x6700:
                strDesc = "Wrong length of the APDU or wrong Lc byte";
                break;
            case 0x6883:
                strDesc = "Final chained command expected; running command aborted...";
                break;
            case 0x6982:
                strDesc = "Security status not satisfied (cryptogram incorrect)";
                break;
            case 0x6984:
                strDesc = "Referenced data invalid(Key entry of CRC not valid)";
                break;
            case 0x6985:
                strDesc = "Conditions of use not satisfied(host authen with KeyNoCEK required)";
                break;
            case 0x6986:
                strDesc = "Command not allowed with currently authenticated key";
                break;
            case 0x6A80:
                strDesc = "Incorrect parameters in the command data field";
                break;
            case 0x6A82:
                strDesc = "No valid key version found";
                break;
            case 0x6A84:
                strDesc = "SAM Host protection error, only valid in AV2 mode";
                break;
            case 0x6A86:
                strDesc = "Incorrect value for P1 and/or P2";
                break;
            case 0x6C00:
                strDesc = "Incorrect Le value";
                break;
            case 0x6D00:
                strDesc = "Instruction not supported or invalid or not available in current SAM";
                break;
            case 0x6E00:
                strDesc = "Class not supported";
                break;
            case 0x6F00:
                strDesc = "No precise diagnosis (physical address invalid, ...)";
                break;
            case 0x9000:
                strDesc = "Correct execution";
                break;
            case 0x901E:
                strDesc = "Correct execution, authentication failed.";
                break;
            case 0x90AF:
                strDesc = "Correct & Encrypted random number B...";
                break;
            default:
                if ((uSW & 0xFF00) == 0x9000)
                    strDesc = "Mifare PICC error or to be defined error...";
                break;
        }

        return strDesc;
    }
}
