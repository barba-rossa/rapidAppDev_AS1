
namespace TicTacToe
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            btn1.Location = new Point(10, 10);
            btn1.Name = "btn1";
            btn1.Size = new Size(100, 100);
            btn1.TabIndex = 0;
            btn1.Tag = "play";
            btn1.Click += buttonClick;
            // 
            // btn2
            // 
            btn2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            btn2.Location = new Point(120, 10);
            btn2.Name = "btn2";
            btn2.Size = new Size(100, 100);
            btn2.TabIndex = 1;
            btn2.Tag = "play";
            btn2.Click += buttonClick;
            // 
            // btn3
            // 
            btn3.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            btn3.Location = new Point(230, 10);
            btn3.Name = "btn3";
            btn3.Size = new Size(100, 100);
            btn3.TabIndex = 2;
            btn3.Tag = "play";
            btn3.Click += buttonClick;
            // 
            // btn4
            // 
            btn4.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            btn4.Location = new Point(10, 120);
            btn4.Name = "btn4";
            btn4.Size = new Size(100, 100);
            btn4.TabIndex = 3;
            btn4.Tag = "play";
            btn4.Click += buttonClick;
            // 
            // btn5
            // 
            btn5.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            btn5.Location = new Point(120, 120);
            btn5.Name = "btn5";
            btn5.Size = new Size(100, 100);
            btn5.TabIndex = 4;
            btn5.Tag = "play";
            btn5.Click += buttonClick;



            // btn6
            // 
            btn6.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            btn6.Location = new Point(230, 120);
            btn6.Name = "btn6";
            btn6.Size = new Size(100, 100);
            btn6.TabIndex = 5;
            btn6.Tag = "play";
            btn6.Click += buttonClick;
            // 
            // btn7
            // 
            btn7.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            btn7.Location = new Point(10, 230);
            btn7.Name = "btn7";
            btn7.Size = new Size(100, 100);
            btn7.TabIndex = 6;
            btn7.Tag = "play";
            btn7.Click += buttonClick;
            // 
            // btn8
            // 
            btn8.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            btn8.Location = new Point(120, 230);
            btn8.Name = "btn8";
            btn8.Size = new Size(100, 100);
            btn8.TabIndex = 7;
            btn8.Tag = "play";
            btn8.Click += buttonClick;
            // 
            // btn9
            // 
            btn9.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            btn9.Location = new Point(230, 230);
            btn9.Name = "btn9";
            btn9.Size = new Size(100, 100);
            btn9.TabIndex = 8;
            btn9.Tag = "play";
            btn9.Click += buttonClick;
            // 
            // Form1
            // 
            ClientSize = new Size(615, 567);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Name = "Form1";
            Text = "Tic-Tac-Toe";
            ResumeLayout(false);
        }

    }
}
