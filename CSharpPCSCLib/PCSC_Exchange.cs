﻿/*
Copyright (c) 2011, Gerhard H. Schalk, www.smartcard-magic.net
All rights reserved.

Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.
Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the 
documentation and/or other materials provided with the distribution.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT 
LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT 
HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT 
LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON 
ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.*/
using System;
using GS.Apdu;
using GS.Util.Hex;

namespace GS.PCSC
{
    /// <summary>
    /// A high level PC/SC  API.
    /// </summary>
    public partial class PCSCReader 
    {
        /// <summary>
        /// The function Exchange sends a command APDU to a smart card and returns the response ADPU from the card. 
        /// </summary>
        /// <param name="cmdApdu">Hexadecimal string containing the command ADPU.</param>
        /// <returns></returns>
        public RespApdu Exchange(string cmdApdu)
        {
            return this.Exchange(cmdApdu, null);
        }

        /// <summary>
        /// The function Exchange sends a command APDU to a smart card and returns the response ADPU from the card.
        /// </summary>
        /// <param name="cmdApdu">Hexadecimal  string containing the command APDU.</param>
        /// <param name="expectedSW1SW2">The expected status word SW1SW2.</param>
        /// <returns></returns>
        public RespApdu Exchange(string cmdApdu, ushort? expectedSW1SW2)
        {
            byte[] responseBuffer = this.Exchange(HexEncoding.GetBytes(cmdApdu), expectedSW1SW2);
            RespApdu respApdu = new RespApdu(responseBuffer);
            return respApdu;
        }

        /// <summary>
        /// The function Exchange sends a command APDU to a smart card and returns the response ADPU from the card.
        /// </summary>
        /// <param name="cmdApdu">The command ADPU.</param>
        /// <returns>The response APDU.</returns>
        public RespApdu Exchange(CmdApdu cmdApdu)
        {
            return this.Exchange(cmdApdu, null);
        }

        /// <summary>
        /// The function Exchange sends a command APDU to a smart card and returns the response ADPU from the card.
        /// </summary>
        /// <param name="cmdApdu">The command ADPU.</param>
        /// <param name="expectedSW1SW2">The expected status word SW1SW2.</param>
        /// <returns>The response APDU.</returns>
        public RespApdu Exchange(CmdApdu cmdApdu, ushort? expectedSW1SW2)
        {
            byte[] responseBuffer = this.Exchange(cmdApdu.GetBytes(), expectedSW1SW2);
            RespApdu respApdu = new RespApdu(responseBuffer);
            return respApdu;
        }

        /// <summary>
        /// The function Exchange sends a command APDU to a smart card and returns the response ADPU from the card.
        /// </summary>
        /// <param name="sendBuffer">The command ADPU.</param>
        /// <returns>The response APDU.</returns>
        public byte[] Exchange(byte[] sendBuffer)
        {
            return this.Exchange(sendBuffer, null);
        }

        /// <summary>
        /// The function Exchange sends a command APDU to a smart card and returns the response ADPU from the card.
        /// </summary>
        /// <param name="sendBuffer">The command ADPU.</param>
        /// <param name="expectedSW1SW2">The expected status word SW1SW2.</param>
        /// <returns>The response APDU.</returns>
        public byte[] Exchange(byte[] sendBuffer, ushort? expectedSW1SW2)
        {
            byte[] responseBuffer = null;
            this.Exchange(sendBuffer, out responseBuffer, expectedSW1SW2);
            return responseBuffer;
        }


        /// <summary>
        /// The function Exchange sends a command APDU to a smart card and returns the response ADPU from the card.
        /// </summary>
        /// <param name="sendBuffer">The command ADPU.</param>
        /// <param name="responseBuffer">The response APDU.</param>
        public void Exchange(byte[] sendBuffer, out byte[] responseBuffer)
        {
            this.Exchange( sendBuffer, out responseBuffer, null );
        }


        /// <summary>
        /// The function Exchange sends a command APDU to a smart card and returns the response ADPU from the card.
        /// </summary>
        /// <param name="sendBuffer">The command ADPU.</param>
        /// <param name="responseBuffer">The response APDU.</param>
        /// <param name="expectedSW1SW2">The expected status word SW1SW2.</param>
        public void Exchange(byte[] sendBuffer, out byte[] responseBuffer, ushort? expectedSW1SW2)
        {
            int responseLength = 0;
            this.Exchange(sendBuffer, sendBuffer.Length, out responseBuffer, out responseLength, expectedSW1SW2);
        }

