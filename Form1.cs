using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace BackendChallenge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            slider.Height = 30;
            trackList.Font = new System.Drawing.Font("Century Gothic", 12, System.Drawing.FontStyle.Regular);

        }
        string[] paths, files;
        float Default_value = 0.1f, Min = 0.0f, Max = 1.0f;
        bool mouse=false;

        public float Bar(float value)
        {
            return (slider.Width -24) * (value - Min) / (float)(Max - Min);
        }

        public void thumb(float value)
        {
            if (value < Min) value = Min;
            if (value > Max) value = Max;
            Default_value = value;
            slider.Refresh();

        }

        public float slider_width(int x)
        {
            return Min + (Max - Min) * x / (float)(slider.Width);
        }

        private void trackList_SelectedIndexChanged(object sender, EventArgs e)
        {
            wmPlayer.URL = paths[trackList.SelectedIndex];
            wmPlayer.Ctlcontrols.play();
            comboBoxSpeed.Text = Convert.ToString(wmPlayer.settings.rate) + ",0";
            wmPlayer.settings.volume = trackBarVolume.Value = 15;
            lblVolume.Text = trackBarVolume.Value.ToString();
        }

        private void btnstartpause_Click(object sender, EventArgs e)
        {
            if (wmPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                wmPlayer.Ctlcontrols.pause();
            }
            else
            {
                wmPlayer.Ctlcontrols.play();
            }
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            wmPlayer.Ctlcontrols.stop();
        }

        private void btnforward_Click(object sender, EventArgs e)
        {
            wmPlayer.Ctlcontrols.currentPosition += 5;
        }

        private void btnbackward_Click(object sender, EventArgs e)
        {
            wmPlayer.Ctlcontrols.currentPosition -= 5;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (trackList.SelectedIndex < trackList.Items.Count - 1)
            {
                trackList.SelectedIndex = trackList.SelectedIndex + 1;
                wmPlayer.settings.volume = trackBarVolume.Value = 15;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (trackList.SelectedIndex > 0)
            {
                trackList.SelectedIndex = trackList.SelectedIndex + -1;
                wmPlayer.settings.volume = trackBarVolume.Value = 15;
            }
        }

        private void comboBoxSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            wmPlayer.settings.rate = Double.Parse(comboBoxSpeed.Text);
        }

        private void slider_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            thumb(slider_width(e.X));
            wmPlayer.Ctlcontrols.currentPosition = wmPlayer.currentMedia.duration * e.X / slider.Width;
        }

        private void slider_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouse) return;
            thumb(slider_width(e.X));
            wmPlayer.Ctlcontrols.currentPosition = wmPlayer.currentMedia.duration * e.X / slider.Width;
        }

        private void slider_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (wmPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                Max = (int)wmPlayer.Ctlcontrols.currentItem.duration;
                Default_value = (int)wmPlayer.Ctlcontrols.currentPosition;
                slider.Invalidate();

                labelStart.Text = wmPlayer.Ctlcontrols.currentPositionString;
                labelEnd.Text = wmPlayer.Ctlcontrols.currentItem.durationString;
            }
        }
        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            wmPlayer.settings.volume= trackBarVolume.Value;
            lblVolume.Text = trackBarVolume.Value.ToString();
        }

        private void slider_Paint(object sender, PaintEventArgs e)
        {
            float bar_size = 0.45f;
            float x = Bar(Default_value);
            int y = (int)(slider.Height * bar_size);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillRectangle(Brushes.DimGray, 0, y, slider.Width, y / 2);
            e.Graphics.FillRectangle(Brushes.Red, 0, y, x, slider.Height - 2 * y);


            using (Pen pen = new Pen(Color.Black, 8))
            {
                e.Graphics.DrawEllipse(pen, x + 4, y - 6, slider.Height / 2, slider.Height / 2);
                e.Graphics.FillEllipse(Brushes.Red, x + 4, y - 6, slider.Height / 2, slider.Height / 2);
            };

            using (Pen pen = new Pen(Color.White, 5))
            {
                e.Graphics.DrawEllipse(pen, x + 4, y - 6, slider.Height / 2, slider.Height / 2);

            };
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = openFileDialog.SafeFileNames;
                paths = openFileDialog.FileNames;

                for (int i = 0; i < files.Length; i++)
                {
                    trackList.Items.Add(files[i]);
                }
            }
        }
    }
}
