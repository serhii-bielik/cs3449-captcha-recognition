using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FANNCSharp;
using FANNCSharp.Double;

namespace CaptchaGenerator
{
    class NNManager
    {
        char[] allChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789".ToCharArray();

        internal void TestNN(string preprocessTestingPath)
        {
            StringBuilder testingOutput = new StringBuilder();
            string outputTrainedFilePath = Path.Combine(Environment.CurrentDirectory, "Preprocess\\Training\\trained.data");
            if (File.Exists(outputTrainedFilePath))
            {
                NeuralNet net = new NeuralNet(outputTrainedFilePath);

                string[] testDataPathes = Directory.GetDirectories(preprocessTestingPath);
                for (int i = 0; i < testDataPathes.Length; i++)
                {
                    string[] imgs = Directory.GetFiles(testDataPathes[i], "*.jpg");
                    testingOutput.Append(Path.GetFileName(testDataPathes[i]));
                    testingOutput.Append(",");
                    for (int j = 0; j < imgs.Length; j++)
                    {
                        testingOutput.Append(ExtractPrediction(net.Run(getImageDataAsArray(imgs[j]))));
                    }
                    testingOutput.Append(Environment.NewLine);
                }

                string resultsPath = Path.Combine(Environment.CurrentDirectory, "output.csv");
                if (File.Exists(resultsPath))
                    File.Delete(resultsPath);
                File.WriteAllText(resultsPath, testingOutput.ToString());
            }
        }

        private string ExtractPrediction(double[] data)
        {
            double max = data[0];
            int maxId = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > max)
                {
                    maxId = i;
                    max = data[i];
                }
            }

            return allChars[maxId].ToString();
        }

        internal void TrainNN(string preprocessTrainingPath)
        {
            StringBuilder trainingOutput = new StringBuilder();
            List<int[]> input = new List<int[]>();

            string[] dataPathes = Directory.GetDirectories(preprocessTrainingPath);
            int totalImages = 0;
            for (int i = 0; i < dataPathes.Length; i++)
            {
                string[] imgs = Directory.GetFiles(dataPathes[i], "*.jpg");
                string curDirectory = Path.GetFileName(dataPathes[i]);
                if (imgs.Length != 5)
                    continue;
                for (int j = 0; j < imgs.Length; j++)
                {
                    trainingOutput.Append(getImageData(imgs[j]));
                    trainingOutput.Append(Environment.NewLine);
                    trainingOutput.Append(getAnswerData(curDirectory[j]));
                    trainingOutput.Append(Environment.NewLine);
                    totalImages++;
                }
            }
            trainingOutput.Insert(0, totalImages + " 336 35" + Environment.NewLine);
            string outputFilePath = Path.Combine(preprocessTrainingPath, "training.data");

            if (File.Exists(outputFilePath))
                File.Delete(outputFilePath);
            File.WriteAllText(outputFilePath, trainingOutput.ToString());

            if (File.Exists(outputFilePath))
            {
                uint[] layers = { 336, 150, 35 };
                NeuralNet net = new NeuralNet(1, layers);

                net.RandomizeWeights(-0.1, 0.1);
                net.LearningRate = 0.7f;

                TrainingData data = new TrainingData();
                data.ReadTrainFromFile(outputFilePath);

                net.TrainOnData(data, 1000, 0, 0.001f);

                string outputTrainedFilePath = Path.Combine(preprocessTrainingPath, "trained.data");

                if (File.Exists(outputTrainedFilePath))
                    File.Delete(outputTrainedFilePath);

                net.Save(outputTrainedFilePath);
            }                
        }

        private string getAnswerData(char current)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < allChars.Length; i++)
            {
                sb.Append(current == allChars[i] ? "1 " : "0 ");
            }
            return sb.ToString().Trim();
        }

        private string getImageData(string img)
        {
            StringBuilder sb = new StringBuilder();
            Bitmap bit = new Bitmap(img);
            for (int y = 0; y < bit.Height; y++)
            {
                for (int x = 0; x < bit.Width; x++)
                {
                    sb.Append(bit.GetPixel(x, y) == Color.FromArgb(0, 0, 0) ? "1 " : "0 ");
                }
            }
            return sb.ToString().Trim();
        }

        private double[] getImageDataAsArray(string img)
        {
            double[] input = new double[336];
            Bitmap bit = new Bitmap(img);

            int pointer = 0;
            for (int y = 0; y < bit.Height; y++)
            {
                for (int x = 0; x < bit.Width; x++)
                {
                    input[pointer] = (bit.GetPixel(x, y) == Color.FromArgb(0, 0, 0) ? 1 : 0);
                    pointer++;
                }
            }
            return input;
        }
    }
}
