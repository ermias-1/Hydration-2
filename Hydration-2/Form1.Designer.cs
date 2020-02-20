namespace Hydration_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.numGlasses = new System.Windows.Forms.NumericUpDown();
            this.lblHydrationStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numGlasses)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "How many glasses of water did you drink today?";
            // 
            // numGlasses
            // 
            this.numGlasses.Location = new System.Drawing.Point(258, 191);
            this.numGlasses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numGlasses.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numGlasses.Name = "numGlasses";
            this.numGlasses.Size = new System.Drawing.Size(180, 26);
            this.numGlasses.TabIndex = 1;
            this.numGlasses.ValueChanged += new System.EventHandler(this.numGlasses_ValueChanged);
            // 
            // lblHydrationStatus
            // 
            this.lblHydrationStatus.AutoSize = true;
            this.lblHydrationStatus.Location = new System.Drawing.Point(410, 368);
            this.lblHydrationStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHydrationStatus.Name = "lblHydrationStatus";
            this.lblHydrationStatus.Size = new System.Drawing.Size(0, 20);
            this.lblHydrationStatus.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.lblHydrationStatus);
            this.Controls.Add(this.numGlasses);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numGlasses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numGlasses;
        private System.Windows.Forms.Label lblHydrationStatus;
    }
}

