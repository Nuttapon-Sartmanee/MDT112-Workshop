using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLocal = Console.ReadLine();
            string convoLocal = Console.ReadLine();
            string outputLocal = Console.ReadLine();

            double[,] imageData = ReadImageDataFromFile(inputLocal);
            double[,] convoData = ReadImageDataFromFile(convoLocal);

            double[,] addedData = new double[imageData.GetLength(0) + 2, imageData.GetLength(1) + 2];
            double[,] outputData = new double[imageData.GetLength(0) , imageData.GetLength(1)];
            double[,] koonedData = new double[convoData.GetLength(0) , convoData.GetLength(1)];
            
            //MAIN
            for (int i = 1 ; i < addedData.GetLength(1) - 1; i++ )
            {
                for (int j = 1; j < addedData.GetLength(0) - 1; j++)
                {
                    addedData[i, j] = imageData[i - 1, j - 1];
                }
            }

            //LEFT
            for (int i = 0; i < 5; i++)
            {
              addedData[i+1 , 0] = imageData[i , 4];
            }

            //RIGHT
            for (int i = 0; i < 5; i++)
            {
                addedData[ i+1 , addedData.GetLength(1) - 1] = imageData[i, 0];
            }

            //TOP
            for (int i = 0; i < addedData.GetLength(1) ; i++)
            {
                addedData[0 , i] = addedData[ 5 , i];
            }

            //BOTTOM
            for (int i = 0; i < addedData.GetLength(1); i++)
            {
                addedData[6, i] = addedData[ 1 , i];
            }


            //Output Data ---------------------------------------------------------------------------------------------------------------------------------------------------------------
            for (int BigRow = 0; BigRow < 5; BigRow++)
            {
                for (int BigColum = 0; BigColum < 5; BigColum++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {

                            koonedData[i, j] = addedData[i + BigRow, j + BigColum] * convoData[i, j];
                            outputData[BigRow , BigColum] = Math.Round(koonedData[0 , 0] + koonedData[0, 1] + koonedData[0, 2] + koonedData[1, 0] + koonedData[1, 1] + koonedData[1, 2] + koonedData[2, 0] + koonedData[2, 1] + koonedData[2, 2] , 2);

                        }
                        
                    }

                }
                
            }

            WriteImageDataToFile(outputLocal, outputData);


            /* TEST ONLY
            //READ koonedDATA
            for (int i = 0; i < koonedData.GetLength(1); i++)
            {
                for (int j = 0; j < koonedData.GetLength(0); j++)
                {
                    Console.Write(koonedData[i, j]);
                    Console.Write("       ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //READ CONVO
            for (int i = 0; i < convoData.GetLength(1); i++)
            {
                for (int j = 0; j < convoData.GetLength(0); j++)
                {
                    Console.Write(convoData[i, j]);
                    Console.Write("       ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //READ OUTPUT DATA
            for (int i = 0; i < outputData.GetLength(1); i++)
            {
                for (int j = 0; j < outputData.GetLength(0); j++)
                {
                    Console.Write(outputData[i, j]);
                    Console.Write("       ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //READ ARRAYS addedData
            for (int i = 0; i < addedData.GetLength(1); i++)
            {
                for (int j = 0; j < addedData.GetLength(0) ; j++)
                {
                    Console.Write(addedData[i, j]);
                    Console.Write("       ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
            */

        }
        static void WriteImageDataToFile(string imageDataFilePath,
                                   double[,] imageDataArray)
        {
            string imageDataString = "";
            for (int i = 0; i < imageDataArray.GetLength(0); i++)
            {
                for (int j = 0; j < imageDataArray.GetLength(1) - 1; j++)
                {
                    imageDataString += imageDataArray[i, j] + ", ";
                }
                imageDataString += imageDataArray[i,
                                                imageDataArray.GetLength(1) - 1];
                imageDataString += "\n";
            }

            System.IO.File.WriteAllText(imageDataFilePath, imageDataString);
        }
        static double[,] ReadImageDataFromFile(string imageDataFilePath)
        {
            string[] lines = System.IO.File.ReadAllLines(imageDataFilePath);
            int imageHeight = lines.Length;
            int imageWidth = lines[0].Split(',').Length;
            double[,] imageDataArray = new double[imageHeight, imageWidth];

            for (int i = 0; i < imageHeight; i++)
            {
                string[] items = lines[i].Split(',');
                for (int j = 0; j < imageWidth; j++)
                {
                    imageDataArray[i, j] = double.Parse(items[j]);
                }
            }
            return imageDataArray;
        }
    }
}
