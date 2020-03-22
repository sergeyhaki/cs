//winquall.cs
using System;
using System.Windows.Forms;
using System.IO;

class winQUAll : Form
{
	winQUAll()
	{
		Text= "winQUAll Например A=6 B=7 C=2";
		//BackColor = System.Drawing.Color.Green;
		//ForeColor = System.Drawing.Color.White;
		ResizeRedraw = true;
		Width = 400;
		Height = 250;
		{
			var buttons = new Button();
			buttons.Text= "SAVE";
			buttons.Dock = DockStyle.Top;
			var zc = -7;
    var labelc = new Label();
    var buttonc = new Button();
    buttonc.Text= "C+3";
    buttonc.Dock = DockStyle.Bottom;
var zb = 12;
var labelb = new Label();
var buttonb = new Button();
buttonb.Text= "B-1";
buttonb.Dock = DockStyle.Bottom;
    var za = 2;
    var labela = new Label();
    var buttona = new Button();
    buttona.Text= "A+1";
    buttona.Dock = DockStyle.Bottom;
var labelx = new Label();
    var d = (zb * zb - 4 * za * zc);
    double x1 = (-zb + Math.Sqrt(d)) / (2 * za);
    double x2 = (-zb - Math.Sqrt(d)) / (2 * za);
    var labeld = new Label();
labeld.Text= "d= " + d +"   X1= " + x1 + "   X2= " + x2 + "  ";
labeld.Dock = DockStyle.Top;
x1 = (Math.Truncate(x1 * 100))/100;
x2 = (Math.Truncate(x2 * 100))/100;
    //labeld.Location = new System.Drawing.Point(80, 15);
labelx.Text= "X1=" + x1 + " X2=" + x2 + "  ";
labelx.Location = new System.Drawing.Point(125, 125);
Controls.Add(labeld);
Controls.Add(labelx);
    labelc.Text= "C=" + zc + ".....";
    labelc.Location = new System.Drawing.Point(20, 100);
Controls.Add(labelc);
buttonc.Click += delegate
    {
    zc = zc+3;
    d = (zb * zb - 4 * za * zc);
    x1 = (-zb + Math.Sqrt(d)) / (2 * za);
    x2 = (-zb - Math.Sqrt(d)) / (2 * za);
labeld.Text= "d= " + d +"   X1= " + x1 + "   X2= " + x2 + "  ";
labeld.Dock = DockStyle.Top;
x1 = (Math.Truncate(x1 * 100))/100;
x2 = (Math.Truncate(x2 * 100))/100;
    //labeld.Location = new System.Drawing.Point(80, 15);
labelx.Text= "X1=" + x1 + " X2=" + x2 + "  ";
labelx.Location = new System.Drawing.Point(125, 125);
labelc.Text= "C=" + zc + "  ...";
labelc.Location = new System.Drawing.Point(20, 100);
    };
Controls.Add(buttonc);
Controls.Add(labeld);
Controls.Add(labelx);
    labelb.Text= "B=" + zb + ".....";
    labelb.Location = new System.Drawing.Point(50, 80);
Controls.Add(labelb);
buttonb.Click += delegate
    {
    zb--;
    d = (zb * zb - 4 * za * zc);
    x1 = (-zb + Math.Sqrt(d)) / (2 * za);
    x2 = (-zb - Math.Sqrt(d)) / (2 * za);
labeld.Text= "d= " + d +"   X1= " + x1 + "   X2= " + x2 + "  ";
labeld.Dock = DockStyle.Top;
x1 = (Math.Truncate(x1 * 100))/100;
x2 = (Math.Truncate(x2 * 100))/100;
    //labeld.Location = new System.Drawing.Point(80, 15);
labelx.Text= "X1=" + x1 + " X2=" + x2 + "  ";
labelx.Location = new System.Drawing.Point(125, 125);
labelb.Text= "B=" + zb + "  ...";
labelb.Location = new System.Drawing.Point(50, 80);
    };
Controls.Add(buttonb);
Controls.Add(labeld);
Controls.Add(labelx);
    labela.Text= "A=" + za + ".....";
    labela.Location = new System.Drawing.Point(80, 60);
Controls.Add(labela);
buttona.Click += delegate
    {
    za++;
    d = (zb * zb - 4 * za * zc);
    x1 = (-zb + Math.Sqrt(d)) / (2 * za);
    x2 = (-zb - Math.Sqrt(d)) / (2 * za);
labeld.Text= "d= " + d +"   X1= " + x1 + "   X2= " + x2 + "  ";
labeld.Dock = DockStyle.Top;
x1 = (Math.Truncate(x1 * 100))/100;
x2 = (Math.Truncate(x2 * 100))/100;
    //labeld.Location = new System.Drawing.Point(80, 15);
labelx.Text= "X1=" + x1 + " X2=" + x2 + "  ";
labelx.Location = new System.Drawing.Point(125, 125);
labela.Text= "A=" + za + "  ...";
labela.Location = new System.Drawing.Point(80, 60);
    };
Controls.Add(buttons);
buttons.Click += delegate
    {
var outFile = new StreamWriter("dan.txt");
outFile.WriteLine(za);
outFile.WriteLine(zb);
outFile.WriteLine(zc);
outFile.WriteLine(d);
outFile.WriteLine(x1);
outFile.WriteLine(x2);
outFile.Close();
    };
Controls.Add(buttona);
Controls.Add(labeld);
Controls.Add(labelx);
    };
}
    static void Main()
    {
Application.Run(new winQUAll());
    }
}
