namespace CarafeModuleUI
{
    partial class CarafeForm
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
            this.Panel = new System.Windows.Forms.Panel();
            this.CarafeGroupBox = new System.Windows.Forms.GroupBox();
            this.BuildButtonGroupBox = new System.Windows.Forms.GroupBox();
            this.BuildButton = new System.Windows.Forms.Button();
            this.ParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.HandleGroupBox = new System.Windows.Forms.GroupBox();
            this.RangeHandleLengthLabel = new System.Windows.Forms.Label();
            this.RangeHandleAngleLabel = new System.Windows.Forms.Label();
            this.HandleAngleTextBox = new System.Windows.Forms.TextBox();
            this.HandleComboBox = new System.Windows.Forms.ComboBox();
            this.HandleAngleLabel = new System.Windows.Forms.Label();
            this.HandleLabel = new System.Windows.Forms.Label();
            this.HandleLengthLabel = new System.Windows.Forms.Label();
            this.HandleLengthTextBox = new System.Windows.Forms.TextBox();
            this.BaseGroupBox = new System.Windows.Forms.GroupBox();
            this.RangeThroatDiameterLabel = new System.Windows.Forms.Label();
            this.RangeCarafeHeightLabel = new System.Windows.Forms.Label();
            this.RangeBaseDiameterLabel = new System.Windows.Forms.Label();
            this.ThroatDiameterTextBox = new System.Windows.Forms.TextBox();
            this.BaseDiameterTextBox = new System.Windows.Forms.TextBox();
            this.BaseDiameterLabel = new System.Windows.Forms.Label();
            this.ThroatDiameterLabel = new System.Windows.Forms.Label();
            this.CarafeHeightTextBox = new System.Windows.Forms.TextBox();
            this.CarafeHeightLabel = new System.Windows.Forms.Label();
            this.StopperGroupBox = new System.Windows.Forms.GroupBox();
            this.RangeStopperHeightLabel = new System.Windows.Forms.Label();
            this.BottleStopperComboBox = new System.Windows.Forms.ComboBox();
            this.StopperHeightTextBox = new System.Windows.Forms.TextBox();
            this.BottleStopperLabel = new System.Windows.Forms.Label();
            this.StopperHeightLabel = new System.Windows.Forms.Label();
            this.Panel.SuspendLayout();
            this.CarafeGroupBox.SuspendLayout();
            this.BuildButtonGroupBox.SuspendLayout();
            this.ParametersGroupBox.SuspendLayout();
            this.HandleGroupBox.SuspendLayout();
            this.BaseGroupBox.SuspendLayout();
            this.StopperGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel.Controls.Add(this.CarafeGroupBox);
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(404, 420);
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
            this.CarafeGroupBox.Size = new System.Drawing.Size(377, 411);
            this.CarafeGroupBox.TabIndex = 1;
            this.CarafeGroupBox.TabStop = false;
            this.CarafeGroupBox.Text = "Carafe";
            // 
            // BuildButtonGroupBox
            // 
            this.BuildButtonGroupBox.Controls.Add(this.BuildButton);
            this.BuildButtonGroupBox.Location = new System.Drawing.Point(6, 352);
            this.BuildButtonGroupBox.Name = "BuildButtonGroupBox";
            this.BuildButtonGroupBox.Size = new System.Drawing.Size(365, 53);
            this.BuildButtonGroupBox.TabIndex = 1;
            this.BuildButtonGroupBox.TabStop = false;
            // 
            // BuildButton
            // 
            this.BuildButton.Location = new System.Drawing.Point(129, 20);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(102, 26);
            this.BuildButton.TabIndex = 1;
            this.BuildButton.Text = "Build";
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // ParametersGroupBox
            // 
            this.ParametersGroupBox.Controls.Add(this.HandleGroupBox);
            this.ParametersGroupBox.Controls.Add(this.BaseGroupBox);
            this.ParametersGroupBox.Controls.Add(this.StopperGroupBox);
            this.ParametersGroupBox.Location = new System.Drawing.Point(6, 20);
            this.ParametersGroupBox.Name = "ParametersGroupBox";
            this.ParametersGroupBox.Size = new System.Drawing.Size(365, 332);
            this.ParametersGroupBox.TabIndex = 23;
            this.ParametersGroupBox.TabStop = false;
            this.ParametersGroupBox.Text = "Parameters";
            // 
            // HandleGroupBox
            // 
            this.HandleGroupBox.Controls.Add(this.RangeHandleLengthLabel);
            this.HandleGroupBox.Controls.Add(this.RangeHandleAngleLabel);
            this.HandleGroupBox.Controls.Add(this.HandleAngleTextBox);
            this.HandleGroupBox.Controls.Add(this.HandleComboBox);
            this.HandleGroupBox.Controls.Add(this.HandleAngleLabel);
            this.HandleGroupBox.Controls.Add(this.HandleLabel);
            this.HandleGroupBox.Controls.Add(this.HandleLengthLabel);
            this.HandleGroupBox.Controls.Add(this.HandleLengthTextBox);
            this.HandleGroupBox.Location = new System.Drawing.Point(6, 217);
            this.HandleGroupBox.Name = "HandleGroupBox";
            this.HandleGroupBox.Size = new System.Drawing.Size(350, 109);
            this.HandleGroupBox.TabIndex = 4;
            this.HandleGroupBox.TabStop = false;
            this.HandleGroupBox.Text = "Handle";
            // 
            // RangeHandleLengthLabel
            // 
            this.RangeHandleLengthLabel.AutoSize = true;
            this.RangeHandleLengthLabel.Location = new System.Drawing.Point(189, 52);
            this.RangeHandleLengthLabel.Name = "RangeHandleLengthLabel";
            this.RangeHandleLengthLabel.Size = new System.Drawing.Size(135, 15);
            this.RangeHandleLengthLabel.TabIndex = 9;
            this.RangeHandleLengthLabel.Text = "(min:0.0 - max:0.0 mm)";
            // 
            // RangeHandleAngleLabel
            // 
            this.RangeHandleAngleLabel.AutoSize = true;
            this.RangeHandleAngleLabel.Location = new System.Drawing.Point(189, 79);
            this.RangeHandleAngleLabel.Name = "RangeHandleAngleLabel";
            this.RangeHandleAngleLabel.Size = new System.Drawing.Size(135, 15);
            this.RangeHandleAngleLabel.TabIndex = 7;
            this.RangeHandleAngleLabel.Text = "(min:0.0 - max:0.0 mm)";
            // 
            // HandleAngleTextBox
            // 
            this.HandleAngleTextBox.Location = new System.Drawing.Point(114, 76);
            this.HandleAngleTextBox.MaxLength = 6;
            this.HandleAngleTextBox.Name = "HandleAngleTextBox";
            this.HandleAngleTextBox.Size = new System.Drawing.Size(69, 21);
            this.HandleAngleTextBox.TabIndex = 9;
            this.HandleAngleTextBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.HandleAngleTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPressOnlyNumber);
            this.HandleAngleTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // HandleComboBox
            // 
            this.HandleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HandleComboBox.FormattingEnabled = true;
            this.HandleComboBox.Location = new System.Drawing.Point(114, 20);
            this.HandleComboBox.Name = "HandleComboBox";
            this.HandleComboBox.Size = new System.Drawing.Size(69, 23);
            this.HandleComboBox.TabIndex = 7;
            this.HandleComboBox.SelectedIndexChanged += new System.EventHandler(this.HandleComboBox_SelectedIndexChanged);
            // 
            // HandleAngleLabel
            // 
            this.HandleAngleLabel.AutoSize = true;
            this.HandleAngleLabel.Location = new System.Drawing.Point(21, 79);
            this.HandleAngleLabel.Name = "HandleAngleLabel";
            this.HandleAngleLabel.Size = new System.Drawing.Size(87, 15);
            this.HandleAngleLabel.TabIndex = 0;
            this.HandleAngleLabel.Text = "Handle angle :";
            // 
            // HandleLabel
            // 
            this.HandleLabel.AutoSize = true;
            this.HandleLabel.Location = new System.Drawing.Point(55, 23);
            this.HandleLabel.Name = "HandleLabel";
            this.HandleLabel.Size = new System.Drawing.Size(53, 15);
            this.HandleLabel.TabIndex = 0;
            this.HandleLabel.Text = "Handle :";
            // 
            // HandleLengthLabel
            // 
            this.HandleLengthLabel.AutoSize = true;
            this.HandleLengthLabel.Location = new System.Drawing.Point(18, 52);
            this.HandleLengthLabel.Name = "HandleLengthLabel";
            this.HandleLengthLabel.Size = new System.Drawing.Size(90, 15);
            this.HandleLengthLabel.TabIndex = 0;
            this.HandleLengthLabel.Text = "Handle length :";
            // 
            // HandleLengthTextBox
            // 
            this.HandleLengthTextBox.Location = new System.Drawing.Point(114, 49);
            this.HandleLengthTextBox.MaxLength = 6;
            this.HandleLengthTextBox.Name = "HandleLengthTextBox";
            this.HandleLengthTextBox.Size = new System.Drawing.Size(69, 21);
            this.HandleLengthTextBox.TabIndex = 8;
            this.HandleLengthTextBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.HandleLengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPressOnlyNumber);
            this.HandleLengthTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // BaseGroupBox
            // 
            this.BaseGroupBox.Controls.Add(this.RangeThroatDiameterLabel);
            this.BaseGroupBox.Controls.Add(this.RangeCarafeHeightLabel);
            this.BaseGroupBox.Controls.Add(this.RangeBaseDiameterLabel);
            this.BaseGroupBox.Controls.Add(this.ThroatDiameterTextBox);
            this.BaseGroupBox.Controls.Add(this.BaseDiameterTextBox);
            this.BaseGroupBox.Controls.Add(this.BaseDiameterLabel);
            this.BaseGroupBox.Controls.Add(this.ThroatDiameterLabel);
            this.BaseGroupBox.Controls.Add(this.CarafeHeightTextBox);
            this.BaseGroupBox.Controls.Add(this.CarafeHeightLabel);
            this.BaseGroupBox.Location = new System.Drawing.Point(6, 20);
            this.BaseGroupBox.Name = "BaseGroupBox";
            this.BaseGroupBox.Size = new System.Drawing.Size(350, 100);
            this.BaseGroupBox.TabIndex = 2;
            this.BaseGroupBox.TabStop = false;
            this.BaseGroupBox.Text = "Base";
            // 
            // RangeThroatDiameterLabel
            // 
            this.RangeThroatDiameterLabel.AutoSize = true;
            this.RangeThroatDiameterLabel.Location = new System.Drawing.Point(189, 77);
            this.RangeThroatDiameterLabel.Name = "RangeThroatDiameterLabel";
            this.RangeThroatDiameterLabel.Size = new System.Drawing.Size(135, 15);
            this.RangeThroatDiameterLabel.TabIndex = 6;
            this.RangeThroatDiameterLabel.Text = "(min:0.0 - max:0.0 mm)";
            // 
            // RangeCarafeHeightLabel
            // 
            this.RangeCarafeHeightLabel.AutoSize = true;
            this.RangeCarafeHeightLabel.Location = new System.Drawing.Point(189, 50);
            this.RangeCarafeHeightLabel.Name = "RangeCarafeHeightLabel";
            this.RangeCarafeHeightLabel.Size = new System.Drawing.Size(135, 15);
            this.RangeCarafeHeightLabel.TabIndex = 5;
            this.RangeCarafeHeightLabel.Text = "(min:0.0 - max:0.0 mm)";
            // 
            // RangeBaseDiameterLabel
            // 
            this.RangeBaseDiameterLabel.AutoSize = true;
            this.RangeBaseDiameterLabel.Location = new System.Drawing.Point(189, 23);
            this.RangeBaseDiameterLabel.Name = "RangeBaseDiameterLabel";
            this.RangeBaseDiameterLabel.Size = new System.Drawing.Size(135, 15);
            this.RangeBaseDiameterLabel.TabIndex = 4;
            this.RangeBaseDiameterLabel.Text = "(min:0.0 - max:0.0 mm)";
            // 
            // ThroatDiameterTextBox
            // 
            this.ThroatDiameterTextBox.Location = new System.Drawing.Point(114, 74);
            this.ThroatDiameterTextBox.MaxLength = 6;
            this.ThroatDiameterTextBox.Name = "ThroatDiameterTextBox";
            this.ThroatDiameterTextBox.Size = new System.Drawing.Size(69, 21);
            this.ThroatDiameterTextBox.TabIndex = 4;
            this.ThroatDiameterTextBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.ThroatDiameterTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPressOnlyNumber);
            this.ThroatDiameterTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // BaseDiameterTextBox
            // 
            this.BaseDiameterTextBox.Location = new System.Drawing.Point(114, 20);
            this.BaseDiameterTextBox.MaxLength = 6;
            this.BaseDiameterTextBox.Name = "BaseDiameterTextBox";
            this.BaseDiameterTextBox.Size = new System.Drawing.Size(69, 21);
            this.BaseDiameterTextBox.TabIndex = 2;
            this.BaseDiameterTextBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.BaseDiameterTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPressOnlyNumber);
            this.BaseDiameterTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // BaseDiameterLabel
            // 
            this.BaseDiameterLabel.AutoSize = true;
            this.BaseDiameterLabel.Location = new System.Drawing.Point(15, 23);
            this.BaseDiameterLabel.Name = "BaseDiameterLabel";
            this.BaseDiameterLabel.Size = new System.Drawing.Size(93, 15);
            this.BaseDiameterLabel.TabIndex = 0;
            this.BaseDiameterLabel.Text = "Base diameter :";
            // 
            // ThroatDiameterLabel
            // 
            this.ThroatDiameterLabel.AutoSize = true;
            this.ThroatDiameterLabel.Location = new System.Drawing.Point(8, 77);
            this.ThroatDiameterLabel.Name = "ThroatDiameterLabel";
            this.ThroatDiameterLabel.Size = new System.Drawing.Size(100, 15);
            this.ThroatDiameterLabel.TabIndex = 0;
            this.ThroatDiameterLabel.Text = "Throat diameter :";
            // 
            // CarafeHeightTextBox
            // 
            this.CarafeHeightTextBox.Location = new System.Drawing.Point(114, 47);
            this.CarafeHeightTextBox.MaxLength = 6;
            this.CarafeHeightTextBox.Name = "CarafeHeightTextBox";
            this.CarafeHeightTextBox.Size = new System.Drawing.Size(69, 21);
            this.CarafeHeightTextBox.TabIndex = 3;
            this.CarafeHeightTextBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.CarafeHeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPressOnlyNumber);
            this.CarafeHeightTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // CarafeHeightLabel
            // 
            this.CarafeHeightLabel.AutoSize = true;
            this.CarafeHeightLabel.Location = new System.Drawing.Point(22, 50);
            this.CarafeHeightLabel.Name = "CarafeHeightLabel";
            this.CarafeHeightLabel.Size = new System.Drawing.Size(86, 15);
            this.CarafeHeightLabel.TabIndex = 0;
            this.CarafeHeightLabel.Text = "Carafe height :";
            // 
            // StopperGroupBox
            // 
            this.StopperGroupBox.Controls.Add(this.RangeStopperHeightLabel);
            this.StopperGroupBox.Controls.Add(this.BottleStopperComboBox);
            this.StopperGroupBox.Controls.Add(this.StopperHeightTextBox);
            this.StopperGroupBox.Controls.Add(this.BottleStopperLabel);
            this.StopperGroupBox.Controls.Add(this.StopperHeightLabel);
            this.StopperGroupBox.Location = new System.Drawing.Point(6, 126);
            this.StopperGroupBox.Name = "StopperGroupBox";
            this.StopperGroupBox.Size = new System.Drawing.Size(350, 85);
            this.StopperGroupBox.TabIndex = 3;
            this.StopperGroupBox.TabStop = false;
            this.StopperGroupBox.Text = "Stopper";
            // 
            // RangeStopperHeightLabel
            // 
            this.RangeStopperHeightLabel.AutoSize = true;
            this.RangeStopperHeightLabel.Location = new System.Drawing.Point(189, 52);
            this.RangeStopperHeightLabel.Name = "RangeStopperHeightLabel";
            this.RangeStopperHeightLabel.Size = new System.Drawing.Size(135, 15);
            this.RangeStopperHeightLabel.TabIndex = 6;
            this.RangeStopperHeightLabel.Text = "(min:0.0 - max:0.0 mm)";
            // 
            // BottleStopperComboBox
            // 
            this.BottleStopperComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BottleStopperComboBox.FormattingEnabled = true;
            this.BottleStopperComboBox.Location = new System.Drawing.Point(114, 20);
            this.BottleStopperComboBox.Name = "BottleStopperComboBox";
            this.BottleStopperComboBox.Size = new System.Drawing.Size(69, 23);
            this.BottleStopperComboBox.TabIndex = 5;
            this.BottleStopperComboBox.SelectedIndexChanged += new System.EventHandler(this.BottleStopperComboBox_SelectedIndexChanged);
            // 
            // StopperHeightTextBox
            // 
            this.StopperHeightTextBox.Location = new System.Drawing.Point(114, 49);
            this.StopperHeightTextBox.MaxLength = 6;
            this.StopperHeightTextBox.Name = "StopperHeightTextBox";
            this.StopperHeightTextBox.Size = new System.Drawing.Size(69, 21);
            this.StopperHeightTextBox.TabIndex = 6;
            this.StopperHeightTextBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.StopperHeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPressOnlyNumber);
            this.StopperHeightTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // BottleStopperLabel
            // 
            this.BottleStopperLabel.AutoSize = true;
            this.BottleStopperLabel.Location = new System.Drawing.Point(20, 23);
            this.BottleStopperLabel.Name = "BottleStopperLabel";
            this.BottleStopperLabel.Size = new System.Drawing.Size(88, 15);
            this.BottleStopperLabel.TabIndex = 0;
            this.BottleStopperLabel.Text = "Bottle stopper :";
            // 
            // StopperHeightLabel
            // 
            this.StopperHeightLabel.AutoSize = true;
            this.StopperHeightLabel.Location = new System.Drawing.Point(15, 52);
            this.StopperHeightLabel.Name = "StopperHeightLabel";
            this.StopperHeightLabel.Size = new System.Drawing.Size(93, 15);
            this.StopperHeightLabel.TabIndex = 0;
            this.StopperHeightLabel.Text = "Stopper height :";
            // 
            // CarafeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 417);
            this.Controls.Add(this.Panel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(417, 456);
            this.MinimumSize = new System.Drawing.Size(417, 456);
            this.Name = "CarafeForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoCAD:  Carafe";
            this.Panel.ResumeLayout(false);
            this.CarafeGroupBox.ResumeLayout(false);
            this.BuildButtonGroupBox.ResumeLayout(false);
            this.ParametersGroupBox.ResumeLayout(false);
            this.HandleGroupBox.ResumeLayout(false);
            this.HandleGroupBox.PerformLayout();
            this.BaseGroupBox.ResumeLayout(false);
            this.BaseGroupBox.PerformLayout();
            this.StopperGroupBox.ResumeLayout(false);
            this.StopperGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.GroupBox CarafeGroupBox;
        private System.Windows.Forms.Label HandleLabel;
        private System.Windows.Forms.Label BottleStopperLabel;
        private System.Windows.Forms.Label ThroatDiameterLabel;
        private System.Windows.Forms.Label BaseDiameterLabel;
        private System.Windows.Forms.Label CarafeHeightLabel;
        private System.Windows.Forms.Label StopperHeightLabel;
        private System.Windows.Forms.Label HandleLengthLabel;
        private System.Windows.Forms.TextBox CarafeHeightTextBox;
        private System.Windows.Forms.ComboBox HandleComboBox;
        private System.Windows.Forms.TextBox HandleLengthTextBox;
        private System.Windows.Forms.TextBox ThroatDiameterTextBox;
        private System.Windows.Forms.TextBox BaseDiameterTextBox;
        private System.Windows.Forms.Button BuildButton;
        private System.Windows.Forms.TextBox StopperHeightTextBox;
        private System.Windows.Forms.ComboBox BottleStopperComboBox;
        private System.Windows.Forms.TextBox HandleAngleTextBox;
        private System.Windows.Forms.Label HandleAngleLabel;
        private System.Windows.Forms.GroupBox ParametersGroupBox;
        private System.Windows.Forms.GroupBox BuildButtonGroupBox;
        private System.Windows.Forms.GroupBox HandleGroupBox;
        private System.Windows.Forms.GroupBox BaseGroupBox;
        private System.Windows.Forms.GroupBox StopperGroupBox;
        private System.Windows.Forms.Label RangeHandleLengthLabel;
        private System.Windows.Forms.Label RangeHandleAngleLabel;
        private System.Windows.Forms.Label RangeThroatDiameterLabel;
        private System.Windows.Forms.Label RangeCarafeHeightLabel;
        private System.Windows.Forms.Label RangeBaseDiameterLabel;
        private System.Windows.Forms.Label RangeStopperHeightLabel;
    }
}

