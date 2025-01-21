namespace WinFormsApp2
{
    partial class BasketForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddNewPlan;

        /// <summary>
        /// Dispose resources being used.
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

        /// <summary>
        /// Initializes the form components.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddNewPlan = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.Color.WhiteSmoke; // Optional: Set background color
            this.flowLayoutPanel.Location = new System.Drawing.Point(20, 60);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(760, 330);
            this.flowLayoutPanel.TabIndex = 0;

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(137, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Your Tour Plans";

            // 
            // btnAddNewPlan
            // 
            this.btnAddNewPlan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddNewPlan.Location = new System.Drawing.Point(20, 400);
            this.btnAddNewPlan.Name = "btnAddNewPlan";
            this.btnAddNewPlan.Size = new System.Drawing.Size(200, 30);
            this.btnAddNewPlan.TabIndex = 2;
            this.btnAddNewPlan.Text = "Make a New Tour Plan";
            this.btnAddNewPlan.UseVisualStyleBackColor = true;
            this.btnAddNewPlan.Click += new System.EventHandler(this.BtnAddNewPlan_Click);

            // 
            // BasketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddNewPlan);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "BasketForm";
            this.Text = "BasketForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        /// <summary>
        /// Event handler for the 'Make a New Tour Plan' button click.
        /// </summary>
        private void BtnAddNewPlan_Click(object sender, System.EventArgs e)
        {
            // Placeholder for the event handler logic
            MessageBox.Show("New tour plan creation logic goes here.");
        }
    }
}
