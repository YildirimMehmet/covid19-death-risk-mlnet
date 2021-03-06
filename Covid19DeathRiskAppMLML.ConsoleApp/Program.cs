// This file was auto-generated by ML.NET Model Builder. 

using System;
using Covid19DeathRiskAppMLML.Model;

namespace Covid19DeathRiskAppMLML.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = new ModelInput()
            {
                Sex = @"Male",
                Age_Years = @"<1 year",
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Death_Percent with predicted Death_Percent from sample data...\n\n");
            Console.WriteLine($"Sex: {sampleData.Sex}");
            Console.WriteLine($"Age_Years: {sampleData.Age_Years}");
            Console.WriteLine($"\n\nPredicted Death_Percent: {predictionResult.Score}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
