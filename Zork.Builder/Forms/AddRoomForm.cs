using System;
using System.Windows.Forms;

namespace Zork.Builder.Forms
{
    public partial class AddRoomForm : Form
    {
        public string RoomName
        {
            get => RoomNameTextBox.Text;
            set => RoomNameTextBox.Text = value;
        }

        public AddRoomForm()
        {
            InitializeComponent();
        }

        private void RoomNameTextBox_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = !string.IsNullOrEmpty(RoomName);
        }
    }
}
