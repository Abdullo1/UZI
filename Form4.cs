using System;
using System.Windows.Forms;



namespace Diagnoses
{
    public partial class Form4 : Form
    {
       
 
        public Form4()
        {
            InitializeComponent();
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint); this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            this.btnPageSetup.Click += new System.EventHandler(this.btnPageSetup_Click);

        }
        public string
                     name;


        private void button3_Click_1(object sender, EventArgs e)
        {
            Close();
        }


        private int checkPrint; private void btnPageSetup_Click(object sender, System.EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }
        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            checkPrint = 0;
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
           {


            // Print the content of RichTextBox. Store the last character printed.
            checkPrint = richTextBoxPrintCtrl2.Print(checkPrint, richTextBoxPrintCtrl2.TextLength, e);

            // Check for more pages
          //  if (checkPrint < richTextBoxPrintCtrl2.TextLength)
           //     e.HasMorePages = true;
            //else
              //  e.HasMorePages = false;
        }
  
      

        private void button2_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBoxPrintCtrl2.SelectionFont = fontDialog1.Font;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
