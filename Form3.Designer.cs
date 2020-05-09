namespace Semestr_Project
{
    partial class SettingsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LonelinessNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.OverpopulationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BirthConditionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.LonelinessNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OverpopulationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthConditionNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loneliness Threshold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Overpopulation Threshold";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Birth Condition";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(156, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(50, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LonelinessNumericUpDown
            // 
            this.LonelinessNumericUpDown.Location = new System.Drawing.Point(202, 111);
            this.LonelinessNumericUpDown.Name = "LonelinessNumericUpDown";
            this.LonelinessNumericUpDown.Size = new System.Drawing.Size(71, 20);
            this.LonelinessNumericUpDown.TabIndex = 3;
            // 
            // OverpopulationNumericUpDown
            // 
            this.OverpopulationNumericUpDown.Location = new System.Drawing.Point(202, 147);
            this.OverpopulationNumericUpDown.Name = "OverpopulationNumericUpDown";
            this.OverpopulationNumericUpDown.Size = new System.Drawing.Size(71, 20);
            this.OverpopulationNumericUpDown.TabIndex = 3;
            // 
            // BirthConditionNumericUpDown
            // 
            this.BirthConditionNumericUpDown.Location = new System.Drawing.Point(202, 183);
            this.BirthConditionNumericUpDown.Name = "BirthConditionNumericUpDown";
            this.BirthConditionNumericUpDown.Size = new System.Drawing.Size(71, 20);
            this.BirthConditionNumericUpDown.TabIndex = 3;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(307, 321);
            this.Controls.Add(this.BirthConditionNumericUpDown);
            this.Controls.Add(this.OverpopulationNumericUpDown);
            this.Controls.Add(this.LonelinessNumericUpDown);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.LonelinessNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OverpopulationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthConditionNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown LonelinessNumericUpDown;
        private System.Windows.Forms.NumericUpDown OverpopulationNumericUpDown;
        private System.Windows.Forms.NumericUpDown BirthConditionNumericUpDown;
    }
}