using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp20
{
    public partial class Form1 : Form
    {
        string imgPath = Application.StartupPath.Replace(@"\Rock_Paper_Scissore\bin\Debug", @"\Image");//ดึงภาพออกมาจากไพล์\bin\Debug
        string[] moves = new string[3] { "scissors", "paper", "stone" }; //สร้างอาเรมาเก็บค่า3ตัว
        string myMove = "", comMove = "";//ประการตัวแปรสติง
        int myScore = 0, comScore = 0; // ประกาศค่าตัวแปร2ตัวให้มีค่าเท่ากับ0

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }
        private void MyMove(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender; 

            if (pic == Scissors) //ถ้าเลือกรูปScissorsจะเข้าเขี่อนไขนี้
            {
                myMove = "scissors"; //จะแสดงscissors
                Paper.Visible = false; // Paperจะหายไป
                Stone.Visible = false; 
            }
            else if (pic == Stone) //ถ้าจะเลือกรูปStoneจะเข้าเขี่อนไขนี้
            {
                myMove = "stone"; //จะรูปแสดงรูปstone
                Paper.Visible = false; // Paperจะหายไป
                Scissors.Visible = false; // Stoneจะหายไป
            }
            else if (pic == Paper) //ถ้าจะเลือกรูปPaperจะเข้าเขี่อนไขนี้
            {
                myMove = "paper";  //จะแสดงรูป paper
                Scissors.Visible = false; //scissorsจะหายไป
                Stone.Visible = false; //stoneจะหายไป
            }     
            ComputerSelect();
            MessageBox.Show("The winner is:  " + WhoWillwin()); //แสดงMessagebox The winner is ว่าใครชนะ
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            btnNext.Visible = false; //กดแปุ่มbtnext จะหายไป
            Scissors.Visible = true; //กดปุ่มแล้วภาพจะกลับมา
            Paper.Visible = true;    //กดปุ่มแล้วภาพจะกลับมา
            Stone.Visible = true;    //กดปุ่มแล้วภาพจะกลับมา
            Comp.Image = null;     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close(); //ปิดโปรแกรม
        }

        private void ComputerSelect() 
        {
            Random rdm = new Random(); //สร้างตัวแปรสุ่ม
            int num = rdm.Next(0, 3);  //สร้างตัวแปรรับค่าสุ่ม
            comMove = moves[num];      //ให้คอมแสดงการทำงาน โดยอ้างอิงจากเลขที่สุ่มได้
            Comp.Image = Image.FromFile(imgPath + @"\" + moves[num] + ".png");  //สุ่มรูปภาพคอม
        }
        private string WhoWillwin()
        {
            string result = "";       //รอเดิมค่า
            if (myMove == comMove) //ถ้าสุ่มได้เหมือนกัน
                result = "เสมอ";    //จะแสดงเสมอ
            else if (myMove == "scissors" && comMove == "paper" || myMove == "paper" && comMove == "stone" || myMove == "stone" && comMove == "scissors")  //
            //ถ้านอกจากเขื่อนไขที่กำหนดให้คอมจะชนะทันที
            {
                myScore++;  //สกอเรา+1
                lblYouScore.Text = myScore.ToString(); //แปลงค่าให้เป็นสติง
                result = "You win"; //แสดงผลเราชนะ
            }
            else
            {
                comScore++; //สกอคอม+1
                lblComScore.Text = comScore.ToString(); //แปลงค่าให้เป็นสติง
                result = "Computer win"; //แสดงผลคอมนะ
            }
            btnNext.Visible = true; //แสดงปุ่มที่ซ่อนไว้
            return result; 
        }
    }
}
