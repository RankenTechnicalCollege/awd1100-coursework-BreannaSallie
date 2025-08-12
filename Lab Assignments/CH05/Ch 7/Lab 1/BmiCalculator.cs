using Lab_1;

namespace Lab_1
{
    public static class BmiCalculator
    {
        public static Bmi CalcBmi(float weightInPounds, float heightInInches)
        {
            if (weightInPounds < 70f || weightInPounds > 300f)
                throw new InvalidWeightException("INVALID WEIGHT");

            if (heightInInches < 60f || heightInInches > 84f)
                throw new InvalidHeightException("INVALID HEIGHT");

            float bmi = (weightInPounds * 703f) / (heightInInches * heightInInches);

            WeightCategory category;
            if (bmi < 18.5f) category = WeightCategory.UNDERWEIGHT;
            else if (bmi < 25f) category = WeightCategory.NORMAL;
            else if (bmi < 30f) category = WeightCategory.OVERWEIGHT;
            else category = WeightCategory.OBESE;

            return new Bmi(weightInPounds, heightInInches, bmi, category);
        }
    }
}
