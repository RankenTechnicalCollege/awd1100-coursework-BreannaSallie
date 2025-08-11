using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace lab_2
{
    public partial class Form1 : Form
    {
        private readonly List<double> _scores = new List<double>();

        public bool TryAdd(double value, out string error)
        {
            if (value < 0 || value > 100)
            {
                error = "Invalid score";
                return false;
            }
            _scores.Add(value);
            error = null;
            return true;
        }

        public int Count { get { return _scores.Count; } }
        public double Sum { get { return _scores.Sum(); } }
        public double Average { get { return _scores.Count == 0 ? 0 : _scores.Average(); } }
        public double Min { get { return _scores.Count == 0 ? 0 : _scores.Min(); } }
        public double Max { get { return _scores.Count == 0 ? 0 : _scores.Max(); } }
    }
}