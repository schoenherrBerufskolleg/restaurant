namespace WinFormsApp1
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
            tabControl1 = new TabControl();
            Tableview = new TabPage();
            label5 = new Label();
            AssignedToOthers = new TableLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            FreeTable = new TableLayoutPanel();
            AssignedToYou = new TableLayoutPanel();
            Tipsview = new TabPage();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            AddTip = new TextBox();
            TipsTable = new TableLayoutPanel();
            Turnover = new TabPage();
            TuroverYourself = new Label();
            label8 = new Label();
            TotalTurnoverNumberLabel = new Label();
            TotalTurnoverLabel = new Label();
            TurnoverTable1 = new TableLayoutPanel();
            label6 = new Label();
            tabControl1.SuspendLayout();
            Tableview.SuspendLayout();
            Tipsview.SuspendLayout();
            Turnover.SuspendLayout();
            SuspendLayout();
            //
            // tabControl1
            //
            tabControl1.Controls.Add(Tableview);
            tabControl1.Controls.Add(Tipsview);
            tabControl1.Controls.Add(Turnover);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(801, 449);
            tabControl1.TabIndex = 0;
            //
            // Tableview
            //
            Tableview.Controls.Add(label5);
            Tableview.Controls.Add(AssignedToOthers);
            Tableview.Controls.Add(label2);
            Tableview.Controls.Add(label1);
            Tableview.Controls.Add(FreeTable);
            Tableview.Controls.Add(AssignedToYou);
            Tableview.Location = new Point(4, 24);
            Tableview.Name = "Tableview";
            Tableview.Padding = new Padding(3);
            Tableview.Size = new Size(793, 421);
            Tableview.TabIndex = 0;
            Tableview.Text = "Tableview";
            Tableview.UseVisualStyleBackColor = true;
            //
            // label5
            //
            label5.AutoSize = true;
            label5.Location = new Point(48, 280);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 5;
            label5.Text = "Assigned to others";
            //
            // AssignedToOthers
            //
            AssignedToOthers.ColumnCount = 2;
            AssignedToOthers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            AssignedToOthers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            AssignedToOthers.Location = new Point(48, 307);
            AssignedToOthers.Name = "AssignedToOthers";
            AssignedToOthers.RowCount = 2;
            AssignedToOthers.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            AssignedToOthers.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            AssignedToOthers.Size = new Size(690, 89);
            AssignedToOthers.TabIndex = 4;
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Location = new Point(48, 154);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 3;
            label2.Text = "Free Tables";
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Location = new Point(48, 27);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 2;
            label1.Text = "Assigned to you";
            //
            // FreeTable
            //
            FreeTable.ColumnCount = 2;
            FreeTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            FreeTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            FreeTable.Location = new Point(48, 181);
            FreeTable.Name = "FreeTable";
            FreeTable.RowCount = 2;
            FreeTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50.60241F));
            FreeTable.RowStyles.Add(new RowStyle(SizeType.Percent, 49.39759F));
            FreeTable.Size = new Size(690, 83);
            FreeTable.TabIndex = 1;
            //
            // AssignedToYou
            //
            AssignedToYou.ColumnCount = 3;
            AssignedToYou.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.2781067F));
            AssignedToYou.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.7218933F));
            AssignedToYou.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 182F));
            AssignedToYou.Dock = DockStyle.Fill;
            AssignedToYou.Location = new Point(3, 3);
            AssignedToYou.Name = "AssignedToYou";
            AssignedToYou.RowCount = 1;
            AssignedToYou.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            AssignedToYou.Size = new Size(787, 415);
            AssignedToYou.TabIndex = 0;
            AssignedToYou.Paint += AssignedToYou_Paint;
            //
            // Tipsview
            //
            Tipsview.Controls.Add(button1);
            Tipsview.Controls.Add(label4);
            Tipsview.Controls.Add(label3);
            Tipsview.Controls.Add(AddTip);
            Tipsview.Controls.Add(TipsTable);
            Tipsview.Location = new Point(4, 24);
            Tipsview.Name = "Tipsview";
            Tipsview.Padding = new Padding(3);
            Tipsview.Size = new Size(793, 421);
            Tipsview.TabIndex = 1;
            Tipsview.Text = "Tipsview";
            Tipsview.UseVisualStyleBackColor = true;
            Tipsview.Click += Tipsview_Click;
            //
            // button1
            //
            button1.Location = new Point(160, 45);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            //
            // label4
            //
            label4.AutoSize = true;
            label4.Location = new Point(31, 101);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "Recent Tips";
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Location = new Point(31, 17);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "Tip Amount";
            //
            // AddTip
            //
            AddTip.Location = new Point(31, 45);
            AddTip.Name = "AddTip";
            AddTip.Size = new Size(100, 23);
            AddTip.TabIndex = 1;
            //
            // TipsTable
            //
            TipsTable.AutoScroll = true;
            TipsTable.AutoScrollMinSize = new Size(800, 150);
            TipsTable.AutoSize = true;
            TipsTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            TipsTable.ColumnCount = 2;
            TipsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TipsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TipsTable.Location = new Point(31, 130);
            TipsTable.MaximumSize = new Size(700, 150);
            TipsTable.Name = "TipsTable";
            TipsTable.RowCount = 1;
            TipsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TipsTable.Size = new Size(700, 50);
            TipsTable.TabIndex = 0;
            TipsTable.Paint += TipsTable_Paint;
            //
            // Turnover
            //
            Turnover.Controls.Add(TuroverYourself);
            Turnover.Controls.Add(label8);
            Turnover.Controls.Add(TotalTurnoverNumberLabel);
            Turnover.Controls.Add(TotalTurnoverLabel);
            Turnover.Controls.Add(TurnoverTable1);
            Turnover.Controls.Add(label6);
            Turnover.Location = new Point(4, 24);
            Turnover.Name = "Turnover";
            Turnover.Size = new Size(793, 421);
            Turnover.TabIndex = 2;
            Turnover.Text = "Turnover";
            Turnover.UseVisualStyleBackColor = true;
            //
            // TuroverYourself
            //
            TuroverYourself.AutoSize = true;
            TuroverYourself.BackColor = Color.Gainsboro;
            TuroverYourself.Location = new Point(459, 28);
            TuroverYourself.Name = "TuroverYourself";
            TuroverYourself.Size = new Size(13, 15);
            TuroverYourself.TabIndex = 6;
            TuroverYourself.Text = "0";
            //
            // label8
            //
            label8.AutoSize = true;
            label8.Location = new Point(365, 28);
            label8.Name = "label8";
            label8.Size = new Size(87, 15);
            label8.TabIndex = 5;
            label8.Text = "Your Turnover: ";
            //
            // TotalTurnoverNumberLabel
            //
            TotalTurnoverNumberLabel.AutoSize = true;
            TotalTurnoverNumberLabel.BackColor = Color.Gainsboro;
            TotalTurnoverNumberLabel.Location = new Point(636, 28);
            TotalTurnoverNumberLabel.Name = "TotalTurnoverNumberLabel";
            TotalTurnoverNumberLabel.Size = new Size(38, 15);
            TotalTurnoverNumberLabel.TabIndex = 4;
            TotalTurnoverNumberLabel.Text = "label7";
            //
            // TotalTurnoverLabel
            //
            TotalTurnoverLabel.AutoSize = true;
            TotalTurnoverLabel.Location = new Point(542, 28);
            TotalTurnoverLabel.Name = "TotalTurnoverLabel";
            TotalTurnoverLabel.Size = new Size(88, 15);
            TotalTurnoverLabel.TabIndex = 3;
            TotalTurnoverLabel.Text = "Total Turnover: ";
            TotalTurnoverLabel.Click += label7_Click;
            //
            // TurnoverTable1
            //
            TurnoverTable1.AutoScroll = true;
            TurnoverTable1.AutoScrollMinSize = new Size(800, 150);
            TurnoverTable1.AutoSize = true;
            TurnoverTable1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            TurnoverTable1.ColumnCount = 2;
            TurnoverTable1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TurnoverTable1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TurnoverTable1.Location = new Point(26, 67);
            TurnoverTable1.MaximumSize = new Size(700, 150);
            TurnoverTable1.Name = "TurnoverTable1";
            TurnoverTable1.RowCount = 1;
            TurnoverTable1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TurnoverTable1.Size = new Size(700, 50);
            TurnoverTable1.TabIndex = 2;
            //
            // label6
            //
            label6.AutoSize = true;
            label6.Location = new Point(26, 28);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 1;
            label6.Text = "Turnover by date";
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            Tableview.ResumeLayout(false);
            Tableview.PerformLayout();
            Tipsview.ResumeLayout(false);
            Tipsview.PerformLayout();
            Turnover.ResumeLayout(false);
            Turnover.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Tableview;
        private TabPage Tipsview;
        private TableLayoutPanel FreeTable;
        private TableLayoutPanel AssignedToYou;
        private Label label2;
        private Label label1;
        private TableLayoutPanel TipsTable;
        private Label label4;
        private Label label3;
        private TextBox AddTip;
        private Label label5;
        private TableLayoutPanel AssignedToOthers;
        private TabPage Turnover;
        private Label label6;
        private TableLayoutPanel TurnoverTable;
        private Button button1;
        private TableLayoutPanel TurnoverTable1;
        private Label TotalTurnoverLabel;
        private Label TotalTurnoverNumberLabel;
        private Label TuroverYourself;
        private Label label8;
    }
}