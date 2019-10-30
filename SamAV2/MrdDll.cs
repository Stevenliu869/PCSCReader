using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

// The 64-bits DLL is used for this case.
public class MrdDll
{
    public const int MRD_OK = 0;
    public const int COM_RECV_ERR = 3; //Data Receive timeout.
    public const int MRD_COM_FAILED = 9; //Com port communication failed. Continuous timeout too many times. Steven Liu 2017/01/03

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ComPort">由0開始算, COM1是 0, COM2 是 1... </param>
    /// <param name="SAMSLOT">8 bytes </param>
    /// <returns></returns>
    [DllImport("MRD_Interface.dll")] //1
    public static extern int MRD_Open(int ComPort, byte[] SAMSLOT);

    [DllImport("MRD_Interface.dll")] //no, 0
    public static extern int MRD_Close(int ComPort);

    [DllImport("MRD_Interface.dll")] //1
    public static extern int MRD_Reset_SAMSlots(byte[] SAMSLOT);

    [DllImport("MRD_Interface.dll")] 
    public static extern int CheckReaderProtocol(); //Steven Liu 2017/02/20

    /// <summary>
    /// Read Mifare Key Buffer from Reade
    /// </summary>
    /// <param name="KeyAB">0x01:KeyA, 0x02:KeyB</param>
    /// <param name="KeyBuffer">96 bytes is required</param>
    /// <returns>0 means succeeded.</returns>
    [DllImport("MRD_Interface.dll")] 
    public static extern int RAM_ReadKeyAB(byte KeyAB, byte[] KeyBuffer);

    [DllImport("MRD_Interface.dll")] 
    public static extern int MRD_RF(int RdNo, int OnOff);

    [DllImport("MRD_Interface.dll")] //2**
    public static extern int PcdRequest(Byte RAD, int port, Byte req_mode, ref Byte atq);
    
    /// <summary>
    /// To halt the card on inductive area.
    /// </summary>
    /// <param name="RAD">0x01, seems to be discarded now.</param>
    /// <param name="port">Antenna port, must be 0x01 or 0x02.</param>
    /// <returns></returns>
    [DllImport("MRD_Interface.dll")] //2**
    public static extern int  PcdHalt(Byte RAD, int port);

    /// <summary>
    /// Switch Reader's antenna 1 or 2.
    /// </summary>
    /// <param name="Antenna">
    /// It must to be set to 1 or 2 only.
    /// </param>
    /// <returns></returns>
    [DllImport("MRD_Interface.dll")] //
    public static extern int MRD_Switch_Antenna(Byte Antenna);

    [DllImport("MRD_Interface.dll")] 
    public static extern int PcdAntennaOn(Byte RAD, int port);

    [DllImport("MRD_Interface.dll")]
    public static extern int PcdAntennaOff(Byte RAD, int port);

    [DllImport("MRD_Interface.dll")]
    public static extern int PcdRead(Byte RAD, int port, Byte addr, Byte[] readdata);

    [DllImport("MRD_Interface.dll")]
    public static extern int PcdWrite(Byte RAD, int port, Byte addr, Byte[] writedata);

    [DllImport("MRD_Interface.dll")]
    public static extern int PcdAuthPart1(int port, Byte auth, Byte addr, Byte[] tokenRB);

    [DllImport("MRD_Interface.dll")]
    public static extern int PcdAuthPart2(int port, Byte[] tokenAB, Byte[] tokenBA);

    [DllImport("MRD_Interface.dll")]
    public static extern int PcdLowLTransceive(Byte Mode, Byte[] SendData, UInt16 SendLen, Byte[] ReadData, ref UInt16 ReadLen);

    [DllImport("MRD_Interface.dll")]
    public static extern int PcdBitsTransceive(Byte Mode, Byte[] SendData, UInt16 SendBitLen, Byte[] ReadData, ref UInt16 ReadLen);

    /// <summary>
    /// Define consts of Mode for PcdLowLTransceive()
    /// </summary>
    public const Byte MODE_ParityEnable = 0x01;
    public const Byte MODE_ISO14443A    = 0x02; //This setting can be ignored by AP due to it's a mandatory setting for Mifare card and has been enabled in MRD firmware.
    public const Byte MODE_TxCRCEnable  = 0x04;
    public const Byte MODE_RxCRCEnable  = 0x08;
    public const Byte MODE_RxCRC8       = 0x10;
    public const Byte MODE_RxCRC3309    = 0x20;

