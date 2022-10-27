namespace winforms_checkean
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmdCheck_Click(object sender, EventArgs e)
        {
            //Länge der Eingabe prüfen
            if (cboEan.Text.Length == 13)
            {
                long eZahl = Convert.ToInt64(cboEan.Text);
                long temp = 0;
                long[] array = new long[13];
                long[] array_MultOne = new long[7];
                long[] array_MultThree = new long[6];
                long a = 1;
                long b = 10;
                //Schreibe die einzelnen Zeichen der Eingabe vom Ende her rückwärts in ein Array
                for (int i = array.Length-1; i >= 0; i--)
                {
                    temp = eZahl % b;
                    b = b * 10;
                    array[i] = temp / a;
                    a = a * 10;
                    eZahl = eZahl - temp;
                }
                int j = 0;
                long k = 0;
                long l = 0;
                /*Schreibe Elemente des Array abwechelnd in Variablen k und l, und multipliziere die
                  Zwischenwerte jeweils mit 3 und 1*/
                for (int i = 0; i < array.Length-6; i++)
                {
                    k += array[j];
                    j++;
                    if (i < array.Length-7)
                    {
                        l += array[j] * 3;
                        j++;
                    }
                }

                long prüf = 0;
                prüf = k + l;
                //Prüfe, ob die abwechselnd gewichtete Quersumme ein Vielfaches von 10 ist.
                if (prüf % 10 == 0)
                {
                    LblAusgabe.ForeColor = Color.Green;
                    LblAusgabe.Text = "OK";
                }
                else
                {
                    LblAusgabe.ForeColor = Color.Red;
                    LblAusgabe.Text = "NOT OK";
                }
                LblQuersumme.ForeColor = Color.Black;
                LblQuersumme.Text = "Gewichtete Quersumme: " + prüf;
                
            }
            //Wenn Eingabe-Länge ungleich 13, zu erneuter Eingabe auffordern
            else
            {
                LblAusgabe.ForeColor = Color.Red;
                LblAusgabe.Text = "Invalid Length (" + cboEan.Text.Length + ")";
                LblQuersumme.ForeColor = Color.DarkRed;
                LblQuersumme.Text = "Bitte geben Sie erneut die dreizehnstellige EA-Nummer ein.";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}