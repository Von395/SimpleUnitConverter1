namespace Harjoitus_22
{
    partial class Converter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblImperial = new Label();
            lblInternational = new Label();
            lstConverter = new ListBox();
            txtImperial = new TextBox();
            txtInternational = new TextBox();
            grpUnits = new GroupBox();
            rbnInternational = new RadioButton();
            rbnImperial = new RadioButton();
            btnClose = new Button();
            grpUnits.SuspendLayout();
            SuspendLayout();
            // 
            // lblImperial
            // 
            lblImperial.AutoSize = true;
            lblImperial.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblImperial.Location = new Point(12, 15);
            lblImperial.Name = "lblImperial";
            lblImperial.Size = new Size(80, 25);
            lblImperial.TabIndex = 0;
            lblImperial.Text = "Imperial";
            // 
            // lblInternational
            // 
            lblInternational.AutoSize = true;
            lblInternational.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblInternational.Location = new Point(12, 67);
            lblInternational.Name = "lblInternational";
            lblInternational.Size = new Size(120, 25);
            lblInternational.TabIndex = 1;
            lblInternational.Text = "International";
            // 
            // lstConverter
            // 
            lstConverter.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lstConverter.FormattingEnabled = true;
            lstConverter.ItemHeight = 25;
            lstConverter.Items.AddRange(new object[] { "Feet --> Meter", "Inch --> Centimeter", "Pound --> Kilo" });
            lstConverter.Location = new Point(433, 12);
            lstConverter.Name = "lstConverter";
            lstConverter.Size = new Size(355, 204);
            lstConverter.TabIndex = 2;
            lstConverter.DoubleClick += lstMuunnos_DoubleClick;
            // 
            // txtImperial
            // 
            txtImperial.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtImperial.Location = new Point(174, 12);
            txtImperial.Multiline = true;
            txtImperial.Name = "txtImperial";
            txtImperial.Size = new Size(239, 46);
            txtImperial.TabIndex = 3;
            // 
            // txtInternational
            // 
            txtInternational.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtInternational.Location = new Point(174, 64);
            txtInternational.Multiline = true;
            txtInternational.Name = "txtInternational";
            txtInternational.Size = new Size(239, 46);
            txtInternational.TabIndex = 4;
            // 
            // grpUnits
            // 
            grpUnits.Controls.Add(rbnInternational);
            grpUnits.Controls.Add(rbnImperial);
            grpUnits.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grpUnits.Location = new Point(12, 135);
            grpUnits.Name = "grpUnits";
            grpUnits.Size = new Size(401, 164);
            grpUnits.TabIndex = 5;
            grpUnits.TabStop = false;
            grpUnits.Text = "Unit conversion";
            // 
            // rbnInternational
            // 
            rbnInternational.AutoSize = true;
            rbnInternational.Location = new Point(6, 100);
            rbnInternational.Name = "rbnInternational";
            rbnInternational.Size = new Size(344, 29);
            rbnInternational.TabIndex = 1;
            rbnInternational.Text = "International units --> Imperial units";
            rbnInternational.UseVisualStyleBackColor = true;
            rbnInternational.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rbnImperial
            // 
            rbnImperial.AutoSize = true;
            rbnImperial.Checked = true;
            rbnImperial.Location = new Point(6, 52);
            rbnImperial.Name = "rbnImperial";
            rbnImperial.Size = new Size(344, 29);
            rbnImperial.TabIndex = 0;
            rbnImperial.TabStop = true;
            rbnImperial.Text = "Imperial units --> International units";
            rbnImperial.UseVisualStyleBackColor = true;
            rbnImperial.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(433, 222);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(355, 77);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnSulje_Click;
            // 
            // Converter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 311);
            Controls.Add(btnClose);
            Controls.Add(grpUnits);
            Controls.Add(txtInternational);
            Controls.Add(txtImperial);
            Controls.Add(lstConverter);
            Controls.Add(lblInternational);
            Controls.Add(lblImperial);
            Name = "Converter";
            Text = "Converter";
            grpUnits.ResumeLayout(false);
            grpUnits.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblImperial;
        private Label lblInternational;
        private ListBox lstConverter;
        private TextBox txtImperial;
        private TextBox txtInternational;
        private GroupBox grpUnits;
        private RadioButton rbnInternational;
        private RadioButton rbnImperial;
        private Button btnClose;
    }
}