    /// <summary>
    /// Read Mifare Card
    /// </summary>
    /// <param name="Snr">卡片序號</param>
    /// <param name="IssuerNo">發卡單位代號1 Byte</param>
    /// <param name="TagType">0x0004=Mifare 1K(CSC), 0x0002=Mifare 4K(CSC), 0x0044=Mifare Ultralight(CST), 0x0344 Mifare DESFire</param>
    /// <param name="Flag">0 = Run as memory card, 1 = Run as CPU card</param>
    /// <param name="SNR_Length"> Snr 序號長度 4 or 7</param>
    /// <param name="Sak">0x04/0x00 Mifare ultralight, 0x08: Mifare 1K, 0x18:Mifare 4K</param>
    /// <returns></returns>
    [DllImport("MRD_Interface.dll")] //1
    public static extern int MRD_CardRequest(byte[] Snr, ref byte IssuerNo, byte[] TagType, ref byte CardMode, ref int SNR_Length, ref byte Sak);

    /// <summary>
    /// Read Felica Token
    /// </summary>
    /// <param name="Snr">卡片序號</param>
    /// <param name="IssuerNo">發卡單位代號1 Byte</param>
    /// <param name="TagType">0x0004=Mifare 1K(CSC), 0x0002=Mifare 4K(CSC), 0x0044=Mifare Ultralight(CST), 0x0344 Mifare DESFire</param>
    /// <param name="Flag">0=正常卡片, 1=異常卡片</param>
    /// <param name="SNR_Length"> Snr 序號長度 4 or 7</param>
    /// <param name="Sak">0x04/0x00 Mifare ultralight, 0x08: Mifare 1K, 0x18:Mifare 4K</param>
    /// <returns></returns>
    [DllImport("MRD_Interface.dll")] 
    public static extern int MRD_CardRequestC(byte[] Snr, ref byte IssuerNo, byte[] TagType, ref byte Flag, ref int SNR_Length, ref byte Sak);

    /// <summary>
    /// Read One Block data from Card.
    /// </summary>
    /// <param name="BlockNo"> The specified block number. Available range: 0 ~ 63</param>
    /// <param name="BlockData">The retried data, 16 bytes.</param>
    /// <returns></returns>
    [DllImport("MRD_Interface.dll")] //24
    public static extern int MRD_CSCReadOneBlock(int BlockNo, Byte[] BlockData);

    /// <summary>
    /// Read reading block timing info for diagnostic only
    /// </summary>
    /// <param name="TimeInfo">
    ///  TimeInfo: 32 bytes array for,
	///     AuthTime: 8 bytes
	///     SelectChipTime: 8 bytes
	///     ReadBlockTime: 8 bytes
	///     ReadBlockTotalTime: 8 bytes
    /// </param>
    /// <returns></returns>
    [DllImport("MRD_Interface.dll")] //for diagnostic only
    public static extern int MRD_CSCReadBlockTimeInfo(Byte[] TimeInfo);

    [DllImport("MRD_Interface.dll")] //14
    public static extern int MRD_CSCWriteOneBlock(int BlockNo, Byte[] BlockData);
    
    [DllImport("MRD_Interface.dll")] //un-U
    public static extern int MRD_CSCReadLogData(Byte[] LogData);

    /// <summary>
    /// New APIs for PreRead function.
    /// </summary>
    /// <param name="EnableFlag"></param>
    /// <returns></returns>
    [DllImport("MRD_Interface.dll")] //
    public static extern int MRD_CSCEnablePreReadFunc(int EnableFlag);

    [DllImport("MRD_Interface.dll")] //
    public static extern int MRD_CSCPreReadSectors(int[] SecArray, int SecCount);
    // End of New APIs for PreRead function.

    [DllImport("MRD_Interface.dll")] //5
    public static extern int MRD_CSCReadSectorData(Byte Sector, Byte[] SectorData);

    [DllImport("MRD_Interface.dll")]
    public static extern int MRD_CSCWriteSectorData(Byte SectorNo, Byte[] SectorData);

    [DllImport("MRD_Interface.dll")]
    public static extern int MRD_CSCReadMassData(ref Byte SectorCnt, Byte[] baSectorNo, Byte[] MassData);

