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
            this.label3 = new System.Windows.Forms.Label();
            this.numTrainAmount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTrainPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupPreview = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numTestAmount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTestPath = new System.Windows.Forms.TextBox();
            this.groupPreprocess = new System.Windows.Forms.GroupBox();
            this.groupTrain = new System.Windows.Forms.GroupBox();
            this.groupTest = new System.Windows.Forms.GroupBox();
            this.bntTestNN = new System.Windows.Forms.Button();
            this.bntTrainNN = new System.Windows.Forms.Button();
            this.bntPreprocessDatasets = new System.Windows.Forms.Button();
            this.bntGenerateDatasets = new System.Windows.Forms.Button();
            this.btnBrowseTestPath = new System.Windows.Forms.Button();
            this.btnBrowseTrainPath = new System.Windows.Forms.Button();
            this.picCaptchaPreview = new System.Windows.Forms.PictureBox();
            this.groupGenerate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTrainAmount)).BeginInit();
            this.groupPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTestAmount)).BeginInit();
            this.groupPreprocess.SuspendLayout();
            this.groupTrain.SuspendLayout();
            this.groupTest.SuspendLayout();
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
            this.groupGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupGenerate.Location = new System.Drawing.Point(15, 132);
            this.groupGenerate.Name = "groupGenerate";
            this.groupGenerate.Size = new System.Drawing.Size(515, 114);
            this.groupGenerate.TabIndex = 0;
            this.groupGenerate.TabStop = false;
            this.groupGenerate.Text = "Step #1: Generating Datasets";
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
            this.numTrainAmount.Size = new System.Drawing.Size(65, 22);
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
            // txtTrainPath
            // 
            this.txtTrainPath.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTrainPath.Location = new System.Drawing.Point(127, 17);
            this.txtTrainPath.Name = "txtTrainPath";
            this.txtTrainPath.ReadOnly = true;
            this.txtTrainPath.Size = new System.Drawing.Size(165, 22);
            this.txtTrainPath.TabIndex = 1;
            this.txtTrainPath.Text = "c:\\Users\\WD\\source\\repos\\CaptchaGenerator\\CaptchaGenerator\\bin\\Debug\\Training\\";
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
            // groupPreview
            // 
            this.groupPreview.Controls.Add(this.picCaptchaPreview);
            this.groupPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupPreview.Location = new System.Drawing.Point(170, 12);
            this.groupPreview.Name = "groupPreview";
            this.groupPreview.Size = new System.Drawing.Size(258, 114);
            this.groupPreview.TabIndex = 0;
            this.groupPreview.TabStop = false;
            this.groupPreview.Text = "Step #0: Captcha Preview";
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
            this.numTestAmount.Size = new System.Drawing.Size(65, 22);
            this.numTestAmount.TabIndex = 4;
            this.numTestAmount.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
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
            // txtTestPath
            // 
            this.txtTestPath.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTestPath.Location = new System.Drawing.Point(127, 45);
            this.txtTestPath.Name = "txtTestPath";
            this.txtTestPath.ReadOnly = true;
            this.txtTestPath.Size = new System.Drawing.Size(165, 22);
            this.txtTestPath.TabIndex = 1;
            this.txtTestPath.Text = "c:\\Users\\WD\\source\\repos\\CaptchaGenerator\\CaptchaGenerator\\bin\\Debug\\Testing\\";
            // 
            // groupPreprocess
            // 
            this.groupPreprocess.Controls.Add(this.bntPreprocessDatasets);
            this.groupPreprocess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupPreprocess.Location = new System.Drawing.Point(15, 252);
            this.groupPreprocess.Name = "groupPreprocess";
            this.groupPreprocess.Size = new System.Drawing.Size(515, 165);
            this.groupPreprocess.TabIndex = 1;
            this.groupPreprocess.TabStop = false;
            this.groupPreprocess.Text = "Step #2: Preprocessing";
            // 
            // groupTrain
            // 
            this.groupTrain.Controls.Add(this.bntTrainNN);
            this.groupTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupTrain.Location = new System.Drawing.Point(15, 423);
            this.groupTrain.Name = "groupTrain";
            this.groupTrain.Size = new System.Drawing.Size(515, 73);
            this.groupTrain.TabIndex = 1;
            this.groupTrain.TabStop = false;
            this.groupTrain.Text = "Step #3: Neural Network Training";
            // 
            // groupTest
            // 
            this.groupTest.Controls.Add(this.bntTestNN);
            this.groupTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupTest.Location = new System.Drawing.Point(538, 12);
            this.groupTest.Name = "groupTest";
            this.groupTest.Size = new System.Drawing.Size(505, 484);
            this.groupTest.TabIndex = 1;
            this.groupTest.TabStop = false;
            this.groupTest.Text = "Step #4: Neural Network Testing";
            // 
            // bntTestNN
            // 
            this.bntTestNN.Image = global::CaptchaGenerator.Properties.Resources.wand;
            this.bntTestNN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntTestNN.Location = new System.Drawing.Point(187, 21);
            this.bntTestNN.Name = "bntTestNN";
            this.bntTestNN.Size = new System.Drawing.Size(200, 35);
            this.bntTestNN.TabIndex = 0;
            this.bntTestNN.Text = "Test Neural Network";
            this.bntTestNN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntTestNN.UseVisualStyleBackColor = true;
            // 
            // bntTrainNN
            // 
            this.bntTrainNN.Image = global::CaptchaGenerator.Properties.Resources.wand;
            this.bntTrainNN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntTrainNN.Location = new System.Drawing.Point(187, 21);
            this.bntTrainNN.Name = "bntTrainNN";
            this.bntTrainNN.Size = new System.Drawing.Size(200, 35);
            this.bntTrainNN.TabIndex = 0;
            this.bntTrainNN.Text = "Train Neural Network";
            this.bntTrainNN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntTrainNN.UseVisualStyleBackColor = true;
            // 
            // bntPreprocessDatasets
            // 
            this.bntPreprocessDatasets.Image = global::CaptchaGenerator.Properties.Resources.wand;
            this.bntPreprocessDatasets.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntPreprocessDatasets.Location = new System.Drawing.Point(187, 21);
            this.bntPreprocessDatasets.Name = "bntPreprocessDatasets";
            this.bntPreprocessDatasets.Size = new System.Drawing.Size(200, 35);
            this.bntPreprocessDatasets.TabIndex = 0;
            this.bntPreprocessDatasets.Text = "Preprocess Datasets";
            this.bntPreprocessDatasets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntPreprocessDatasets.UseVisualStyleBackColor = true;
            // 
            // bntGenerateDatasets
            // 
            this.bntGenerateDatasets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bntGenerateDatasets.Image = global::CaptchaGenerator.Properties.Resources.wand;
            this.bntGenerateDatasets.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntGenerateDatasets.Location = new System.Drawing.Point(187, 73);
            this.bntGenerateDatasets.Name = "bntGenerateDatasets";
            this.bntGenerateDatasets.Size = new System.Drawing.Size(200, 35);
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
            this.picCaptchaPreview.Location = new System.Drawing.Point(3, 18);
            this.picCaptchaPreview.Name = "picCaptchaPreview";
            this.picCaptchaPreview.Size = new System.Drawing.Size(252, 93);
            this.picCaptchaPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCaptchaPreview.TabIndex = 0;
            this.picCaptchaPreview.TabStop = false;
            this.picCaptchaPreview.Click += new System.EventHandler(this.picCaptchaPreview_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 506);
            this.Controls.Add(this.groupTest);
            this.Controls.Add(this.groupTrain);
            this.Controls.Add(this.groupPreprocess);
            this.Controls.Add(this.groupGenerate);
            this.Controls.Add(this.groupPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CaptchaGenerator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupGenerate.ResumeLayout(false);
            this.groupGenerate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTrainAmount)).EndInit();
            this.groupPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numTestAmount)).EndInit();
            this.groupPreprocess.ResumeLayout(false);
            this.groupTrain.ResumeLayout(false);
            this.groupTest.ResumeLayout(false);
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
    }
}

