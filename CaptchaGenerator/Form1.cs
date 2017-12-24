using CaptchaGenerator.Properties;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        NNManager nnMng = new NNManager();

        string preprocessTrainingPath = Environment.CurrentDirectory + "\\Preprocess\\Training";
        string preprocessTestingPath = Environment.CurrentDirectory + "\\Preprocess\\Testing";

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
                Stopwatch watch = Stopwatch.StartNew();

                imgProc.GenerateImages(trainingDatasetpath, trainingAmount, false);
                imgProc.GenerateImages(testingDatasetpath, testingAmount, false);

                watch.Stop();
                int elapsedS = Convert.ToInt32(watch.ElapsedMilliseconds / 1000);
                MessageBox.Show("Datasets successfuly generated in " + elapsedS + "s!", "Stage is done", 
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
                Stopwatch watch = Stopwatch.StartNew();
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

                watch.Stop();
                int elapsedS = Convert.ToInt32(watch.ElapsedMilliseconds / 1000);
                MessageBox.Show("Preprocess has been completed in " + elapsedS + "s!", "Stage is done",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during preprocessing. " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            
        }

        private void bntTrainNN_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(preprocessTrainingPath))
            {
                Stopwatch watch = Stopwatch.StartNew();
                nnMng.TrainNN(preprocessTrainingPath);
                watch.Stop();
                int elapsedS = Convert.ToInt32(watch.ElapsedMilliseconds / 1000);
                MessageBox.Show("Neural network training has been completed in " + elapsedS + "s!", "Stage is done",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Seems like no data for is ready for training yet.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void bntTestNN_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(preprocessTestingPath))
            {
                Stopwatch watch = Stopwatch.StartNew();
                nnMng.TestNN(preprocessTestingPath);
                watch.Stop();
                int elapsedS = Convert.ToInt32(watch.ElapsedMilliseconds / 1000);
                MessageBox.Show("Neural network testing has been completed in " + elapsedS + "s!", "Stage is done",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadResults(100);
            }
            else
            {
                MessageBox.Show("Seems like no data for is ready for testing yet.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadResults(int amount = 50)
        {
            try
            {
                string resultsPath = Path.Combine(Environment.CurrentDirectory, "output.csv");
                if(File.Exists(resultsPath))
                {
                    List<CaptchaItem> captchas = new List<CaptchaItem>();
                    int totalCaptchas = 0;
                    int correctCaptchas = 0;
                    int totalSymbols = 0;                    
                    int correctSymbols = 0;

                    string[] results = File.ReadAllLines(resultsPath);
                    totalCaptchas = results.Length;
                    int maxElements = (amount > results.Length) ? results.Length : amount;

                    for (int i = 0; i < results.Length; i++)
                    {
                        string[] resultsData = results[i].Split(',');
                        string answer = resultsData[0];
                        string guess = resultsData[1];

                        string originalImagePath = Path.Combine(Environment.CurrentDirectory, "Testing", resultsData[0] + ".png");
                        if (!File.Exists(originalImagePath))
                            throw new Exception("Can't locate original image for " + resultsData[0] + ".png");
                        Image originalImage = Image.FromFile(originalImagePath);

                        string preprocessedPath = Path.Combine(Environment.CurrentDirectory, "Preprocess\\Testing", resultsData[0], "contours.png");
                        if (!File.Exists(preprocessedPath))
                            throw new Exception("Can't locate original image for contours.png");
                        Image preprocessedImage = Image.FromFile(preprocessedPath);

                        Image[] segments = new Image[5];
                        for (int j = 0; j < segments.Length; j++)
                        {
                            string segmentPath = Path.Combine(Environment.CurrentDirectory, "Preprocess\\Testing", resultsData[0], j + ".jpg");
                            if (File.Exists(segmentPath))
                            {
                                segments[j] = Image.FromFile(segmentPath);
                                totalSymbols++;
                            }                                
                            else
                                segments[j] = null;
                        }
                        if(i < maxElements)
                            captchas.Add(new CaptchaItem(originalImage, preprocessedImage, guess, answer, segments));
                        if (guess == answer)
                            correctCaptchas++;
                        for (int k = 0; k < answer.Length; k++)
                        {
                            if (k < guess.Length && answer[k] == guess[k])
                                correctSymbols++;
                        }
                    }

                    dataGridView1.DataSource = captchas;
                    labTotalCaptchas.Text = totalCaptchas.ToString();
                    labTotalCaptchasCorrect.Text = correctCaptchas.ToString();
                    labCaptchasAccuracy.Text = Math.Round(100.0 * correctCaptchas / totalCaptchas, 2) + "%";
                    labTotalSymbols.Text = totalSymbols.ToString();
                    labTotalSymbolsCorrect.Text = correctSymbols.ToString();
                    labSymbolsAccuracy.Text = Math.Round(100.0 * correctSymbols / totalSymbols, 2) + "%";
                }
                else
                {
                    MessageBox.Show("There is no output file yet. Have you completed all stages before this?", 
                        "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during loading results to the table. " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void OpenLink(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch (Exception)
            {
                MessageBox.Show("Can't open browser. Please visit this link manually: " + url);
            }
        }
        private void lnkOpenCV_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink("https://opencv.org/");
        }

        private void lnkEmgu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink("http://www.emgu.com/");
        }

        private void lnkFANN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink("http://leenissen.dk/fann/wp/");
        }

        private void lnkFANNSharp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink("https://github.com/joelself/FannCSharp");
        }
    }
}
