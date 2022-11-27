using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tastaturavirtualawithbuttonctrl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        public void setValue(string n)
        {
            if (n == "&&")
            {
                textBox1.Text += "&";
            }
            else
            {
                textBox1.Text += n;
            }
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //first line of buttons esc fn...
                        vkkb145.setText("ESC");
                        vkkb146.setText("F1");
                        vkkb147.setText("F2");
                        vkkb148.setText("F3");
                        vkkb149.setText("F4");
                        vkkb150.setText("F5");
                        vkkb151.setText("F6");
                        vkkb152.setText("F7");
                        vkkb153.setText("F8");
                        vkkb154.setText("F9");
                        vkkb155.setText("F10");
                        vkkb156.setText("F11");
                        vkkb157.setText("F12");
                        vkkb158.setText("POS1");
                        vkkb159.setText("END");
                        vkkb160.setText("ROLL");

                        vkkb161.setText("WIFI");
                        vkkb162.setText("SNDD");
                        vkkb163.setText("MUT");
                        vkkb164.setText("SNDD");
                        vkkb165.setText("MOU");
                        vkkb166.setText("CAM");
                        vkkb167.setText("B-");
                        vkkb168.setText("B+");
                        vkkb169.setText("SCR");
                        vkkb170.setText("FAN");
                        vkkb171.setText("SLEEP");
                        vkkb172.setText("NUM");
                        vkkb173.setText("DRUCK");
                        vkkb174.setText("EINFG");
                        vkkb175.setText("PAUSE");
                        vkkb176.setText("ENTF");
            // line of digits 

                        vkkb1.setText("~");
                        vkkb2.setText("!");
                        vkkb3.setText("@");
                        vkkb4.setText("#");
                        vkkb5.setText("$");
                        vkkb6.setText("%");
                        vkkb7.setText("^");
                        vkkb8.setText("&&");
                        vkkb9.setText("*");
                        vkkb10.setText("(");
                        vkkb11.setText(")");
                        vkkb12.setText("_");
                        vkkb13.setText("+");
                        vkkb14.setText("<--");
                        vkkb15.setText("EN");
                        vkkb16.setText("RO");

                        vkkb17.setText("`");
                        vkkb18.setText("1");
                        vkkb19.setText("2");
                        vkkb20.setText("3");
                        vkkb21.setText("4");
                        vkkb22.setText("5");
                        vkkb23.setText("6");
                        vkkb24.setText("7");
                        vkkb25.setText("8");
                        vkkb26.setText("9");
                        vkkb27.setText("0");
                        vkkb28.setText("-");
                        vkkb29.setText("=");
                        vkkb30.setText("RET");
                        vkkb31.setText("SCH");
                        vkkb32.setText("TAB");

           // first row of letters 

                        vkkb33.setText("TAB");
                        vkkb34.setText("Q");
                        vkkb35.setText("W");
                        vkkb36.setText("E");
                        vkkb37.setText("R");
                        vkkb38.setText("T");
                        vkkb39.setText("Y");
                        vkkb40.setText("U");
                        vkkb41.setText("I");
                        vkkb42.setText("O");
                        vkkb43.setText("P");
                        vkkb44.setText("{");
                        vkkb45.setText("}");
                        vkkb46.setText("ENT");
                        vkkb47.setText("ESC");
                        vkkb48.setText("PRN");

                        vkkb49.setText("TAB");
                        vkkb50.setText("q");
                        vkkb51.setText("w");
                        vkkb52.setText("e");
                        vkkb53.setText("r");
                        vkkb54.setText("t");
                        vkkb55.setText("y");
                        vkkb56.setText("u");
                        vkkb57.setText("i");
                        vkkb58.setText("o");
                        vkkb59.setText("p");
                        vkkb60.setText("[");
                        vkkb61.setText("]");
                        vkkb62.setText("RET");
                        vkkb63.setText("SCH");
                        vkkb64.setText("TAB");

                        vkkb65.setText("CL");
                        vkkb66.setText("A");
                        vkkb67.setText("S");
                        vkkb68.setText("D");
                        vkkb69.setText("F");
                        vkkb70.setText("G");
                        vkkb71.setText("H");
                        vkkb72.setText("J");
                        vkkb73.setText("K");
                        vkkb74.setText("L");
                        vkkb75.setText(":");
                        vkkb76.setText("\"");
                        vkkb77.setText("|");
                        vkkb78.setText("RET");
                        vkkb79.setText("SCH");
                        vkkb80.setText("TAB");

                        vkkb81.setText("CL");
                        vkkb82.setText("a");
                        vkkb83.setText("s");
                        vkkb84.setText("d");
                        vkkb85.setText("f");
                        vkkb86.setText("g");
                        vkkb87.setText("h");
                        vkkb88.setText("j");
                        vkkb89.setText("k");
                        vkkb90.setText("l");
                        vkkb91.setText(";");
                        vkkb92.setText("'");
                        vkkb93.setText("\\");
                        vkkb94.setText("RET");
                        vkkb95.setText("SCH");
                        vkkb96.setText("TAB");

                        vkkb97.setText("SHF");
                        vkkb98.setText("|");
                        vkkb99.setText("Z");
                        vkkb100.setText("X");
                        vkkb101.setText("C");
                        vkkb102.setText("V");
                        vkkb103.setText("B");
                        vkkb104.setText("N");
                        vkkb105.setText("M");
                        vkkb106.setText(",");
                        vkkb107.setText(".");
                        vkkb108.setText("/");
                        vkkb109.setText("SCH");
                        vkkb110.setText("RET");
                        vkkb111.setText("CTRL");
                        vkkb112.setText("TAB");

                        vkkb113.setText("SCH");
                        vkkb114.setText("\\");
                        vkkb115.setText("z");
                        vkkb116.setText("x");
                        vkkb117.setText("c");
                        vkkb118.setText("v");
                        vkkb119.setText("b");
                        vkkb120.setText("n");
                        vkkb121.setText("m");
                        vkkb122.setText("<");
                        vkkb123.setText(">");
                        vkkb124.setText("?");
                        vkkb125.setText("SCH");
                        vkkb126.setText("RET");
                        vkkb127.setText("SCH");
                        vkkb128.setText("TAB");
            //last row of buttons
                        vkkb129.setText("CTRL");
                        vkkb130.setText("FN");
                        vkkb131.setText("WIN");
                        vkkb132.setText("ALT");
                        vkkb133.setText(" ");
                        vkkb134.setText("  ");
                        vkkb135.setText(" ");
                        vkkb136.setText(" ");
                        vkkb137.setText(" ");
                        vkkb138.setText("AGR");
                        vkkb139.setText("MEN");
                        vkkb140.setText("CTRL");
                        vkkb141.setText("UP");
                        vkkb142.setText("LF");
                        vkkb143.setText("DN");
                        vkkb144.setText("RG");

            //partea 2 colorare butoane

            //first line of buttons esc fn...
            vkkb145.setColorOfButton(Color.Red); //("ESC");
            vkkb146.setColorOfButton(Color.Gray);// ("F1");
            vkkb147.setColorOfButton(Color.Gray); //("F2");
            vkkb148.setColorOfButton(Color.Gray);// ("F3");
            vkkb149.setColorOfButton(Color.Gray);// ("F4");
            vkkb150.setColorOfButton(Color.Gray);// ("F5");
            vkkb151.setColorOfButton(Color.Gray);// ("F6");
            vkkb152.setColorOfButton(Color.Gray);// ("F7");
            vkkb153.setColorOfButton(Color.Gray);//("F8");
            vkkb154.setColorOfButton(Color.Gray);//("F9");
            vkkb155.setColorOfButton(Color.Gray);//("F10");
            vkkb156.setColorOfButton(Color.Gray);//("F11");
            vkkb157.setColorOfButton(Color.Gray);//("F12");
            vkkb158.setColorOfButton(Color.Green);//("POS1");
            vkkb159.setColorOfButton(Color.Green);//("END");
            vkkb160.setColorOfButton(Color.Green);//("ROLL");

            vkkb161.setColorOfButton(Color.Blue);//("WIFI");
            vkkb162.setColorOfButton(Color.Blue);//("SNDD");
            vkkb163.setColorOfButton(Color.Blue);//("MUT");
            vkkb164.setColorOfButton(Color.Blue);//("SNDD");
            vkkb165.setColorOfButton(Color.Blue);//("MOU");
            vkkb166.setColorOfButton(Color.Blue);//("CAM");
            vkkb167.setColorOfButton(Color.Blue);//("B-");
            vkkb168.setColorOfButton(Color.Blue);//("B+");
            vkkb169.setColorOfButton(Color.Blue);//("SCR");
            vkkb170.setColorOfButton(Color.Blue);//("FAN");
            vkkb171.setColorOfButton(Color.Blue);//("SLEEP");
            vkkb172.setColorOfButton(Color.Blue);//("NUM");
            vkkb173.setColorOfButton(Color.Blue);//("DRUCK");
            vkkb174.setColorOfButton(Color.Blue);//("EINFG");
            vkkb175.setColorOfButton(Color.Blue);//("PAUSE");
            vkkb176.setColorOfButton(Color.Blue);//("ENTF");
            // line of digits 

            vkkb1.setColorOfButton(Color.Coral);//("~");
            vkkb2.setColorOfButton(Color.Coral);//("!");
            vkkb3.setColorOfButton(Color.Coral);//("@");
            vkkb4.setColorOfButton(Color.Coral);//("#");
            vkkb5.setColorOfButton(Color.Coral);//("$");
            vkkb6.setColorOfButton(Color.Coral);//("%");
            vkkb7.setColorOfButton(Color.Coral);//("^");
            vkkb8.setColorOfButton(Color.Coral);//("&&");
            vkkb9.setColorOfButton(Color.Coral);//("*");
            vkkb10.setColorOfButton(Color.Coral);//("(");
            vkkb11.setColorOfButton(Color.Coral);//(")");
            vkkb12.setColorOfButton(Color.Coral);//("_");
            vkkb13.setColorOfButton(Color.Coral);//("+");
            vkkb14.setColorOfButton(Color.Red);//("<--");
            vkkb15.setColorOfButton(Color.Blue);//("EN");
            vkkb16.setColorOfButton(Color.Blue);//("RO");

            vkkb17.setColorOfButton(Color.Coral);//("`");
            vkkb18.setColorOfButton(Color.Gray);//("1");
            vkkb19.setColorOfButton(Color.Gray);//("2");
            vkkb20.setColorOfButton(Color.Gray);//("3");
            vkkb21.setColorOfButton(Color.Gray);//("4");
            vkkb22.setColorOfButton(Color.Gray);//("5");
            vkkb23.setColorOfButton(Color.Gray);//("6");
            vkkb24.setColorOfButton(Color.Gray);//("7");
            vkkb25.setColorOfButton(Color.Gray);//("8");
            vkkb26.setColorOfButton(Color.Gray);//("9");
            vkkb27.setColorOfButton(Color.Gray);//("0");
            vkkb28.setColorOfButton(Color.Coral);//("-");
            vkkb29.setColorOfButton(Color.Coral);//("=");
            vkkb30.setColorOfButton(Color.Green);//("RET");
            vkkb31.setColorOfButton(Color.Green);//("SCH");
            vkkb32.setColorOfButton(Color.Green);//("TAB");

            // first row of letters 

            vkkb33.setColorOfButton(Color.Red);//("TAB");
            vkkb34.setColorOfButton(Color.Chocolate);//("Q");
            vkkb35.setColorOfButton(Color.Chocolate);//("W");
            vkkb36.setColorOfButton(Color.Chocolate);//("E");
            vkkb37.setColorOfButton(Color.Chocolate);//("R");
            vkkb38.setColorOfButton(Color.Chocolate);//("T");
            vkkb39.setColorOfButton(Color.Chocolate);//("Y");
            vkkb40.setColorOfButton(Color.Chocolate);//("U");
            vkkb41.setColorOfButton(Color.Chocolate);//("I");
            vkkb42.setColorOfButton(Color.Chocolate);//("O");
            vkkb43.setColorOfButton(Color.Chocolate);//("P");
            vkkb44.setColorOfButton(Color.Coral);//("{");
            vkkb45.setColorOfButton(Color.Coral);//("}");
            vkkb46.setColorOfButton(Color.Red);//("ENT");
            vkkb47.setColorOfButton(Color.Red);//("ESC");
            vkkb48.setColorOfButton(Color.Green);//("PRN");

            vkkb49.setColorOfButton(Color.Red);//("TAB");
            vkkb50.setColorOfButton(Color.Chocolate);//("q");
            vkkb51.setColorOfButton(Color.Chocolate);//("w");
            vkkb52.setColorOfButton(Color.Chocolate);//("e");
            vkkb53.setColorOfButton(Color.Chocolate);//("r");
            vkkb54.setColorOfButton(Color.Chocolate);//("t");
            vkkb55.setColorOfButton(Color.Chocolate);//("y");
            vkkb56.setColorOfButton(Color.Chocolate);//("u");
            vkkb57.setColorOfButton(Color.Chocolate);//("i");
            vkkb58.setColorOfButton(Color.Chocolate);//("o");
            vkkb59.setColorOfButton(Color.Chocolate);//("p");
            vkkb60.setColorOfButton(Color.Coral);//("[");
            vkkb61.setColorOfButton(Color.Coral);//("]");
            vkkb62.setColorOfButton(Color.Green);//("RET");
            vkkb63.setColorOfButton(Color.Green);//("SCH");
            vkkb64.setColorOfButton(Color.Red);//("TAB");

            vkkb65.setColorOfButton(Color.Red);//("CL");
            vkkb66.setColorOfButton(Color.Chocolate);//("A");
            vkkb67.setColorOfButton(Color.Chocolate);//("S");
            vkkb68.setColorOfButton(Color.Chocolate);//("D");
            vkkb69.setColorOfButton(Color.Chocolate);//("F");
            vkkb70.setColorOfButton(Color.Chocolate);//("G");
            vkkb71.setColorOfButton(Color.Chocolate);//("H");
            vkkb72.setColorOfButton(Color.Chocolate);//("J");
            vkkb73.setColorOfButton(Color.Chocolate);//("K");
            vkkb74.setColorOfButton(Color.Chocolate);//("L");
            vkkb75.setColorOfButton(Color.Coral);//(":");
            vkkb76.setColorOfButton(Color.Coral);//("\"");
            vkkb77.setColorOfButton(Color.Coral);//("|");
            vkkb78.setColorOfButton(Color.Green);//("RET");
            vkkb79.setColorOfButton(Color.Green);//("SCH");
            vkkb80.setColorOfButton(Color.Red);//("TAB");

            vkkb81.setColorOfButton(Color.Red);//("CL");
            vkkb82.setColorOfButton(Color.Chocolate);//("a");
            vkkb83.setColorOfButton(Color.Chocolate);//("s");
            vkkb84.setColorOfButton(Color.Chocolate);//("d");
            vkkb85.setColorOfButton(Color.Chocolate);//("f");
            vkkb86.setColorOfButton(Color.Chocolate);//("g");
            vkkb87.setColorOfButton(Color.Chocolate);//("h");
            vkkb88.setColorOfButton(Color.Chocolate);//("j");
            vkkb89.setColorOfButton(Color.Chocolate);//("k");
            vkkb90.setColorOfButton(Color.Chocolate);//("l");
            vkkb91.setColorOfButton(Color.Coral);//(";");
            vkkb92.setColorOfButton(Color.Coral);//("'");
            vkkb93.setColorOfButton(Color.Coral);//("\\");
            vkkb94.setColorOfButton(Color.Green);//("RET");
            vkkb95.setColorOfButton(Color.Green);//("SCH");
            vkkb96.setColorOfButton(Color.Red);//("TAB");
            vkkb97.setColorOfButton(Color.Red);//("SHF");
            vkkb98.setColorOfButton(Color.Coral);//("|");
            vkkb99.setColorOfButton(Color.Chocolate);//("Z");
            vkkb100.setColorOfButton(Color.Chocolate);//("X");
            vkkb101.setColorOfButton(Color.Chocolate);//("C");
            vkkb102.setColorOfButton(Color.Chocolate);//("V");
            vkkb103.setColorOfButton(Color.Chocolate);//("B");
            vkkb104.setColorOfButton(Color.Chocolate);//("N");
            vkkb105.setColorOfButton(Color.Chocolate);//("M");
            vkkb106.setColorOfButton(Color.Coral);//(",");
            vkkb107.setColorOfButton(Color.Coral);//(".");
            vkkb108.setColorOfButton(Color.Coral);//("/");
            vkkb109.setColorOfButton(Color.Green);//("SCH");
            vkkb110.setColorOfButton(Color.Green);//("RET");
            vkkb111.setColorOfButton(Color.Green);//("CTRL");
            vkkb112.setColorOfButton(Color.Red);//("TAB");

            vkkb113.setColorOfButton(Color.Green);//("SCH");
            vkkb114.setColorOfButton(Color.Coral);//("\\");
            vkkb115.setColorOfButton(Color.Chocolate);//("z");
            vkkb116.setColorOfButton(Color.Chocolate);//("x");
            vkkb117.setColorOfButton(Color.Chocolate);//("c");
            vkkb118.setColorOfButton(Color.Chocolate);//("v");
            vkkb119.setColorOfButton(Color.Chocolate);//("b");
            vkkb120.setColorOfButton(Color.Chocolate);//("n");
            vkkb121.setColorOfButton(Color.Chocolate);//("m");
            vkkb122.setColorOfButton(Color.Coral);//("<");
            vkkb123.setColorOfButton(Color.Coral);//(">");
            vkkb124.setColorOfButton(Color.Coral);//("?");
            vkkb125.setColorOfButton(Color.Green);//("SCH");
            vkkb126.setColorOfButton(Color.Red);//("RET");
            vkkb127.setColorOfButton(Color.Green);//("SCH");
            vkkb128.setColorOfButton(Color.Red);//("TAB");

            //last row of buttons
            vkkb129.setColorOfButton(Color.Green);//("CTRL");
            vkkb130.setColorOfButton(Color.Green);//("FN");
            vkkb131.setColorOfButton(Color.Green);//("WIN");
            vkkb132.setColorOfButton(Color.Green);//("ALT");
            vkkb133.setColorOfButton(Color.Gray);//(" ");
            vkkb134.setColorOfButton(Color.Gray);//("  ");
            vkkb135.setColorOfButton(Color.Gray);//(" ");
            vkkb136.setColorOfButton(Color.Gray);//(" ");
            vkkb137.setColorOfButton(Color.Gray);//(" ");
            vkkb138.setColorOfButton(Color.Green);//("AGR");
            vkkb139.setColorOfButton(Color.Green);//("MEN");
            vkkb140.setColorOfButton(Color.Green);//("CTRL");
            vkkb141.setColorOfButton(Color.Blue);//("UP");
            vkkb142.setColorOfButton(Color.Blue);//("LF");
            vkkb143.setColorOfButton(Color.Blue);//("DN");
            vkkb144.setColorOfButton(Color.Blue);//("RG");



        }
    }
}
