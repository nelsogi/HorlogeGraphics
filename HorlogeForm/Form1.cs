using System.Drawing;
using System.Windows.Forms;

namespace HorlogeForm
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            Horloge horloge = new Horloge
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(horloge);
        }
    }
}
