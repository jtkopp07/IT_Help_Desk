using System.Diagnostics;

namespace LoginAndRegister
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void btnCloseHelpForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOpenPDF_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedge.exe", "C:\\Users\\labuser\\source\\repos\\gbeblo\\J.F.G.H\\HelpDocument.pdf");
        }
    }
}
