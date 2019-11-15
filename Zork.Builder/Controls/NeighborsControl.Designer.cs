namespace Zork.Builder.Controls
{
    partial class NeighborsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NeighborsTextBox = new System.Windows.Forms.TextBox();
            this.NeighborsComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // NeighborsTextBox
            // 
            this.NeighborsTextBox.Location = new System.Drawing.Point(4, 4);
            this.NeighborsTextBox.Name = "NeighborsTextBox";
            this.NeighborsTextBox.ReadOnly = true;
            this.NeighborsTextBox.Size = new System.Drawing.Size(214, 22);
            this.NeighborsTextBox.TabIndex = 0;
            this.NeighborsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NeighborsComboBox
            // 
            this.NeighborsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NeighborsComboBox.FormattingEnabled = true;
            this.NeighborsComboBox.Location = new System.Drawing.Point(4, 32);
            this.NeighborsComboBox.Name = "NeighborsComboBox";
            this.NeighborsComboBox.Size = new System.Drawing.Size(215, 24);
            this.NeighborsComboBox.TabIndex = 1;
            this.NeighborsComboBox.SelectedIndexChanged += new System.EventHandler(this.NeighborsComboBox_SelectedIndexChanged);
            // 
            // NeighborsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NeighborsComboBox);
            this.Controls.Add(this.NeighborsTextBox);
            this.Name = "NeighborsControl";
            this.Size = new System.Drawing.Size(229, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NeighborsTextBox;
        private System.Windows.Forms.ComboBox NeighborsComboBox;
    }
}
