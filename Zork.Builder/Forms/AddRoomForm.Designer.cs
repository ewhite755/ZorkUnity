namespace Zork.Builder.Forms
{
    partial class AddRoomForm
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
            this.RoomNameLabel = new System.Windows.Forms.Label();
            this.RoomNameTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RoomNameLabel
            // 
            this.RoomNameLabel.AutoSize = true;
            this.RoomNameLabel.Location = new System.Drawing.Point(9, 9);
            this.RoomNameLabel.Name = "RoomNameLabel";
            this.RoomNameLabel.Size = new System.Drawing.Size(86, 17);
            this.RoomNameLabel.TabIndex = 0;
            this.RoomNameLabel.Text = "Room Name";
            // 
            // RoomNameTextBox
            // 
            this.RoomNameTextBox.Location = new System.Drawing.Point(12, 30);
            this.RoomNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RoomNameTextBox.Name = "RoomNameTextBox";
            this.RoomNameTextBox.Size = new System.Drawing.Size(268, 22);
            this.RoomNameTextBox.TabIndex = 1;
            this.RoomNameTextBox.TextChanged += new System.EventHandler(this.RoomNameTextBox_TextChanged);
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Enabled = false;
            this.okButton.Location = new System.Drawing.Point(110, 56);
            this.okButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(83, 27);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "&Ok";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(199, 56);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(83, 27);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // AddRoomForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 95);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.RoomNameTextBox);
            this.Controls.Add(this.RoomNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRoomForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RoomNameLabel;
        private System.Windows.Forms.TextBox RoomNameTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}