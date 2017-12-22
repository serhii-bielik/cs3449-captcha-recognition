using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CaptchaGenerator
{
    class ImageProcessing
    {
        static Random rnd = new Random();

        const int minContourArea = 60;        

        const int imageHeight = 90;
        const int imageWidth = 200;

        const int resizedWidth = 20;
        const int resizedHeight = 30;

        int[] backgroundColor = new int[] { 150, 150, 150 };
        int[] textColor = new int[] { 0, 0, 0 };
        int[] fontSizes = new int[] { 18, 20, 22, 24, 26, 27, 28, 29, 30, 31, 32, 34 };

        string[] fonts = new string[]
        {
                 "Comic Sans MS",
                 "Arial",
                 "Times New Roman",
                 "Georgia",
                 "Verdana",
                 "Geneva"
        };
        FontStyle[] fontStyles = new FontStyle[]
        {
                 FontStyle.Bold,
                 FontStyle.Italic,
                 FontStyle.Regular
        };
        HatchStyle[] backgroundStyles = new HatchStyle[]
        {
                HatchStyle.BackwardDiagonal,
                HatchStyle.Cross,
                HatchStyle.DashedDownwardDiagonal,
                HatchStyle.DashedHorizontal,
                HatchStyle.DashedUpwardDiagonal,
                HatchStyle.DashedVertical,
                HatchStyle.DiagonalBrick,
                HatchStyle.DiagonalCross,
                HatchStyle.Divot,
                HatchStyle.DottedDiamond,
                HatchStyle.DottedGrid,
                HatchStyle.ForwardDiagonal,
                HatchStyle.Horizontal,
                HatchStyle.HorizontalBrick,
                HatchStyle.LargeCheckerBoard,
                HatchStyle.LargeConfetti,
                HatchStyle.LargeGrid,
                HatchStyle.LightDownwardDiagonal,
                HatchStyle.LightHorizontal,
                HatchStyle.LightUpwardDiagonal,
                HatchStyle.LightVertical,
                HatchStyle.Max,
                HatchStyle.Min,
                HatchStyle.NarrowHorizontal,
                HatchStyle.NarrowVertical,
                HatchStyle.OutlinedDiamond,
                HatchStyle.Plaid,
                HatchStyle.Shingle,
                HatchStyle.SmallCheckerBoard,
                HatchStyle.SmallConfetti,
                HatchStyle.SmallGrid,
                HatchStyle.SolidDiamond,
                HatchStyle.Sphere,
                HatchStyle.Trellis,
                HatchStyle.Vertical,
                HatchStyle.Wave,
                HatchStyle.Weave,
                HatchStyle.WideDownwardDiagonal,
                HatchStyle.WideUpwardDiagonal,
                HatchStyle.ZigZag
        };


        public string[] GenerateImages(string outputPath, int amount, bool isHidden = true)
        {
            List<string> outputPaths = new List<string>();
            Parallel.For(0, amount,
                   i => {
                       outputPaths.Add(GenerateImage(outputPath, isHidden));
                   });
            /*for (int i = 0; i < amount; i++)
            {
                outputPaths.Add(GenerateImage(outputPath, isHidden));
            }*/
            return outputPaths.ToArray();
        }

        private string GenerateImage(string outputPath, bool isHidden = true)
        {
            begin:
            string captchaAnswer = GetRandomString(5);

            Bitmap outputImage = new Bitmap(imageWidth, imageHeight, PixelFormat.Format24bppRgb);
            Graphics graphics = Graphics.FromImage(outputImage);
            graphics.TextRenderingHint = TextRenderingHint.AntiAlias;

            RectangleF drawingArea = new RectangleF(0, 0, imageWidth, imageHeight);
            Brush brush = default(Brush);

            brush = new HatchBrush(backgroundStyles[rnd.Next
                (backgroundStyles.Length - 1)], Color.FromArgb((rnd.Next(200, 255)),
                (rnd.Next(200, 255)), (rnd.Next(200, 255))), Color.White);
            graphics.FillRectangle(brush, drawingArea);

            Matrix matrix = new Matrix();
            int i = 0;
            for (i = 0; i <= captchaAnswer.Length - 1; i++)
            {
                matrix.Reset();
                int charsLength = captchaAnswer.Length - 1;
                int x = imageWidth / (charsLength + 1) * i;
                int y = imageHeight / 2;

                matrix.RotateAt(rnd.Next(-20, 20), new PointF(x, y));
                graphics.Transform = matrix;
                
                graphics.DrawString
                (
                    captchaAnswer[i].ToString(),
                    new Font(fonts[rnd.Next(fonts.Length - 1)],
                       fontSizes[rnd.Next(fontSizes.Length - 1)],
                       fontStyles[rnd.Next(fontStyles.Length - 1)]),
                    new SolidBrush(Color.FromArgb(rnd.Next(0, 100),
                       rnd.Next(0, 100), rnd.Next(0, 100))),
                    x,
                    rnd.Next(15, 30)
                );
                graphics.ResetTransform();
            }

            if (isHidden)
                outputPath = Path.Combine(outputPath, Guid.NewGuid() + ".png");
            else
                outputPath = Path.Combine(outputPath, captchaAnswer + ".png");

            FileStream fs = null;
            try
            {              
                if (!File.Exists(outputPath))
                {
                    fs = new FileStream(outputPath, FileMode.Create);
                    outputImage.Save(fs, ImageFormat.Png);
                } else
                {
                    goto begin;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error during saving new captcha. Details:\n" + ex.Message);
            }
            finally
            {
                if(fs != null)
                    fs.Close();
            }
            return outputPath;
        }

        public void Preprocess(string inputPath, string outputPath)
        {
            if (!Directory.Exists(outputPath))
                Directory.CreateDirectory(outputPath);

            Bitmap oOutputBitmap = new Bitmap(inputPath);
            for (int y = 0; y < oOutputBitmap.Height; y++)
            {
                for (int x = 0; x < oOutputBitmap.Width; x++)
                {
                    Color cl = oOutputBitmap.GetPixel(x, y);
                    if (cl.R > 200 || cl.B > 200 || cl.G > 200)
                    {
                        oOutputBitmap.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        oOutputBitmap.SetPixel(x, y, Color.Black);
                    }
                }
            }
            string basicPreprocessPath = Path.Combine(outputPath, "basic.png");
            oOutputBitmap.Save(basicPreprocessPath, ImageFormat.Png);

            using (Mat gray = new Mat())
            using (Mat canny = new Mat())
            using (Mat hierachy = new Mat())
            using (VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint())
            {
                //CvInvoke.CvtColor(img, gray, ColorConversion.Bgr2Gray);
                //CvInvoke.Canny(gray, canny, 0, 0);

                Mat imgTrainingNumbers = new Mat(basicPreprocessPath);

                //CvInvoke.AdaptiveThreshold(canny, contours, 10, AdaptiveThresholdType.GaussianC, ThresholdType.Binary, 10, 5);
                Mat imgGrayscale = new Mat();
                Mat imgBlurred = new Mat(); // declare various images
                Mat imgThresh = new Mat();
                Mat imgThreshCopy = new Mat();

                CvInvoke.CvtColor(imgTrainingNumbers, imgGrayscale, ColorConversion.Bgr2Gray);       //convert to grayscale
                CvInvoke.GaussianBlur(imgGrayscale, imgBlurred, new Size(5, 5), 0);                  //blur

                //threshold image from grayscale to black and white
                CvInvoke.AdaptiveThreshold(imgBlurred, imgThresh, 255.0, AdaptiveThresholdType.GaussianC, ThresholdType.BinaryInv, 11, 2);
                CvInvoke.Imshow("imgThresh", imgThresh);                //show threshold image for reference
                imgThreshCopy = imgThresh.Clone();              //make a copy of the thresh image, this in necessary b/c findContours modifies the image

                //get external countours only
                CvInvoke.FindContours(imgThreshCopy, contours, null, RetrType.External, ChainApproxMethod.ChainApproxSimple);

                //CvInvoke.FindContours(canny, contours, hierachy, RetrType.External, ChainApproxMethod.ChainApproxSimple);

                List<Rectangle> lettersRect = new List<Rectangle>();
                List<Mat> lettersMat = new List<Mat>();
                for (int k = 0; k < contours.Size; ++k)
                {                               //for each contour
                    if (CvInvoke.ContourArea(contours[k]) > minContourArea)
                    {                      //if contour is big enough to consider
                        //Rectangle minAreaRect = CvInvoke.MinAreaRect(contours[k]);
                        Rectangle boundingRect = CvInvoke.BoundingRectangle(contours[k]); //get the bounding rect
                                                                                          //RotatedRect box = CvInvoke.MinAreaRect(contours[k]);
                                                                                          /*if (box.Angle < -45.0)
                                                                                          {*/
                                                                                          /* float tmp = box.Size.Width;
                                                                                           box.Size.Width = box.Size.Height;
                                                                                           box.Size.Height = tmp;
                                                                                           box.Angle += 90.0f;*/
                                                                                          /*}
                                                                                          else if (box.Angle > 45.0)
                                                                                          {
                                                                                              float tmp = box.Size.Width;
                                                                                              box.Size.Width = box.Size.Height;
                                                                                              box.Size.Height = tmp;
                                                                                              box.Angle -= 90.0f;
                                                                                          }*/



                        CvInvoke.Rectangle(imgTrainingNumbers, boundingRect, new MCvScalar(0.0, 0.0, 255.0), 2);    //draw red rectangle around each contour as we ask user for input





                        Mat imgROItoBeCloned = new Mat(imgThreshCopy, boundingRect);//boundingRect);        //get ROI image of current char
                        Mat imgROI = imgROItoBeCloned.Clone();           //make a copy so we do not change the ROI area of the original image
                        Mat imgROIResized = new Mat();

                        //resize image, this is necessary for recognition and storage
                        CvInvoke.Resize(imgROI, imgROIResized, new Size(resizedWidth, resizedHeight));

                        if (lettersRect.Count > 0)
                        {
                            int bestPos = -1;
                            for (int i = 0; i < lettersRect.Count; i++)
                            {
                                if (lettersRect[i].Left > boundingRect.Left)
                                {
                                    bestPos = i;
                                    break;
                                }
                            }
                            if(bestPos != -1)
                            {
                                lettersRect.Insert(bestPos, boundingRect);
                                lettersMat.Insert(bestPos, imgROIResized);
                            } else
                            {
                                lettersRect.Add(boundingRect);
                                lettersMat.Add(imgROIResized);
                            }                            
                        }
                        else
                        {
                            lettersRect.Add(boundingRect);
                            lettersMat.Add(imgROIResized);
                        }

                        //CvInvoke.Imshow("imgROI", imgROI);                                   //show ROI image for reference
                        //CvInvoke.Imshow("imgROIResized", imgROIResized);                     //show resized ROI image for reference
                        
                        //CvInvoke.Imshow("imgTrainingNumbers", imgTrainingNumbers);           //show training numbers image, this will now have red rectangles drawn on it


                    }
                }
                for (int i = 0; i < lettersMat.Count; i++)
                {
                    lettersMat[i].Save(Path.Combine(outputPath, i + ".jpg"));
                }
            }
        }

        private string GetRandomString(int length)
        {
            char[] chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789".ToCharArray();
            byte[] bytes = new byte[1];
            using (RNGCryptoServiceProvider cryptoService = new RNGCryptoServiceProvider())
            {
                cryptoService.GetNonZeroBytes(bytes);
                bytes = new byte[length];
                cryptoService.GetNonZeroBytes(bytes);
            }
            StringBuilder outputString = new StringBuilder(length);
            foreach (byte b in bytes)
            {
                outputString.Append(chars[b % (chars.Length)]);
            }
            return outputString.ToString();
        }
    }
}