    [DllImport("MRD_Interface.dll")]
    public static extern int MRD_CSCWriteMassData(ref Byte SectorCnt, Byte[] baSectorNo, Byte[] MassData);
   
    [DllImport("MRD_Interface.dll")] //2
    public static extern int MRD_CSTReadOnePage(int PageNo, Byte[] PageData);
    
    [DllImport("MRD_Interface.dll")] //2
    public static extern int MRD_CSTWriteOnePage(int PageNo, Byte[] PageData);
    
    [DllImport("MRD_Interface.dll")] //un-U
    public static extern int AnticollisionAndSelect(Byte RAD, int port, Byte[] cpSNR, Byte[] cpSak, ref Byte spUID_Length);
    
    [DllImport("MRD_Interface.dll")] //un-U
    public static extern int MRD_CSCReadTY15Data(Byte[] SectorData_15, Byte Auth_Mode);
    
    [DllImport("MRD_Interface.dll")] //un-U
    public static extern int MRD_ApiVersion(Byte[] LibVersion);
    
    [DllImport("MRD_Interface.dll")] //un-U 
    public static extern int MRD_FW_Version(byte[] FwVersion);

    [DllImport("MRD_Interface.dll")] //un-U 
    public static extern int Get_DeviceID(byte[] baDeviceID);
    
    [DllImport("MRD_Interface.dll")]
    public static extern int BUZZER_Control_ON(byte RAD, int BeepTime);
    
    /// { TAC,MAC }
    [DllImport("MRD_Interface.dll")]
    public static extern int MRD_EASY_GetTAC(byte[] inData, byte len, byte[] byTAC);
    
    [DllImport("MRD_Interface.dll")]
    public static extern int MRD_KRTC_GetTAC(byte[] inData, byte len, byte[] byTAC); //v
    
    [DllImport("MRD_Interface.dll")]
    public static extern int MRD_FETC_GetTAC(byte[] inData, byte len, byte[] byTAC);
    
    [DllImport("MRD_Interface.dll")]
    public static extern int MRD_TYRT_GetTAC(byte[] inData, byte len, byte[] byTAC);
    
    [DllImport("MRD_Interface.dll")]
    public static extern int MRD_TWSC_PSAM_MAC(byte[] inData, byte len, byte[] byTAC); //v
    
    [DllImport("MRD_Interface.dll")]
    public static extern int MRD_TWSC_RSAM_MAC(byte[] inData, byte len, byte[] byTAC);

    /// { v2.27 new API }
    [DllImport("MRD_Interface.dll")]
    public static extern int MRD_TYRT_Read_Serial(byte[] samNo); //讀取桃捷SAM卡的序號(Serial No)
    
    //SAMno	: 8 bytes SAM Serial Number
    [DllImport("MRD_Interface.dll")]
    public static extern int MRD_TYRT_RSAM_TAC(byte[] inData, byte len, byte[] tac); //桃捷RSAM 計算TAC
    
    //tac	: 8 bytes TAC
    [DllImport("MRD_Interface.dll")]
    public static extern int MRD_TYRT_RSAM_MAC(byte[] inData, byte[] mac); //桃捷RSAM傳送使用SHA Hash過的整批交易資料
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="inData">原始交易資料(NB)</param>
    /// <param name="len">inData的長度</param>
    /// <param name="outData">回傳SHA1運算後的加密資料(20B)</param>
    /// <returns></returns>
    [DllImport("MRD_Interface.dll")]
    public static extern int MRD_GetSHA1Data(byte[] inData, int len, byte[] outData); //取得SHA-1驗證碼
    
    /************************************************************************
    //Added by Steven Liu 2015/04/02 begin ++++++++++++++++++++++
    ***************************************************************************/
    /// <summary>
    /// 由 Reader 取得 Random Number
    /// </summary>
    /// <param name="RAD">Reader Address, always set to 0x01 here</param>
    /// <param name="Random">out, the random which generated by reader(actually by SAM)</param>
    /// <returns>0: Succeeded, other: failed</returns>
    [DllImport("MRD_Interface.dll")]
    public static extern int DSK_GetRandom(byte RAD, byte[] Random);

    /// <summary>
    /// Send the random number which encrypted by ISPKey to MR400 to make Terminal Authen.
    /// </summary>
    /// <param name="RAD"></param>
    /// <param name="EncryptedRandom"></param>
    /// <returns></returns>
    [DllImport("MRD_Interface.dll")]
    public static extern int DSK_TerminalAuthKey(byte RAD, byte[] EncryptedRandom);

