// This file was auto-generated by ML.NET Model Builder. 

using Microsoft.ML.Data;

namespace PredictMeML.Model
{
    public class ModelInput
    {
        [ColumnName("f_boxer"), LoadColumn(0)]
        public string F_boxer { get; set; }


        [ColumnName("s_boxer"), LoadColumn(1)]
        public string S_boxer { get; set; }


        [ColumnName("f_boxer_result"), LoadColumn(2)]
        public string F_boxer_result { get; set; }


        [ColumnName("f_boxer_stance"), LoadColumn(3)]
        public string F_boxer_stance { get; set; }


        [ColumnName("f_boxer_age"), LoadColumn(4)]
        public float F_boxer_age { get; set; }


        [ColumnName("f_boxer_height"), LoadColumn(5)]
        public float F_boxer_height { get; set; }


        [ColumnName("f_boxer_reach"), LoadColumn(6)]
        public float F_boxer_reach { get; set; }


        [ColumnName("f_boxer_won"), LoadColumn(7)]
        public float F_boxer_won { get; set; }


        [ColumnName("f_boxer_lost"), LoadColumn(8)]
        public float F_boxer_lost { get; set; }


        [ColumnName("f_boxer_drawn"), LoadColumn(9)]
        public float F_boxer_drawn { get; set; }


        [ColumnName("f_boxer_KOs"), LoadColumn(10)]
        public float F_boxer_KOs { get; set; }


        [ColumnName("f_boxer_ranking"), LoadColumn(11)]
        public float F_boxer_ranking { get; set; }


        [ColumnName("s_boxer_ranking"), LoadColumn(12)]
        public float S_boxer_ranking { get; set; }


        [ColumnName("s_boxer_age"), LoadColumn(13)]
        public float S_boxer_age { get; set; }


        [ColumnName("s_boxer_stance"), LoadColumn(14)]
        public string S_boxer_stance { get; set; }


        [ColumnName("s_boxer_reach"), LoadColumn(15)]
        public float S_boxer_reach { get; set; }


        [ColumnName("s_boxer_height"), LoadColumn(16)]
        public float S_boxer_height { get; set; }


        [ColumnName("s_boxer_won"), LoadColumn(17)]
        public float S_boxer_won { get; set; }


        [ColumnName("s_boxer_lost"), LoadColumn(18)]
        public float S_boxer_lost { get; set; }


        [ColumnName("s_boxer_drawn"), LoadColumn(19)]
        public float S_boxer_drawn { get; set; }


        [ColumnName("s_boxer_KOs"), LoadColumn(20)]
        public float S_boxer_KOs { get; set; }


        [ColumnName("s_boxer_result"), LoadColumn(21)]
        public string S_boxer_result { get; set; }


        [ColumnName("matchRounds"), LoadColumn(22)]
        public float MatchRounds { get; set; }


        [ColumnName("fightEnd"), LoadColumn(23)]
        public string FightEnd { get; set; }


    }
}