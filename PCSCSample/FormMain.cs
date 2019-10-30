using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using GS.Apdu;
using GS.PCSC;
using GS.SCard;
using GS.SCard.Const;
using GS.Util.Hex;

namespace PCSCSample
{
    public partial class FormMain : Form
    {
        private const string Version = " V1.00";
        private PCSCReader mPcscReader = new PCSCReader();
        //private string mReaderName;
        private bool IsReaderConnected = false;
        private MultiLine ml = new MultiLine();

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private int ListReaders()
        {
            //mPcscReader = new PCSCReader();
            string[] readerList = mPcscReader.ListReaders();

            if (readerList.Length <= 0)
                return 0;

            Array.Sort(readerList);

            comboReaders.Items.AddRange(readerList);
            comboReaders.SelectedIndex = 0;

            return readerList.Length;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Text += Version;
#if DEBUG
            this.Text += " - Debug";
#endif

            try
            {
                int ReaderCount = ListReaders();
                //string PortName = "";

                if (ReaderCount > 0)
                {
                    //PortName = (string)comboReaders.SelectedItem;
                    btnConnect.Enabled = true;
                    ml.AddLine("請先選擇要使用的讀卡機, 並確認己插入晶片卡");
                }
                else
                {
                    btnConnect.Enabled = false;
                    btnDisconnect.Enabled = false;

                    ml.AddLine("沒發現 PCSC 讀卡機");
                }

                txtMessage.Text = ml.Text;
                btnConnect.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); //for debug only
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsReaderConnected)
                mPcscReader.Disconnect();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string readerName = (string)comboReaders.SelectedItem;

            try
            {
                mPcscReader.Connect(readerName);
                mPcscReader.ActivateCard();

                txtATR.Text = mPcscReader.SCard.AtrString;
                txtProtocol.Text = mPcscReader.SCard.SCardProtocol.ToString();
                lblProtocol.Visible = true;

                IsReaderConnected = true;
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
                btnSend.Enabled = true;

                txtMessage.Text = ml.AddLine("IsCardPresent = " + mPcscReader.SCard.IsCardPresent);
            }
            catch (Exception ex)
            {
                mPcscReader.Disconnect();
                ml.AddLine(ex.ToString());
                txtMessage.Text = ml.AddLine("卡片連接失敗, 請檢查卡片是否己正確插入讀卡機");
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            txtATR.Text = "";
            txtProtocol.Text = "";
            lblProtocol.Visible = false;
            btnSend.Enabled = false;

            mPcscReader.Disconnect();
            IsReaderConnected = false;
        }

        //
        // To scroll down the text message box automatically
        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            txtMessage.SelectionStart = txtMessage.Text.Length;
            txtMessage.ScrollToCaret();
        }

        private void btnClearMessage_Click(object sender, EventArgs e)
        {
            txtMessage.Text = ml.Clear();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                RespApdu respApdu = mPcscReader.Exchange(txtAPDU.Text);

                ml.NewLine();
                ml.AddLine("Send: " + txtAPDU.Text);
                if (respApdu.Data != null && respApdu.Data.Length > 0)
                {
                    //ml.AddLine("Resp: " + HexFormatting.ToHexString(respApdu.Data, true));
                    ml.AddLine(String.Format("Resp({0}B): {1}", respApdu.Data.Length, 
                        HexFormatting.ToHexString(respApdu.Data, true)));
                }
                else
                {
                    ml.AddLine("Resp: (None)");
                }

                ml.AddLine("Status: " + respApdu.SW1SW2.Value.ToString("X4"));

                txtMessage.Text = ml.Text;
            }
            catch (WinSCardException ex)
            {
                txtMessage.Text = ml.AddLine(ex.WinSCardFunctionName + " Error 0x" +
                                   ex.Status.ToString("X08") + ": " + ex.Message);
            }
            catch (Exception ex)
            {
                txtMessage.Text = ml.AddLine(ex.Message);
            }
        }

        private void txtAPDU_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnSend_Click(sender, e);
            }
        }

        private void txtAPDU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') ||
                (e.KeyChar >= 'A' && e.KeyChar <= 'F') ||
                (e.KeyChar >= 'a' && e.KeyChar <= 'f') ||
                (e.KeyChar == ' ') ||
                (e.KeyChar == 0x08))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                e.Handled = false;
            }
            else
            {
                e.Handled = true; //Ignore the input key
            }
        }
    }
}