    /// <summary>
    /// Send the new DSKey which encrypted by ISPKey to MR400 reader
    /// </summary>
    /// <param name="RAD"></param>
    /// <param name="EncryptedDSKey"></param>
    /// <returns></returns>
    [DllImport("MRD_Interface.dll")]
    public static extern int DSK_UpdateKey(byte RAD, byte[] EncryptedDSKey);

    /// <summary>
    /// 檢查悠遊卡防偽認證碼CPD值
    /// </summary>
    /// <param name="InData"></param>
    /// <returns></returns>
    [DllImport("MRD_Interface.dll")]
    public static extern int MRD_EASY_CheckCPD(byte[] InData);

    #region <KRTC functions>

    /// <summary>
    /// Get Session Key from iPass SAM
    /// </summary>
    /// <param name="NTID">Station+Equip+TimeStamp+Sequence, 10 bytes.</param>
    /// <param name="SessionKey">output, 16 bytes</param>
    /// <returns></returns>
    [DllImport("MRD_Interface.dll")]
    public static extern int MRD_R24_GetSessionKey(byte[] NTID, byte[] SessionKey);

    [DllImport("MRD_Interface.dll")]
    public static extern int MRD_RandomNo(byte[] random);

    [DllImport("MRD_Interface.dll")]
    public static extern int MRD_IPASS_SetSAMType(byte samType);

    //[DllImport("MRD_Interface.dll")]
    //public static extern int MRD_KRTC_GetTAC(byte[] data, byte len, byte[] tac);

    #endregion

    #region <ISO 14443A functions>

    [DllImport("MRD_Interface.dll")] 
    public static extern int IsoCardRequest(byte[] Snr, ref byte SnrLen, byte[] ATQA, ref byte SAK, byte[] ATS, ref byte AtsLen);

    [DllImport("MRD_Interface.dll")]
    public static extern int MifareCardRequest(byte[] Snr, ref byte SnrLen, byte[] ATQA, ref byte SAK);

    [DllImport("MRD_Interface.dll")]
    public static extern int IsoTransceive(byte[] SendBuf, byte SendLen, byte[] RecvBuf, ref byte RecvLen);

    [DllImport("MRD_Interface.dll")]
    public static extern int IsoCardDeselect();

    [DllImport("MRD_Interface.dll")]
    public static extern int IsoPiccPresenceCheck();

    [DllImport("MRD_Interface.dll")]
    public static extern int IsoReGetPiccResponse(byte[] Resp, ref byte RespLen);
    #endregion

    #region <SAM Card Functions>
    [DllImport("MRD_Interface.dll")]
    public static extern int SIM8_Send_Recv_APDU(byte RAD, byte Slot, byte[] SBuffer, int SBufferLen, byte[] RBuffer, ref int RBufferLen);

    /// <summary>
    /// Send and Recv APDU Speed. It only supports SAM Board V.0239 and Reader V.0311A0 and later.
    /// </summary>
    /// <param name="RAD"> 0x01</param>
    /// <param name="Slot"></param>
    /// <param name="SBuffer"></param>
    /// <param name="SBufferLen"></param>
    /// <param name="RBuffer"></param>
    /// <param name="RBufferLen"></param>
    /// <returns></returns>
    [DllImport("MRD_Interface.dll")]
    public static extern int SIM8_Send_Recv_APDU_Speed(byte RAD, byte Slot, byte[] SBuffer, int SBufferLen, byte[] RBuffer, ref int RBufferLen);

    [DllImport("MRD_Interface.dll")]
    public static extern int SIM8_Get_HWVER(byte RAD, byte[] RBuffer, ref int RBufferLen);

    [DllImport("MRD_Interface.dll")]
    public static extern int SIM8_Get_SAM_ATR(byte RAD, byte Slot, byte[] baATR, ref int ATRLen, ref int Protocol, ref int TA1);

    #endregion

    #region <RC531/EEPROM Functions>
    [DllImport("MRD_Interface.dll")]
    public static extern int PcdReset(byte RAD, int port);

    [DllImport("MRD_Interface.dll")]
    public static extern int PcdReadE2(byte RAD, int port, int startaddr, byte length, byte[] readdata);

