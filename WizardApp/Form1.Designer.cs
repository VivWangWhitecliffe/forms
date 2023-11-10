
namespace WizardApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

       private void InitializeComponent()
{
    this.labelStep = new System.Windows.Forms.Label();
    this.panelStep = new System.Windows.Forms.Panel();
    this.buttonNext = new System.Windows.Forms.Button();
    this.buttonPrevious = new System.Windows.Forms.Button();
    this.buttonExit = new System.Windows.Forms.Button();
    this.SuspendLayout();
    // 
    // labelStep
    // 
    this.labelStep.AutoSize = true;
    this.labelStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.labelStep.Location = new System.Drawing.Point(12, 9);
    this.labelStep.Name = "labelStep";
    this.labelStep.Size = new System.Drawing.Size(144, 20);
    this.labelStep.TabIndex = 0;
    this.labelStep.Text = "Step 1: Introduction";
    // 
    // panelStep
    // 
    this.panelStep.Location = new System.Drawing.Point(16, 45);
    this.panelStep.Name = "panelStep";
    this.panelStep.Size = new System.Drawing.Size(431, 232);
    this.panelStep.TabIndex = 1;
    // 
    // buttonNext
    // 
    this.buttonNext.Location = new System.Drawing.Point(372, 283);
    this.buttonNext.Name = "buttonNext";
    this.buttonNext.Size = new System.Drawing.Size(75, 23);
    this.buttonNext.TabIndex = 2;
    this.buttonNext.Text = "Next";
    this.buttonNext.UseVisualStyleBackColor = true;
    this.buttonNext.Click += new System.EventHandler(this.ButtonNext_Click);
    // 
    // buttonPrevious
    // 
    this.buttonPrevious.Location = new System.Drawing.Point(291, 283);
    this.buttonPrevious.Name = "buttonPrevious";
    this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
    this.buttonPrevious.TabIndex = 3;
    this.buttonPrevious.Text = "Previous";
    this.buttonPrevious.UseVisualStyleBackColor = true;
    this.buttonPrevious.Click += new System.EventHandler(this.ButtonPrevious_Click);
    // 
    // buttonExit
    // 
    this.buttonExit.Location = new System.Drawing.Point(16, 283);
    this.buttonExit.Name = "buttonExit";
    this.buttonExit.Size = new System.Drawing.Size(75, 23);
    this.buttonExit.TabIndex = 4;
    this.buttonExit.Text = "Exit";
    this.buttonExit.UseVisualStyleBackColor = true;
    this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
    // 
    // Form1
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.ClientSize = new System.Drawing.Size(459, 318);
    this.Controls.Add(this.buttonExit);
    this.Controls.Add(this.buttonPrevious);
    this.Controls.Add(this.buttonNext);
    this.Controls.Add(this.panelStep);
    this.Controls.Add(this.labelStep);
    this.Name = "Form1";
    this.Text = "Wizard Form";
    this.ResumeLayout(false);
    this.PerformLayout();
}



        private System.Windows.Forms.Label labelStep;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonExit;
        private Control panelStep;
    }
}
