
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