    [DllImport("MRD_Interface.dll")]
    public static extern int PcdReadE2Ex(byte RAD, int port, int startaddr, byte length, byte[] readdata);

    [DllImport("MRD_Interface.dll")]
    public static extern int PcdReadE2Page(byte RAD, int port, byte pageAddr, byte length, byte[] readdata);

    [DllImport("MRD_Interface.dll")]
    public static extern int PcdWriteE2(byte RAD, int port, int startaddr, byte length, byte[] writedata);

    [DllImport("MRD_Interface.dll")]
    public static extern int PcdWriteE2Ex(byte RAD, int port, int startaddr, byte length, byte[] writedata);

    [DllImport("MRD_Interface.dll")]
    public static extern int PcdWriteE2Page(byte RAD, int port, byte pageAddr, byte length, byte[] writedata);

    #endregion

    #region <YHDP L1 Functions>
    [DllImport("MRD_Interface.dll")]
    public static extern int MRD_YHDP_ReadBinary(byte[] baCID);

    [DllImport("MRD_Interface.dll")]
    public static extern int MRD_YHDP_AntiCounterfeit(byte bKID1, byte bKID2, byte[] baData, byte bDataLen);

    [DllImport("MRD_Interface.dll")]
    public static extern int MRD_YHDP_AntiFake(byte xLc, byte[] DidMatc);

    [DllImport("MRD_Interface.dll")]
    public static extern int MRD_YHDP_GetCADID(byte[] baCADID);

    [DllImport("MRD_Interface.dll")]
    public static extern int MRD_YHDP_GetTransNum(byte[] baTransSeq);

    [DllImport("MRD_Interface.dll")]
    public static extern int MRD_YHDP_GetBatchNum(byte[] baBatchNo);

    [DllImport("MRD_Interface.dll")]
    public static extern int MRD_YHDP_GetMAC(byte bKID, byte[] baICV, byte[] baData, byte bDataLen, byte[] baMAC);

    [DllImport("MRD_Interface.dll")]
    public static extern int MRD_YHDP_GetSAMID(byte[] SamID);
    #endregion

    #region <FETC Functions>
    [DllImport("MRD_Interface.dll")]
    public static extern int MRD_FETC_ReadBinary(byte[] baCID);

    [DllImport("MRD_Interface.dll")]
    public static extern int MRD_FETC_AntiCounterfeit(byte bKID1, byte bKID2, byte[] baData, byte bDataLen);

    [DllImport("MRD_Interface.dll")]
    public static extern int MRD_FETC_AntiFake(byte xLc, byte[] DidMatc);

    [DllImport("MRD_Interface.dll")]
    public static extern int MRD_FETC_GetCADID(byte[] baCADID);

    [DllImport("MRD_Interface.dll")]
    public static extern int MRD_FETC_GetTransNum(byte[] baTransSeq);

    [DllImport("MRD_Interface.dll")]
    public static extern int MRD_FETC_GetBatchNum(byte[] baBatchNo);

    [DllImport("MRD_Interface.dll")]
    public static extern int MRD_FETC_GetMAC(byte bKID, byte[] baICV, byte[] baData, byte bDataLen, byte[] baMAC);

    [DllImport("MRD_Interface.dll")]
    public static extern int MRD_FETC_GetSAMID(byte[] SamID);
    #endregion

    #region <YHDP L2 Functions, Suitable for MRD DLL V4.100>
    [DllImport("MRD_Interface.dll")]
    public static extern int YHDP_SAM_Initial(byte[] baSamID, byte[] baApiVersion, byte[] baRandom);

    [DllImport("MRD_Interface.dll")]
    public static extern int YHDP_SAM_Auth(byte[] baAuthData, byte[] baSAC, byte[] baSAMOSN);

    // 桃捷, 票卡讀取資料資料
    [DllImport("MRD_Interface.dll")]
    public static extern int YHDP_TYRTC_ReadCardData(byte[] baDateTime, byte[] baCardData);

    // 讀取交易記錄
    [DllImport("MRD_Interface.dll")]
    public static extern int YHDP_Read_TxnRecords(byte[] baInData, byte[] baRecord, ref ushort rusRecordLen);

    // 讀取最近第二筆交易及最新一筆加值記錄
    [DllImport("MRD_Interface.dll")]
    public static extern int YHDP_TYRTC_AG_TxnRecords(byte[] baInData, byte[] baRecord, ref ushort rusRecordLen);

