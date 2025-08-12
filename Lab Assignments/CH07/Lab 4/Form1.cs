using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_4   // <-- change if your Form1.cs uses a different namespace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ClearErrors();
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            ClearErrors();

            if (!int.TryParse(txtShift.Text.Trim(), out int shift))
            { Show(lblShiftError, "Invalid shift"); return; }

            try
            {
                var ring = new DecoderRing(shift);
                txtDecode.Text = ring.Encode(txtEncode.Text);
            }
            catch (Exception ex)
            {
                Show(lblEncodeError, ex.Message); // "Invalid characters in message"
            }
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            ClearErrors();

            if (!int.TryParse(txtShift.Text.Trim(), out int shift))
            { Show(lblShiftError, "Invalid shift"); return; }

            try
            {
                var ring = new DecoderRing(shift);
                txtEncode.Text = ring.Decode(txtDecode.Text);
            }
            catch (Exception ex)
            {
                Show(lblDecodeError, ex.Message);
            }
        }

        private void Show(Label lbl, string msg)
        {
            lbl.ForeColor = Color.Red;
            lbl.Text = msg;
        }

        private void ClearErrors()
        {
            lblEncodeError.Text = "";
            lblDecodeError.Text = "";
            lblShiftError.Text = "";
        }
    }
}