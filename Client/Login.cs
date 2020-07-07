using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skyzer_Production.Client
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            IndexClient client = new IndexClient();
            client.Show();
        }
    }
}
