using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exhibition
{
    public partial class Form2 : Form
    {
        private int StepCount = 1;
        private int CurrentDeployment = 1;
        public static Form2 Form2instance;
        public Form2()
        {
            Form2instance = this;
            InitializeComponent();
            Back.Enabled = false;
            Back.Visible = false;
            Step2Box.Visible = false;
            Step3Box.Visible = false;
            Camera1.SelectedIndex = 1;
            SelectImage.Visible = false;
            pictureBox2.Image = Image.FromFile("D:\\Visual Studio Repo\\Exhibition\\InspectionAI\\logo.png");

        }

        public void SetCurrentDeployment()
        {
            Form1.Form1Instance.SetCurrentDeployment(this.CurrentDeployment);
        }

        private void myButton6_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in openFileDialog1.FileNames)
                {
                    try
                    {
                        PictureBox imageControl = new PictureBox();
                        imageControl.Height = 170;
                        imageControl.Width = 170;
                        imageControl.SizeMode = PictureBoxSizeMode.StretchImage;

                        imageControl.Image = Image.FromFile(file);

                        imageControl.Click += new System.EventHandler(this.ImageClicked);
                        flowLayoutPanel1.Controls.Add(imageControl);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                UploadImages.Visible = false;
                SelectImage.Visible = true;
            }

        }

        private void ImageClicked(object sender, EventArgs e)
        {
            SelectImage.Visible = false;
            var image = sender as PictureBox;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = image.Image;
        }

        public bool ThumbnailCallback()
        {
            return false;
        }

        private void myButton4_Click(object sender, EventArgs e)
        {
                StepCount++;
            if (StepCount == 2)
            {
                Step1Box.Visible = false;
                Step2Box.Visible = true;
                Back.Enabled = true;
                Back.Visible = true;
                this.Step1.BackColor = System.Drawing.Color.DarkTurquoise;
                this.Step1.BackgroundColor = System.Drawing.Color.DarkTurquoise;
                this.Step2.BackColor = System.Drawing.Color.MediumSlateBlue;
                this.Step2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
                this.Step2.BorderSize = 0;
                this.Step2.TextColor = Color.White;
            }
            if (StepCount == 3)
            {
                Step2Box.Visible = false;
                Step3Box.Visible = true;
                this.Step2.BackColor = System.Drawing.Color.DarkTurquoise;
                this.Step2.BackgroundColor = System.Drawing.Color.DarkTurquoise;
                this.Step2.BorderSize = 0;
                this.Step3.BackColor = System.Drawing.Color.MediumSlateBlue;
                this.Step3.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
                this.Step3.TextColor = Color.White;
                Next.Text = "Close";
            }
            if (StepCount == 4)
            {
                SetCurrentDeployment();
                this.Close();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (StepCount > 1)
                StepCount--;
            if (StepCount == 1)
            {
                Step2Box.Visible = false;
                Step1Box.Visible = true;
                this.Step2.BackColor = System.Drawing.Color.Transparent;
                this.Step2.BackgroundColor = System.Drawing.Color.Transparent;
                this.Step2.BorderColor = System.Drawing.Color.MediumSlateBlue;
                this.Step2.TextColor = System.Drawing.Color.MediumSlateBlue;
                this.Step2.BorderSize = 1;
                this.Step1.BackColor = System.Drawing.Color.MediumSlateBlue;
                this.Step1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
                this.Step1.TextColor = System.Drawing.Color.White;
                Back.Enabled = false;
                Back.Visible = false;
            }
            if (StepCount == 2)
            {
                Step3Box.Visible = false;
                Step2Box.Visible = true;
                this.Step3.BackColor = System.Drawing.Color.Transparent;
                this.Step3.BackgroundColor = System.Drawing.Color.Transparent;
                this.Step3.BorderColor = System.Drawing.Color.MediumSlateBlue;
                this.Step3.TextColor = System.Drawing.Color.MediumSlateBlue;
                this.Step3.BorderSize = 1;
                this.Step2.BackColor = System.Drawing.Color.MediumSlateBlue;
                this.Step2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
                this.Step2.TextColor = System.Drawing.Color.White;
                Next.Text = "Next";
            }
        }

        private void Deploy2_Click(object sender, EventArgs e)
        {
            if (CurrentDeployment == 1 || CurrentDeployment == 0)
            {
                CurrentDeployment = 2;
                Camera2.SelectedIndex = 1;
                Camera1.SelectedIndex = 0;
                Deploy1.Text = "Deploy";
                this.Deploy1.BackColor = System.Drawing.Color.Turquoise;
                this.Deploy1.BackgroundColor = System.Drawing.Color.Turquoise;
                this.Deploy2.Text = "Stop";
                this.Deploy2.BackColor = System.Drawing.Color.Crimson;
                this.Deploy2.BackgroundColor = System.Drawing.Color.Crimson;
            }
            else
            {
                Camera1.SelectedIndex = 0;
                Camera2.SelectedIndex = 0;
                CurrentDeployment = 0;
                Deploy2.Text = "Deploy";
                this.Deploy2.BackColor = System.Drawing.Color.Turquoise;
                this.Deploy2.BackgroundColor = System.Drawing.Color.Turquoise;
                Deploy1.Text = "Deploy";
                this.Deploy1.BackColor = System.Drawing.Color.Turquoise;
                this.Deploy1.BackgroundColor = System.Drawing.Color.Turquoise;
            }
        }

        private void Deploy1_Click(object sender, EventArgs e)
        {
            if (CurrentDeployment == 2 || CurrentDeployment == 0)
            {
                Camera1.SelectedIndex = 1;
                Camera2.SelectedIndex = 0;
                CurrentDeployment = 1;
                Deploy2.Text = "Deploy";
                this.Deploy2.BackColor = System.Drawing.Color.Turquoise;
                this.Deploy2.BackgroundColor = System.Drawing.Color.Turquoise;
                this.Deploy1.Text = "Stop";
                this.Deploy1.BackColor = System.Drawing.Color.Crimson;
                this.Deploy1.BackgroundColor = System.Drawing.Color.Crimson;
            }
            else
            {
                Camera1.SelectedIndex = 0;
                Camera2.SelectedIndex = 0;
                CurrentDeployment = 0;
                Deploy2.Text = "Deploy";
                this.Deploy2.BackColor = System.Drawing.Color.Turquoise;
                this.Deploy2.BackgroundColor = System.Drawing.Color.Turquoise;
                Deploy1.Text = "Deploy";
                this.Deploy1.BackColor = System.Drawing.Color.Turquoise;
                this.Deploy1.BackgroundColor = System.Drawing.Color.Turquoise;
            }
        }
    }
}
