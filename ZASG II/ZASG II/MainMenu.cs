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
    public partial class MainMenu : Form {
        public MainMenu() {
            InitializeComponent();
        }

        string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private void Form1_Load(object sender, EventArgs e) {

        }

        private void TitleText_Click(object sender, EventArgs e) {

        }

        private void PlayButton_Click(object sender, EventArgs e) {
            PlayMenu playMenu = new PlayMenu();
            playMenu.Show();
            this.Hide();
        }
    }
}
