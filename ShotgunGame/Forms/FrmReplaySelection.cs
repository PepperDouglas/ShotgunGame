using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShotgunGame.Forms
{
    public partial class FrmReplaySelection : Form
    {
        public string ResetMessage { get; set; }
        public FrmReplaySelection(string resetMessage) {
            ResetMessage = resetMessage;
            InitializeComponent();
            SetGameOverMessage();
        }

        private void buttonQuitGame_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void buttonPlayAgain_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void SetGameOverMessage() {
            labelGameOverMessage.Text = ResetMessage;
        }
    }
}
