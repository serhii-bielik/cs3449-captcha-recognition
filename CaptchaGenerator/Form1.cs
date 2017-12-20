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
        const int MIN_CONTOUR_AREA = 80;

        const int RESIZED_IMAGE_WIDTH = 20;
        const int RESIZED_IMAGE_HEIGHT = 30;

        ImageProcessing imgProc = new ImageProcessing();
        public Form1()
        {
            InitializeComponent();

            folderBrowserDialog1.SelectedPath = Environment.CurrentDirectory;
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
                deleteAllImages(trainingDatasetpath);
                deleteAllImages(testingDatasetpath);
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

        private void picCaptchaPreview_Click(object sender, EventArgs e)
        {
            try
            {
                string tmpPath = "tmp";
                if (!Directory.Exists(tmpPath))
                    Directory.CreateDirectory(tmpPath);

                picCaptchaPreview.ImageLocation = imgProc.GenerateImages(tmpPath, 1)[0];
                picCaptchaPreview.Load();
            } catch (Exception ex)
            {
                MessageBox.Show("Error during generating preview. " + ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            picCaptchaPreview.Image = Resources.NoImageAvailable;
            try
            {
                deleteAllImages(Path.Combine(Environment.CurrentDirectory, "tmp"));
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Can't remove file. " + ex.Message);
            }            
        }

        private static void deleteAllImages(string path)
        {
            foreach (string filePath in Directory.GetFiles(path, "*.png", SearchOption.TopDirectoryOnly))
            {
                File.Delete(filePath);
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
