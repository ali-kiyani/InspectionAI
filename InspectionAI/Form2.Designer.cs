using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Exhibition
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Step2Box = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.MAP = new System.Windows.Forms.TextBox();
            this.Precision = new System.Windows.Forms.TextBox();
            this.Confidence = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TimeSplit = new System.Windows.Forms.Label();
            this.DatasetSize = new System.Windows.Forms.Label();
            this.ModelName = new System.Windows.Forms.Label();
            this.MAP2 = new System.Windows.Forms.Label();
            this.Prec = new System.Windows.Forms.Label();
            this.Rec = new System.Windows.Forms.Label();
            this.Conf = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TSplit = new System.Windows.Forms.Label();
            this.Mname = new System.Windows.Forms.Label();
            this.Dset = new System.Windows.Forms.Label();
            this.Recall = new System.Windows.Forms.TextBox();
            this.Step1Box = new System.Windows.Forms.GroupBox();
            this.SelectImage = new System.Windows.Forms.Label();
            this.UploadImages = new System.Windows.Forms.Label();
            this.ProjectName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.defect1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Step3Box = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Map5 = new System.Windows.Forms.Label();
            this.ConfThresh4 = new System.Windows.Forms.Label();
            this.ModelName4 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.Camera2 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Map4 = new System.Windows.Forms.Label();
            this.ConfThresh3 = new System.Windows.Forms.Label();
            this.ModelName3 = new System.Windows.Forms.Label();
            this.Action = new System.Windows.Forms.Label();
            this.Camera = new System.Windows.Forms.Label();
            this.Map3 = new System.Windows.Forms.Label();
            this.ConfThresh2 = new System.Windows.Forms.Label();
            this.ModelName2 = new System.Windows.Forms.Label();
            this.Camera1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.Step2Box.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.Step1Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.Step3Box.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Location = new System.Drawing.Point(531, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Step2Box
            // 
            this.Step2Box.Controls.Add(this.tableLayoutPanel2);
            this.Step2Box.Location = new System.Drawing.Point(49, 179);
            this.Step2Box.Name = "Step2Box";
            this.Step2Box.Size = new System.Drawing.Size(1642, 754);
            this.Step2Box.TabIndex = 0;
            this.Step2Box.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Controls.Add(this.MAP, 7, 1);
            this.tableLayoutPanel2.Controls.Add(this.Precision, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.Confidence, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.label11, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.TimeSplit, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.DatasetSize, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.ModelName, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.MAP2, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.Prec, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.Rec, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.Conf, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.TSplit, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Mname, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Dset, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Recall, 4, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(37, 112);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.6F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.4F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1566, 125);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // MAP
            // 
            this.MAP.Location = new System.Drawing.Point(1401, 77);
            this.MAP.Margin = new System.Windows.Forms.Padding(35, 15, 0, 0);
            this.MAP.Name = "MAP";
            this.MAP.Size = new System.Drawing.Size(125, 27);
            this.MAP.TabIndex = 1;
            this.MAP.Text = "0.35";
            // 
            // Precision
            // 
            this.Precision.Location = new System.Drawing.Point(1206, 77);
            this.Precision.Margin = new System.Windows.Forms.Padding(35, 15, 0, 0);
            this.Precision.Name = "Precision";
            this.Precision.Size = new System.Drawing.Size(125, 27);
            this.Precision.TabIndex = 1;
            this.Precision.Text = "0.30";
            // 
            // Confidence
            // 
            this.Confidence.Location = new System.Drawing.Point(816, 77);
            this.Confidence.Margin = new System.Windows.Forms.Padding(35, 15, 0, 0);
            this.Confidence.Name = "Confidence";
            this.Confidence.Size = new System.Drawing.Size(125, 27);
            this.Confidence.TabIndex = 1;
            this.Confidence.Text = "0.30";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(589, 62);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(40, 20, 0, 0);
            this.label11.Size = new System.Drawing.Size(188, 62);
            this.label11.TabIndex = 0;
            this.label11.Text = "3 hours 52 mins";
            // 
            // TimeSplit
            // 
            this.TimeSplit.AutoSize = true;
            this.TimeSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeSplit.Location = new System.Drawing.Point(394, 62);
            this.TimeSplit.Name = "TimeSplit";
            this.TimeSplit.Padding = new System.Windows.Forms.Padding(75, 20, 0, 0);
            this.TimeSplit.Size = new System.Drawing.Size(188, 62);
            this.TimeSplit.TabIndex = 0;
            this.TimeSplit.Text = "70:30";
            // 
            // DatasetSize
            // 
            this.DatasetSize.AutoSize = true;
            this.DatasetSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatasetSize.Location = new System.Drawing.Point(199, 62);
            this.DatasetSize.Name = "DatasetSize";
            this.DatasetSize.Padding = new System.Windows.Forms.Padding(75, 20, 0, 0);
            this.DatasetSize.Size = new System.Drawing.Size(188, 62);
            this.DatasetSize.TabIndex = 0;
            this.DatasetSize.Text = "-size-";
            // 
            // ModelName
            // 
            this.ModelName.AutoSize = true;
            this.ModelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModelName.Location = new System.Drawing.Point(4, 62);
            this.ModelName.Name = "ModelName";
            this.ModelName.Padding = new System.Windows.Forms.Padding(45, 20, 0, 0);
            this.ModelName.Size = new System.Drawing.Size(188, 62);
            this.ModelName.TabIndex = 0;
            this.ModelName.Text = "Custom CNN";
            // 
            // MAP2
            // 
            this.MAP2.AutoSize = true;
            this.MAP2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MAP2.Location = new System.Drawing.Point(1369, 1);
            this.MAP2.Name = "MAP2";
            this.MAP2.Padding = new System.Windows.Forms.Padding(75, 20, 0, 0);
            this.MAP2.Size = new System.Drawing.Size(193, 60);
            this.MAP2.TabIndex = 0;
            this.MAP2.Text = "mAP";
            // 
            // Prec
            // 
            this.Prec.AutoSize = true;
            this.Prec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Prec.Location = new System.Drawing.Point(1174, 1);
            this.Prec.Name = "Prec";
            this.Prec.Padding = new System.Windows.Forms.Padding(60, 20, 0, 0);
            this.Prec.Size = new System.Drawing.Size(188, 60);
            this.Prec.TabIndex = 0;
            this.Prec.Text = "Precision";
            // 
            // Rec
            // 
            this.Rec.AutoSize = true;
            this.Rec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rec.Location = new System.Drawing.Point(979, 1);
            this.Rec.Name = "Rec";
            this.Rec.Padding = new System.Windows.Forms.Padding(70, 20, 0, 0);
            this.Rec.Size = new System.Drawing.Size(188, 60);
            this.Rec.TabIndex = 0;
            this.Rec.Text = "Recall";
            // 
            // Conf
            // 
            this.Conf.AutoSize = true;
            this.Conf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Conf.Location = new System.Drawing.Point(784, 1);
            this.Conf.Name = "Conf";
            this.Conf.Padding = new System.Windows.Forms.Padding(30, 20, 0, 0);
            this.Conf.Size = new System.Drawing.Size(188, 60);
            this.Conf.TabIndex = 0;
            this.Conf.Text = "Confidence Thresh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(589, 1);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(45, 20, 0, 0);
            this.label4.Size = new System.Drawing.Size(188, 60);
            this.label4.TabIndex = 0;
            this.label4.Text = "Training Time";
            // 
            // TSplit
            // 
            this.TSplit.AutoSize = true;
            this.TSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TSplit.Location = new System.Drawing.Point(394, 1);
            this.TSplit.Name = "TSplit";
            this.TSplit.Padding = new System.Windows.Forms.Padding(40, 20, 0, 0);
            this.TSplit.Size = new System.Drawing.Size(188, 60);
            this.TSplit.TabIndex = 0;
            this.TSplit.Text = "Train Test Split";
            // 
            // Mname
            // 
            this.Mname.AutoSize = true;
            this.Mname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mname.Location = new System.Drawing.Point(4, 1);
            this.Mname.Name = "Mname";
            this.Mname.Padding = new System.Windows.Forms.Padding(45, 20, 0, 0);
            this.Mname.Size = new System.Drawing.Size(188, 60);
            this.Mname.TabIndex = 0;
            this.Mname.Text = "Model Name";
            // 
            // Dset
            // 
            this.Dset.AutoSize = true;
            this.Dset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dset.Location = new System.Drawing.Point(199, 1);
            this.Dset.Name = "Dset";
            this.Dset.Padding = new System.Windows.Forms.Padding(50, 20, 0, 0);
            this.Dset.Size = new System.Drawing.Size(188, 60);
            this.Dset.TabIndex = 0;
            this.Dset.Text = "Dataset Size";
            // 
            // Recall
            // 
            this.Recall.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Recall.Location = new System.Drawing.Point(1011, 77);
            this.Recall.Margin = new System.Windows.Forms.Padding(35, 15, 0, 0);
            this.Recall.Name = "Recall";
            this.Recall.Size = new System.Drawing.Size(125, 27);
            this.Recall.TabIndex = 1;
            this.Recall.Text = "0.35";
            // 
            // Step1Box
            // 
            this.Step1Box.Controls.Add(this.SelectImage);
            this.Step1Box.Controls.Add(this.UploadImages);
            this.Step1Box.Controls.Add(this.ProjectName);
            this.Step1Box.Controls.Add(this.pictureBox1);
            this.Step1Box.Controls.Add(this.flowLayoutPanel1);
            this.Step1Box.Controls.Add(this.groupBox3);
            this.Step1Box.Location = new System.Drawing.Point(49, 179);
            this.Step1Box.Name = "Step1Box";
            this.Step1Box.Size = new System.Drawing.Size(1642, 754);
            this.Step1Box.TabIndex = 1;
            this.Step1Box.TabStop = false;
            // 
            // SelectImage
            // 
            this.SelectImage.AutoSize = true;
            this.SelectImage.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectImage.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SelectImage.Location = new System.Drawing.Point(473, 298);
            this.SelectImage.Name = "SelectImage";
            this.SelectImage.Size = new System.Drawing.Size(746, 81);
            this.SelectImage.TabIndex = 5;
            this.SelectImage.Text = "Select Image to Show Here";
            // 
            // UploadImages
            // 
            this.UploadImages.AutoSize = true;
            this.UploadImages.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UploadImages.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.UploadImages.Location = new System.Drawing.Point(600, 288);
            this.UploadImages.Name = "UploadImages";
            this.UploadImages.Size = new System.Drawing.Size(433, 81);
            this.UploadImages.TabIndex = 4;
            this.UploadImages.Text = "Upload Images";
            // 
            // ProjectName
            // 
            this.ProjectName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProjectName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ProjectName.Location = new System.Drawing.Point(1412, 26);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(192, 31);
            this.ProjectName.TabIndex = 4;
            this.ProjectName.Text = "Enter Project Name";
            this.ProjectName.GotFocus += new System.EventHandler(this.GotFocusEvent);
            this.ProjectName.LostFocus += new System.EventHandler(this.LostFocusEvent);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(303, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1065, 714);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(29, 26);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(227, 714);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.defect1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(1412, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(191, 174);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Scratch";
            // 
            // defect1
            // 
            this.defect1.AutoSize = true;
            this.defect1.Location = new System.Drawing.Point(50, 65);
            this.defect1.Name = "defect1";
            this.defect1.Size = new System.Drawing.Size(41, 20);
            this.defect1.TabIndex = 2;
            this.defect1.Text = "Dent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(51, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Defect Book";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "jpg";
            this.openFileDialog1.Filter = "Image Files|*.jpg;*jpeg;*.png|All Files|*.*";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Title = "Browse Defect Images";
            // 
            // Step3Box
            // 
            this.Step3Box.Controls.Add(this.tableLayoutPanel3);
            this.Step3Box.Controls.Add(this.tableLayoutPanel1);
            this.Step3Box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Step3Box.Location = new System.Drawing.Point(49, 179);
            this.Step3Box.Name = "Step3Box";
            this.Step3Box.Size = new System.Drawing.Size(1642, 754);
            this.Step3Box.TabIndex = 0;
            this.Step3Box.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.Map5, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.ConfThresh4, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.ModelName4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label26, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.label27, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label28, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label29, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label30, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Camera2, 3, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(41, 372);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1566, 125);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // Map5
            // 
            this.Map5.AutoSize = true;
            this.Map5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Map5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Map5.Location = new System.Drawing.Point(630, 63);
            this.Map5.Name = "Map5";
            this.Map5.Padding = new System.Windows.Forms.Padding(130, 20, 0, 0);
            this.Map5.Size = new System.Drawing.Size(306, 61);
            this.Map5.TabIndex = 0;
            this.Map5.Text = "0.35";
            // 
            // ConfThresh4
            // 
            this.ConfThresh4.AutoSize = true;
            this.ConfThresh4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfThresh4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfThresh4.Location = new System.Drawing.Point(317, 63);
            this.ConfThresh4.Name = "ConfThresh4";
            this.ConfThresh4.Padding = new System.Windows.Forms.Padding(130, 20, 0, 0);
            this.ConfThresh4.Size = new System.Drawing.Size(306, 61);
            this.ConfThresh4.TabIndex = 0;
            this.ConfThresh4.Text = "0.30";
            // 
            // ModelName4
            // 
            this.ModelName4.AutoSize = true;
            this.ModelName4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModelName4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModelName4.Location = new System.Drawing.Point(4, 63);
            this.ModelName4.Name = "ModelName4";
            this.ModelName4.Padding = new System.Windows.Forms.Padding(95, 20, 0, 0);
            this.ModelName4.Size = new System.Drawing.Size(306, 61);
            this.ModelName4.TabIndex = 0;
            this.ModelName4.Text = "Custom CNN";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label26.Location = new System.Drawing.Point(1256, 1);
            this.label26.Name = "label26";
            this.label26.Padding = new System.Windows.Forms.Padding(125, 20, 0, 0);
            this.label26.Size = new System.Drawing.Size(306, 61);
            this.label26.TabIndex = 0;
            this.label26.Text = "Action";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label27.Location = new System.Drawing.Point(943, 1);
            this.label27.Name = "label27";
            this.label27.Padding = new System.Windows.Forms.Padding(120, 20, 0, 0);
            this.label27.Size = new System.Drawing.Size(306, 61);
            this.label27.TabIndex = 0;
            this.label27.Text = "Camera";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label28.Location = new System.Drawing.Point(630, 1);
            this.label28.Name = "label28";
            this.label28.Padding = new System.Windows.Forms.Padding(130, 20, 0, 0);
            this.label28.Size = new System.Drawing.Size(306, 61);
            this.label28.TabIndex = 0;
            this.label28.Text = "mAP";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label29.Location = new System.Drawing.Point(317, 1);
            this.label29.Name = "label29";
            this.label29.Padding = new System.Windows.Forms.Padding(80, 20, 0, 0);
            this.label29.Size = new System.Drawing.Size(306, 61);
            this.label29.TabIndex = 0;
            this.label29.Text = "ConfidenceThresh";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label30.Location = new System.Drawing.Point(4, 1);
            this.label30.Name = "label30";
            this.label30.Padding = new System.Windows.Forms.Padding(100, 20, 0, 0);
            this.label30.Size = new System.Drawing.Size(306, 61);
            this.label30.TabIndex = 0;
            this.label30.Text = "Model Name";
            // 
            // Camera2
            // 
            this.Camera2.BackColor = System.Drawing.Color.White;
            this.Camera2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Camera2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Camera2.ForeColor = System.Drawing.Color.Black;
            this.Camera2.FormattingEnabled = true;
            this.Camera2.Items.AddRange(new object[] {
            "--Select--",
            "Camera 1"});
            this.Camera2.Location = new System.Drawing.Point(975, 78);
            this.Camera2.Margin = new System.Windows.Forms.Padding(35, 15, 3, 3);
            this.Camera2.Name = "Camera2";
            this.Camera2.Size = new System.Drawing.Size(239, 31);
            this.Camera2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.Map4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ConfThresh3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ModelName3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Action, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.Camera, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Map3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ConfThresh2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ModelName2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Camera1, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(37, 120);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1566, 125);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Map4
            // 
            this.Map4.AutoSize = true;
            this.Map4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Map4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Map4.Location = new System.Drawing.Point(630, 63);
            this.Map4.Name = "Map4";
            this.Map4.Padding = new System.Windows.Forms.Padding(130, 20, 0, 0);
            this.Map4.Size = new System.Drawing.Size(306, 61);
            this.Map4.TabIndex = 0;
            this.Map4.Text = "0.35";
            // 
            // ConfThresh3
            // 
            this.ConfThresh3.AutoSize = true;
            this.ConfThresh3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfThresh3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfThresh3.Location = new System.Drawing.Point(317, 63);
            this.ConfThresh3.Name = "ConfThresh3";
            this.ConfThresh3.Padding = new System.Windows.Forms.Padding(130, 20, 0, 0);
            this.ConfThresh3.Size = new System.Drawing.Size(306, 61);
            this.ConfThresh3.TabIndex = 0;
            this.ConfThresh3.Text = "0.30";
            // 
            // ModelName3
            // 
            this.ModelName3.AutoSize = true;
            this.ModelName3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModelName3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModelName3.Location = new System.Drawing.Point(4, 63);
            this.ModelName3.Name = "ModelName3";
            this.ModelName3.Padding = new System.Windows.Forms.Padding(95, 20, 0, 0);
            this.ModelName3.Size = new System.Drawing.Size(306, 61);
            this.ModelName3.TabIndex = 0;
            this.ModelName3.Text = "Custom CNN";
            // 
            // Action
            // 
            this.Action.AutoSize = true;
            this.Action.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Action.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Action.Location = new System.Drawing.Point(1256, 1);
            this.Action.Name = "Action";
            this.Action.Padding = new System.Windows.Forms.Padding(125, 20, 0, 0);
            this.Action.Size = new System.Drawing.Size(306, 61);
            this.Action.TabIndex = 0;
            this.Action.Text = "Action";
            // 
            // Camera
            // 
            this.Camera.AutoSize = true;
            this.Camera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Camera.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Camera.Location = new System.Drawing.Point(943, 1);
            this.Camera.Name = "Camera";
            this.Camera.Padding = new System.Windows.Forms.Padding(120, 20, 0, 0);
            this.Camera.Size = new System.Drawing.Size(306, 61);
            this.Camera.TabIndex = 0;
            this.Camera.Text = "Camera";
            // 
            // Map3
            // 
            this.Map3.AutoSize = true;
            this.Map3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Map3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Map3.Location = new System.Drawing.Point(630, 1);
            this.Map3.Name = "Map3";
            this.Map3.Padding = new System.Windows.Forms.Padding(130, 20, 0, 0);
            this.Map3.Size = new System.Drawing.Size(306, 61);
            this.Map3.TabIndex = 0;
            this.Map3.Text = "mAP";
            // 
            // ConfThresh2
            // 
            this.ConfThresh2.AutoSize = true;
            this.ConfThresh2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfThresh2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfThresh2.Location = new System.Drawing.Point(317, 1);
            this.ConfThresh2.Name = "ConfThresh2";
            this.ConfThresh2.Padding = new System.Windows.Forms.Padding(80, 20, 0, 0);
            this.ConfThresh2.Size = new System.Drawing.Size(306, 61);
            this.ConfThresh2.TabIndex = 0;
            this.ConfThresh2.Text = "ConfidenceThresh";
            // 
            // ModelName2
            // 
            this.ModelName2.AutoSize = true;
            this.ModelName2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModelName2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModelName2.Location = new System.Drawing.Point(4, 1);
            this.ModelName2.Name = "ModelName2";
            this.ModelName2.Padding = new System.Windows.Forms.Padding(100, 20, 0, 0);
            this.ModelName2.Size = new System.Drawing.Size(306, 61);
            this.ModelName2.TabIndex = 0;
            this.ModelName2.Text = "Model Name";
            // 
            // Camera1
            // 
            this.Camera1.BackColor = System.Drawing.Color.White;
            this.Camera1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Camera1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Camera1.ForeColor = System.Drawing.Color.Black;
            this.Camera1.FormattingEnabled = true;
            this.Camera1.Items.AddRange(new object[] {
            "--Select--",
            "Camera 1"});
            this.Camera1.Location = new System.Drawing.Point(975, 78);
            this.Camera1.Margin = new System.Windows.Forms.Padding(35, 15, 3, 3);
            this.Camera1.Name = "Camera1";
            this.Camera1.Size = new System.Drawing.Size(239, 31);
            this.Camera1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(630, 63);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(100, 20, 0, 0);
            this.label2.Size = new System.Drawing.Size(306, 61);
            this.label2.TabIndex = 0;
            this.label2.Text = "-mAP-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(317, 63);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(100, 20, 0, 0);
            this.label5.Size = new System.Drawing.Size(306, 61);
            this.label5.TabIndex = 0;
            this.label5.Text = "-ConfThresh-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(4, 63);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(100, 20, 0, 0);
            this.label6.Size = new System.Drawing.Size(306, 61);
            this.label6.TabIndex = 0;
            this.label6.Text = "-Model Name-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1256, 1);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(125, 20, 0, 0);
            this.label7.Size = new System.Drawing.Size(306, 61);
            this.label7.TabIndex = 0;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(943, 1);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(120, 20, 0, 0);
            this.label8.Size = new System.Drawing.Size(306, 61);
            this.label8.TabIndex = 0;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(630, 1);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(130, 20, 0, 0);
            this.label9.Size = new System.Drawing.Size(306, 61);
            this.label9.TabIndex = 0;
            this.label9.Text = "mAP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(317, 1);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(80, 20, 0, 0);
            this.label10.Size = new System.Drawing.Size(306, 61);
            this.label10.TabIndex = 0;
            this.label10.Text = "ConfidenceThresh";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(4, 1);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(100, 20, 0, 0);
            this.label12.Size = new System.Drawing.Size(306, 61);
            this.label12.TabIndex = 0;
            this.label12.Text = "Model Name";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox2.ForeColor = System.Drawing.Color.White;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(975, 78);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(35, 15, 3, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(239, 31);
            this.comboBox2.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(4, 1);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(100, 20, 0, 0);
            this.label13.Size = new System.Drawing.Size(306, 61);
            this.label13.TabIndex = 0;
            this.label13.Text = "Model Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(630, 63);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(100, 20, 0, 0);
            this.label14.Size = new System.Drawing.Size(306, 61);
            this.label14.TabIndex = 0;
            this.label14.Text = "-mAP-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(317, 63);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(100, 20, 0, 0);
            this.label15.Size = new System.Drawing.Size(306, 61);
            this.label15.TabIndex = 0;
            this.label15.Text = "-ConfThresh-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(4, 63);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(100, 20, 0, 0);
            this.label16.Size = new System.Drawing.Size(306, 61);
            this.label16.TabIndex = 0;
            this.label16.Text = "-Model Name-";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(1256, 1);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(125, 20, 0, 0);
            this.label17.Size = new System.Drawing.Size(306, 61);
            this.label17.TabIndex = 0;
            this.label17.Text = "label17";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(943, 1);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(120, 20, 0, 0);
            this.label18.Size = new System.Drawing.Size(306, 61);
            this.label18.TabIndex = 0;
            this.label18.Text = "label18";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(630, 1);
            this.label19.Name = "label19";
            this.label19.Padding = new System.Windows.Forms.Padding(130, 20, 0, 0);
            this.label19.Size = new System.Drawing.Size(306, 61);
            this.label19.TabIndex = 0;
            this.label19.Text = "mAP";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(317, 1);
            this.label20.Name = "label20";
            this.label20.Padding = new System.Windows.Forms.Padding(80, 20, 0, 0);
            this.label20.Size = new System.Drawing.Size(306, 61);
            this.label20.TabIndex = 0;
            this.label20.Text = "ConfidenceThresh";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(4, 1);
            this.label21.Name = "label21";
            this.label21.Padding = new System.Windows.Forms.Padding(100, 20, 0, 0);
            this.label21.Size = new System.Drawing.Size(306, 61);
            this.label21.TabIndex = 0;
            this.label21.Text = "Model Name";
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.White;
            this.comboBox3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox3.ForeColor = System.Drawing.Color.White;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(975, 78);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(35, 15, 3, 3);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(239, 31);
            this.comboBox3.TabIndex = 2;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(4, 1);
            this.label22.Name = "label22";
            this.label22.Padding = new System.Windows.Forms.Padding(100, 20, 0, 0);
            this.label22.Size = new System.Drawing.Size(306, 61);
            this.label22.TabIndex = 0;
            this.label22.Text = "Model Name";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.Step1Box);
            this.Controls.Add(this.Step2Box);
            this.Controls.Add(this.Step3Box);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Inspection AI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Step2Box.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.Step1Box.ResumeLayout(false);
            this.Step1Box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Step3Box.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void LostFocusEvent(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ProjectName.Text))
            {
                ProjectName.Text = "Enter Project Name";
                this.ProjectName.ForeColor = System.Drawing.SystemColors.WindowFrame;

            }
        }

        private void GotFocusEvent(object sender, EventArgs e)
        {
            if (ProjectName.Text == "Enter Project Name")
            {
                ProjectName.Text = "";
                this.ProjectName.ForeColor = Color.Black;
            }
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Step1Box;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label defect1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        private System.Windows.Forms.GroupBox Step2Box;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label MAP2;
        private System.Windows.Forms.Label Prec;
        private System.Windows.Forms.Label Rec;
        private System.Windows.Forms.Label Conf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TSplit;
        private System.Windows.Forms.Label Mname;
        private System.Windows.Forms.Label Dset;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label TimeSplit;
        private System.Windows.Forms.Label DatasetSize;
        private System.Windows.Forms.Label ModelName;
        private System.Windows.Forms.TextBox Recall;
        private System.Windows.Forms.TextBox Confidence;
        private System.Windows.Forms.TextBox MAP;
        private System.Windows.Forms.TextBox Precision;
        private System.Windows.Forms.GroupBox Step3Box;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ModelName2;
        private System.Windows.Forms.Label Action;
        private System.Windows.Forms.Label Camera;
        private System.Windows.Forms.Label Map3;
        private System.Windows.Forms.Label ConfThresh2;
        private System.Windows.Forms.Label Map4;
        private System.Windows.Forms.Label ConfThresh3;
        private System.Windows.Forms.Label ModelName3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label Map5;
        private System.Windows.Forms.Label ConfThresh4;
        private System.Windows.Forms.Label ModelName4;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ComboBox Camera2;
        private System.Windows.Forms.ComboBox Camera1;
        private System.Windows.Forms.TextBox ProjectName;
        private System.Windows.Forms.Label UploadImages;
        private System.Windows.Forms.Label SelectImage;
        private CustomUI.MyButton2 Step3;
        private CustomUI.MyButton2 Step2;
        private CustomUI.MyButton2 Step1;
        private CustomUI.MyButton2 myButton6;
        private CustomUI.MyButton2 myButton22;
        private CustomUI.MyButton2 myButton21;
        private CustomUI.MyButton2 myButton23;
        private CustomUI.MyButton2 Next;
        private CustomUI.MyButton2 Back;
        private CustomUI.MyButton2 Deploy1;
        private CustomUI.MyButton2 Deploy2;
        private CustomUI.MyButton2 myButton24;
        private CustomUI.MyButton2 myButton25;
        private CustomUI.MyButton2 myButton26;
    }
}