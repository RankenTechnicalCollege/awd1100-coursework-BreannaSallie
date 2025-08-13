using System;

namespace Ch7Test   
{
    public class TestStatistics
    {
        // instance fields (per UML)
        private int _count;
        private float _sum;
        private float _avg;
        private float _min;
        private float _max;

        // read-only properties
        public int Count => _count;
        public float Sum => _sum;
        public float Average => _avg;
        public float Min => _min;
        public float Max => _max;

        public TestStatistics()
        {
            _count = 0;
            _sum = 0f;
            _avg = 0f;
            _min = 0f;
            _max = 0f;
        }

        // AddScore(score: float)
        public void AddScore(float score)
        {
            // spec: only accept [0, 100]; otherwise throw
            if (score < 0f || score > 100f)
                throw new ArgumentException("Score must be between 0 and 100 (inclusive).");

            _sum += score;
            _count++;

            if (_count == 1)
            {
                _min = score;
                _max = score;
            }
            else
            {
                if (score < _min) _min = score;
                if (score > _max) _max = score;
            }

            _avg = _sum / _count;
        }
    }
}
