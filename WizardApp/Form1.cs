using System;
using System.Windows.Forms;

namespace WizardApp
{
    public partial class Form1 : Form
    {
        string[] steps = { "Step 1", "Step 2", "Step 3", "Step 4" };
        int currentStep = 0;

        public Form1()
        {
            InitializeComponent();
            ShowCurrentStep();
        }

        private void ShowCurrentStep()
        {
            labelStep.Text = steps[currentStep];
            panelStep.Controls.Clear();
            panelStep.Controls.Add(new Label() { Text = $"You are at {steps[currentStep]}", Dock = DockStyle.Fill, TextAlign = System.Drawing.ContentAlignment.MiddleCenter });
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            if (currentStep < steps.Length - 1)
            {
                currentStep++;
                ShowCurrentStep();
            }
        }

        private void ButtonPrevious_Click(object sender, EventArgs e)
        {
            if (currentStep > 0)
            {
                currentStep--;
                ShowCurrentStep();
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
