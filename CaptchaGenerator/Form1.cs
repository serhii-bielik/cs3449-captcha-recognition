using CaptchaGenerator.Properties;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaptchaGenerator
{
    public partial class Form1 : Form
    {
        ImageProcessing imgProc = new ImageProcessing();
        public Form1()
        {
            InitializeComponent();

            folderBrowserDialog1.SelectedPath = Environment.CurrentDirectory;
        }

        private void picCaptchaPreview_Click(object sender, EventArgs e)
        {
            try
            {
                string tmpPath = "tmp";
                if (!Directory.Exists(tmpPath))
                    Directory.CreateDirectory(tmpPath);

                picCaptchaPreview.ImageLocation = imgProc.GenerateImages(tmpPath, 1)[0];
                picCaptchaPreview.Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during generating preview. " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bntGenerate_Click(object sender, EventArgs e)
        {
            string trainingDatasetpath = txtTrainPath.Text;
            int trainingAmount = Convert.ToInt32(numTrainAmount.Value);
            if(!Directory.Exists(trainingDatasetpath))
            {
                MessageBox.Show("Training dataset path does not exists.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                

            string testingDatasetpath = txtTestPath.Text;
            int testingAmount = Convert.ToInt32(numTestAmount.Value);
            if (!Directory.Exists(testingDatasetpath))
            {
                MessageBox.Show("Testing dataset path does not exists.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (trainingDatasetpath == testingDatasetpath)
            {
                MessageBox.Show("Training and testing dataset pathes can't be equal.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DeleteAllImages(trainingDatasetpath);
                DeleteAllImages(testingDatasetpath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during cleaning dataset folders. " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                imgProc.GenerateImages(trainingDatasetpath, trainingAmount, false);
                imgProc.GenerateImages(testingDatasetpath, testingAmount, false);
                MessageBox.Show("Datasets successfuly generated!", "Stage is done", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during generating datasets. " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bntPreprocessDatasets_Click(object sender, EventArgs e)
        {
            string preprocessTrainingPath = Environment.CurrentDirectory + "\\Preprocess\\Training";
            string preprocessTestingPath = Environment.CurrentDirectory + "\\Preprocess\\Testing";
            try
            {
                if (!Directory.Exists(Environment.CurrentDirectory + "\\Preprocess"))
                    Directory.CreateDirectory(Environment.CurrentDirectory + "\\Preprocess");
                
                if (!Directory.Exists(preprocessTrainingPath))
                    Directory.CreateDirectory(preprocessTrainingPath);                
                if (!Directory.Exists(preprocessTestingPath))
                    Directory.CreateDirectory(preprocessTestingPath);

                //DeleteFilesAndFolders(preprocessTrainingPath);
                //DeleteFilesAndFolders(preprocessTestingPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during files structure preparation. " + ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            try
            {
                string[] files = Directory.GetFiles(
                Path.Combine(Environment.CurrentDirectory, txtTrainPath.Text), "*.png", SearchOption.TopDirectoryOnly);
                Parallel.For(0, files.Length,
                   i => {
                       imgProc.Preprocess(files[i], Path.Combine(preprocessTrainingPath, Path.GetFileNameWithoutExtension(files[i])));
                   });

                files = Directory.GetFiles(
                Path.Combine(Environment.CurrentDirectory, txtTestPath.Text), "*.png", SearchOption.TopDirectoryOnly);
                Parallel.For(0, files.Length,
                   i => {
                       imgProc.Preprocess(files[i], Path.Combine(preprocessTestingPath, Path.GetFileNameWithoutExtension(files[i])));
                   });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during preprocessing. " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Preprocess has been completed!", "Stage is done",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }                

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            picCaptchaPreview.Image = Resources.NoImageAvailable;
            try
            {
                DeleteAllImages(Path.Combine(Environment.CurrentDirectory, "tmp"));
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Can't remove file. " + ex.Message);
            }            
        }

        private void DeleteAllImages(string path)
        {
            foreach (string filePath in Directory.GetFiles(path, "*.png", SearchOption.TopDirectoryOnly))
            {
                File.Delete(filePath);
            }
        }

        private void DeleteFilesAndFolders(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
        }

        private void btnBrowseTrainPath_Click(object sender, EventArgs e)
        {            
            folderBrowserDialog1.Description = "Please specify output derictory for training dataset.";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtTrainPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnBrowseTestPath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Please specify output derictory for testing dataset.";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtTestPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        
    }
}
