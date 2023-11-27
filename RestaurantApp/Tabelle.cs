using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using RestaurantApp;
using System.Data.SQLite;

public class Tabelle
{
    public TableLayoutPanel Table;

    public Tabelle(TableLayoutPanel table)
	{
        this.Table = table;
	}
    public void initTable(List<string> headerList) {
        //TableLayoutPanel panel = (TableLayoutPanel)this.TipsTable;
        TableLayoutPanel panel = this.Table;
        panel.MaximumSize = new Size(700, 300);
        panel.AutoScroll = false;
        panel.AutoSize = true;
        panel.RowCount = 0;
        panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
        int headerNumber = 0;
        foreach(string header in headerList) {
            panel.Controls.Add(new Label() { Text = header }, headerNumber, 0);
            headerNumber++;
        }
    }

    public void addTipRow(decimal amount, DateTime date) {
        //TableLayoutPanel panel = (TableLayoutPanel)this.TipsTable;
        TableLayoutPanel panel = this.Table;
        int width = panel.Size.Width;
        int height = panel.Size.Height;
        if (height > 150 && !panel.AutoScroll)
        {
            panel.AutoScroll = true;
        }
        panel.RowCount = panel.RowCount + 1;
        panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        panel.Controls.Add(new Label() { Text = amount.ToString() }, 0, panel.RowCount);
        panel.Controls.Add(new Label() { Text = date.ToString() }, 1, panel.RowCount);
        Table = panel;
    }
    public void addTurnoverRow(decimal totalPrice, DateTime date) {
        //TableLayoutPanel panel = (TableLayoutPanel)this.TipsTable;
        TableLayoutPanel panel = this.Table;
        int width = panel.Size.Width;
        int height = panel.Size.Height;
        if (height > 150 && !panel.AutoScroll)
        {
            panel.AutoScroll = true;
        }
        panel.RowCount = panel.RowCount + 1;
        panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        panel.Controls.Add(new Label() { Text = totalPrice.ToString() }, 0, panel.RowCount);
        panel.Controls.Add(new Label() { Text = date.ToString() }, 1, panel.RowCount);
        Table = panel;
    }
}
    //private void createView(TableRow tr, TextView t, String viewdata) {

        //t.SetText(viewdata, TextView.BufferType.Editable);

       ////adjust the porperties of the textView

       ////t.SetLayoutParams(new LayoutParams(LayoutParams.WRAP_CONTENT,LayoutParams.WRAP_CONTENT));

        ////You have to use Android.Graphics.Color not System.ConsoleColor;
        //t.SetTextColor(Color.Blue);
        //t.SetBackgroundColor(Color.Cyan); 
        //t.SetPadding(5, 0, 0, 0);

        //tr.SetPadding(0, 1, 0, 1); 
        //tr.SetBackgroundColor(Color.Black); 
        //tr.setClickable(true);

        //tr.setOnClickListener(tablerowOnClickListener);//add OnClickListener Here

        //tr.AddView(t); // add TextView to row.


   //}
	//private OnClickListener tablerowOnClickListener = new OnClickListener() {
        	//public void onClick(View v) {
            	////GET TEXT HERE
            	//String currenttext = ((TextView)v).getText().toString());
        	//}
    	//};
//}