    //票卡進閘
    [DllImport("MRD_Interface.dll")]
    public static extern int YHDP_TYRTC_Txn_Entry(byte[] baInData, byte[] baOutData);

    //票卡出閘
    [DllImport("MRD_Interface.dll")]
    public static extern int YHDP_TYRTC_Txn_Exit(byte[] baInData, byte[] baOutData);

    //罰款
    [DllImport("MRD_Interface.dll")]
    public static extern int YHDP_TYRTC_Txn_Penalty(byte[] baInData, byte[] baOutData);

    // 小額消費
    [DllImport("MRD_Interface.dll")]
    public static extern int YHDP_Txn_MicroPayment(byte[] baInData, byte[] baOutData);

    // 離線加值
    [DllImport("MRD_Interface.dll")]
    public static extern int YHDP_Txn_HalfOffLine(byte[] baInData, byte bOperate, byte[] baOutData);

    // 取消離線加值
    [DllImport("MRD_Interface.dll")]
    public static extern int YHDP_Txn_CancelAdd(byte[] baInData, byte bOperate, byte[] baOutData);

    // 鎖卡
    [DllImport("MRD_Interface.dll")]
    public static extern int YHDP_Txn_LockCard(byte[] baInData, byte[] baOutData);

    //更改進出碼
    [DllImport("MRD_Interface.dll")]
    public static extern int YHDP_TYRTC_AlterInOut(byte[] baInData, byte[] baOutData);

    // 卡片修復
    [DllImport("MRD_Interface.dll")]
    public static extern int YHDP_CardRepair(byte[] baInData);

    // 查詢離線加值水位資訊
    [DllImport("MRD_Interface.dll")]
    public static extern int YHDP_QueryWaterLV(byte[] baOutData);

    // 取得離線加值水位授權
    [DllImport("MRD_Interface.dll")]
    public static extern int YHDP_GetWaterLV(byte[] baInData, byte[] baNII, byte[] baOutData);

    // 更新離線加值水位資訊
    [DllImport("MRD_Interface.dll")]
    public static extern int YHDP_UpdateWaterLV(byte[] baISO8583, byte[] baInTransData, byte[] baOutData);

    //讀取SAM 基本資料
    [DllImport("MRD_Interface.dll")]
    public static extern int YHDP_GetSAMID(byte[] baSamId);
    
    [DllImport("MRD_Interface.dll")]
    public static extern int YHDP_GetSAMAPIVersion(byte[] baSamApiVer);
    
    [DllImport("MRD_Interface.dll")]
    public static extern int YHDP_GetSAC(byte[] baSamAuthCode);

    [DllImport("MRD_Interface.dll")]
    public static extern int YHDP_GetSAMOSN(byte[] baSamOSN);

    // 退卡退費 查詢
    [DllImport("MRD_Interface.dll")]
    public static extern int YHDP_GetDeactivateAndWithdraw(byte[] pu8InData, byte[] pu8NII, byte[] pu8OutData);

    // 退卡退費
    [DllImport("MRD_Interface.dll")]
    public static extern int YHDP_Txn_DeactivateAndWithdraw(byte[] pu8ISO8583, byte[] pu8InTransData, byte[] pu8OutData);

    #endregion

    #region <iCash Functions, Suitable for MRD DLL V4.122 and later>

    //	Description : Get Initial Info	(Load Key 1)
    [DllImport("MRD_Interface.dll")]
    public static extern int icasH_GetInitialInfo(byte[] pucInData, byte[] pucOutData);
        
    //	Description : Install Auth Info	 (Load Key 2)
    [DllImport("MRD_Interface.dll")]
    public static extern int icasH_InstallAuthInfo(byte[] pucInData, byte[] pucOutData);
        
    //	Description : Initialize icasH Env and SAM	
    [DllImport("MRD_Interface.dll")]
    public static extern int icasH_SAM_Initial(byte[] pucInData, byte[] pucOutData);
        
    //	Description : Search icasH Card	
    [DllImport("MRD_Interface.dll")]
    public static extern int icasH_SeCheckService(byte[] pucInData);
        
    //	Description : Read Card Info	
    [DllImport("MRD_Interface.dll")]
    public static extern int icasH_Read_CardData(byte[] pucInData, byte[] pucOutData);
        
