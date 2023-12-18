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
            OrderMenu = new GroupBox();
            PayButton = new Button();
            TotalLabel = new Label();
            OrderInfoListBox = new ListBox();
            label3 = new Label();
            AnnotationTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            OrderedItemsListBox = new ListBox();
            OrderButton = new Button();
            MenuListBox = new ListBox();
            ChangeTableButton = new Button();
            ChangeTableNumberBox = new NumericUpDown();
            OrderMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ChangeTableNumberBox).BeginInit();
            SuspendLayout();
            // 
            // AssignButton
            // 
            AssignButton.Location = new Point(12, 235);
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
            EmployeeListBox.Location = new Point(12, 135);
            EmployeeListBox.Name = "EmployeeListBox";
            EmployeeListBox.Size = new Size(258, 94);
            EmployeeListBox.TabIndex = 1;
            // 
            // AssignedEmployeeLabel
            // 
            AssignedEmployeeLabel.AutoSize = true;
            AssignedEmployeeLabel.Location = new Point(12, 104);
            AssignedEmployeeLabel.Name = "AssignedEmployeeLabel";
            AssignedEmployeeLabel.Size = new Size(113, 15);
            AssignedEmployeeLabel.TabIndex = 2;
            AssignedEmployeeLabel.Text = "Assigned Employee:";
            // 
            // AssignedEmployee
            // 
            AssignedEmployee.AutoSize = true;
            AssignedEmployee.Location = new Point(131, 104);
            AssignedEmployee.Name = "AssignedEmployee";
            AssignedEmployee.Size = new Size(68, 15);
            AssignedEmployee.TabIndex = 3;
            AssignedEmployee.Text = "Unassigned";
            // 
            // OrderMenu
            // 
            OrderMenu.Controls.Add(ChangeTableNumberBox);
            OrderMenu.Controls.Add(ChangeTableButton);
            OrderMenu.Controls.Add(PayButton);
            OrderMenu.Controls.Add(TotalLabel);
            OrderMenu.Controls.Add(OrderInfoListBox);
            OrderMenu.Controls.Add(label3);
            OrderMenu.Controls.Add(AnnotationTextBox);
            OrderMenu.Controls.Add(label2);
            OrderMenu.Controls.Add(label1);
            OrderMenu.Controls.Add(OrderedItemsListBox);
            OrderMenu.Controls.Add(OrderButton);
            OrderMenu.Controls.Add(MenuListBox);
            OrderMenu.Location = new Point(293, 12);
            OrderMenu.Name = "OrderMenu";
            OrderMenu.Size = new Size(495, 362);
            OrderMenu.TabIndex = 4;
            OrderMenu.TabStop = false;
            OrderMenu.Text = "Order Menu";
            // 
            // PayButton
            // 
            PayButton.Location = new Point(6, 333);
            PayButton.Name = "PayButton";
            PayButton.Size = new Size(75, 23);
            PayButton.TabIndex = 16;
            PayButton.Text = "Paid";
            PayButton.UseVisualStyleBackColor = true;
            PayButton.Click += PayButton_Click;
            // 
            // TotalLabel
            // 
            TotalLabel.AutoSize = true;
            TotalLabel.Location = new Point(369, 300);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(38, 15);
            TotalLabel.TabIndex = 15;
            TotalLabel.Text = "Total: ";
            // 
            // OrderInfoListBox
            // 
            OrderInfoListBox.FormattingEnabled = true;
            OrderInfoListBox.ItemHeight = 15;
            OrderInfoListBox.Location = new Point(6, 17);
            OrderInfoListBox.Name = "OrderInfoListBox";
            OrderInfoListBox.Size = new Size(341, 79);
            OrderInfoListBox.TabIndex = 14;
            OrderInfoListBox.SelectedIndexChanged += OrderInfoListBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 297);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 13;
            label3.Text = "Annotation:";
            // 
            // AnnotationTextBox
            // 
            AnnotationTextBox.Location = new Point(163, 294);
            AnnotationTextBox.Name = "AnnotationTextBox";
            AnnotationTextBox.Size = new Size(184, 23);
            AnnotationTextBox.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 114);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 11;
            label2.Text = "Menu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(367, 114);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 10;
            label1.Text = "Ordered Items";
            // 
            // OrderedItemsListBox
            // 
            OrderedItemsListBox.DisplayMember = "Name";
            OrderedItemsListBox.FormattingEnabled = true;
            OrderedItemsListBox.ItemHeight = 15;
            OrderedItemsListBox.Location = new Point(367, 132);
            OrderedItemsListBox.Name = "OrderedItemsListBox";
            OrderedItemsListBox.Size = new Size(117, 154);
            OrderedItemsListBox.TabIndex = 6;
            // 
            // OrderButton
            // 
            OrderButton.Location = new Point(6, 292);
            OrderButton.Name = "OrderButton";
            OrderButton.Size = new Size(75, 23);
            OrderButton.TabIndex = 5;
            OrderButton.Text = "Order";
            OrderButton.UseVisualStyleBackColor = true;
            OrderButton.Click += OrderButton_Click;
            // 
            // MenuListBox
            // 
            MenuListBox.DisplayMember = "Name";
            MenuListBox.FormattingEnabled = true;
            MenuListBox.ItemHeight = 15;
            MenuListBox.Location = new Point(6, 132);
            MenuListBox.Name = "MenuListBox";
            MenuListBox.Size = new Size(341, 154);
            MenuListBox.TabIndex = 5;
            // 
            // ChangeTableButton
            // 
            ChangeTableButton.Location = new Point(386, 61);
            ChangeTableButton.Name = "ChangeTableButton";
            ChangeTableButton.Size = new Size(98, 23);
            ChangeTableButton.TabIndex = 17;
            ChangeTableButton.Text = "Change Table";
            ChangeTableButton.UseVisualStyleBackColor = true;
            ChangeTableButton.Click += ChangeTableButton_Click;
            // 
            // ChangeTableNumberBox
            // 
            ChangeTableNumberBox.Location = new Point(386, 32);
            ChangeTableNumberBox.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            ChangeTableNumberBox.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ChangeTableNumberBox.Name = "ChangeTableNumberBox";
            ChangeTableNumberBox.Size = new Size(98, 23);
            ChangeTableNumberBox.TabIndex = 18;
            ChangeTableNumberBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // TableAssignment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OrderMenu);
            Controls.Add(AssignedEmployee);
            Controls.Add(AssignedEmployeeLabel);
            Controls.Add(EmployeeListBox);
            Controls.Add(AssignButton);
            Name = "TableAssignment";
            Text = "Form3";
            OrderMenu.ResumeLayout(false);
            OrderMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ChangeTableNumberBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AssignButton;
        private ListBox EmployeeListBox;
        private Label AssignedEmployeeLabel;
        private Label AssignedEmployee;
        private GroupBox OrderMenu;
        private ListBox OrderedItemsListBox;
        private Button OrderButton;
        private ListBox MenuListBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox AnnotationTextBox;
        private ListBox OrderInfoListBox;
        private Label TotalLabel;
        private Button PayButton;
        private NumericUpDown ChangeTableNumberBox;
        private Button ChangeTableButton;
    }
}