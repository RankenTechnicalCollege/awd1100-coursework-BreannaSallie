using System.Text;

namespace Lab_4   // <-- change to match your Form1.cs namespace if different
{
    public class DecoderRing
    {
        private const string OuterRing = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private int _shift;
        private string _innerRing; // Outer rotated LEFT by _shift

        public DecoderRing(int shift)
        {
            Shift = shift; // validates and builds inner ring
        }

        public int Shift
        {
            get => _shift;
            set
            {
                if (value < 0 || value > 25)
                    throw new System.Exception("Invalid shift");
                _shift = value;
                _innerRing = RotateLeft(OuterRing, _shift); // LEFT rotation
            }
        }

        // Encode: find each letter on the INNER ring, output the aligned OUTER letter
        public string Encode(string message)
        {
            if (!IsValidMessage(message))
                throw new System.Exception("Invalid characters in message");

            string upper = (message ?? string.Empty).ToUpperInvariant();
            var sb = new StringBuilder(upper.Length);

            foreach (char ch in upper)
            {
                if (ch == ' ') { sb.Append(' '); continue; }
                int idx = _innerRing.IndexOf(ch);
                if (idx < 0) throw new System.Exception("Invalid characters in message");
                sb.Append(OuterRing[idx]);
            }
            return sb.ToString();
        }

        // Decode: find each letter on the OUTER ring, output the aligned INNER letter
        public string Decode(string message)
        {
            if (!IsValidMessage(message))
                throw new System.Exception("Invalid characters in message");

            string upper = (message ?? string.Empty).ToUpperInvariant();
            var sb = new StringBuilder(upper.Length);

            foreach (char ch in upper)
            {
                if (ch == ' ') { sb.Append(' '); continue; }
                int idx = OuterRing.IndexOf(ch);
                if (idx < 0) throw new System.Exception("Invalid characters in message");
                sb.Append(_innerRing[idx]);
            }
            return sb.ToString();
        }

        private static bool IsValidMessage(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;
            foreach (char ch in s)
            {
                if (ch == ' ') continue;
                char u = char.ToUpperInvariant(ch);
                if (u < 'A' || u > 'Z') return false; // letters + spaces only
            }
            return true;
        }

        private static string RotateLeft(string s, int k)
        {
            if (s.Length == 0) return s;
            k = ((k % s.Length) + s.Length) % s.Length;
            if (k == 0) return s;
            return s.Substring(k) + s.Substring(0, k);
        }
    }
}