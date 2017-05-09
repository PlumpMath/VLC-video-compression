using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KompresjaVideo
{
    public partial class Form1 : Form
    {
        public VlcManager VlcManager { get; set; }
        public bool InputFileOk { get; set; }
        public int VBitRate { get; set; }
        public int ABitRate { get; set; }
        public double FPS { get; set; }
        public double VideoScale { get; set; }
        public string VCodec { get; set; }
        public string ACodec { get; set; }

        public Form1()
        {
            InitializeComponent();
            InitializeBoxes();
            VlcManager = new VlcManager();
            InputFileOk = false;
        }

        private void btnVlcLocation_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.ShowDialog();
            VlcManager = new VlcManager(dialog.FileName);

            if(VlcManager.IsInitialized)
                textBoxVlcLocation.Text = dialog.FileName;

            ToggleGroupBoxes();
        }

        private void buttonFileInput_Click(object sender, EventArgs e)
        {
            if (VlcManager.IsInitialized)
            {
                var dialog = new OpenFileDialog();
                dialog.Multiselect = false;
                dialog.ShowDialog();

                textBoxInput.Text = dialog.FileName;
                VlcManager.FileName = dialog.FileName;
                InputFileOk = true;

                ToggleGroupBoxes();
            }
        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.DefaultExt = VCodec;
            dialog.ShowDialog();

            textBoxOutput.Text = dialog.FileName;
            VlcManager.FileDest = dialog.FileName;

            buttonTranscode.Enabled = true;
        }

        private void buttonTranscode_Click(object sender, EventArgs e)
        {
            textBoxScale.Text.Replace('.', ',');
            VideoScale = Double.Parse(textBoxScale.Text);
            VlcManager.Export(VCodec, ACodec, VBitRate, ABitRate, FPS, VideoScale);
        }

        private void ToggleGroupBoxes()
        {
            if(VlcManager.IsInitialized && InputFileOk)
            {
                groupBoxSettings.Enabled = true;
                groupBoxOutput.Enabled = true;
                labelVlcLocation.Text = "OK";
            }
            else
            {
                groupBoxSettings.Enabled = false;
                groupBoxOutput.Enabled = false;
            }
        }

        private void InitializeBoxes()
        {
            var vCodecs = new List<string>
            {
                "mp4v",
                "h264",
                "WMV3"
            };

            var aCodecs = new List<string>
            {
                "mp4a",
                "mp3",
                "flac"
            };

            comboBoxAudioCodec.Items.Add("mp3");
            comboBoxAudioCodec.Items.Add("flac");
            comboBoxAudioCodec.SelectedIndex = 1;

            comboBoxVideoCodec.Items.Add("mp4v");
            comboBoxVideoCodec.Items.Add("h264");
            comboBoxVideoCodec.Items.Add("WMV3");
            comboBoxVideoCodec.SelectedIndex = 1;

            textBoxVideoBitRate.Text = "1500";
            textBoxAudioBitRate.Text = "128";
            textBoxFPS.Text = "30";
            textBoxScale.Text = "1";
        }

        private void textBoxVideoBitRate_TextChanged(object sender, EventArgs e)
        {
            VBitRate = 1000;

            if (Int32.TryParse(textBoxVideoBitRate.Text, out int temp))
            {
                if (VBitRate > 0 && VBitRate < 100000)
                {
                    VBitRate = temp;
                }
            }

            textBoxVideoBitRate.Text = VBitRate.ToString();
        }

        private void textBoxFPS_TextChanged(object sender, EventArgs e)
        {
            FPS = 30;

            if (Double.TryParse(textBoxFPS.Text, out double temp))
            {
                if (FPS > 0 && FPS < 10000)
                {
                    FPS = temp;
                }
            }

            textBoxFPS.Text = FPS.ToString();
        }

        private void textBoxScale_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxAudioBitRate_TextChanged(object sender, EventArgs e)
        {
            ABitRate = 128;

            if (Int32.TryParse(textBoxAudioBitRate.Text, out int temp))
            {
                if (ABitRate > 0 && ABitRate < 10000)
                {
                    ABitRate = temp;
                }
            }

            textBoxAudioBitRate.Text = ABitRate.ToString();
        }

        private void comboBoxVideoCodec_SelectedIndexChanged(object sender, EventArgs e)
        {
            VCodec = comboBoxVideoCodec.SelectedItem.ToString();
        }

        private void comboBoxAudioCodec_SelectedIndexChanged(object sender, EventArgs e)
        {
            ACodec = comboBoxAudioCodec.SelectedItem.ToString();
        }
    }
}
