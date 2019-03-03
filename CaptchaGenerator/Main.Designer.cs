namespace CaptchaGenerator
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupGenerate = new System.Windows.Forms.GroupBox();
            this.txtTestPath = new System.Windows.Forms.TextBox();
            this.bntGenerateDatasets = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTrainPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseTestPath = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numTestAmount = new System.Windows.Forms.NumericUpDown();
            this.btnBrowseTrainPath = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numTrainAmount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupPreview = new System.Windows.Forms.GroupBox();
            this.picCaptchaPreview = new System.Windows.Forms.PictureBox();
            this.groupPreprocess = new System.Windows.Forms.GroupBox();
            this.lnkEmgu = new System.Windows.Forms.LinkLabel();
            this.lnkOpenCV = new System.Windows.Forms.LinkLabel();
            this.bntPreprocessDatasets = new System.Windows.Forms.Button();
            this.groupTrain = new System.Windows.Forms.GroupBox();
            this.lnkFANNSharp = new System.Windows.Forms.LinkLabel();
            this.bntTrainNN = new System.Windows.Forms.Button();
            this.lnkFANN = new System.Windows.Forms.LinkLabel();
            this.groupTest = new System.Windows.Forms.GroupBox();
            this.bntTestNN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Original = new System.Windows.Forms.DataGridViewImageColumn();
            this.Processed = new System.Windows.Forms.DataGridViewImageColumn();
            this.Symb1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Symb2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Symb3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Symb4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Symb5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Guess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewImageColumn();
            this.labTotalSymbolsCorrect = new System.Windows.Forms.Label();
            this.labSymbolsAccuracy = new System.Windows.Forms.Label();
            this.labCaptchasSpeed = new System.Windows.Forms.Label();
            this.labCaptchasAccuracy = new System.Windows.Forms.Label();
            this.labTotalSymbols = new System.Windows.Forms.Label();
            this.labTotalCaptchasCorrect = new System.Windows.Forms.Label();
            this.labTotalCaptchas = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupGenerate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTestAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrainAmount)).BeginInit();
            this.groupPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCaptchaPreview)).BeginInit();
            this.groupPreprocess.SuspendLayout();
            this.groupTrain.SuspendLayout();
            this.groupTest.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupGenerate
            // 
            this.groupGenerate.Controls.Add(this.txtTestPath);
            this.groupGenerate.Controls.Add(this.bntGenerateDatasets);
            this.groupGenerate.Controls.Add(this.label6);
            this.groupGenerate.Controls.Add(this.txtTrainPath);
            this.groupGenerate.Controls.Add(this.label5);
            this.groupGenerate.Controls.Add(this.label1);
            this.groupGenerate.Controls.Add(this.btnBrowseTestPath);
            this.groupGenerate.Controls.Add(this.label3);
            this.groupGenerate.Controls.Add(this.numTestAmount);
            this.groupGenerate.Controls.Add(this.btnBrowseTrainPath);
            this.groupGenerate.Controls.Add(this.label4);
            this.groupGenerate.Controls.Add(this.numTrainAmount);
            this.groupGenerate.Controls.Add(this.label2);
            this.groupGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupGenerate.Location = new System.Drawing.Point(15, 110);
            this.groupGenerate.Name = "groupGenerate";
            this.groupGenerate.Size = new System.Drawing.Size(515, 113);
            this.groupGenerate.TabIndex = 0;
            this.groupGenerate.TabStop = false;
            this.groupGenerate.Text = "Step #1: Generating Datasets";
            // 
            // txtTestPath
            // 
            this.txtTestPath.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTestPath.Location = new System.Drawing.Point(127, 45);
            this.txtTestPath.Name = "txtTestPath";
            this.txtTestPath.ReadOnly = true;
            this.txtTestPath.Size = new System.Drawing.Size(165, 21);
            this.txtTestPath.TabIndex = 1;
            this.txtTestPath.Text = "c:\\Users\\WD\\source\\repos\\CaptchaGenerator\\CaptchaGenerator\\bin\\Debug\\Testing\\";
            // 
            // bntGenerateDatasets
            // 
            this.bntGenerateDatasets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bntGenerateDatasets.Image = global::CaptchaGenerator.Properties.Resources.wand;
            this.bntGenerateDatasets.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntGenerateDatasets.Location = new System.Drawing.Point(187, 73);
            this.bntGenerateDatasets.Name = "bntGenerateDatasets";
            this.bntGenerateDatasets.Size = new System.Drawing.Size(200, 30);
            this.bntGenerateDatasets.TabIndex = 0;
            this.bntGenerateDatasets.Text = "Generate Datasets";
            this.bntGenerateDatasets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntGenerateDatasets.UseVisualStyleBackColor = true;
            this.bntGenerateDatasets.Click += new System.EventHandler(this.bntGenerate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Testing Set Output:";
            // 
            // txtTrainPath
            // 
            this.txtTrainPath.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTrainPath.Location = new System.Drawing.Point(127, 17);
            this.txtTrainPath.Name = "txtTrainPath";
            this.txtTrainPath.ReadOnly = true;
            this.txtTrainPath.Size = new System.Drawing.Size(165, 21);
            this.txtTrainPath.TabIndex = 1;
            this.txtTrainPath.Text = "c:\\Users\\WD\\source\\repos\\CaptchaGenerator\\CaptchaGenerator\\bin\\Debug\\Training\\";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(460, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "images";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Training Set Output:";
            // 
            // btnBrowseTestPath
            // 
            this.btnBrowseTestPath.Image = global::CaptchaGenerator.Properties.Resources.folder_explore;
            this.btnBrowseTestPath.Location = new System.Drawing.Point(298, 45);
            this.btnBrowseTestPath.Name = "btnBrowseTestPath";
            this.btnBrowseTestPath.Size = new System.Drawing.Size(33, 23);
            this.btnBrowseTestPath.TabIndex = 2;
            this.btnBrowseTestPath.UseVisualStyleBackColor = true;
            this.btnBrowseTestPath.Click += new System.EventHandler(this.btnBrowseTestPath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(460, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "images";
            // 
            // numTestAmount
            // 
            this.numTestAmount.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numTestAmount.Location = new System.Drawing.Point(395, 45);
            this.numTestAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numTestAmount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numTestAmount.Name = "numTestAmount";
            this.numTestAmount.Size = new System.Drawing.Size(65, 21);
            this.numTestAmount.TabIndex = 4;
            this.numTestAmount.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnBrowseTrainPath
            // 
            this.btnBrowseTrainPath.Image = global::CaptchaGenerator.Properties.Resources.folder_explore;
            this.btnBrowseTrainPath.Location = new System.Drawing.Point(298, 17);
            this.btnBrowseTrainPath.Name = "btnBrowseTrainPath";
            this.btnBrowseTrainPath.Size = new System.Drawing.Size(33, 23);
            this.btnBrowseTrainPath.TabIndex = 2;
            this.btnBrowseTrainPath.UseVisualStyleBackColor = true;
            this.btnBrowseTrainPath.Click += new System.EventHandler(this.btnBrowseTrainPath_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(337, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Amount:";
            // 
            // numTrainAmount
            // 
            this.numTrainAmount.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numTrainAmount.Location = new System.Drawing.Point(395, 17);
            this.numTrainAmount.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numTrainAmount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numTrainAmount.Name = "numTrainAmount";
            this.numTrainAmount.Size = new System.Drawing.Size(65, 21);
            this.numTrainAmount.TabIndex = 4;
            this.numTrainAmount.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(337, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amount:";
            // 
            // groupPreview
            // 
            this.groupPreview.Controls.Add(this.picCaptchaPreview);
            this.groupPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupPreview.Location = new System.Drawing.Point(170, 12);
            this.groupPreview.Name = "groupPreview";
            this.groupPreview.Size = new System.Drawing.Size(206, 95);
            this.groupPreview.TabIndex = 0;
            this.groupPreview.TabStop = false;
            this.groupPreview.Text = "Step #0: Captcha Preview (Click)";
            // 
            // picCaptchaPreview
            // 
            this.picCaptchaPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCaptchaPreview.Image = global::CaptchaGenerator.Properties.Resources.NoImageAvailable;
            this.picCaptchaPreview.Location = new System.Drawing.Point(3, 17);
            this.picCaptchaPreview.Name = "picCaptchaPreview";
            this.picCaptchaPreview.Size = new System.Drawing.Size(200, 75);
            this.picCaptchaPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCaptchaPreview.TabIndex = 0;
            this.picCaptchaPreview.TabStop = false;
            this.picCaptchaPreview.Click += new System.EventHandler(this.picCaptchaPreview_Click);
            // 
            // groupPreprocess
            // 
            this.groupPreprocess.Controls.Add(this.lnkEmgu);
            this.groupPreprocess.Controls.Add(this.lnkOpenCV);
            this.groupPreprocess.Controls.Add(this.bntPreprocessDatasets);
            this.groupPreprocess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupPreprocess.Location = new System.Drawing.Point(536, 12);
            this.groupPreprocess.Name = "groupPreprocess";
            this.groupPreprocess.Size = new System.Drawing.Size(360, 69);
            this.groupPreprocess.TabIndex = 1;
            this.groupPreprocess.TabStop = false;
            this.groupPreprocess.Text = "Step #2: Preprocessing";
            // 
            // lnkEmgu
            // 
            this.lnkEmgu.AutoSize = true;
            this.lnkEmgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkEmgu.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lnkEmgu.LinkArea = new System.Windows.Forms.LinkArea(5, 4);
            this.lnkEmgu.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.lnkEmgu.Location = new System.Drawing.Point(111, 50);
            this.lnkEmgu.Name = "lnkEmgu";
            this.lnkEmgu.Size = new System.Drawing.Size(54, 17);
            this.lnkEmgu.TabIndex = 1;
            this.lnkEmgu.TabStop = true;
            this.lnkEmgu.Text = " via Emgu";
            this.lnkEmgu.UseCompatibleTextRendering = true;
            this.lnkEmgu.VisitedLinkColor = System.Drawing.Color.Thistle;
            this.lnkEmgu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEmgu_LinkClicked);
            // 
            // lnkOpenCV
            // 
            this.lnkOpenCV.AutoSize = true;
            this.lnkOpenCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkOpenCV.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lnkOpenCV.LinkArea = new System.Windows.Forms.LinkArea(11, 17);
            this.lnkOpenCV.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.lnkOpenCV.Location = new System.Drawing.Point(5, 50);
            this.lnkOpenCV.Name = "lnkOpenCV";
            this.lnkOpenCV.Size = new System.Drawing.Size(110, 17);
            this.lnkOpenCV.TabIndex = 1;
            this.lnkOpenCV.TabStop = true;
            this.lnkOpenCV.Text = "Powered by OpenCV";
            this.lnkOpenCV.UseCompatibleTextRendering = true;
            this.lnkOpenCV.VisitedLinkColor = System.Drawing.Color.Thistle;
            this.lnkOpenCV.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkOpenCV_LinkClicked);
            // 
            // bntPreprocessDatasets
            // 
            this.bntPreprocessDatasets.Image = global::CaptchaGenerator.Properties.Resources.layers;
            this.bntPreprocessDatasets.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntPreprocessDatasets.Location = new System.Drawing.Point(90, 17);
            this.bntPreprocessDatasets.Name = "bntPreprocessDatasets";
            this.bntPreprocessDatasets.Size = new System.Drawing.Size(200, 30);
            this.bntPreprocessDatasets.TabIndex = 0;
            this.bntPreprocessDatasets.Text = "Preprocess Datasets";
            this.bntPreprocessDatasets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntPreprocessDatasets.UseVisualStyleBackColor = true;
            this.bntPreprocessDatasets.Click += new System.EventHandler(this.bntPreprocessDatasets_Click);
            // 
            // groupTrain
            // 
            this.groupTrain.Controls.Add(this.lnkFANNSharp);
            this.groupTrain.Controls.Add(this.bntTrainNN);
            this.groupTrain.Controls.Add(this.lnkFANN);
            this.groupTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupTrain.Location = new System.Drawing.Point(536, 87);
            this.groupTrain.Name = "groupTrain";
            this.groupTrain.Size = new System.Drawing.Size(360, 69);
            this.groupTrain.TabIndex = 1;
            this.groupTrain.TabStop = false;
            this.groupTrain.Text = "Step #3: Neural Network Training";
            // 
            // lnkFANNSharp
            // 
            this.lnkFANNSharp.AutoSize = true;
            this.lnkFANNSharp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkFANNSharp.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lnkFANNSharp.LinkArea = new System.Windows.Forms.LinkArea(5, 10);
            this.lnkFANNSharp.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.lnkFANNSharp.Location = new System.Drawing.Point(253, 50);
            this.lnkFANNSharp.Name = "lnkFANNSharp";
            this.lnkFANNSharp.Size = new System.Drawing.Size(94, 17);
            this.lnkFANNSharp.TabIndex = 1;
            this.lnkFANNSharp.TabStop = true;
            this.lnkFANNSharp.Text = " via FANNCSharp";
            this.lnkFANNSharp.UseCompatibleTextRendering = true;
            this.lnkFANNSharp.VisitedLinkColor = System.Drawing.Color.Thistle;
            this.lnkFANNSharp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFANNSharp_LinkClicked);
            // 
            // bntTrainNN
            // 
            this.bntTrainNN.Image = global::CaptchaGenerator.Properties.Resources.bricks;
            this.bntTrainNN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntTrainNN.Location = new System.Drawing.Point(90, 17);
            this.bntTrainNN.Name = "bntTrainNN";
            this.bntTrainNN.Size = new System.Drawing.Size(200, 30);
            this.bntTrainNN.TabIndex = 0;
            this.bntTrainNN.Text = "Train Neural Network";
            this.bntTrainNN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntTrainNN.UseVisualStyleBackColor = true;
            this.bntTrainNN.Click += new System.EventHandler(this.bntTrainNN_Click);
            // 
            // lnkFANN
            // 
            this.lnkFANN.AutoSize = true;
            this.lnkFANN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkFANN.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lnkFANN.LinkArea = new System.Windows.Forms.LinkArea(11, 37);
            this.lnkFANN.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.lnkFANN.Location = new System.Drawing.Point(4, 50);
            this.lnkFANN.Name = "lnkFANN";
            this.lnkFANN.Size = new System.Drawing.Size(254, 17);
            this.lnkFANN.TabIndex = 1;
            this.lnkFANN.TabStop = true;
            this.lnkFANN.Text = "Powered by FANN (Fast Artificial Neural Network)";
            this.lnkFANN.UseCompatibleTextRendering = true;
            this.lnkFANN.VisitedLinkColor = System.Drawing.Color.Thistle;
            this.lnkFANN.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFANN_LinkClicked);
            // 
            // groupTest
            // 
            this.groupTest.Controls.Add(this.bntTestNN);
            this.groupTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupTest.Location = new System.Drawing.Point(536, 164);
            this.groupTest.Name = "groupTest";
            this.groupTest.Size = new System.Drawing.Size(360, 59);
            this.groupTest.TabIndex = 1;
            this.groupTest.TabStop = false;
            this.groupTest.Text = "Step #4: Neural Network Testing";
            // 
            // bntTestNN
            // 
            this.bntTestNN.Image = global::CaptchaGenerator.Properties.Resources.lightbulb;
            this.bntTestNN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntTestNN.Location = new System.Drawing.Point(90, 23);
            this.bntTestNN.Name = "bntTestNN";
            this.bntTestNN.Size = new System.Drawing.Size(200, 30);
            this.bntTestNN.TabIndex = 0;
            this.bntTestNN.Text = "Test Neural Network";
            this.bntTestNN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntTestNN.UseVisualStyleBackColor = true;
            this.bntTestNN.Click += new System.EventHandler(this.bntTestNN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.labTotalSymbolsCorrect);
            this.groupBox1.Controls.Add(this.labSymbolsAccuracy);
            this.groupBox1.Controls.Add(this.labCaptchasSpeed);
            this.groupBox1.Controls.Add(this.labCaptchasAccuracy);
            this.groupBox1.Controls.Add(this.labTotalSymbols);
            this.groupBox1.Controls.Add(this.labTotalCaptchasCorrect);
            this.groupBox1.Controls.Add(this.labTotalCaptchas);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(15, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(889, 531);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step #5: Results Overview";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Original,
            this.Processed,
            this.Symb1,
            this.Symb2,
            this.Symb3,
            this.Symb4,
            this.Symb5,
            this.Guess,
            this.Answer,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(9, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 95;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(872, 465);
            this.dataGridView1.TabIndex = 1;
            // 
            // Original
            // 
            this.Original.DataPropertyName = "Original";
            this.Original.HeaderText = "Original";
            this.Original.MinimumWidth = 240;
            this.Original.Name = "Original";
            this.Original.ReadOnly = true;
            this.Original.Width = 240;
            // 
            // Processed
            // 
            this.Processed.DataPropertyName = "Processed";
            this.Processed.HeaderText = "Processed";
            this.Processed.MinimumWidth = 240;
            this.Processed.Name = "Processed";
            this.Processed.ReadOnly = true;
            this.Processed.Width = 240;
            // 
            // Symb1
            // 
            this.Symb1.DataPropertyName = "Symb1";
            this.Symb1.HeaderText = "1";
            this.Symb1.MinimumWidth = 40;
            this.Symb1.Name = "Symb1";
            this.Symb1.ReadOnly = true;
            this.Symb1.Width = 40;
            // 
            // Symb2
            // 
            this.Symb2.DataPropertyName = "Symb2";
            this.Symb2.HeaderText = "2";
            this.Symb2.MinimumWidth = 40;
            this.Symb2.Name = "Symb2";
            this.Symb2.ReadOnly = true;
            this.Symb2.Width = 40;
            // 
            // Symb3
            // 
            this.Symb3.DataPropertyName = "Symb3";
            this.Symb3.HeaderText = "3";
            this.Symb3.MinimumWidth = 40;
            this.Symb3.Name = "Symb3";
            this.Symb3.ReadOnly = true;
            this.Symb3.Width = 40;
            // 
            // Symb4
            // 
            this.Symb4.DataPropertyName = "Symb4";
            this.Symb4.HeaderText = "4";
            this.Symb4.MinimumWidth = 40;
            this.Symb4.Name = "Symb4";
            this.Symb4.ReadOnly = true;
            this.Symb4.Width = 40;
            // 
            // Symb5
            // 
            this.Symb5.DataPropertyName = "Symb5";
            this.Symb5.HeaderText = "5";
            this.Symb5.MinimumWidth = 40;
            this.Symb5.Name = "Symb5";
            this.Symb5.ReadOnly = true;
            this.Symb5.Width = 40;
            // 
            // Guess
            // 
            this.Guess.DataPropertyName = "Guess";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Guess.DefaultCellStyle = dataGridViewCellStyle1;
            this.Guess.HeaderText = "Guess";
            this.Guess.MinimumWidth = 60;
            this.Guess.Name = "Guess";
            this.Guess.ReadOnly = true;
            this.Guess.Width = 60;
            // 
            // Answer
            // 
            this.Answer.DataPropertyName = "Answer";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Answer.DefaultCellStyle = dataGridViewCellStyle2;
            this.Answer.HeaderText = "Answer";
            this.Answer.MinimumWidth = 60;
            this.Answer.Name = "Answer";
            this.Answer.ReadOnly = true;
            this.Answer.Width = 60;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 50;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 50;
            // 
            // labTotalSymbolsCorrect
            // 
            this.labTotalSymbolsCorrect.AutoSize = true;
            this.labTotalSymbolsCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labTotalSymbolsCorrect.Location = new System.Drawing.Point(369, 43);
            this.labTotalSymbolsCorrect.Name = "labTotalSymbolsCorrect";
            this.labTotalSymbolsCorrect.Size = new System.Drawing.Size(13, 16);
            this.labTotalSymbolsCorrect.TabIndex = 0;
            this.labTotalSymbolsCorrect.Text = "-";
            // 
            // labSymbolsAccuracy
            // 
            this.labSymbolsAccuracy.AutoSize = true;
            this.labSymbolsAccuracy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labSymbolsAccuracy.Location = new System.Drawing.Point(531, 41);
            this.labSymbolsAccuracy.Name = "labSymbolsAccuracy";
            this.labSymbolsAccuracy.Size = new System.Drawing.Size(13, 16);
            this.labSymbolsAccuracy.TabIndex = 0;
            this.labSymbolsAccuracy.Text = "-";
            // 
            // labCaptchasSpeed
            // 
            this.labCaptchasSpeed.AutoSize = true;
            this.labCaptchasSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labCaptchasSpeed.Location = new System.Drawing.Point(766, 18);
            this.labCaptchasSpeed.Name = "labCaptchasSpeed";
            this.labCaptchasSpeed.Size = new System.Drawing.Size(13, 16);
            this.labCaptchasSpeed.TabIndex = 0;
            this.labCaptchasSpeed.Text = "-";
            // 
            // labCaptchasAccuracy
            // 
            this.labCaptchasAccuracy.AutoSize = true;
            this.labCaptchasAccuracy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labCaptchasAccuracy.Location = new System.Drawing.Point(531, 17);
            this.labCaptchasAccuracy.Name = "labCaptchasAccuracy";
            this.labCaptchasAccuracy.Size = new System.Drawing.Size(13, 16);
            this.labCaptchasAccuracy.TabIndex = 0;
            this.labCaptchasAccuracy.Text = "-";
            // 
            // labTotalSymbols
            // 
            this.labTotalSymbols.AutoSize = true;
            this.labTotalSymbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labTotalSymbols.Location = new System.Drawing.Point(164, 42);
            this.labTotalSymbols.Name = "labTotalSymbols";
            this.labTotalSymbols.Size = new System.Drawing.Size(13, 16);
            this.labTotalSymbols.TabIndex = 0;
            this.labTotalSymbols.Text = "-";
            // 
            // labTotalCaptchasCorrect
            // 
            this.labTotalCaptchasCorrect.AutoSize = true;
            this.labTotalCaptchasCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labTotalCaptchasCorrect.Location = new System.Drawing.Point(369, 18);
            this.labTotalCaptchasCorrect.Name = "labTotalCaptchasCorrect";
            this.labTotalCaptchasCorrect.Size = new System.Drawing.Size(13, 16);
            this.labTotalCaptchasCorrect.TabIndex = 0;
            this.labTotalCaptchasCorrect.Text = "-";
            // 
            // labTotalCaptchas
            // 
            this.labTotalCaptchas.AutoSize = true;
            this.labTotalCaptchas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labTotalCaptchas.Location = new System.Drawing.Point(164, 17);
            this.labTotalCaptchas.Name = "labTotalCaptchas";
            this.labTotalCaptchas.Size = new System.Drawing.Size(13, 16);
            this.labTotalCaptchas.TabIndex = 0;
            this.labTotalCaptchas.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(260, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Correct Symbols:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(260, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Correct Captchas:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(631, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Avg Recognition Time:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(467, 41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 15);
            this.label17.TabIndex = 0;
            this.label17.Text = "Accuracy:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(467, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "Accuracy:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(101, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Symbols:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(101, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Captchas:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 764);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupTest);
            this.Controls.Add(this.groupTrain);
            this.Controls.Add(this.groupPreprocess);
            this.Controls.Add(this.groupGenerate);
            this.Controls.Add(this.groupPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Captcha Recognition [Serhii Bielik 5748106 for CS 3449 Machine Learning]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupGenerate.ResumeLayout(false);
            this.groupGenerate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTestAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrainAmount)).EndInit();
            this.groupPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCaptchaPreview)).EndInit();
            this.groupPreprocess.ResumeLayout(false);
            this.groupPreprocess.PerformLayout();
            this.groupTrain.ResumeLayout(false);
            this.groupTrain.PerformLayout();
            this.groupTest.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupGenerate;
        private System.Windows.Forms.Button btnBrowseTrainPath;
        private System.Windows.Forms.TextBox txtTrainPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntGenerateDatasets;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numTrainAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtTestPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBrowseTestPath;
        private System.Windows.Forms.NumericUpDown numTestAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupPreview;
        private System.Windows.Forms.PictureBox picCaptchaPreview;
        private System.Windows.Forms.GroupBox groupPreprocess;
        private System.Windows.Forms.Button bntPreprocessDatasets;
        private System.Windows.Forms.GroupBox groupTrain;
        private System.Windows.Forms.Button bntTrainNN;
        private System.Windows.Forms.GroupBox groupTest;
        private System.Windows.Forms.Button bntTestNN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labTotalSymbolsCorrect;
        private System.Windows.Forms.Label labSymbolsAccuracy;
        private System.Windows.Forms.Label labCaptchasAccuracy;
        private System.Windows.Forms.Label labTotalSymbols;
        private System.Windows.Forms.Label labTotalCaptchasCorrect;
        private System.Windows.Forms.Label labTotalCaptchas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel lnkEmgu;
        private System.Windows.Forms.LinkLabel lnkOpenCV;
        private System.Windows.Forms.LinkLabel lnkFANNSharp;
        private System.Windows.Forms.LinkLabel lnkFANN;
        private System.Windows.Forms.DataGridViewImageColumn Original;
        private System.Windows.Forms.DataGridViewImageColumn Processed;
        private System.Windows.Forms.DataGridViewImageColumn Symb1;
        private System.Windows.Forms.DataGridViewImageColumn Symb2;
        private System.Windows.Forms.DataGridViewImageColumn Symb3;
        private System.Windows.Forms.DataGridViewImageColumn Symb4;
        private System.Windows.Forms.DataGridViewImageColumn Symb5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Guess;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
        private System.Windows.Forms.DataGridViewImageColumn Status;
        private System.Windows.Forms.Label labCaptchasSpeed;
        private System.Windows.Forms.Label label8;
    }
}

