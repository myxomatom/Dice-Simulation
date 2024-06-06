namespace Essaye_dés
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BTN_Create_Number = new Button();
            label1 = new Label();
            BTN_Strart_Simulation = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // BTN_Create_Number
            // 
            BTN_Create_Number.Location = new Point(22, 216);
            BTN_Create_Number.Name = "BTN_Create_Number";
            BTN_Create_Number.Size = new Size(310, 65);
            BTN_Create_Number.TabIndex = 0;
            BTN_Create_Number.Text = "Create a number";
            BTN_Create_Number.UseVisualStyleBackColor = true;
            BTN_Create_Number.Click += button1_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlDark;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Cursor = Cursors.IBeam;
            label1.Location = new Point(174, 93);
            label1.Name = "label1";
            label1.Size = new Size(279, 24);
            label1.TabIndex = 1;
            label1.Text = "Number generator";
            label1.Click += button1_Click;
            // 
            // BTN_Strart_Simulation
            // 
            BTN_Strart_Simulation.Location = new Point(362, 216);
            BTN_Strart_Simulation.Name = "BTN_Strart_Simulation";
            BTN_Strart_Simulation.Size = new Size(256, 61);
            BTN_Strart_Simulation.TabIndex = 2;
            BTN_Strart_Simulation.Text = "Start a simulation";
            BTN_Strart_Simulation.UseVisualStyleBackColor = true;
            BTN_Strart_Simulation.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(560, 12);
            button1.Name = "button1";
            button1.Size = new Size(89, 23);
            button1.TabIndex = 3;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 296);
            Controls.Add(button1);
            Controls.Add(BTN_Strart_Simulation);
            Controls.Add(label1);
            Controls.Add(BTN_Create_Number);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Dice Simulation";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BTN_Create_Number;
        private Label label1;
        private Button BTN_Strart_Simulation;
        private Button button1;
    }
}
