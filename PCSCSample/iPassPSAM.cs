using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using GS.Apdu;
using GS.PCSC;
using GS.SCard;
using GS.SCard.Const;
using GS.Util.Hex;

namespace PCSCSample
{
    class iPassPSAM
    {
        private PCSCReader mReader;

        public byte[] baRandom;
        public string strRandom;


        public iPassPSAM(PCSCReader reader)
        {
            mReader = reader;
        }


        /// <summary>
        /// iPass PSAM card 測試
        /// </summary>
        /// <returns></returns>
        public bool RunTest()
        {
            try
            {

                SelectAID();
                GetRandom();

                return true;
            }
            catch (WinSCardException ex)
            {
                //Console.WriteLine(ex.WinSCardFunctionName + " Error 0x" +
                //                   ex.Status.ToString("X08") + ": " + ex.Message);
                throw ex;
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                throw ex;
            }

            //return false;
        }


        public void SelectAID()
        {
            try
            {
                RespApdu respApdu = mReader.Exchange("00 A4 04 00 0C A0 00 00 02 83 00 00 08 12 01 07 00"); // SELECT_AID
            }
            catch (WinSCardException ex)
            {
                //Console.WriteLine(ex.WinSCardFunctionName + " Error 0x" +
                //                   ex.Status.ToString("X08") + ": " + ex.Message);
                throw ex;

            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                throw ex;
            }
        }


        public byte[] GetRandom()
        {
            try
            {
                RespApdu respApdu = mReader.Exchange("A4 0A 00 00 08"); // Get Random Number

                //Console.WriteLine("Random  = 0x" + HexFormatting.ToHexString(respApdu.Data, true));
                //if (respApdu != null && respApdu.Data != null)
                if (respApdu.SW1SW2 == 0x9000)
                {
                    baRandom = respApdu.Data;
                    strRandom = HexFormatting.ToHexString(baRandom, true);
                }
                else
                {
                    //baRandom = new byte[8];
                    //Array.Clear(baRandom, 0, 8);
                    //return null;
                    ushort sw = respApdu.SW1SW2??0;
                    throw new Exception("GetRandom has not supported. Card's SW = " + sw.ToString("X4"));
                }
                //strRandom = HexFormatting.ToHexString(baRandom, true);

                return baRandom;
            }
            catch (WinSCardException ex)
            {
                //Console.WriteLine(ex.WinSCardFunctionName + " Error 0x" +
                //                   ex.Status.ToString("X08") + ": " + ex.Message);
                throw ex;
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        public byte[] RsReset()
        {
            try
            {
                RespApdu respApdu = mReader.Exchange("A4 0A 00 00 08"); // Get Random Number

                //Console.WriteLine("Random  = 0x" + HexFormatting.ToHexString(respApdu.Data, true));
                if (respApdu != null)
                {
                    baRandom = respApdu.Data;
                    strRandom = HexFormatting.ToHexString(baRandom, true);
                }
                else
                {
                    baRandom = new byte[8];
                    Array.Clear(baRandom, 0, 8);
                }

                return baRandom;
            }
            catch (WinSCardException ex)
            {
                //Console.WriteLine(ex.WinSCardFunctionName + " Error 0x" +
                //                   ex.Status.ToString("X08") + ": " + ex.Message);
                throw ex;
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                throw ex;
            }
        }



    }
}
