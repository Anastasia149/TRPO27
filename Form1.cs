using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ТРПО27
{
    public partial class Form1 : Form
    {
        public bool isFirstCharSelected { get; private set; } = false;
        public bool isSecondCharSelected { get; private set; } = false;
        public bool isThirdCharSelected { get; private set; } = false;
        public bool isFourthCharSelected { get; private set; } = false;
        public bool isFirstCharSSelected { get; private set; } = false;
        public bool isSecondCharSSelected { get; private set; } = false;
        public bool isThirdCharSSelected { get; private set; } = false;
        public bool isFourthCharSSelected { get; private set; } = false;

        public bool[] isCharFSelected = new bool[4]; // Для первого набора персонажей
        public bool[] isCharSSelected = new bool[4]; // Для второго набора персонажей
        Label player1ScoreLabel;
        Label player2ScoreLabel;
        Label scoree;
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // Полноэкранный режим


            player1ScoreLabel = new Label
            {
                Location = new Point(150, 100),
                AutoSize = true,
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                ForeColor = Color.Black,
                BackColor = Color.Transparent  // Устанавливаем прозрачный фон
            };
            this.Controls.Add(player1ScoreLabel);

            player2ScoreLabel = new Label
            {
                Location = new Point(1040, 100),
                AutoSize = true,
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                ForeColor = Color.Black,
                BackColor = Color.Transparent  // Устанавливаем прозрачный фон
            };
            this.Controls.Add(player2ScoreLabel);

            scoree = new Label
            {
                Location = new Point(650, 60),
                AutoSize = true,
                Font = new Font("Segoe UI", 25, FontStyle.Bold),
                ForeColor = Color.Black,
                BackColor = Color.Transparent  // Устанавливаем прозрачный фон
            };
            this.Controls.Add(scoree);
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void фон1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"landscape12.jpg");
        }

        private void фон2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"landscape13.jpg");
        }

        private void фон3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"landscape11.jpg");
        }

        private void обИгреToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Была написана в 8 рук. Прыгай и не умрай.");
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Нажмите <<Сменить фон>> для смены фона.\n" +
                "Нажмите<<Выбрать персонажа>> для смены персонажа.\n" +
                "Нажмите<<Старт>> для начала игры.");
        }

        private void Start_Click(object sender, EventArgs e)
        {
            using (Form2 form2 = new Form2(this))
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    // Обновите метки с счетами
                    player1ScoreLabel.Text = "Игрок 1: " + form2.FinalScore1;
                    player2ScoreLabel.Text = "Игрок 2: " + form2.FinalScore2;
                    scoree.Text = "Счет";
                }
            }
            this.Show();
        }

        private void Start_Paint(object sender, PaintEventArgs e)
        {
          
        }


        public void FirstCharF_Click(object sender, EventArgs e)
        {
            isFirstCharSelected = true;
            MessageBox.Show("Персонаж выбран!");
        }

        public void SecondCharF_Click(object sender, EventArgs e)
        {
            isSecondCharSelected = true;
            MessageBox.Show("Персонаж выбран!");

        }

        private void ThirdCharF_Click(object sender, EventArgs e)
        {
            isThirdCharSelected = true;
            MessageBox.Show("Персонаж выбран!");
        }

        private void FourthCharF_Click(object sender, EventArgs e)
        {
            isFourthCharSelected = true;
            MessageBox.Show("Персонаж выбран!");
        }

        private void FirstCharS_Click(object sender, EventArgs e)
        {
            isFirstCharSSelected = true;
            MessageBox.Show("Персонаж выбран!");
        }

        private void SecondCharS_Click(object sender, EventArgs e)
        {
            isSecondCharSSelected = true;
            MessageBox.Show("Персонаж выбран!");
        }

        private void ThirdCharS_Click(object sender, EventArgs e)
        {
            isThirdCharSSelected = true;
            MessageBox.Show("Персонаж выбран!");
        }

        private void FourthCharS_Click(object sender, EventArgs e)
        {
            isFourthCharSSelected = true;
            MessageBox.Show("Персонаж выбран!");
        }
    }
}
