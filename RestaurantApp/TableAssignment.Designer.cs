namespace RestaurantApp
{
    partial class TableAssignment
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
            AssignButton = new Button();
            EmployeeListBox = new ListBox();
            AssignedEmployeeLabel = new Label();
            AssignedEmployee = new Label();
            SuspendLayout();
            // 
            // AssignButton
            // 
            AssignButton.Location = new Point(186, 235);
            AssignButton.Name = "AssignButton";
            AssignButton.Size = new Size(75, 23);
            AssignButton.TabIndex = 0;
            AssignButton.Text = "Assign";
            AssignButton.UseVisualStyleBackColor = true;
            AssignButton.Click += AssignButton_Click;
            // 
            // EmployeeListBox
            // 
            EmployeeListBox.DisplayMember = "Name";
            EmployeeListBox.FormattingEnabled = true;
            EmployeeListBox.ItemHeight = 15;
            EmployeeListBox.Location = new Point(186, 135);
            EmployeeListBox.Name = "EmployeeListBox";
            EmployeeListBox.Size = new Size(258, 94);
            EmployeeListBox.TabIndex = 1;
            // 
            // AssignedEmployeeLabel
            // 
            AssignedEmployeeLabel.AutoSize = true;
            AssignedEmployeeLabel.Location = new Point(186, 104);
            AssignedEmployeeLabel.Name = "AssignedEmployeeLabel";
            AssignedEmployeeLabel.Size = new Size(113, 15);
            AssignedEmployeeLabel.TabIndex = 2;
            AssignedEmployeeLabel.Text = "Assigned Employee:";
            // 
            // AssignedEmployee
            // 
            AssignedEmployee.AutoSize = true;
            AssignedEmployee.Location = new Point(305, 104);
            AssignedEmployee.Name = "AssignedEmployee";
            AssignedEmployee.Size = new Size(68, 15);
            AssignedEmployee.TabIndex = 3;
            AssignedEmployee.Text = "Unassigned";
            // 
            // TableAssignment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AssignedEmployee);
            Controls.Add(AssignedEmployeeLabel);
            Controls.Add(EmployeeListBox);
            Controls.Add(AssignButton);
            Name = "TableAssignment";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AssignButton;
        private ListBox EmployeeListBox;
        private Label AssignedEmployeeLabel;
        private Label AssignedEmployee;
    }
}