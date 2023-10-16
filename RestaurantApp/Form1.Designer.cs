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
            Tipsview = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            label5 = new Label();
            Turnover = new TabPage();
            tableLayoutPanel5 = new TableLayoutPanel();
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
            Tableview.Controls.Add(tableLayoutPanel4);
            Tableview.Controls.Add(label2);
            Tableview.Controls.Add(label1);
            Tableview.Controls.Add(tableLayoutPanel2);
            Tableview.Controls.Add(tableLayoutPanel1);
            Tableview.Location = new Point(4, 24);
            Tableview.Name = "Tableview";
            Tableview.Padding = new Padding(3);
            Tableview.Size = new Size(793, 421);
            Tableview.TabIndex = 0;
            Tableview.Text = "Tableview";
            Tableview.UseVisualStyleBackColor = true;
            // 
            // Tipsview
            // 
            Tipsview.Controls.Add(label4);
            Tipsview.Controls.Add(label3);
            Tipsview.Controls.Add(textBox1);
            Tipsview.Controls.Add(tableLayoutPanel3);
            Tipsview.Location = new Point(4, 24);
            Tipsview.Name = "Tipsview";
            Tipsview.Padding = new Padding(3);
            Tipsview.Size = new Size(793, 421);
            Tipsview.TabIndex = 1;
            Tipsview.Text = "Tipsview";
            Tipsview.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(48, 60);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(690, 72);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Location = new Point(48, 181);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50.60241F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 49.39759F));
            tableLayoutPanel2.Size = new Size(690, 83);
            tableLayoutPanel2.TabIndex = 1;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 154);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 3;
            label2.Text = "Free Tables";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Location = new Point(31, 130);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(732, 272);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(31, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 101);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "Recent Tips";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Location = new Point(48, 307);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(690, 89);
            tableLayoutPanel4.TabIndex = 4;
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
            // Turnover
            // 
            Turnover.Controls.Add(label6);
            Turnover.Controls.Add(tableLayoutPanel5);
            Turnover.Location = new Point(4, 24);
            Turnover.Name = "Turnover";
            Turnover.Size = new Size(793, 421);
            Turnover.TabIndex = 2;
            Turnover.Text = "Turnover";
            Turnover.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Location = new Point(26, 56);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(743, 348);
            tableLayoutPanel5.TabIndex = 0;
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
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label4;
        private Label label3;
        private TextBox textBox1;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel4;
        private TabPage Turnover;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel5;
    }
}