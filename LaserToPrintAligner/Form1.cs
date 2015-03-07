using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LaserToPrintAligner
{
    public partial class Form1 : Form
    {
        List<Point>  Points = new List<Point>();
        double rotation = 0.0d;
        double XPitch = 0.0d;
        double YPitch = 0.0d;
        string Filename = "Blank";
        string VerticalFilename = "Blank";
        string InsulatorFilename = "Blank";
        string HorizontalFilename = "Blank";
        string Path = "C:";

        string RowNumber = "006";

        double X1 = 0.0d;
        double Y1 = 5.5d;
        double X2 = 0.0d;
        double Y2 = -5.5d;

        public Form1()
        {
            InitializeComponent();
                       
        // initialise point list
            for (int N = 0; N < 15; N++)
            {
                Points.Add(new Point(0.0d, 0.0d, 0.0d, 0.0d));
                
            }

        //intitialise other data
            rotation = 0.0d;
            XPitch = 7.914d;
            YPitch = 0.0d;

            //send to textboxes
            CopyDataToText();
        }

        void CopyTextToData()
        {
            //read in other data
            double.TryParse(textBoxRotation.Text, out rotation);
            double.TryParse(textBoxXPitch.Text, out XPitch);
            double.TryParse(textBoxYPitch.Text, out YPitch);

            Filename = textBoxFileName.Text;
            VerticalFilename = textBoxVerticalFilename.Text;
            InsulatorFilename = textBoxInsulatorFilename.Text;
            HorizontalFilename = textBoxHorizontalFilename.Text;

            Path = textBoxFileLocation.Text;

            RowNumber = textBox1.Text;

            double.TryParse(textBoxPointX1.Text, out X1);
            double.TryParse(textBoxPointY1.Text, out Y1);
            double.TryParse(textBoxPointX2.Text, out X2);
            double.TryParse(textBoxPointY2.Text, out Y2);
            
            //read in points to data
            for (int N = 0; N < 15; N++)
                try
                {
                    switch (N)
                    {

                        case 0:
                            double.TryParse(textBoxX1.Text, out Points[N].XMeasured);
                            double.TryParse(textBoxY1.Text, out Points[N].YMeasured);
                            double.TryParse(textBoxXr1.Text, out Points[N].XRemap);
                            double.TryParse(textBoxYr1.Text, out Points[N].YRemap);

                            break;
                        case 1:
                            double.TryParse(textBoxX2.Text, out Points[N].XMeasured);
                            double.TryParse(textBoxY2.Text, out Points[N].YMeasured);
                            double.TryParse(textBoxXr2.Text, out Points[N].XRemap);
                            double.TryParse(textBoxYr2.Text, out Points[N].YRemap);
                            break;
                        case 2:
                            double.TryParse(textBoxX3.Text, out Points[N].XMeasured);
                            double.TryParse(textBoxY3.Text, out Points[N].YMeasured);
                            double.TryParse(textBoxXr3.Text, out Points[N].XRemap);
                            double.TryParse(textBoxYr3.Text, out Points[N].YRemap);
                            break;
                        case 3:
                           double.TryParse(textBoxX4.Text, out Points[N].XMeasured);
                            double.TryParse(textBoxY4.Text, out Points[N].YMeasured);
                            double.TryParse(textBoxXr4.Text, out Points[N].XRemap);
                            double.TryParse(textBoxYr4.Text, out Points[N].YRemap);
                            break;
                        case 4:
                            double.TryParse(textBoxX5.Text, out Points[N].XMeasured);
                            double.TryParse(textBoxY5.Text, out Points[N].YMeasured);
                            double.TryParse(textBoxXr5.Text, out Points[N].XRemap);
                            double.TryParse(textBoxYr5.Text, out Points[N].YRemap);
                            break;
                        case 5:
                            double.TryParse(textBoxX6.Text, out Points[N].XMeasured);
                            double.TryParse(textBoxY6.Text, out Points[N].YMeasured);
                            double.TryParse(textBoxXr6.Text, out Points[N].XRemap);
                            double.TryParse(textBoxYr6.Text, out Points[N].YRemap);
                            break;
                        case 6:
                            double.TryParse(textBoxX7.Text, out Points[N].XMeasured);
                            double.TryParse(textBoxY7.Text, out Points[N].YMeasured);
                            double.TryParse(textBoxXr7.Text, out Points[N].XRemap);
                            double.TryParse(textBoxYr7.Text, out Points[N].XRemap);
                            break;
                        case 7:
                            double.TryParse(textBoxX8.Text, out Points[N].XMeasured);
                            double.TryParse(textBoxY8.Text, out Points[N].YMeasured);
                            double.TryParse(textBoxXr8.Text, out Points[N].XRemap);
                            double.TryParse(textBoxYr8.Text, out Points[N].YRemap);
                            break;
                        case 8:
                            double.TryParse(textBoxX9.Text, out Points[N].XMeasured);
                            double.TryParse(textBoxY9.Text, out Points[N].YMeasured);
                            double.TryParse(textBoxXr9.Text, out Points[N].XRemap);
                            double.TryParse(textBoxYr9.Text, out Points[N].XRemap);
                            break;
                        case 9:
                            double.TryParse(textBoxX10.Text, out Points[N].XMeasured);
                            double.TryParse(textBoxY10.Text, out Points[N].YMeasured);
                            double.TryParse(textBoxXr10.Text, out Points[N].XRemap);
                            double.TryParse(textBoxYr10.Text, out Points[N].XRemap);
                            break;
                        case 10:
                            double.TryParse(textBoxX11.Text, out Points[N].XMeasured);
                            double.TryParse(textBoxY11.Text, out Points[N].YMeasured);
                            double.TryParse(textBoxXr11.Text, out Points[N].XRemap);
                            double.TryParse(textBoxYr11.Text, out Points[N].YRemap);
                            break;
                        case 11:
                            double.TryParse(textBoxX12.Text, out Points[N].XMeasured);
                            double.TryParse(textBoxY12.Text, out Points[N].YMeasured);
                            double.TryParse(textBoxXr12.Text, out Points[N].XRemap);
                            double.TryParse(textBoxYr12.Text, out Points[N].YRemap);
                            break;
                        case 12:
                           double.TryParse(textBoxX13.Text, out Points[N].XMeasured);
                            double.TryParse(textBoxY13.Text, out Points[N].YMeasured);
                            double.TryParse(textBoxXr13.Text, out Points[N].XRemap);
                            double.TryParse(textBoxYr13.Text, out Points[N].YRemap);
                            break;
                        case 13:
                            double.TryParse(textBoxX14.Text, out Points[N].XMeasured);
                            double.TryParse(textBoxY14.Text, out Points[N].YMeasured);
                            double.TryParse(textBoxXr14.Text, out Points[N].XRemap);
                            double.TryParse(textBoxYr14.Text, out Points[N].YRemap);
                            break;
                        case 14:
                            double.TryParse(textBoxX15.Text, out Points[N].XMeasured);
                            double.TryParse(textBoxY15.Text, out Points[N].YMeasured);
                            double.TryParse(textBoxXr15.Text, out Points[N].XRemap);
                            double.TryParse(textBoxYr15.Text, out Points[N].YRemap);
                            break;

                        default:
                            break;
                    }

                }
                catch
                {
                    MessageBox.Show("Assignment error");
                }


        }

        void CopyDataToText()
        {
            textBoxRotation.Text = rotation.ToString();
            textBoxXPitch.Text = XPitch.ToString();
            textBoxYPitch.Text = YPitch.ToString();
            textBoxFileName.Text = Filename;
            textBoxVerticalFilename.Text = VerticalFilename;
            textBoxInsulatorFilename.Text = InsulatorFilename;
            textBoxHorizontalFilename.Text = HorizontalFilename;

            textBoxFileLocation.Text = Path;

            textBox1.Text = RowNumber;

            textBoxPointX1.Text = X1.ToString();
            textBoxPointX2.Text = X2.ToString();
            textBoxPointY1.Text = Y1.ToString();
            textBoxPointY2.Text = Y2.ToString();

            for(int N=0; N<15; N++)
                try
                {
                    switch (N)
                    {

                        case 0:
                            textBoxX1.Text = Points[N].XMeasured.ToString();
                            textBoxY1.Text = Points[N].YMeasured.ToString();
                            textBoxXr1.Text = Points[N].XRemap.ToString();
                            textBoxYr1.Text = Points[N].YRemap.ToString();
                            break;
                        case 1:
                            textBoxX2.Text = Points[N].XMeasured.ToString();
                            textBoxY2.Text = Points[N].YMeasured.ToString();
                            textBoxXr2.Text = Points[N].XRemap.ToString();
                            textBoxYr2.Text = Points[N].YRemap.ToString();
                            break;
                        case 2:
                            textBoxX3.Text = Points[N].XMeasured.ToString();
                            textBoxY3.Text = Points[N].YMeasured.ToString();
                            textBoxXr3.Text = Points[N].XRemap.ToString();
                            textBoxYr3.Text = Points[N].YRemap.ToString();
                            break;
                        case 3:
                            textBoxX4.Text = Points[N].XMeasured.ToString();
                            textBoxY4.Text = Points[N].YMeasured.ToString();
                            textBoxXr4.Text = Points[N].XRemap.ToString();
                            textBoxYr4.Text = Points[N].YRemap.ToString();
                            break;
                        case 4:
                            textBoxX5.Text = Points[N].XMeasured.ToString();
                            textBoxY5.Text = Points[N].YMeasured.ToString();
                            textBoxXr5.Text = Points[N].XRemap.ToString();
                            textBoxYr5.Text = Points[N].YRemap.ToString();
                            break;
                        case 5:
                            textBoxX6.Text = Points[N].XMeasured.ToString();
                            textBoxY6.Text = Points[N].YMeasured.ToString();
                            textBoxXr6.Text = Points[N].XRemap.ToString();
                            textBoxYr6.Text = Points[N].YRemap.ToString();
                            break;
                        case 6:
                            textBoxX7.Text = Points[N].XMeasured.ToString();
                            textBoxY7.Text = Points[N].YMeasured.ToString();
                            textBoxXr7.Text = Points[N].XRemap.ToString();
                            textBoxYr7.Text = Points[N].YRemap.ToString();
                            break;
                        case 7:
                            textBoxX8.Text = Points[N].XMeasured.ToString();
                            textBoxY8.Text = Points[N].YMeasured.ToString();
                            textBoxXr8.Text = Points[N].XRemap.ToString();
                            textBoxYr8.Text = Points[N].YRemap.ToString();
                            break;
                        case 8:
                            textBoxX9.Text = Points[N].XMeasured.ToString();
                            textBoxY9.Text = Points[N].YMeasured.ToString();
                            textBoxXr9.Text = Points[N].XRemap.ToString();
                            textBoxYr9.Text = Points[N].YRemap.ToString();
                            break;
                        case 9:
                            textBoxX10.Text = Points[N].XMeasured.ToString();
                            textBoxY10.Text = Points[N].YMeasured.ToString();
                            textBoxXr10.Text = Points[N].XRemap.ToString();
                            textBoxYr10.Text = Points[N].YRemap.ToString();
                            break;
                        case 10:
                            textBoxX11.Text = Points[N].XMeasured.ToString();
                            textBoxY11.Text = Points[N].YMeasured.ToString();
                            textBoxXr11.Text = Points[N].XRemap.ToString();
                            textBoxYr11.Text = Points[N].YRemap.ToString();
                            break;
                        case 11:
                            textBoxX12.Text = Points[N].XMeasured.ToString();
                            textBoxY12.Text = Points[N].YMeasured.ToString();
                            textBoxXr12.Text = Points[N].XRemap.ToString();
                            textBoxYr12.Text = Points[N].YRemap.ToString();
                            break;
                        case 12:
                            textBoxX13.Text = Points[N].XMeasured.ToString();
                            textBoxY13.Text = Points[N].YMeasured.ToString();
                            textBoxXr13.Text = Points[N].XRemap.ToString();
                            textBoxYr13.Text = Points[N].YRemap.ToString();
                            break;
                        case 13:
                            textBoxX14.Text = Points[N].XMeasured.ToString();
                            textBoxY14.Text = Points[N].YMeasured.ToString();
                            textBoxXr14.Text = Points[N].XRemap.ToString();
                            textBoxYr14.Text = Points[N].YRemap.ToString();
                            break;
                        case 14:
                            textBoxX15.Text = Points[N].XMeasured.ToString();
                            textBoxY15.Text = Points[N].YMeasured.ToString();
                            textBoxXr15.Text = Points[N].XRemap.ToString();
                            textBoxYr15.Text = Points[N].YRemap.ToString();
                            break;

                        default:
                            break;
                    }

                }
                catch
                {
                    MessageBox.Show("Assignment error");
                }

        }

        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            //Read in current state of boxes
            CopyTextToData();

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files|*.txt";
            saveFileDialog1.Title = "Save a header file";
            saveFileDialog1.DefaultExt = ".txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                FileStream fs = File.Open(saveFileDialog1.FileName, FileMode.Create);
                StreamWriter writer = new StreamWriter(fs);

                foreach (Point P in Points)
                {
                    writer.WriteLine(P.XMeasured.ToString());
                    writer.WriteLine(P.YMeasured.ToString());
                }

                writer.Close();
                fs.Close();
                
            }
        }

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files|*.txt";
            openFileDialog1.Title = "Select a Data File";

            // Show the Dialog.
            // If the user clicked OK in the dialog and
            // a .txt file was selected, open it.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = File.Open(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                BinaryReader reader = new BinaryReader(fs);
                StreamReader sreader = new StreamReader(fs);
                
                try
                {
                    // If the file is not empty, 
                    // read the XY data in pairs 
                    // First read 4 bytes into a buffer to 
                    // determine if the file is empty.
                    byte[] testArray = new byte[3];
                    int count = reader.Read(testArray, 0, 3);
                    if (count != 0)
                    {

                        // Reset the position in the stream to zero.
                        reader.BaseStream.Seek(0, SeekOrigin.Begin);

                        //read lines from the stream
                        for (int N = 0; N < 15; N++)
                        {
                            double.TryParse(sreader.ReadLine().Trim(), out Points[N].XMeasured);
                            double.TryParse(sreader.ReadLine().Trim(), out Points[N].YMeasured);
                        }
                        //push data to text boxes
                        CopyDataToText();
                    }


                }

                // If the end of the stream is reached before reading 
                // the data values, clear all data

                catch (EndOfStreamException err)
                {
                    MessageBox.Show(err.GetType().Name);
                    
                }
                finally
                {
                    reader.Close();
                    sreader.Close();
                    fs.Close();
                    
                }
            }
        }

        private void buttonCalculateOffsets_Click(object sender, EventArgs e)
        {
            //update data
            CopyTextToData();

            double X = 0.0d;
            double Y = 0.0d;


            /*
            //stage XY offsets are opposite to measured offsets

            double anglerads = 2 * Math.PI * rotation / 360.0d;
            
            //apply rotation about 
            double Mat11 = Math.Cos(anglerads);
            double Mat12 = -1.0d * Math.Sin(anglerads);
            double Mat21 = Math.Sin(anglerads);
            double Mat22 = Math.Cos(anglerads);

            //rotate coords
            

            foreach (Point P in Points)
            {
                X = P.XMeasured;
                Y = P.YMeasured;

                P.XRemap = (X * Mat11 + Y * Mat21);
                P.YRemap = (X * Mat12 + Y * Mat22);

            }
            */
            for (int N = 0; N < 15; N++)
            {
                X = Points[N].XMeasured;
                Y = Points[N].YMeasured;

                Points[N].XRemap = (X - N * XPitch)*1000.0d;
                Points[N].YRemap = (Y - N * YPitch)*1000.0d;


                if (Points[N].XRemap < 0.00001d && Points[N].XRemap > -0.00001d)
                    Points[N].XRemap = 0.0000d;

                if (Points[N].YRemap < 0.00001d && Points[N].YRemap > -0.00001d)
                    Points[N].YRemap = 0.0000d;
            }
            

            CopyDataToText();
        }

        private void buttonSelectFiles_Click(object sender, EventArgs e)
        {
            /*
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "XML Files|*.xml";
            openFileDialog1.Title = "Select a base XML File";

            // Show the Dialog.
            // If the user clicked OK in the dialog and
            // a .txt file was selected, open it.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxFileLocation.Text = openFileDialog1.FileName;
            }
            */

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            string[] files = Directory.GetFiles(fbd.SelectedPath);
            MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
            textBoxFileLocation.Text = fbd.SelectedPath;
        }

        private void buttonWriteOffsets_Click(object sender, EventArgs e)
        {
            //buttonCalculateOffsets.PerformClick();
            CopyTextToData();
            FileStream fs;
            try
            {
                for (int N = 0; N < 15; N++)
                {
                    if (N > 8)
                        fs = File.Open(Path + @"\" + Filename + "X0" + (N + 1).ToString() + "Y"+RowNumber + ".dxf", FileMode.Create);
                    else
                        fs = File.Open(Path + @"\" + Filename + "X00" + (N + 1).ToString() + "Y"+RowNumber + ".dxf", FileMode.Create);


                    StreamWriter writer = new StreamWriter(fs);

                    //WRITE HEADER

                    writer.WriteLine("0");
                    writer.WriteLine("SECTION");
                    writer.WriteLine("2");
                    writer.WriteLine("ENTITIES");
                    writer.WriteLine("0");

                    //WRITE LINE
                    writer.WriteLine("LINE");
                    writer.WriteLine("8");
                    writer.WriteLine("0");
                    writer.WriteLine("10");
                    writer.WriteLine((X1 + Points[N].XRemap/1000.0d).ToString());
                    writer.WriteLine("11");
                    writer.WriteLine((X2 + Points[N].XRemap/1000.0d).ToString());
                    writer.WriteLine("20");
                    writer.WriteLine((Y1 + Points[N].YRemap/1000.0d).ToString());
                    writer.WriteLine("21");
                    writer.WriteLine((Y2 + Points[N].YRemap/1000.0d).ToString());
                    writer.WriteLine("0");

                    //WRITE FOOTER
                    writer.WriteLine("ENDSEC");
                    writer.WriteLine("0");
                    writer.WriteLine("EOF");

                    writer.Close();
                    fs.Close();
                }
            }
            catch
            {
                MessageBox.Show("File error - check not open elsewhere");
            }
        
        }

        private void buttonWriteVerticalDXF_Click(object sender, EventArgs e)
        {
            CopyTextToData();
            FileStream fs;
            try
            {
                for (int N = 0; N < 15; N++)
                {
                    if (N > 8)
                        fs = File.Open(Path + @"\" + VerticalFilename + "X0" + (N + 1).ToString() + "Y" + RowNumber + ".dxf", FileMode.Create);
                    else
                        fs = File.Open(Path + @"\" + VerticalFilename + "X00" + (N + 1).ToString() + "Y" + RowNumber + ".dxf", FileMode.Create);

                    StreamWriter writer = new StreamWriter(fs);

                    //WRITE HEADER

                    writer.WriteLine("0");
                    writer.WriteLine("SECTION");
                    writer.WriteLine("2");
                    writer.WriteLine("ENTITIES");
                    writer.WriteLine("0");

                    //WRITE LINE 1
                    writer.WriteLine("LINE");
                    writer.WriteLine("8");
                    writer.WriteLine("0");
                    writer.WriteLine("10");
                    writer.WriteLine((-1.9535 + Points[N].XRemap / 1000.0d).ToString());
                    writer.WriteLine("11");
                    writer.WriteLine((-1.9535 + Points[N].XRemap / 1000.0d).ToString());
                    writer.WriteLine("20");
                    writer.WriteLine((8.7594 + Points[N].YRemap / 1000.0d).ToString());
                    writer.WriteLine("21");
                    writer.WriteLine((-7.1506 + Points[N].YRemap / 1000.0d).ToString());
                    writer.WriteLine("0");

                    //WRITE LINE 2
                    writer.WriteLine("LINE");
                    writer.WriteLine("8");
                    writer.WriteLine("0");
                    writer.WriteLine("10");
                    writer.WriteLine((1.9535 + Points[N].XRemap / 1000.0d).ToString());
                    writer.WriteLine("11");
                    writer.WriteLine((1.9535 + Points[N].XRemap / 1000.0d).ToString());
                    writer.WriteLine("20");
                    writer.WriteLine((8.7594 + Points[N].YRemap / 1000.0d).ToString());
                    writer.WriteLine("21");
                    writer.WriteLine((-7.1506 + Points[N].YRemap / 1000.0d).ToString());
                    writer.WriteLine("0");

                    //WRITE FOOTER
                    writer.WriteLine("ENDSEC");
                    writer.WriteLine("0");
                    writer.WriteLine("EOF");

                    writer.Close();
                    fs.Close();
                }
            }
            catch
            {
                MessageBox.Show("File error - check not open elsewhere");
            }

        }

        private void buttonWriteInsulatorDXFs_Click(object sender, EventArgs e)
        {
            CopyTextToData();
            FileStream fs;
            try
            {
                for (int N = 0; N < 15; N++)
                {
                    if (N > 8)
                        fs = File.Open(Path + @"\" + InsulatorFilename + "X0" + (N + 1).ToString() + "Y" + RowNumber + ".dxf", FileMode.Create);
                    else
                        fs = File.Open(Path + @"\" + InsulatorFilename + "X00" + (N + 1).ToString() + "Y" + RowNumber + ".dxf", FileMode.Create);

                    StreamWriter writer = new StreamWriter(fs);

                    //WRITE HEADER

                    writer.WriteLine("0");
                    writer.WriteLine("SECTION");
                    writer.WriteLine("2");
                    writer.WriteLine("ENTITIES");
                    writer.WriteLine("0");

                    //WRITE LINE 1
                    writer.WriteLine("LINE");
                    writer.WriteLine("8");
                    writer.WriteLine("0");
                    writer.WriteLine("10");
                    writer.WriteLine((-2.0035 + Points[N].XRemap / 1000.0d).ToString());
                    writer.WriteLine("11");
                    writer.WriteLine((-2.0035 + Points[N].XRemap / 1000.0d).ToString());
                    writer.WriteLine("20");
                    writer.WriteLine((-6.8506 + Points[N].YRemap / 1000.0d).ToString());
                    writer.WriteLine("21");
                    writer.WriteLine((-7.9506 + Points[N].YRemap / 1000.0d).ToString());
                    writer.WriteLine("0");

                    //WRITE LINE 2
                    writer.WriteLine("LINE");
                    writer.WriteLine("8");
                    writer.WriteLine("0");
                    writer.WriteLine("10");
                    writer.WriteLine((-1.9035 + Points[N].XRemap / 1000.0d).ToString());
                    writer.WriteLine("11");
                    writer.WriteLine((-1.9035 + Points[N].XRemap / 1000.0d).ToString());
                    writer.WriteLine("20");
                    writer.WriteLine((-6.8506 + Points[N].YRemap / 1000.0d).ToString());
                    writer.WriteLine("21");
                    writer.WriteLine((-7.9506 + Points[N].YRemap / 1000.0d).ToString());
                    writer.WriteLine("0");

                    //WRITE LINE 3
                    writer.WriteLine("LINE");
                    writer.WriteLine("8");
                    writer.WriteLine("0");
                    writer.WriteLine("10");
                    writer.WriteLine((1.9035 + Points[N].XRemap / 1000.0d).ToString());
                    writer.WriteLine("11");
                    writer.WriteLine((1.9035 + Points[N].XRemap / 1000.0d).ToString());
                    writer.WriteLine("20");
                    writer.WriteLine((-6.8506 + Points[N].YRemap / 1000.0d).ToString());
                    writer.WriteLine("21");
                    writer.WriteLine((-7.9506 + Points[N].YRemap / 1000.0d).ToString());
                    writer.WriteLine("0");

                    //WRITE LINE 4
                    writer.WriteLine("LINE");
                    writer.WriteLine("8");
                    writer.WriteLine("0");
                    writer.WriteLine("10");
                    writer.WriteLine((2.0035 + Points[N].XRemap / 1000.0d).ToString());
                    writer.WriteLine("11");
                    writer.WriteLine((2.0035 + Points[N].XRemap / 1000.0d).ToString());
                    writer.WriteLine("20");
                    writer.WriteLine((-6.8506 + Points[N].YRemap / 1000.0d).ToString());
                    writer.WriteLine("21");
                    writer.WriteLine((-7.9506 + Points[N].YRemap / 1000.0d).ToString());
                    writer.WriteLine("0");

                    //WRITE FOOTER
                    writer.WriteLine("ENDSEC");
                    writer.WriteLine("0");
                    writer.WriteLine("EOF");

                    writer.Close();
                    fs.Close();
                }
            }
            catch
            {
                MessageBox.Show("File error - check not open elsewhere");
            }
           
        }

        private void buttonWriteHorizontalDXfs_Click(object sender, EventArgs e)
        {
            CopyTextToData();
            FileStream fs;
            int YIndex = 1;
            try
            {
                for (int N = 0; N < 15; N++)
                {

                    YIndex = 16 - (N + 1);

                    if (YIndex > 9)
                        fs = File.Open(Path + @"\" + HorizontalFilename + "X" + RowNumber + "Y0" + YIndex.ToString() + ".dxf", FileMode.Create);
                    else
                        fs = File.Open(Path + @"\" + HorizontalFilename + "X" + RowNumber + "Y00" + YIndex.ToString() + ".dxf", FileMode.Create);

                    StreamWriter writer = new StreamWriter(fs);

                    //WRITE HEADER

                    writer.WriteLine("0");
                    writer.WriteLine("SECTION");
                    writer.WriteLine("2");
                    writer.WriteLine("ENTITIES");
                    writer.WriteLine("0");

                    //WRITE LINE 1
                    writer.WriteLine("LINE");
                    writer.WriteLine("8");
                    writer.WriteLine("0");
                    writer.WriteLine("10");
                    writer.WriteLine((8.6594 + Points[N].YRemap / 1000.0d).ToString());
                    writer.WriteLine("11");
                    writer.WriteLine((8.6594 + Points[N].YRemap / 1000.0d).ToString());
                    writer.WriteLine("20");
                    writer.WriteLine((1.9535 - Points[N].XRemap / 1000.0d).ToString());
                    writer.WriteLine("21");
                    writer.WriteLine((-2.0535 - Points[N].XRemap / 1000.0d).ToString());
                    writer.WriteLine("0");

                    //WRITE LINE 2
                    writer.WriteLine("LINE");
                    writer.WriteLine("8");
                    writer.WriteLine("0");
                    writer.WriteLine("10");
                    writer.WriteLine((-7.4756 + Points[N].YRemap / 1000.0d).ToString());
                    writer.WriteLine("11");
                    writer.WriteLine((-7.4756 + Points[N].YRemap / 1000.0d).ToString());
                    writer.WriteLine("20");
                    writer.WriteLine((2.6285 - Points[N].XRemap / 1000.0d).ToString());
                    writer.WriteLine("21");
                    writer.WriteLine((-5.7855 - Points[N].XRemap / 1000.0d).ToString());
                    writer.WriteLine("0");

                    //WRITE LINE 3
                    writer.WriteLine("LINE");
                    writer.WriteLine("8");
                    writer.WriteLine("0");
                    writer.WriteLine("10");
                    writer.WriteLine((-7.3756 + Points[N].YRemap / 1000.0d).ToString());
                    writer.WriteLine("11");
                    writer.WriteLine((-7.3756 + Points[N].YRemap / 1000.0d).ToString());
                    writer.WriteLine("20");
                    writer.WriteLine((2.6285 - Points[N].XRemap / 1000.0d).ToString());
                    writer.WriteLine("21");
                    writer.WriteLine((-5.7855 - Points[N].XRemap / 1000.0d).ToString());
                    writer.WriteLine("0");

                    //WRITE LINE 4
                    writer.WriteLine("LINE");
                    writer.WriteLine("8");
                    writer.WriteLine("0");
                    writer.WriteLine("10");
                    writer.WriteLine((-7.4756 + Points[N].YRemap / 1000.0d).ToString());
                    writer.WriteLine("11");
                    writer.WriteLine((-7.4756 + Points[N].YRemap / 1000.0d).ToString());
                    writer.WriteLine("20");
                    writer.WriteLine((3.9570 - Points[N].XRemap / 1000.0d).ToString());
                    writer.WriteLine("21");
                    writer.WriteLine((2.1285 - Points[N].XRemap / 1000.0d).ToString());
                    writer.WriteLine("0");

                    //WRITE LINE 5
                    writer.WriteLine("LINE");
                    writer.WriteLine("8");
                    writer.WriteLine("0");
                    writer.WriteLine("10");
                    writer.WriteLine((-7.3756 + Points[N].YRemap / 1000.0d).ToString());
                    writer.WriteLine("11");
                    writer.WriteLine((-7.3756 + Points[N].YRemap / 1000.0d).ToString());
                    writer.WriteLine("20");
                    writer.WriteLine((3.9570 - Points[N].XRemap / 1000.0d).ToString());
                    writer.WriteLine("21");
                    writer.WriteLine((2.1285 - Points[N].XRemap / 1000.0d).ToString());
                    writer.WriteLine("0");

                    //WRITE FOOTER
                    writer.WriteLine("ENDSEC");
                    writer.WriteLine("0");
                    writer.WriteLine("EOF");

                    writer.Close();
                    fs.Close();
                }
            }
            catch
            {
                MessageBox.Show("File error - check not open elsewhere");
            }
        }

       

               
        
    }
}
