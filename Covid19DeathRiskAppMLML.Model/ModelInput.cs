// This file was auto-generated by ML.NET Model Builder. 

using Microsoft.ML.Data;

namespace Covid19DeathRiskAppMLML.Model
{
    public class ModelInput
    {
        [ColumnName("Sex"), LoadColumn(0)]
        public string Sex { get; set; }


        [ColumnName("Age Years"), LoadColumn(1)]
        public string Age_Years { get; set; }


        [ColumnName("Total deaths"), LoadColumn(2)]
        public float Total_deaths { get; set; }


        [ColumnName("COVID-19 Deaths"), LoadColumn(3)]
        public float COVID_19_Deaths { get; set; }


        [ColumnName("Death Percent"), LoadColumn(4)]
        public float Death_Percent { get; set; }


    }
}