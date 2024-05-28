namespace PostmanClone.UI
{
    partial class Dashboard
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
            formHeader = new Label();
            apiLabel = new Label();
            apiText = new TextBox();
            resultText = new TextBox();
            callAPI = new Button();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            resultLabel = new Label();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // formHeader
            // 
            formHeader.AutoSize = true;
            formHeader.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            formHeader.Location = new Point(35, 40);
            formHeader.Margin = new Padding(4, 0, 4, 0);
            formHeader.Name = "formHeader";
            formHeader.Size = new Size(317, 60);
            formHeader.TabIndex = 0;
            formHeader.Text = "Postman Clone";
            // 
            // apiLabel
            // 
            apiLabel.AutoSize = true;
            apiLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            apiLabel.Location = new Point(68, 186);
            apiLabel.Margin = new Padding(4, 0, 4, 0);
            apiLabel.Name = "apiLabel";
            apiLabel.Size = new Size(47, 23);
            apiLabel.TabIndex = 1;
            apiLabel.Text = "API: ";
            // 
            // apiText
            // 
            apiText.Location = new Point(142, 177);
            apiText.Margin = new Padding(4);
            apiText.Name = "apiText";
            apiText.Size = new Size(859, 38);
            apiText.TabIndex = 2;
            // 
            // resultText
            // 
            resultText.ImeMode = ImeMode.On;
            resultText.Location = new Point(142, 328);
            resultText.Margin = new Padding(4);
            resultText.Multiline = true;
            resultText.Name = "resultText";
            resultText.ScrollBars = ScrollBars.Both;
            resultText.Size = new Size(1032, 419);
            resultText.TabIndex = 3;
            // 
            // callAPI
            // 
            callAPI.Location = new Point(1011, 173);
            callAPI.Margin = new Padding(4);
            callAPI.Name = "callAPI";
            callAPI.Size = new Size(136, 46);
            callAPI.TabIndex = 4;
            callAPI.Text = "Call";
            callAPI.UseVisualStyleBackColor = true;
            callAPI.Click += CallApiOnClick;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 958);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 20, 0);
            statusStrip.Size = new Size(1429, 38);
            statusStrip.TabIndex = 5;
            statusStrip.Text = "statusStrip1";
            statusStrip.BackColor = System.Drawing.Color.White;
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(80, 32);
            toolStripStatusLabel.Text = "Ready";
            toolStripStatusLabel.Click += toolStripStatusLabel_Click;
            toolStripStatusLabel.BackColor = System.Drawing.Color.White;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(142, 276);
            resultLabel.Margin = new Padding(4, 0, 4, 0);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(86, 31);
            resultLabel.TabIndex = 6;
            resultLabel.Text = "Results";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1429, 996);
            Controls.Add(resultLabel);
            Controls.Add(statusStrip);
            Controls.Add(callAPI);
            Controls.Add(resultText);
            Controls.Add(apiText);
            Controls.Add(apiLabel);
            Controls.Add(formHeader);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(4);
            Name = "Dashboard";
            Text = "Postman Clone";
            Load += Dashboard_Load;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label formHeader;
        private Label apiLabel;
        private TextBox apiText;
        private TextBox resultText;
        private Button callAPI;
        private StatusStrip statusStrip;
        private Label resultLabel;
        private ToolStripStatusLabel toolStripStatusLabel;
    }
}
