using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cantStop
{
    public partial class Tabuleiro : Form
    {
        public Tabuleiro()
        {
            Lobby lobby = new Lobby();
            lobby.ShowDialog();
            InitializeComponent();
        }

        private void Tabuleiro_Load(object sender, EventArgs e)
        {

        }
    }
}
