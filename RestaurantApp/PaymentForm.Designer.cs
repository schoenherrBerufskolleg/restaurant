using System.Windows.Forms;

namespace RestaurantApp
{
    partial class PaymentForm
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
            OpenOrdersCheckedListBox = new CheckedListBox();
            label1 = new Label();
            AmountPaidNumberbox = new NumericUpDown();
            TotalSumLabel = new Label();
            label3 = new Label();
            CloseOrdersButton = new Button();
            ((System.ComponentModel.ISupportInitialize)AmountPaidNumberbox).BeginInit();
            SuspendLayout();
            // 
            // OpenOrdersCheckedListBox
            // 
            OpenOrdersCheckedListBox.FormattingEnabled = true;
            OpenOrdersCheckedListBox.Location = new Point(52, 44);
            OpenOrdersCheckedListBox.Name = "OpenOrdersCheckedListBox";
            OpenOrdersCheckedListBox.Size = new Size(269, 130);
            OpenOrdersCheckedListBox.TabIndex = 0;
            OpenOrdersCheckedListBox.ItemCheck += OpenOrdersCheckedListBox_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 26);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Pay for:";
            // 
            // AmountPaidNumberbox
            // 
            AmountPaidNumberbox.DecimalPlaces = 2;
            AmountPaidNumberbox.Location = new Point(52, 229);
            AmountPaidNumberbox.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            AmountPaidNumberbox.Name = "AmountPaidNumberbox";
            AmountPaidNumberbox.Size = new Size(120, 23);
            AmountPaidNumberbox.TabIndex = 2;
            // 
            // TotalSumLabel
            // 
            TotalSumLabel.AutoSize = true;
            TotalSumLabel.Location = new Point(52, 177);
            TotalSumLabel.Name = "TotalSumLabel";
            TotalSumLabel.Size = new Size(35, 15);
            TotalSumLabel.TabIndex = 3;
            TotalSumLabel.Text = "Total:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 211);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 4;
            label3.Text = "Amount paid:";
            // 
            // CloseOrdersButton
            // 
            CloseOrdersButton.Location = new Point(224, 227);
            CloseOrdersButton.Name = "CloseOrdersButton";
            CloseOrdersButton.Size = new Size(97, 23);
            CloseOrdersButton.TabIndex = 5;
            CloseOrdersButton.Text = "Close Orders";
            CloseOrdersButton.UseVisualStyleBackColor = true;
            CloseOrdersButton.Click += CloseOrdersButton_Click;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 301);
            Controls.Add(CloseOrdersButton);
            Controls.Add(label3);
            Controls.Add(TotalSumLabel);
            Controls.Add(AmountPaidNumberbox);
            Controls.Add(label1);
            Controls.Add(OpenOrdersCheckedListBox);
            Name = "PaymentForm";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)AmountPaidNumberbox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox OpenOrdersCheckedListBox;
        private Label label1;
        private NumericUpDown AmountPaidNumberbox;
        private Label TotalSumLabel;
        private Label label3;
        private Button CloseOrdersButton;
    }
}