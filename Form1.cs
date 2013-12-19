using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semester_Grade_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int FQGI;
            FQGI = Convert.ToInt32(FQG.Text);
            int SQGI;
            SQGI = Convert.ToInt32(SQG.Text);
            int DSGI;
            DSGI = Convert.ToInt32(DSG.Text);
            double P = 0.4d;
            decimal FSQGI;
            FSQGI = ((Convert.ToDecimal(FQGI) * Convert.ToDecimal(P)) + (Convert.ToDecimal(SQGI) * Convert.ToDecimal(P))) ;
            Console.WriteLine(Convert.ToString(FSQGI));
            decimal PG;
            PG = ((5 * DSGI) - (FSQGI / 0.2m)) ;
            RSTS.Text = Convert.ToString(PG);



        }
    }
}
