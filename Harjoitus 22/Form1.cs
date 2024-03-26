namespace Harjoitus_22
{
    public partial class Converter : Form
    {
        public Converter()
        {
            InitializeComponent();
        }

        private void btnSulje_Click(object sender, EventArgs e)
        {
            DialogResult vast;
            vast = MessageBox.Show("Are you sure you want to close app?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vast == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lstConverter.Items.Clear();
            lstConverter.Items.Add("Feet --> Meter");
            lstConverter.Items.Add("Inch --> Centimeter");
            lstConverter.Items.Add("Pound --> Kilo");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lstConverter.Items.Clear();
            lstConverter.Items.Add("Meter --> Feet");
            lstConverter.Items.Add("Centimeter --> Inch");
            lstConverter.Items.Add("Kilo --> Pound");
        }

        private void lstMuunnos_DoubleClick(object sender, EventArgs e)
        {
            if (rbnImperial.Checked)
            {
                if (lstConverter.SelectedItem.ToString() == "Feet --> Meter")
                    txtInternational.Text = Convert.ToString(Convert.ToSingle(txtImperial.Text) * 0.3048);
                else if (lstConverter.SelectedItem.ToString() == "Inch --> Centimeter")
                    txtInternational.Text = Convert.ToString(Convert.ToSingle(txtImperial.Text) * 2.54);
                else if (lstConverter.SelectedItem.ToString() == "Pound --> Kilo")
                    txtInternational.Text = Convert.ToString(Convert.ToSingle(txtImperial.Text) * 0.45359);
            }
            else if (rbnInternational.Checked)
            {
                if (lstConverter.SelectedItem.ToString() == "Meter --> Feet")
                    txtImperial.Text = Convert.ToString(Convert.ToSingle(txtInternational.Text) / 0.3048);
                else if (lstConverter.SelectedItem.ToString() == "Centimeter --> Inch")
                    txtImperial.Text = Convert.ToString(Convert.ToSingle(txtInternational.Text) / 2.54);
                else if (lstConverter.SelectedItem.ToString() == "Kilo --> Pound")
                    txtImperial.Text = Convert.ToString(Convert.ToSingle(txtInternational.Text) / 0.45359);
            }
        }
    }
}