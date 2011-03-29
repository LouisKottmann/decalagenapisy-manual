/*    DecalageNapisy allows users to shift the time of SRT files, forward or backwards.
    Copyright (C) 2011  Louis Kottmann (louis.kottmann@gmail.com)

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>. 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DecalageNapisy
{
    public partial class NapisyForm : Form
    {
        public NapisyForm()
        {
            InitializeComponent();
            buttonDecaler.Enabled = false;
            textBoxDecaler.Enabled = false;
            comboBoxPM.Enabled = false;
            comboBoxPM.Text = "+";
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Filter = "SRT Files|*.srt";
            DialogResult result = fileOpen.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                textBoxLoad.Text = fileOpen.FileName;
                buttonDecaler.Enabled = true;
                textBoxDecaler.Enabled = true;
                comboBoxPM.Enabled = true;
            }
        }

        private String DecalerNapisy(String line)
        {
            String lineToReturn = String.Empty;
            String[] lineSplitted = line.Split(new char[5]{' ', '-', '-', '>', ' '}, StringSplitOptions.RemoveEmptyEntries);

            //First number
            String[] times = lineSplitted[0].Split(',');
            Int32 mSecs, hours, minutes, seconds;
            if (Int32.TryParse(times[1], out mSecs))
            {
                String[] HMS = times[0].Split(':');
                if ((Int32.TryParse(HMS[0], out hours)) && (Int32.TryParse(HMS[1], out minutes)) && (Int32.TryParse(HMS[2], out seconds)))
                {
                    TimeSpan tSpan = new TimeSpan(0, hours, minutes, seconds, mSecs);
                    if (isPlus)
                    {                        
                        tSpan = tSpan.Add(new TimeSpan(0, 0, 0, 0, timeDiff));                        
                    }
                    else
                    {
                        tSpan = tSpan.Subtract(new TimeSpan(0, 0, 0, 0, timeDiff));
                    }
                    lineToReturn = tSpan.Hours.ToString("00") 
                           + ":" + tSpan.Minutes.ToString("00")
                           + ":" + tSpan.Seconds.ToString("00")
                           + "," + tSpan.Milliseconds.ToString("000") 
                           + " --> ";
                }
            }

            //Second number
            String[] times2 = lineSplitted[1].Split(',');
            Int32 mSecs2, hours2, minutes2, seconds2;
            if (Int32.TryParse(times2[1], out mSecs2))
            {
                String[] HMS = times2[0].Split(':');
                if ((Int32.TryParse(HMS[0], out hours2)) && (Int32.TryParse(HMS[1], out minutes2)) && (Int32.TryParse(HMS[2], out seconds2)))
                {
                    TimeSpan tSpan = new TimeSpan(0, hours2, minutes2, seconds2, mSecs2);
                    if (isPlus)
                    {
                        tSpan = tSpan.Add(new TimeSpan(0, 0, 0, 0, timeDiff));
                    }
                    else
                    {
                        tSpan = tSpan.Subtract(new TimeSpan(0, 0, 0, 0, timeDiff));
                    }
                    lineToReturn += tSpan.Hours.ToString("00")
                            + ":" + tSpan.Minutes.ToString("00") 
                            + ":" + tSpan.Seconds.ToString("00")
                            + "," + tSpan.Milliseconds.ToString("000");
                }
            }

            return lineToReturn; 
        }

        private void buttonDecaler_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxDecaler.Text))
            {
                //input
                FileStream fStream = new FileStream(textBoxLoad.Text, FileMode.Open, FileAccess.Read);
                StreamReader fRead = new StreamReader(fStream);
                //output
                String outputPath = textBoxLoad.Text;
                outputPath = outputPath.Replace(".srt", "");
                outputPath += ".DS.srt";
                FileStream oStream = new FileStream(outputPath, FileMode.CreateNew, FileAccess.ReadWrite);
                StreamWriter oWrite = new StreamWriter(oStream);

                while (!fRead.EndOfStream)
                {
                    String lineRead = fRead.ReadLine();
                    if (lineRead.Contains(@"-->"))
                    {
                        lineRead = DecalerNapisy(lineRead);
                    }
                    oWrite.WriteLine(lineRead);
                }
                fRead.Close();
                fStream.Close();
                oWrite.Close();
                oStream.Close();                
                MessageBox.Show("All done!", "Work done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please input a number in milliseconds", "You forgot something!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBoxPM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPM.Text == "+")
            {
                isPlus = true;
            }
            else
            {
                isPlus = false;
            }
        }

        private void textBoxDecaler_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(textBoxDecaler.Text, out timeDiff);
        }

        Boolean isPlus = true;
        Int32 timeDiff = 0;
    }
}
