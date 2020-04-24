namespace TextFile
{
    partial class Form1
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
            this.colourInput = new System.Windows.Forms.TextBox();
            this.addColourButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.loadColoursButton = new System.Windows.Forms.Button();
            this.saveColoursButton = new System.Windows.Forms.Button();
            this.sortColoursButton = new System.Windows.Forms.Button();
            this.removeInput = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // colourInput
            // 
            this.colourInput.Location = new System.Drawing.Point(26, 140);
            this.colourInput.Name = "colourInput";
            this.colourInput.Size = new System.Drawing.Size(154, 22);
            this.colourInput.TabIndex = 7;
            // 
            // addColourButton
            // 
            this.addColourButton.Location = new System.Drawing.Point(215, 128);
            this.addColourButton.Name = "addColourButton";
            this.addColourButton.Size = new System.Drawing.Size(154, 46);
            this.addColourButton.TabIndex = 6;
            this.addColourButton.Text = "Add Colour";
            this.addColourButton.UseVisualStyleBackColor = true;
            this.addColourButton.Click += new System.EventHandler(this.addColourButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(23, 254);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(346, 173);
            this.outputLabel.TabIndex = 5;
            // 
            // loadColoursButton
            // 
            this.loadColoursButton.Location = new System.Drawing.Point(26, 22);
            this.loadColoursButton.Name = "loadColoursButton";
            this.loadColoursButton.Size = new System.Drawing.Size(154, 46);
            this.loadColoursButton.TabIndex = 4;
            this.loadColoursButton.Text = "Load Colours";
            this.loadColoursButton.UseVisualStyleBackColor = true;
            this.loadColoursButton.Click += new System.EventHandler(this.loadColoursButton_Click);
            // 
            // saveColoursButton
            // 
            this.saveColoursButton.Location = new System.Drawing.Point(215, 448);
            this.saveColoursButton.Name = "saveColoursButton";
            this.saveColoursButton.Size = new System.Drawing.Size(154, 46);
            this.saveColoursButton.TabIndex = 9;
            this.saveColoursButton.Text = "Save and Close";
            this.saveColoursButton.UseVisualStyleBackColor = true;
            this.saveColoursButton.Click += new System.EventHandler(this.saveColoursButton_Click);
            // 
            // sortColoursButton
            // 
            this.sortColoursButton.Location = new System.Drawing.Point(215, 22);
            this.sortColoursButton.Name = "sortColoursButton";
            this.sortColoursButton.Size = new System.Drawing.Size(154, 46);
            this.sortColoursButton.TabIndex = 12;
            this.sortColoursButton.Text = "Sort Colours";
            this.sortColoursButton.UseVisualStyleBackColor = true;
            this.sortColoursButton.Click += new System.EventHandler(this.sortColoursButton_Click);
            // 
            // removeInput
            // 
            this.removeInput.Location = new System.Drawing.Point(26, 192);
            this.removeInput.Name = "removeInput";
            this.removeInput.Size = new System.Drawing.Size(154, 22);
            this.removeInput.TabIndex = 14;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(215, 180);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(154, 46);
            this.removeButton.TabIndex = 13;
            this.removeButton.Text = "Remove Colour";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 523);
            this.Controls.Add(this.removeInput);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.sortColoursButton);
            this.Controls.Add(this.saveColoursButton);
            this.Controls.Add(this.colourInput);
            this.Controls.Add(this.addColourButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.loadColoursButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text File Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox colourInput;
        private System.Windows.Forms.Button addColourButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button loadColoursButton;
        private System.Windows.Forms.Button saveColoursButton;
        private System.Windows.Forms.Button sortColoursButton;
        private System.Windows.Forms.TextBox removeInput;
        private System.Windows.Forms.Button removeButton;
    }
}

