using System;
using System.Windows.Forms;
using Zork.Common;
using Newtonsoft.Json;
using System.IO;
using Zork.Builder.ViewModels;

namespace Zork.Builder
{
    public partial class ZorkMainForm : Form
    {
        private GameViewModel ViewModel
        { 
            get => mViewModel;
            set
            {
                if (mViewModel != value)
                {
                    mViewModel = value;
                    gameViewModelBindingSource.DataSource = mViewModel;
                }
            }
        }

        public ZorkMainForm()
        {
            InitializeComponent();
            ViewModel = new GameViewModel();
        }

        private GameViewModel mViewModel;

        #region Menu Items
        private void OpenWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.Game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(openFileDialog.FileName));
                ViewModel.Filename = openFileDialog.FileName;
            }
        }
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewModel.SaveWorld();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.Filename = saveFileDialog.FileName;
                ViewModel.SaveWorld();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion Menu Items
    }

}