    //	Description : Lock Card 
    [DllImport("MRD_Interface.dll")]
    public static extern int icasH_Txn_Lock(byte[] pucInData, byte[] pucOutData);
    	
    //******************************************************************************
    //                                AG FUNCTIONS
    //******************************************************************************
    //	Description : Entry	
    [DllImport("MRD_Interface.dll")]
    public static extern int icasH_Txn_Entry(byte[] pucInData, byte[] pucOutData);

    //	Description : Exit	
    [DllImport("MRD_Interface.dll")]
    public static extern int icasH_Txn_Exit(byte[] pucInData, byte[] pucOutData);
    		
    //	Description : Overdue fine
    [DllImport("MRD_Interface.dll")]
    public static extern int icasH_Txn_Replenish_AG(byte[] pucInData, byte[] pucOutData);

    //	Description : Offline Autoload
    [DllImport("MRD_Interface.dll")]
    public static extern int icasH_Txn_ALOffline(byte[] pucInData, byte[] pucOutData);
    					
    //******************************************************************************
    //                                PAM FUNCTIONS
    //******************************************************************************
    //	Description : Query Current Water Lv
    [DllImport("MRD_Interface.dll")]
    public static extern int icasH_Txn_QueryWaterLV(byte[] pucInData, byte[] pucOutput);
            
    //	Description : Getting Authentication for Water Lv
    [DllImport("MRD_Interface.dll")]
    public static extern int icasH_Txn_GetWaterLV(byte[] pucInData, byte[] pucOutput);
            
    //	Description : Update Water Info to Reader
    [DllImport("MRD_Interface.dll")]
    public static extern int icasH_Txn_UpdateWaterLV(byte[] pucInData, byte[] pucOutput);
            
    //	Description : Alter 
    [DllImport("MRD_Interface.dll")]
    public static extern int icasH_Txn_AlterInOut(byte[] pucInData, byte[] pucOutData);
            
    //	Description : Replenish 
    [DllImport("MRD_Interface.dll")]
    public static extern int icasH_Txn_Replenish_PAM(byte[] pucInData, byte[] pucOutData);
            
    //	Description : Charage Cancel 
    [DllImport("MRD_Interface.dll")]
    public static extern int icasH_Txn_CancelAdd(byte[] pucInData, byte[] pucOutData);
            
    //	Description : Charge 
    [DllImport("MRD_Interface.dll")]
    public static extern int icasH_Txn_HalfOffLine(byte[] pucInData, byte[] pucOutData);
            
    //	Description : Recent Rercords form this card
    [DllImport("MRD_Interface.dll")]
    public static extern int icasH_Read_CardTxnRecords(byte[] pucInData, byte[] ucOutput);
            
    #endregion


    #region <CMD Transceive Functions>

    [DllImport("MRD_Interface.dll")]
    public static extern int MRD_TransceiveCmd(byte Cmd, byte[] DataBuf, int DataLen, byte[] RecvBuf, ref int pRecvLen);

    [DllImport("MRD_Interface.dll")]
    public static extern int MRD_TransceiveSubCmd(byte Cmd, byte SubCmd, byte[] DataBuf, int DataLen, byte[] RecvBuf, ref int pRecvLen);
    #endregion

    #region <KR Commands being supported by MRD DLL V4.030>

    //Supported by MRD DLL V4.030
    [DllImport("MRD_Interface.dll")]
    public static extern int KR_Send_Cmd(byte[] SendBuf, byte SendLen, byte[] RecvBuf, ref byte pRecvLen);

    [DllImport("MRD_Interface.dll")]
    public static extern int ABR_Send_Cmd(byte[] RecvBuf, ref byte pRecvLen);

    #endregion
    #region <RTC Functions>
    /// <summary>
    /// Set RTC Time
    /// </summary>
    /// <param name="RAD"> Fixed value of 0x01</param>
    /// <param name="SetTime">18 Bytes, YYYYMMDDhhmmssWddd</param>
    /// <returns></returns>
    [DllImport("MRD_Interface.dll")]
    public static extern int RTC_SetTime(byte RAD, byte[] SetTime);


    [DllImport("MRD_Interface.dll")]
    public static extern int RTC_GetTime(byte RAD, byte[] GetTime);
    #endregion


    public static int ReadRC531SNum(byte[] baRdId)
    {
        return PcdReadE2(1, 1, 8, 4, baRdId); //Read RC531 S/N from the first chip
    }
}