        /// <summary>
        /// The function Exchange sends a command APDU to a smart card and returns the response ADPU from the card.
        /// </summary>
        /// <param name="sendBuffer">The command ADPU.</param>
        /// <param name="sendLength">Length of the command ADPU.</param>
        /// <param name="responseBuffer">The response APDU.</param>
        /// <param name="responseLength">Length of the response APDU.</param>
        public void Exchange(byte[] sendBuffer, int sendLength, out byte[] responseBuffer, out int responseLength)
        {
            this.Exchange(sendBuffer, sendLength, out responseBuffer, out responseLength, null);
        }

        /// <summary>
        /// The function Exchange sends a command APDU to a smart card and returns the response ADPU from the card.
        /// </summary>
        /// <param name="sendBuffer">The command ADPU.</param>
        /// <param name="sendLength">Length of the command ADPU.</param>
        /// <param name="responseBuffer">The response APDU.</param>
        /// <param name="responseLength">Length of the response APDU.</param>
        /// <param name="expectedSW1SW2">The expected status word SW1SW2.</param>
        public void Exchange( byte[] sendBuffer, int sendLength, out byte[] responseBuffer, out int responseLength, ushort? expectedSW1SW2 )
        {
            responseBuffer = null;
 
            CmdApdu cmdApud;

            if (sendBuffer.Length == sendLength)
            {
                cmdApud = new CmdApdu( sendBuffer );
            }
            else
            {
                byte[] baSendTemp = new byte[sendLength];
                Array.Copy(sendBuffer, baSendTemp, sendLength);
                cmdApud = new CmdApdu(baSendTemp);
            }
            
            int respBufferSize = 2;
            
            if((cmdApud.Le != null) ) 
            {
                respBufferSize = (int)cmdApud.Le + 2;
            }
            byte[] baTempResp = new byte[respBufferSize];
            responseLength = baTempResp.Length;

            this.Exchange(sendBuffer, sendLength, baTempResp, ref responseLength, expectedSW1SW2);

            responseBuffer = new byte[responseLength];
            Array.Copy(baTempResp, responseBuffer, responseLength);
        }

        /// <summary>
        /// The function Exchange sends a command APDU to a smart card and returns the response ADPU from the card.
        /// </summary>
        /// <param name="sendBuffer">The command ADPU.</param>
        /// <param name="sendLength">Length of the command ADPU.</param>
        /// <param name="responseBuffer">The response APDU.</param>
        /// <param name="responseLength">
        /// Supplies the length, in bytes, of the response APDU buffer  and 
        /// receives the actual number of bytes received from the smart card.
        /// </param>
        public void Exchange( byte[] sendBuffer, int sendLength, byte[] responseBuffer, ref int responseLength )
        {
            this.Exchange( sendBuffer, sendLength, responseBuffer, ref responseLength, null );
        }

        /// <summary>
        /// The function Exchange sends a command APDU to a smart card and returns the response ADPU from the card.
        /// </summary>
        /// <param name="sendBuffer">The command ADPU.</param>
        /// <param name="sendLength">Length of the command ADPU.</param>
        /// <param name="responseBuffer">The response APDU.</param>
        /// <param name="responseLength">
        /// Supplies the length, in bytes, of the response APDU buffer  and 
        /// receives the actual number of bytes received from the smart card.
        /// </param>
        /// <param name="expectedSW1SW2">The expected status word SW1SW2.</param>
        public void Exchange( byte[] sendBuffer, int sendLength, byte[] responseBuffer, ref int responseLength, ushort? expectedSW1SW2 )
        {
            if (sendBuffer == null)
            {
                throw new ArgumentNullException( "snd_buf" );
            }

            if (responseBuffer == null)
            {
                throw new ArgumentNullException( "rec_buf" );
            }

            this.SCard.Transmit( sendBuffer, sendLength, responseBuffer, ref responseLength );

            RespApdu respApdu = new RespApdu( responseBuffer, responseLength );

            if (expectedSW1SW2 != null)
            {
                // Verify for a valid response status word SW1SW2.
                if (expectedSW1SW2 != respApdu.SW1SW2)
                {
                    throw new ApduException(this.SCard.TraceSCard, 0, (ushort)expectedSW1SW2, respApdu.SW1SW2);
                }
            }
        }
    }
}
