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
            OrderInfoListBox = new ListBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SaveButton = new Button();
            CancelButton = new Button();
            RemoveMenuItemButton = new Button();
            OrderedItemsListBox = new ListBox();
            OrderButton = new Button();
            MenuListBox = new ListBox();
            OrderMenu.SuspendLayout();
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
            OrderMenu.Controls.Add(OrderInfoListBox);
            OrderMenu.Controls.Add(label3);
            OrderMenu.Controls.Add(textBox1);
            OrderMenu.Controls.Add(label2);
            OrderMenu.Controls.Add(label1);
            OrderMenu.Controls.Add(SaveButton);
            OrderMenu.Controls.Add(CancelButton);
            OrderMenu.Controls.Add(RemoveMenuItemButton);
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
            // OrderInfoListBox
            //
            OrderInfoListBox.FormattingEnabled = true;
            OrderInfoListBox.ItemHeight = 15;
            OrderInfoListBox.Location = new Point(6, 17);
            OrderInfoListBox.Name = "OrderInfoListBox";
            OrderInfoListBox.Size = new Size(341, 79);
            OrderInfoListBox.TabIndex = 14;
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
            // textBox1
            //
            textBox1.Location = new Point(163, 294);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 23);
            textBox1.TabIndex = 12;
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
            // SaveButton
            //
            SaveButton.Location = new Point(6, 327);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(117, 23);
            SaveButton.TabIndex = 9;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            //
            // CancelButton
            //
            CancelButton.Location = new Point(182, 327);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(117, 23);
            CancelButton.TabIndex = 8;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            //
            // RemoveMenuItemButton
            //
            RemoveMenuItemButton.Location = new Point(367, 292);
            RemoveMenuItemButton.Name = "RemoveMenuItemButton";
            RemoveMenuItemButton.Size = new Size(117, 23);
            RemoveMenuItemButton.TabIndex = 7;
            RemoveMenuItemButton.Text = "Remove";
            RemoveMenuItemButton.UseVisualStyleBackColor = true;
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AssignButton;
        private ListBox EmployeeListBox;
        private Label AssignedEmployeeLabel;
        private Label AssignedEmployee;
        private GroupBox OrderMenu;
        private Button SaveButton;
        private Button CancelButton;
        private Button RemoveMenuItemButton;
        private ListBox OrderedItemsListBox;
        private Button OrderButton;
        private ListBox MenuListBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private ListBox OrderInfoListBox;
    }
}