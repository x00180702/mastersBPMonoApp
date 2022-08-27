using System;
using System.ComponentModel.DataAnnotations;

namespace BPCalculator
{
    // BP categories
    public enum BPCategory
    {
        [Display(Name = "Low Blood Pressure")] Low,
        [Display(Name = "Ideal Blood Pressure")] Ideal,
        [Display(Name = "Pre-High Blood Pressure")] PreHigh,
        [Display(Name = "High Blood Pressure")] High,
        [Display(Name = "Values entered are not valid")] NotValid,
    };

    public enum Calculations
    {
        [Display(Name = "Mean Arterial Pressure: ")] mapValue,
        [Display(Name = "Pulse Pressure: ")] pulsePressure,
    };

    public enum AgeRange
    {
        [Display(Name = "Average value for your age group [15-19] is 120/78")] AgeGroup1,
        [Display(Name = "Average value for your age group [20-24] is 120/79")] AgeGroup2,
        [Display(Name = "Average value for your age group [25-29] is 121/80")] AgeGroup3,
        [Display(Name = "Average valuefor your age group [30-34] is 123/82")] AgeGroup4,
        [Display(Name = "Average value for your age group [35-39] is 124/83")] AgeGroup5,
        [Display(Name = "Average value for your age group [40-44] is 125/83")] AgeGroup6,
        [Display(Name = "Average value for your age group [45-49] is 127/84")] AgeGroup7,
        [Display(Name = "Average value for your age group [50-54] is 128/85")] AgeGroup8,
        [Display(Name = "Average value for your age group [55-59] is 131/87")] AgeGroup9,
        [Display(Name = "Average value for your age group [60 and over] is 135/88")] AgeGroup10,
        [Display(Name = "Please enter a valid age")] NoAgeGroup,
    };

    public class BloodPressure
    {
        public const int SystolicMin = 70;
        public const int SystolicMax = 190;
        public const int DiastolicMin = 40;
        public const int DiastolicMax = 100;
        public const int AgeMin = 14;
        public const int AgeMax = 100;

        [Range(SystolicMin, SystolicMax, ErrorMessage = "Invalid Systolic Value")]
        public int Systolic { get; set; }                       // mmHG

        [Range(DiastolicMin, DiastolicMax, ErrorMessage = "Invalid Diastolic Value")]
        public int Diastolic { get; set; }                      // mmHG

        [Range(AgeMin, AgeMax, ErrorMessage = "Invalid Age Range. Calculations are for ages over 15 & under 100")]
        public int Age { get; set; }

        public int calculation { get; set; }

        // calculate BP category
        public BPCategory Category
        {
            get
            {
                if (Systolic <= 89 && Diastolic <= 59)
                {

                    return BPCategory.Low;

                }
                else
                if ((Systolic > 90 && Systolic <= 119 || Diastolic >= 60 && Diastolic < 79))
                {
                    return BPCategory.Ideal;
                }
                else
                if ((Systolic > 120 && Systolic <= 139 || Diastolic >= 80 && Diastolic <= 89))
                {
                    return BPCategory.PreHigh;
                }
                else
                 if ((Systolic >= 140 && Systolic <= 190 || Diastolic >= 90 && Diastolic <= 100))
                {
                    return BPCategory.High;
                }
                else
                {

                    return BPCategory.NotValid;
                }
            }
        }

        //Calculation used to get mean arterial pressure from values entered
        public Calculations mapCalulation
        {
            get
            {
                calculation = Systolic + (2 * Diastolic) / 3;


                return Calculations.mapValue + calculation;
            }

        }

        //Calculation user to calculate pulse pressure from values entered
        public Calculations pulsePressureCalulation
        {
            get
            {
                calculation = Systolic - Diastolic;


                return Calculations.pulsePressure + calculation;
            }

        }

        //Returns ideal blood pressure vaule for your age range
        public AgeRange AgeGroup
        {
            get
            {
                if (Age >= 15 && Age <= 19)
                {
                    return AgeRange.AgeGroup1;
                }
                else
                if (Age >= 20 && Age <= 24)
                {
                    return AgeRange.AgeGroup2;
                }
                else
                if (Age >= 25 && Age <= 29)
                {
                    return AgeRange.AgeGroup3;
                }
                else
                if (Age >= 30 && Age <= 34)
                {
                    return AgeRange.AgeGroup4;
                }
                else
                if (Age >= 35 && Age <= 39)
                {
                    return AgeRange.AgeGroup5;
                }
                else
                if (Age >= 40 && Age <= 44)
                {
                    return AgeRange.AgeGroup6;
                }
                else
                if (Age >= 45 && Age <= 49)
                {
                    return AgeRange.AgeGroup7;
                }
                else
                if (Age >= 50 && Age <= 54)
                {
                    return AgeRange.AgeGroup8;
                }
                else
                if (Age >= 55 && Age <= 59)
                {
                    return AgeRange.AgeGroup9;
                }
                else
                if (Age >= 60 && Age <= 100)
                {
                    return AgeRange.AgeGroup10;
                }
                else
                {
                    return AgeRange.NoAgeGroup;
                }
            }
        }
    }
}
