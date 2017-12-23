namespace CaptchaGenerator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupGenerate = new System.Windows.Forms.GroupBox();
            this.txtTestPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTrainPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numTestAmount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numTrainAmount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupPreview = new System.Windows.Forms.GroupBox();
            this.groupPreprocess = new System.Windows.Forms.GroupBox();
            this.groupTrain = new System.Windows.Forms.GroupBox();
            this.groupTest = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
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
            this.bntTestNN = new System.Windows.Forms.Button();
            this.bntTrainNN = new System.Windows.Forms.Button();
            this.bntPreprocessDatasets = new System.Windows.Forms.Button();
            this.bntGenerateDatasets = new System.Windows.Forms.Button();
            this.btnBrowseTestPath = new System.Windows.Forms.Button();
            this.btnBrowseTrainPath = new System.Windows.Forms.Button();
            this.picCaptchaPreview = new System.Windows.Forms.PictureBox();
            this.groupGenerate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTestAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrainAmount)).BeginInit();
            this.groupPreview.SuspendLayout();
            this.groupPreprocess.SuspendLayout();
            this.groupTrain.SuspendLayout();
            this.groupTest.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCaptchaPreview)).BeginInit();
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
            10000,
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
            300,
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
            this.groupPreview.Text = "Step #0: Captcha Preview";
            // 
            // groupPreprocess
            // 
            this.groupPreprocess.Controls.Add(this.bntPreprocessDatasets);
            this.groupPreprocess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupPreprocess.Location = new System.Drawing.Point(536, 34);
            this.groupPreprocess.Name = "groupPreprocess";
            this.groupPreprocess.Size = new System.Drawing.Size(515, 59);
            this.groupPreprocess.TabIndex = 1;
            this.groupPreprocess.TabStop = false;
            this.groupPreprocess.Text = "Step #2: Preprocessing";
            // 
            // groupTrain
            // 
            this.groupTrain.Controls.Add(this.bntTrainNN);
            this.groupTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupTrain.Location = new System.Drawing.Point(536, 99);
            this.groupTrain.Name = "groupTrain";
            this.groupTrain.Size = new System.Drawing.Size(515, 59);
            this.groupTrain.TabIndex = 1;
            this.groupTrain.TabStop = false;
            this.groupTrain.Text = "Step #3: Neural Network Training";
            // 
            // groupTest
            // 
            this.groupTest.Controls.Add(this.bntTestNN);
            this.groupTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupTest.Location = new System.Drawing.Point(536, 164);
            this.groupTest.Name = "groupTest";
            this.groupTest.Size = new System.Drawing.Size(515, 59);
            this.groupTest.TabIndex = 1;
            this.groupTest.TabStop = false;
            this.groupTest.Text = "Step #4: Neural Network Testing";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(15, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1042, 531);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step #5: Results Overview";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(300, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Captchas:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(363, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(300, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Symbols:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(363, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(459, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Correct Captchas:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(459, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Correct Symbols:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(568, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(568, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(666, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "Accuracy:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(730, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "-";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(666, 46);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 15);
            this.label17.TabIndex = 0;
            this.label17.Text = "Accuracy:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(730, 46);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 16);
            this.label18.TabIndex = 0;
            this.label18.Text = "-";
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Location = new System.Drawing.Point(9, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1027, 450);
            this.dataGridView1.TabIndex = 1;
            // 
            // Original
            // 
            this.Original.HeaderText = "Original";
            this.Original.Name = "Original";
            this.Original.ReadOnly = true;
            this.Original.Width = 230;
            // 
            // Processed
            // 
            this.Processed.HeaderText = "Processed";
            this.Processed.Name = "Processed";
            this.Processed.ReadOnly = true;
            this.Processed.Width = 230;
            // 
            // Symb1
            // 
            this.Symb1.HeaderText = "1";
            this.Symb1.Name = "Symb1";
            this.Symb1.ReadOnly = true;
            this.Symb1.Width = 50;
            // 
            // Symb2
            // 
            this.Symb2.HeaderText = "2";
            this.Symb2.Name = "Symb2";
            this.Symb2.ReadOnly = true;
            this.Symb2.Width = 50;
            // 
            // Symb3
            // 
            this.Symb3.HeaderText = "3";
            this.Symb3.Name = "Symb3";
            this.Symb3.ReadOnly = true;
            this.Symb3.Width = 50;
            // 
            // Symb4
            // 
            this.Symb4.HeaderText = "4";
            this.Symb4.Name = "Symb4";
            this.Symb4.ReadOnly = true;
            this.Symb4.Width = 50;
            // 
            // Symb5
            // 
            this.Symb5.HeaderText = "5";
            this.Symb5.Name = "Symb5";
            this.Symb5.ReadOnly = true;
            this.Symb5.Width = 50;
            // 
            // Guess
            // 
            this.Guess.HeaderText = "Guess";
            this.Guess.Name = "Guess";
            this.Guess.ReadOnly = true;
            this.Guess.Width = 80;
            // 
            // Answer
            // 
            this.Answer.HeaderText = "Answer";
            this.Answer.Name = "Answer";
            this.Answer.ReadOnly = true;
            this.Answer.Width = 80;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 50;
            // 
            // bntTestNN
            // 
            this.bntTestNN.Image = global::CaptchaGenerator.Properties.Resources.database_lightning;
            this.bntTestNN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntTestNN.Location = new System.Drawing.Point(187, 21);
            this.bntTestNN.Name = "bntTestNN";
            this.bntTestNN.Size = new System.Drawing.Size(200, 30);
            this.bntTestNN.TabIndex = 0;
            this.bntTestNN.Text = "Test Neural Network";
            this.bntTestNN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntTestNN.UseVisualStyleBackColor = true;
            this.bntTestNN.Click += new System.EventHandler(this.bntTestNN_Click);
            // 
            // bntTrainNN
            // 
            this.bntTrainNN.Image = global::CaptchaGenerator.Properties.Resources.database_refresh;
            this.bntTrainNN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntTrainNN.Location = new System.Drawing.Point(187, 21);
            this.bntTrainNN.Name = "bntTrainNN";
            this.bntTrainNN.Size = new System.Drawing.Size(200, 30);
            this.bntTrainNN.TabIndex = 0;
            this.bntTrainNN.Text = "Train Neural Network";
            this.bntTrainNN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntTrainNN.UseVisualStyleBackColor = true;
            this.bntTrainNN.Click += new System.EventHandler(this.bntTrainNN_Click);
            // 
            // bntPreprocessDatasets
            // 
            this.bntPreprocessDatasets.Image = global::CaptchaGenerator.Properties.Resources.picture_go;
            this.bntPreprocessDatasets.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntPreprocessDatasets.Location = new System.Drawing.Point(187, 21);
            this.bntPreprocessDatasets.Name = "bntPreprocessDatasets";
            this.bntPreprocessDatasets.Size = new System.Drawing.Size(200, 30);
            this.bntPreprocessDatasets.TabIndex = 0;
            this.bntPreprocessDatasets.Text = "Preprocess Datasets";
            this.bntPreprocessDatasets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntPreprocessDatasets.UseVisualStyleBackColor = true;
            this.bntPreprocessDatasets.Click += new System.EventHandler(this.bntPreprocessDatasets_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 764);
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
            this.groupPreprocess.ResumeLayout(false);
            this.groupTrain.ResumeLayout(false);
            this.groupTest.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCaptchaPreview)).EndInit();
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
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
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
    }
}

