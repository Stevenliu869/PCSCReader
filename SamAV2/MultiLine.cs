using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//namespace PCSCSample
//{
    class MultiLine
    {
        //string Text; 
        private string TAG = "";
        private const int MaxLines = 800;
        public string LogTag
        {
            get { return TAG; }
            set { TAG = value; }
        }

        private bool LogFlag = false;
        public bool ToSaveLog
        {
            get { return LogFlag; }
            set { LogFlag = value; }
        }

        private int lines = 0;

        public string Text
        {
            get;
            set;
        }

        public MultiLine()
        {
            Text = "";
            lines = 0;
        }

        public MultiLine(string text)
        {
            Text = text;
            lines = 1;

            if(LogFlag)
                Log.i(TAG, text);
        }

        public string Init(string text)
        {
            Text = text;
            lines = 1;

            if (LogFlag)
                Log.i(TAG, text);
            return Text;
        }

        public string AddLine(string text)
        {
            if (LogFlag)
                Log.i(TAG, text);

            if (Text == "")
            {
                Text = text;
                lines = 1;
            }
            else
            {

                if (lines < MaxLines)
                {
                    Text = Text + Environment.NewLine + text;
                    lines++;
                }
                else
                {
                    //return Text + Environment.NewLine + "Warning: The lines number exceeded limitation. Please clear the old message.";
                    Text ="Warning: The lines number exceeded limitation. All message are cleared.";
                    lines = 1;
                }
            }

            return Text;
        }

        public string NewLine()
        {
            if (LogFlag)
                Log.i(TAG, "");  //Environment.NewLine);

            if (lines < MaxLines)
            {
                Text = Text + Environment.NewLine;
                lines++;
            }
            else
            {
                //return Text + Environment.NewLine +  "Warning: The lines number exceeded limitation. Please clear the old message.";
                Text = "Warning: The lines number exceeded limitation. All message are cleared.";
                lines = 1;
            }

            return Text;
        }


        public string Clear()
        {
            Text = "";
            lines = 0;
            return Text;
        }
    }
//}
