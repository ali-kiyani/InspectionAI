using Exhibition.Backend.Controllers;
using Exhibition.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exhibition
{
    public partial class Form1 : Form
    {
        private Dictionary<int, int> TypeCountMap = new Dictionary<int, int>();
        private List<NewDetection> Detections = new List<NewDetection>();
        private int DefectsCount = 0;
        private int GoodCount = 0;
        public int ChartDuration = 0;
        public int CurrentDeployment = 1;
        public static Form1 Form1Instance;
        public Form1()
        {
            InitializeComponent();
            Form1Instance = this;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar2.Minimum = 0;
            progressBar2.Maximum = 100;
            progressBar3.Minimum = 0;
            progressBar3.Maximum = 100;
            progressBar4.Minimum = 0;
            progressBar4.Maximum = 100;
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar2.Style = ProgressBarStyle.Continuous;
            progressBar3.Style = ProgressBarStyle.Continuous;
            progressBar4.Style = ProgressBarStyle.Continuous;
            pictureBox1.Image = Image.FromFile("D:\\Visual Studio Repo\\Exhibition\\InspectionAI\\InspectionAI\\default.jpg");
            pictureBox2.Image = Image.FromFile("D:\\Visual Studio Repo\\Exhibition\\InspectionAI\\InspectionAI\\default.jpg");
            pictureBox3.Image = Image.FromFile("D:\\Visual Studio Repo\\Exhibition\\InspectionAI\\InspectionAI\\default.jpg");
            pictureBox4.Image = Image.FromFile("D:\\Visual Studio Repo\\Exhibition\\InspectionAI\\InspectionAI\\default.jpg");
            pictureBox12.Image = Image.FromFile("D:\\Visual Studio Repo\\Exhibition\\InspectionAI\\InspectionAI\\power.png");
            pictureBox10.Image = Image.FromFile("D:\\Visual Studio Repo\\Exhibition\\InspectionAI\\InspectionAI\\home3.png");
            pictureBox11.Image = Image.FromFile("D:\\Visual Studio Repo\\Exhibition\\InspectionAI\\InspectionAI\\options.png");
            pictureBox13.Image = Image.FromFile("D:\\Visual Studio Repo\\Exhibition\\InspectionAI\\InspectionAI\\logo.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.BackColor = Color.Transparent;
            pictureBox11.BackColor = Color.Transparent;
            pictureBox12.BackColor = Color.Transparent;
            chartArea1.AxisX.Title = "Timeline (hrs)";
            chartArea1.AxisY.Title = "Total";
        }

        public void SetCurrentDeployment(int CurrentDeployment)
        {
            if (this.CurrentDeployment != CurrentDeployment)
            {
                TypeCountMap = new Dictionary<int, int>();
                Detections = new List<NewDetection>();
                DefectsCount = 0;
                GoodCount = 0;
                CleanUI();
                UpdateUI();
                UpdateChart();
            }
            if (CurrentDeployment == 0 && this.CurrentDeployment != CurrentDeployment)
            {
                this.CurrentDeployment = CurrentDeployment;
                label8.Text = "-";
                label6.Text = "-";
                label7.Text = "-";
            }
            else if (CurrentDeployment == 1 && this.CurrentDeployment != CurrentDeployment)
            {
                this.CurrentDeployment = CurrentDeployment;
                label8.Text = "Good";
                label6.Text = "Scratchs";
                label7.Text = "Innercut";
                label6.Visible = true;
                label10.Visible = true;
                pictureBox7.Visible = true;
            }
            else if (CurrentDeployment == 2 && this.CurrentDeployment != CurrentDeployment)
            {
                this.CurrentDeployment = CurrentDeployment;
                label8.Text = "Good";
                label6.Text = "Stains";
                label6.Visible = false;
                label10.Visible = false;
                pictureBox7.Visible = false;
                label7.Text = "Holes";
            }
        }
        public void UIHandler(NewDetection Detection)
        {
            HandleStructure(Detection);
            UpdateUI();
            UpdateChart();
        }

        public void UIHandlerForBulk(List<NewDetection> Detection)
        {
            Detection.ForEach(x => HandleStructure(x));
            //HandleStructure(Detection);
            UpdateUI();
            UpdateChart();
        }

        public void CleanUI()
        {
            pictureBox1.Image = Image.FromFile("D:\\Visual Studio Repo\\Exhibition\\InspectionAI\\InspectionAI\\default.jpg");
            pictureBox2.Image = Image.FromFile("D:\\Visual Studio Repo\\Exhibition\\InspectionAI\\InspectionAI\\default.jpg");
            pictureBox3.Image = Image.FromFile("D:\\Visual Studio Repo\\Exhibition\\InspectionAI\\InspectionAI\\default.jpg");
            pictureBox4.Image = Image.FromFile("D:\\Visual Studio Repo\\Exhibition\\InspectionAI\\InspectionAI\\default.jpg");
            label1.Text = "-";
            progressBar1.Value = 0;
            label13.Text =  "-%";
            label2.Text = "-";
            progressBar2.Value = 0;
            label14.Text = "-%";
            label3.Text = "-";
            progressBar3.Value = 0;
            label15.Text = "-%";
            label4.Text = "-";
            progressBar4.Value = 0;
            label16.Text = "-%";
        }

        private void UpdateUI()
        {
            int Size = Detections.Count;
            if(Detections.Count >= 1)
            {

                pictureBox1.Image = Image.FromFile(Detections[Size-1].FileName);
                if (CurrentDeployment == 1)
                {
                    label1.Text = Enum.GetName(typeof(DetectionEnum), Detections[Size - 1].Type);
                }
                else if (CurrentDeployment == 2)
                {
                    label1.Text = Enum.GetName(typeof(TextileDetectionEnum), Detections[Size - 1].Type);
                }
                UpdateTextColor(Detections[Size - 1].Type, label1);
                progressBar1.Value = Convert.ToInt32(Detections[Size - 1].Confidence * 100);
                label13.Text = Convert.ToInt32(Detections[Size - 1].Confidence * 100) + "%";
                UpdateTextColor(Detections[Size - 1].Type, label13);
            }
            if (Detections.Count >= 2)
            {
                pictureBox2.Image = Image.FromFile(Detections[Size - 2].FileName);
                if (CurrentDeployment == 1)
                {
                    label2.Text = Enum.GetName(typeof(DetectionEnum), Detections[Size - 2].Type);
                }
                else if (CurrentDeployment == 2)
                {
                    label2.Text = Enum.GetName(typeof(TextileDetectionEnum), Detections[Size - 2].Type);
                }
                UpdateTextColor(Detections[Size - 2].Type, label2);
                progressBar2.Value = Convert.ToInt32(Detections[Size - 2].Confidence * 100);
                label14.Text = Convert.ToInt32(Detections[Size - 2].Confidence * 100) + "%";
                UpdateTextColor(Detections[Size - 2].Type, label14);
            }
            if (Detections.Count >= 3)
            {
                pictureBox3.Image = Image.FromFile(Detections[Size - 3].FileName);
                if (CurrentDeployment == 1)
                {
                    label3.Text = Enum.GetName(typeof(DetectionEnum), Detections[Size - 3].Type);
                }
                else if (CurrentDeployment == 2)
                {
                    label3.Text = Enum.GetName(typeof(TextileDetectionEnum), Detections[Size - 3].Type);
                }
                UpdateTextColor(Detections[Size - 3].Type, label3);
                progressBar3.Value = Convert.ToInt32(Detections[Size - 3].Confidence * 100);
                label15.Text = Convert.ToInt32(Detections[Size - 3].Confidence * 100) + "%";
                UpdateTextColor(Detections[Size - 3].Type, label15);
            }
            if (Detections.Count >= 4)
            {
                pictureBox4.Image = Image.FromFile(Detections[Size - 4].FileName);
                if (CurrentDeployment == 1)
                {
                    label4.Text = Enum.GetName(typeof(DetectionEnum), Detections[Size - 4].Type);
                }
                else if (CurrentDeployment == 2)
                {
                    label4.Text = Enum.GetName(typeof(TextileDetectionEnum), Detections[Size - 4].Type);
                }
                UpdateTextColor(Detections[Size - 4].Type, label4);
                progressBar4.Value = Convert.ToInt32(Detections[Size - 4].Confidence * 100);
                label16.Text = Convert.ToInt32(Detections[Size - 4].Confidence * 100) + "%";
                UpdateTextColor(Detections[Size - 4].Type, label16);
            }

            label9.Text = DefectsCount.ToString();
            if (TypeCountMap.ContainsKey((byte)DetectionEnum.SCRATCH))
                label10.Text = TypeCountMap[(byte)DetectionEnum.SCRATCH].ToString();
            else
                label10.Text = "0";
            if (TypeCountMap.ContainsKey((byte)DetectionEnum.INNERCUT))
                label11.Text = TypeCountMap[(byte)DetectionEnum.INNERCUT].ToString();
            else
                label11.Text = "0";
            label12.Text = GoodCount.ToString();
            label18.Text = (DefectsCount + GoodCount).ToString();

        }

        private void UpdateTextColor(int type, Label label)
        {
            if (type == (byte)DetectionEnum.GOOD)
            {
                label.ForeColor = Color.Green;
            }
            else if (type == (byte)DetectionEnum.INNERCUT)
            {
                label.ForeColor = Color.Red;
            }
            else if (type == (byte)DetectionEnum.SCRATCH)
            {
                label.ForeColor = Color.Orange;
            }
        }

        private void UpdateChart()
        {
            chart1.Series["Defects"].Points.Clear();
            chart1.Series["Good"].Points.Clear();
            if (ChartDuration == 0)
            {
                var today = Detections.FindAll(x => x.Datetime.Date.Equals(DateTime.Now.Date));
                today.Sort((x, y) => x.Datetime.CompareTo(y.Datetime));
                foreach (var items in today.GroupBy(m => m.Datetime.Hour).ToList())
                {
                    int Key = items.Key;
                    int Dcount = 0;
                    int Gcount = 0;
                    Gcount = items.Count(x => x.Type == (byte)DetectionEnum.GOOD);
                    Dcount = items.Count(x => x.Type == (byte)DetectionEnum.INNERCUT || x.Type == (byte)DetectionEnum.SCRATCH);
                    if (Dcount > 0)
                        chart1.Series["Defects"].Points.AddXY(Key.ToString(), Dcount);
                    if (Gcount > 0)
                        chart1.Series["Good"].Points.AddXY(Key.ToString(), Gcount);
                }
            }
            else if (ChartDuration == 1)
            {
                var week = Detections.FindAll(x => x.Datetime >= DateTime.Now.AddDays(-6));
                week.Sort((x, y) => x.Datetime.CompareTo(y.Datetime));
                foreach (var items in week.GroupBy(m => m.Datetime.DayOfWeek).ToList())
                {
                    String Key = items.Key.ToString();
                    int Dcount = 0;
                    int Gcount = 0;
                    Gcount = items.Count(x => x.Type == (byte)DetectionEnum.GOOD);
                    Dcount = items.Count(x => x.Type == (byte)DetectionEnum.INNERCUT || x.Type == (byte)DetectionEnum.SCRATCH);
                    if (Dcount > 0)
                        chart1.Series["Defects"].Points.AddXY(Key, Dcount);
                    if (Gcount > 0)
                        chart1.Series["Good"].Points.AddXY(Key, Gcount);
                }
            }
        }

        private void HandleStructure(NewDetection Detection)
        {
            if (TypeCountMap.ContainsKey(Detection.Type))
            {
                TypeCountMap[Detection.Type] = ++TypeCountMap[Detection.Type];
            }
            else
            {
                TypeCountMap.Add(Detection.Type, 1);
            }
            if (Detection.Type == (byte)DetectionEnum.GOOD)
                GoodCount++;
            else
                DefectsCount++;
            Detections.Add(Detection);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (lastWeek.Checked == true)
            {
                ChartDuration = 1;
                chartArea1.AxisX.Title = "Timeline (Days)";
                UpdateChart();
            }
            else if (Today.Checked == true)
            {
                ChartDuration = 0;
                chartArea1.AxisX.Title = "Timeline (hrs)";
                UpdateChart();
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
