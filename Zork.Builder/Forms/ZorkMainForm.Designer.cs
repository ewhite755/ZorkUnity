namespace Zork.Builder
{
    partial class ZorkMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.RoomListBox = new System.Windows.Forms.ListBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RoomDescription = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.NorthNeighborsControl = new Zork.Builder.Controls.NeighborsControl();
            this.NeighborsLabel = new System.Windows.Forms.Label();
            this.SouthNeighborsControl = new Zork.Builder.Controls.NeighborsControl();
            this.WestNeighborsControl = new Zork.Builder.Controls.NeighborsControl();
            this.EastNeighborsControl = new Zork.Builder.Controls.NeighborsControl();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.RoomsLabel = new System.Windows.Forms.Label();
            this.RoomNameTextBox = new System.Windows.Forms.TextBox();
            this.StartingLocationComboBox1 = new System.Windows.Forms.ComboBox();
            this.gameViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StartingLocationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StartingLocationLabel = new System.Windows.Forms.Label();
            this.StartUpMessageLabel = new System.Windows.Forms.Label();
            this.StartMessageTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartingLocationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "World Files (*json)|*.json";
            // 
            // RoomListBox
            // 
            this.RoomListBox.DataSource = this.roomsBindingSource;
            this.RoomListBox.DisplayMember = "Name";
            this.RoomListBox.FormattingEnabled = true;
            this.RoomListBox.Location = new System.Drawing.Point(11, 64);
            this.RoomListBox.Margin = new System.Windows.Forms.Padding(2);
            this.RoomListBox.Name = "RoomListBox";
            this.RoomListBox.Size = new System.Drawing.Size(182, 329);
            this.RoomListBox.TabIndex = 9;
            this.RoomListBox.ValueMember = "Description";
            this.RoomListBox.SelectedIndexChanged += new System.EventHandler(this.RoomListBox_SelectedIndexChanged);
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataSource = typeof(Zork.Common.Room);
            // 
            // RoomDescription
            // 
            this.RoomDescription.AutoSize = true;
            this.RoomDescription.Location = new System.Drawing.Point(458, 90);
            this.RoomDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RoomDescription.Name = "RoomDescription";
            this.RoomDescription.Size = new System.Drawing.Size(60, 13);
            this.RoomDescription.TabIndex = 11;
            this.RoomDescription.Text = "Description";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DescriptionTextBox.Location = new System.Drawing.Point(319, 106);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(338, 140);
            this.DescriptionTextBox.TabIndex = 12;
            this.DescriptionTextBox.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(902, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openWorldToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // openWorldToolStripMenuItem
            // 
            this.openWorldToolStripMenuItem.Name = "openWorldToolStripMenuItem";
            this.openWorldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openWorldToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.openWorldToolStripMenuItem.Text = "&Open World...";
            this.openWorldToolStripMenuItem.Click += new System.EventHandler(this.OpenWorldToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(187, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click_1);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "World Files (*.json)|*.json";
            this.SaveFileDialog.Title = "Save World";
            // 
            // NorthNeighborsControl
            // 
            this.NorthNeighborsControl.Directions = Zork.Common.Directions.North;
            this.NorthNeighborsControl.Location = new System.Drawing.Point(412, 262);
            this.NorthNeighborsControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NorthNeighborsControl.Name = "NorthNeighborsControl";
            this.NorthNeighborsControl.Neighbor = null;
            this.NorthNeighborsControl.Room = null;
            this.NorthNeighborsControl.Size = new System.Drawing.Size(172, 49);
            this.NorthNeighborsControl.TabIndex = 17;
            this.NorthNeighborsControl.World = null;
            // 
            // NeighborsLabel
            // 
            this.NeighborsLabel.AutoSize = true;
            this.NeighborsLabel.Location = new System.Drawing.Point(463, 246);
            this.NeighborsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NeighborsLabel.Name = "NeighborsLabel";
            this.NeighborsLabel.Size = new System.Drawing.Size(55, 13);
            this.NeighborsLabel.TabIndex = 18;
            this.NeighborsLabel.Text = "Neighbors";
            // 
            // SouthNeighborsControl
            // 
            this.SouthNeighborsControl.Directions = Zork.Common.Directions.South;
            this.SouthNeighborsControl.Location = new System.Drawing.Point(412, 370);
            this.SouthNeighborsControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SouthNeighborsControl.Name = "SouthNeighborsControl";
            this.SouthNeighborsControl.Neighbor = null;
            this.SouthNeighborsControl.Room = null;
            this.SouthNeighborsControl.Size = new System.Drawing.Size(172, 49);
            this.SouthNeighborsControl.TabIndex = 19;
            this.SouthNeighborsControl.World = null;
            // 
            // WestNeighborsControl
            // 
            this.WestNeighborsControl.Directions = Zork.Common.Directions.West;
            this.WestNeighborsControl.Location = new System.Drawing.Point(319, 316);
            this.WestNeighborsControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WestNeighborsControl.Name = "WestNeighborsControl";
            this.WestNeighborsControl.Neighbor = null;
            this.WestNeighborsControl.Room = null;
            this.WestNeighborsControl.Size = new System.Drawing.Size(172, 49);
            this.WestNeighborsControl.TabIndex = 20;
            this.WestNeighborsControl.World = null;
            // 
            // EastNeighborsControl
            // 
            this.EastNeighborsControl.Directions = Zork.Common.Directions.East;
            this.EastNeighborsControl.Location = new System.Drawing.Point(495, 316);
            this.EastNeighborsControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EastNeighborsControl.Name = "EastNeighborsControl";
            this.EastNeighborsControl.Neighbor = null;
            this.EastNeighborsControl.Room = null;
            this.EastNeighborsControl.Size = new System.Drawing.Size(172, 49);
            this.EastNeighborsControl.TabIndex = 21;
            this.EastNeighborsControl.World = null;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(11, 399);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(66, 32);
            this.AddButton.TabIndex = 22;
            this.AddButton.Text = "&Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click_1);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(126, 399);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(66, 32);
            this.DeleteButton.TabIndex = 23;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click_1);
            // 
            // RoomsLabel
            // 
            this.RoomsLabel.AutoSize = true;
            this.RoomsLabel.Location = new System.Drawing.Point(11, 46);
            this.RoomsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RoomsLabel.Name = "RoomsLabel";
            this.RoomsLabel.Size = new System.Drawing.Size(40, 13);
            this.RoomsLabel.TabIndex = 24;
            this.RoomsLabel.Text = "Rooms";
            // 
            // RoomNameTextBox
            // 
            this.RoomNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.RoomNameTextBox.Location = new System.Drawing.Point(319, 46);
            this.RoomNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.RoomNameTextBox.Name = "RoomNameTextBox";
            this.RoomNameTextBox.Size = new System.Drawing.Size(338, 20);
            this.RoomNameTextBox.TabIndex = 25;
            // 
            // StartingLocationComboBox1
            // 
            this.StartingLocationComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameViewModelBindingSource, "StartingLocation", true));
            this.StartingLocationComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.gameViewModelBindingSource, "StartingLocation", true));
            this.StartingLocationComboBox1.DataSource = this.StartingLocationBindingSource;
            this.StartingLocationComboBox1.DisplayMember = "Name";
            this.StartingLocationComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartingLocationComboBox1.FormattingEnabled = true;
            this.StartingLocationComboBox1.Location = new System.Drawing.Point(740, 46);
            this.StartingLocationComboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.StartingLocationComboBox1.Name = "StartingLocationComboBox1";
            this.StartingLocationComboBox1.Size = new System.Drawing.Size(118, 21);
            this.StartingLocationComboBox1.TabIndex = 26;
            this.StartingLocationComboBox1.ValueMember = "Description";
            this.StartingLocationComboBox1.SelectedIndexChanged += new System.EventHandler(this.StartingLocationComboBox1_SelectedIndexChanged);
            // 
            // gameViewModelBindingSource
            // 
            this.gameViewModelBindingSource.DataSource = typeof(Zork.Builder.ViewModels.GameViewModel);
            // 
            // StartingLocationBindingSource
            // 
            this.StartingLocationBindingSource.DataSource = typeof(Zork.Common.Room);
            // 
            // StartingLocationLabel
            // 
            this.StartingLocationLabel.AutoSize = true;
            this.StartingLocationLabel.Location = new System.Drawing.Point(755, 30);
            this.StartingLocationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StartingLocationLabel.Name = "StartingLocationLabel";
            this.StartingLocationLabel.Size = new System.Drawing.Size(87, 13);
            this.StartingLocationLabel.TabIndex = 27;
            this.StartingLocationLabel.Text = "Starting Location";
            // 
            // StartUpMessageLabel
            // 
            this.StartUpMessageLabel.AutoSize = true;
            this.StartUpMessageLabel.Location = new System.Drawing.Point(755, 90);
            this.StartUpMessageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StartUpMessageLabel.Name = "StartUpMessageLabel";
            this.StartUpMessageLabel.Size = new System.Drawing.Size(92, 13);
            this.StartUpMessageLabel.TabIndex = 28;
            this.StartUpMessageLabel.Text = "Start-Up Message";
            // 
            // StartMessageTextBox
            // 
            this.StartMessageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameViewModelBindingSource, "WelcomeMessage", true));
            this.StartMessageTextBox.Location = new System.Drawing.Point(986, 132);
            //this.StartMessageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameViewModelBindingSource, "StartupMessage", true));
            this.StartMessageTextBox.Location = new System.Drawing.Point(740, 107);
            this.StartMessageTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.StartMessageTextBox.Name = "StartMessageTextBox";
            this.StartMessageTextBox.Size = new System.Drawing.Size(118, 138);
            this.StartMessageTextBox.TabIndex = 29;
            this.StartMessageTextBox.Text = "";
            this.StartMessageTextBox.TextChanged += new System.EventHandler(this.StartMessageTextBox_TextChanged);
            // 
            // ZorkMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 450);
            this.Controls.Add(this.StartMessageTextBox);
            this.Controls.Add(this.StartUpMessageLabel);
            this.Controls.Add(this.StartingLocationLabel);
            this.Controls.Add(this.StartingLocationComboBox1);
            this.Controls.Add(this.RoomNameTextBox);
            this.Controls.Add(this.RoomsLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EastNeighborsControl);
            this.Controls.Add(this.WestNeighborsControl);
            this.Controls.Add(this.SouthNeighborsControl);
            this.Controls.Add(this.NeighborsLabel);
            this.Controls.Add(this.NorthNeighborsControl);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.RoomDescription);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.RoomListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ZorkMainForm";
            this.Text = "Zork Builder";
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartingLocationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ListBox RoomListBox;
        private System.Windows.Forms.Label RoomDescription;
        private System.Windows.Forms.RichTextBox DescriptionTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private Controls.NeighborsControl NorthNeighborsControl;
        private System.Windows.Forms.Label NeighborsLabel;
        private Controls.NeighborsControl SouthNeighborsControl;
        private Controls.NeighborsControl WestNeighborsControl;
        private Controls.NeighborsControl EastNeighborsControl;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label RoomsLabel;
        private System.Windows.Forms.TextBox RoomNameTextBox;
        private System.Windows.Forms.ComboBox StartingLocationComboBox1;
        private System.Windows.Forms.Label StartingLocationLabel;
        private System.Windows.Forms.BindingSource StartingLocationBindingSource;
        private System.Windows.Forms.Label StartUpMessageLabel;
        private System.Windows.Forms.RichTextBox StartMessageTextBox;
        private System.Windows.Forms.BindingSource gameViewModelBindingSource;
    }
}

