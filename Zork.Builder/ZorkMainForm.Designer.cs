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
            this.gameViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.RoomsLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.RoomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.WorldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RoomNameDisplay = new System.Windows.Forms.TextBox();
            this.RoomDescription = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorldBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameViewModelBindingSource
            // 
            this.gameViewModelBindingSource.AllowNew = false;
            this.gameViewModelBindingSource.DataSource = typeof(Zork.Builder.ViewModels.GameViewModel);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(9, 410);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 32);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "&Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(117, 410);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 32);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "World Files (*json)|*.json";
            // 
            // RoomsLabel
            // 
            this.RoomsLabel.AutoSize = true;
            this.RoomsLabel.Location = new System.Drawing.Point(6, 24);
            this.RoomsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RoomsLabel.Name = "RoomsLabel";
            this.RoomsLabel.Size = new System.Drawing.Size(40, 13);
            this.RoomsLabel.TabIndex = 8;
            this.RoomsLabel.Text = "Rooms";
            this.RoomsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.RoomsBindingSource;
            this.listBox1.DisplayMember = "Name";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(11, 39);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(182, 355);
            this.listBox1.TabIndex = 9;
            // 
            // RoomsBindingSource
            // 
            this.RoomsBindingSource.DataMember = "Rooms";
            this.RoomsBindingSource.DataSource = this.WorldBindingSource;
            // 
            // WorldBindingSource
            // 
            this.WorldBindingSource.DataMember = "World";
            this.WorldBindingSource.DataSource = this.GameBindingSource;
            // 
            // GameBindingSource
            // 
            this.GameBindingSource.AllowNew = true;
            this.GameBindingSource.DataMember = "Game";
            this.GameBindingSource.DataSource = this.gameViewModelBindingSource;
            // 
            // RoomNameDisplay
            // 
            this.RoomNameDisplay.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.RoomsBindingSource, "Name", true));
            this.RoomNameDisplay.Location = new System.Drawing.Point(319, 39);
            this.RoomNameDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.RoomNameDisplay.Name = "RoomNameDisplay";
            this.RoomNameDisplay.Size = new System.Drawing.Size(338, 20);
            this.RoomNameDisplay.TabIndex = 10;
            this.RoomNameDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RoomDescription
            // 
            this.RoomDescription.AutoSize = true;
            this.RoomDescription.Location = new System.Drawing.Point(453, 61);
            this.RoomDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RoomDescription.Name = "RoomDescription";
            this.RoomDescription.Size = new System.Drawing.Size(60, 13);
            this.RoomDescription.TabIndex = 11;
            this.RoomDescription.Text = "Description";
            // 
            // richTextBox1
            // 
            this.richTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.RoomsBindingSource, "Description", true));
            this.richTextBox1.Location = new System.Drawing.Point(319, 76);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(338, 174);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "World Files(*.json)|*.json";
            this.saveFileDialog.Title = "Save world files";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openWorldToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(761, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ZorkMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.RoomDescription);
            this.Controls.Add(this.RoomNameDisplay);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.RoomsLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ZorkMainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorldBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label RoomsLabel;
        private System.Windows.Forms.BindingSource gameViewModelBindingSource;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource GameBindingSource;
        private System.Windows.Forms.BindingSource RoomsBindingSource;
        private System.Windows.Forms.BindingSource WorldBindingSource;
        private System.Windows.Forms.TextBox RoomNameDisplay;
        private System.Windows.Forms.Label RoomDescription;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

