namespace Lab_1
{
    public class Bmi
    {
        private float _weightInPounds;
        private float _heightInInches;
        private float _bmiValue;
        private WeightCategory _weightCategory;

        public Bmi(float weightInPounds, float heightInInches, float bmiValue, WeightCategory weightCategory)
        {
            _weightInPounds = weightInPounds;
            _heightInInches = heightInInches;
            _bmiValue = bmiValue;
            _weightCategory = weightCategory;
        }

        public float WeightInPounds => _weightInPounds;
        public float HeightInInches => _heightInInches;
        public float BmiValue => _bmiValue;           // renamed
        public WeightCategory WeightCategory => _weightCategory;
    }
}
