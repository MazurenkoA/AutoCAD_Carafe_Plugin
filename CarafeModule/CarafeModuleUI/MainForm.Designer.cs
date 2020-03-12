namespace CarafeModuleUI
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AutoCADMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DisplayModeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel = new System.Windows.Forms.Panel();
            this.CarafeGroupBox = new System.Windows.Forms.GroupBox();
            this.BuildButton = new System.Windows.Forms.Button();
            this.CarafeShapeComboBox = new System.Windows.Forms.ComboBox();
            this.StopperShapeTextBox = new System.Windows.Forms.TextBox();
            this.BottleStopperComboBox = new System.Windows.Forms.ComboBox();
            this.ThroatDiameterTextBox = new System.Windows.Forms.TextBox();
            this.HandleComboBox = new System.Windows.Forms.ComboBox();
            this.BaseDiameterTextBox = new System.Windows.Forms.TextBox();
            this.BaseDiameterLabel = new System.Windows.Forms.Label();
            this.HandleLabel = new System.Windows.Forms.Label();
            this.ThroatDiameterLabel = new System.Windows.Forms.Label();
            this.HandleLengthTextBox = new System.Windows.Forms.TextBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.HandleLengthLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.StopperShapeLabel = new System.Windows.Forms.Label();
            this.BottleStopperLabel = new System.Windows.Forms.Label();
            this.CarafeShapeLabel = new System.Windows.Forms.Label();
            this.HandleAngleTextBox = new System.Windows.Forms.TextBox();
            this.HandleAngleLabel = new System.Windows.Forms.Label();
            this.ParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.BuildButtonGroupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.Panel.SuspendLayout();
            this.CarafeGroupBox.SuspendLayout();
            this.ParametersGroupBox.SuspendLayout();
            this.BuildButtonGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AutoCADMenuItem,
            this.DisplayModeMenuItem,
            this.HelpMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(269, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AutoCADMenuItem
            // 
            this.AutoCADMenuItem.Name = "AutoCADMenuItem";
            this.AutoCADMenuItem.Size = new System.Drawing.Size(69, 20);
            this.AutoCADMenuItem.Text = "AutoCAD";
            // 
            // DisplayModeMenuItem
            // 
            this.DisplayModeMenuItem.Name = "DisplayModeMenuItem";
            this.DisplayModeMenuItem.Size = new System.Drawing.Size(91, 20);
            this.DisplayModeMenuItem.Text = "Display mode";
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItem});
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpMenuItem.Text = "Help";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(107, 22);
            this.AboutMenuItem.Text = "About";
            // 
            // Panel
            // 
            this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel.Controls.Add(this.CarafeGroupBox);
            this.Panel.Location = new System.Drawing.Point(0, 24);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(272, 372);
            this.Panel.TabIndex = 1;
            // 
            // CarafeGroupBox
            // 
            this.CarafeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CarafeGroupBox.Controls.Add(this.BuildButtonGroupBox);
            this.CarafeGroupBox.Controls.Add(this.ParametersGroupBox);
            this.CarafeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CarafeGroupBox.Location = new System.Drawing.Point(12, 3);
            this.CarafeGroupBox.Name = "CarafeGroupBox";
            this.CarafeGroupBox.Size = new System.Drawing.Size(245, 363);
            this.CarafeGroupBox.TabIndex = 0;
            this.CarafeGroupBox.TabStop = false;
            this.CarafeGroupBox.Text = "Carafe";
            // 
            // BuildButton
            // 
            this.BuildButton.Location = new System.Drawing.Point(62, 19);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(102, 26);
            this.BuildButton.TabIndex = 20;
            this.BuildButton.Text = "Build";
            this.BuildButton.UseVisualStyleBackColor = true;
            // 
            // CarafeShapeComboBox
            // 
            this.CarafeShapeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CarafeShapeComboBox.FormattingEnabled = true;
            this.CarafeShapeComboBox.Items.AddRange(new object[] {
            "Square",
            "Round",
            "Default"});
            this.CarafeShapeComboBox.Location = new System.Drawing.Point(114, 240);
            this.CarafeShapeComboBox.Name = "CarafeShapeComboBox";
            this.CarafeShapeComboBox.Size = new System.Drawing.Size(100, 23);
            this.CarafeShapeComboBox.TabIndex = 19;
            // 
            // StopperShapeTextBox
            // 
            this.StopperShapeTextBox.Location = new System.Drawing.Point(114, 130);
            this.StopperShapeTextBox.Name = "StopperShapeTextBox";
            this.StopperShapeTextBox.Size = new System.Drawing.Size(100, 21);
            this.StopperShapeTextBox.TabIndex = 18;
            // 
            // BottleStopperComboBox
            // 
            this.BottleStopperComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BottleStopperComboBox.FormattingEnabled = true;
            this.BottleStopperComboBox.Items.AddRange(new object[] {
            "Present",
            "Missing"});
            this.BottleStopperComboBox.Location = new System.Drawing.Point(114, 101);
            this.BottleStopperComboBox.Name = "BottleStopperComboBox";
            this.BottleStopperComboBox.Size = new System.Drawing.Size(100, 23);
            this.BottleStopperComboBox.TabIndex = 17;
            // 
            // ThroatDiameterTextBox
            // 
            this.ThroatDiameterTextBox.Location = new System.Drawing.Point(114, 74);
            this.ThroatDiameterTextBox.Name = "ThroatDiameterTextBox";
            this.ThroatDiameterTextBox.Size = new System.Drawing.Size(100, 21);
            this.ThroatDiameterTextBox.TabIndex = 13;
            // 
            // HandleComboBox
            // 
            this.HandleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HandleComboBox.FormattingEnabled = true;
            this.HandleComboBox.Items.AddRange(new object[] {
            "Present",
            "Missing"});
            this.HandleComboBox.Location = new System.Drawing.Point(114, 157);
            this.HandleComboBox.Name = "HandleComboBox";
            this.HandleComboBox.Size = new System.Drawing.Size(100, 23);
            this.HandleComboBox.TabIndex = 16;
            // 
            // BaseDiameterTextBox
            // 
            this.BaseDiameterTextBox.Location = new System.Drawing.Point(114, 20);
            this.BaseDiameterTextBox.Name = "BaseDiameterTextBox";
            this.BaseDiameterTextBox.Size = new System.Drawing.Size(100, 21);
            this.BaseDiameterTextBox.TabIndex = 12;
            // 
            // BaseDiameterLabel
            // 
            this.BaseDiameterLabel.AutoSize = true;
            this.BaseDiameterLabel.Location = new System.Drawing.Point(15, 23);
            this.BaseDiameterLabel.Name = "BaseDiameterLabel";
            this.BaseDiameterLabel.Size = new System.Drawing.Size(93, 15);
            this.BaseDiameterLabel.TabIndex = 3;
            this.BaseDiameterLabel.Text = "Base diameter :";
            // 
            // HandleLabel
            // 
            this.HandleLabel.AutoSize = true;
            this.HandleLabel.Location = new System.Drawing.Point(55, 160);
            this.HandleLabel.Name = "HandleLabel";
            this.HandleLabel.Size = new System.Drawing.Size(53, 15);
            this.HandleLabel.TabIndex = 7;
            this.HandleLabel.Text = "Handle :";
            // 
            // ThroatDiameterLabel
            // 
            this.ThroatDiameterLabel.AutoSize = true;
            this.ThroatDiameterLabel.Location = new System.Drawing.Point(8, 77);
            this.ThroatDiameterLabel.Name = "ThroatDiameterLabel";
            this.ThroatDiameterLabel.Size = new System.Drawing.Size(100, 15);
            this.ThroatDiameterLabel.TabIndex = 4;
            this.ThroatDiameterLabel.Text = "Throat diameter :";
            // 
            // HandleLengthTextBox
            // 
            this.HandleLengthTextBox.Location = new System.Drawing.Point(114, 186);
            this.HandleLengthTextBox.Name = "HandleLengthTextBox";
            this.HandleLengthTextBox.Size = new System.Drawing.Size(100, 21);
            this.HandleLengthTextBox.TabIndex = 15;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(114, 47);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(100, 21);
            this.HeightTextBox.TabIndex = 12;
            // 
            // HandleLengthLabel
            // 
            this.HandleLengthLabel.AutoSize = true;
            this.HandleLengthLabel.Location = new System.Drawing.Point(18, 189);
            this.HandleLengthLabel.Name = "HandleLengthLabel";
            this.HandleLengthLabel.Size = new System.Drawing.Size(90, 15);
            this.HandleLengthLabel.TabIndex = 8;
            this.HandleLengthLabel.Text = "Handle length :";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(59, 50);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(49, 15);
            this.HeightLabel.TabIndex = 2;
            this.HeightLabel.Text = "Height :";
            // 
            // StopperShapeLabel
            // 
            this.StopperShapeLabel.AutoSize = true;
            this.StopperShapeLabel.Location = new System.Drawing.Point(15, 133);
            this.StopperShapeLabel.Name = "StopperShapeLabel";
            this.StopperShapeLabel.Size = new System.Drawing.Size(93, 15);
            this.StopperShapeLabel.TabIndex = 9;
            this.StopperShapeLabel.Text = "Stopper shape :";
            // 
            // BottleStopperLabel
            // 
            this.BottleStopperLabel.AutoSize = true;
            this.BottleStopperLabel.Location = new System.Drawing.Point(20, 104);
            this.BottleStopperLabel.Name = "BottleStopperLabel";
            this.BottleStopperLabel.Size = new System.Drawing.Size(88, 15);
            this.BottleStopperLabel.TabIndex = 6;
            this.BottleStopperLabel.Text = "Bottle stopper :";
            // 
            // CarafeShapeLabel
            // 
            this.CarafeShapeLabel.AutoSize = true;
            this.CarafeShapeLabel.Location = new System.Drawing.Point(22, 243);
            this.CarafeShapeLabel.Name = "CarafeShapeLabel";
            this.CarafeShapeLabel.Size = new System.Drawing.Size(86, 15);
            this.CarafeShapeLabel.TabIndex = 5;
            this.CarafeShapeLabel.Text = "Carafe shape :";
            // 
            // HandleAngleTextBox
            // 
            this.HandleAngleTextBox.Location = new System.Drawing.Point(114, 213);
            this.HandleAngleTextBox.Name = "HandleAngleTextBox";
            this.HandleAngleTextBox.Size = new System.Drawing.Size(100, 21);
            this.HandleAngleTextBox.TabIndex = 22;
            // 
            // HandleAngleLabel
            // 
            this.HandleAngleLabel.AutoSize = true;
            this.HandleAngleLabel.Location = new System.Drawing.Point(21, 216);
            this.HandleAngleLabel.Name = "HandleAngleLabel";
            this.HandleAngleLabel.Size = new System.Drawing.Size(87, 15);
            this.HandleAngleLabel.TabIndex = 21;
            this.HandleAngleLabel.Text = "Handle angle :";
            // 
            // ParametersGroupBox
            // 
            this.ParametersGroupBox.Controls.Add(this.ThroatDiameterTextBox);
            this.ParametersGroupBox.Controls.Add(this.HandleAngleTextBox);
            this.ParametersGroupBox.Controls.Add(this.CarafeShapeLabel);
            this.ParametersGroupBox.Controls.Add(this.HandleAngleLabel);
            this.ParametersGroupBox.Controls.Add(this.BottleStopperLabel);
            this.ParametersGroupBox.Controls.Add(this.StopperShapeLabel);
            this.ParametersGroupBox.Controls.Add(this.CarafeShapeComboBox);
            this.ParametersGroupBox.Controls.Add(this.HeightLabel);
            this.ParametersGroupBox.Controls.Add(this.StopperShapeTextBox);
            this.ParametersGroupBox.Controls.Add(this.HandleLengthLabel);
            this.ParametersGroupBox.Controls.Add(this.BottleStopperComboBox);
            this.ParametersGroupBox.Controls.Add(this.HeightTextBox);
            this.ParametersGroupBox.Controls.Add(this.HandleLengthTextBox);
            this.ParametersGroupBox.Controls.Add(this.HandleComboBox);
            this.ParametersGroupBox.Controls.Add(this.ThroatDiameterLabel);
            this.ParametersGroupBox.Controls.Add(this.BaseDiameterTextBox);
            this.ParametersGroupBox.Controls.Add(this.HandleLabel);
            this.ParametersGroupBox.Controls.Add(this.BaseDiameterLabel);
            this.ParametersGroupBox.Location = new System.Drawing.Point(6, 20);
            this.ParametersGroupBox.Name = "ParametersGroupBox";
            this.ParametersGroupBox.Size = new System.Drawing.Size(228, 275);
            this.ParametersGroupBox.TabIndex = 23;
            this.ParametersGroupBox.TabStop = false;
            this.ParametersGroupBox.Text = "Parameters";
            // 
            // BuildButtonGroupBox
            // 
            this.BuildButtonGroupBox.Controls.Add(this.BuildButton);
            this.BuildButtonGroupBox.Location = new System.Drawing.Point(6, 301);
            this.BuildButtonGroupBox.Name = "BuildButtonGroupBox";
            this.BuildButtonGroupBox.Size = new System.Drawing.Size(228, 54);
            this.BuildButtonGroupBox.TabIndex = 24;
            this.BuildButtonGroupBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 396);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoCAD:  Carafe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Panel.ResumeLayout(false);
            this.CarafeGroupBox.ResumeLayout(false);
            this.ParametersGroupBox.ResumeLayout(false);
            this.ParametersGroupBox.PerformLayout();
            this.BuildButtonGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AutoCADMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DisplayModeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.GroupBox CarafeGroupBox;
        private System.Windows.Forms.Label HandleLabel;
        private System.Windows.Forms.Label BottleStopperLabel;
        private System.Windows.Forms.Label CarafeShapeLabel;
        private System.Windows.Forms.Label ThroatDiameterLabel;
        private System.Windows.Forms.Label BaseDiameterLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label StopperShapeLabel;
        private System.Windows.Forms.Label HandleLengthLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.ComboBox HandleComboBox;
        private System.Windows.Forms.TextBox HandleLengthTextBox;
        private System.Windows.Forms.TextBox ThroatDiameterTextBox;
        private System.Windows.Forms.TextBox BaseDiameterTextBox;
        private System.Windows.Forms.Button BuildButton;
        private System.Windows.Forms.ComboBox CarafeShapeComboBox;
        private System.Windows.Forms.TextBox StopperShapeTextBox;
        private System.Windows.Forms.ComboBox BottleStopperComboBox;
        private System.Windows.Forms.TextBox HandleAngleTextBox;
        private System.Windows.Forms.Label HandleAngleLabel;
        private System.Windows.Forms.GroupBox ParametersGroupBox;
        private System.Windows.Forms.GroupBox BuildButtonGroupBox;
    }
}

