using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZASG_II {
    public partial class PlayMenu : Form {
        public PlayMenu() {
            InitializeComponent();
        }

        private void PlayMenu_Load(object sender, EventArgs e) {
            
        }

        private void NewGameButton_Click(object sender, EventArgs e) {
            NewGame newGame = new NewGame();
            newGame.Show();
            this.Close();
        }
    }
}
