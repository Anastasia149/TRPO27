using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ТРПО27
{
    public partial class Form2 : Form
    {
        private Form1 form1Instance;
        PictureBox[] platformsLeft;
        PictureBox[] platformsRight;
        int jumpPower1 = 50;
        int jumpPower2 = 50;
        string horizontalD1 = "stay";
        string horizontalD2 = "stay";
        int scores1 = 0;
        int scores2 = 0;
        Label scoreLabel1, scoreLabel2;
        Label waitingLabel1, waitingLabel2; // Labels for waiting messages
        bool gameOver = false;
        bool gameStarted = false;
        Label countdownLabel;
        Timer countdownTimer;
        int countdownValue = 3;
        Timer timer1, timer3;
        public PictureBox doodle1, doodle2;
        Panel boundary;
        Random rand = new Random();
        int platformHeight = 20;
        int platformWidth = 130;



        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (gameOver || !canMove) return; // Проверяем, можно ли двигаться

            if (e.KeyCode == Keys.A || e.KeyCode == Keys.D) horizontalD1 = "stay";
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right) horizontalD2 = "stay";
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (gameOver || !canMove) return; // Проверяем, можно ли двигаться

            if (e.KeyCode == Keys.A) horizontalD1 = "left";
            else if (e.KeyCode == Keys.D) horizontalD1 = "right";

            if (e.KeyCode == Keys.Left) horizontalD2 = "left";
            else if (e.KeyCode == Keys.Right) horizontalD2 = "right";
        }
        int platformCount = 10;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            form1Instance = form1;
            InitializeGame();
        }

        private void InitializeGame()
        {
            this.WindowState = FormWindowState.Maximized; // Полноэкранный режим
            this.Text = "Jump";
            this.DoubleBuffered = true;
            this.BackgroundImage = form1Instance.BackgroundImage;

            // Разделяющая граница
            boundary = new Panel
            {
                Size = new Size(4, this.ClientSize.Height),
                Location = new Point(this.ClientSize.Width / 2 - 5, 0),
                BackColor = Color.Black
            };
            this.Controls.Add(boundary);

            // Инициализация платформ
            platformsLeft = new PictureBox[platformCount];
            platformsRight = new PictureBox[platformCount];

            // Разделение платформ для левого и правого игроков
            CreatePlatforms(platformsLeft, 10, this.ClientSize.Width / 2 - platformWidth - 10, Color.Green, true);
            CreatePlatforms(platformsRight, this.ClientSize.Width / 2 + 10, this.ClientSize.Width - platformWidth - 10, Color.Red, false);

            // Создание персонажей
            doodle1 = new PictureBox
            {
                Size = new Size(70, 70),
                SizeMode = PictureBoxSizeMode.StretchImage,
            };

            if (form1Instance.isFirstCharSelected)
            {
                doodle1.Image = form1Instance.FirstCharF.Image;
            }
            else
            {
                doodle1.Image = form1Instance.FirstCharF.Image; 
            }
            if (form1Instance.isSecondCharSelected)
            {
                doodle1.Image = form1Instance.SecondCharF.Image;
            }
            else
            {
                doodle1.Image = form1Instance.FirstCharF.Image; 
            }
            if (form1Instance.isThirdCharSelected)
            {
                doodle1.Image = form1Instance.ThirdCharF.Image;
            }
            else
            {
                doodle1.Image = form1Instance.FirstCharF.Image;
            }
            if (form1Instance.isFourthCharSelected)
            {
                doodle1.Image = form1Instance.FourthCharF.Image;
            }
            else
            {
                doodle1.Image = form1Instance.FirstCharF.Image;
            }

            doodle1.Location = new Point(platformsLeft[platformCount - 1].Left + (platformWidth - doodle1.Width) / 2, platformsLeft[platformCount - 1].Top - doodle1.Height);
            this.Controls.Add(doodle1);

            doodle2 = new PictureBox
            {
                Size = new Size(70, 70),
                SizeMode = PictureBoxSizeMode.StretchImage,
            };

            if (form1Instance.isFirstCharSSelected)
            {
                doodle2.Image = form1Instance.FirstCharS.Image;
            }
            else
            {
                doodle2.Image = form1Instance.FirstCharS.Image;
            }
            if (form1Instance.isSecondCharSSelected)
            {
                doodle2.Image = form1Instance.SecondCharS.Image;
            }
            else
            {
                doodle2.Image = form1Instance.FirstCharS.Image;
            }
            if (form1Instance.isThirdCharSSelected)
            {
                doodle2.Image = form1Instance.ThirdCharS.Image;
            }
            else
            {

                doodle2.Image = form1Instance.FirstCharS.Image;
            }
            if (form1Instance.isFourthCharSSelected)
            {
                doodle2.Image = form1Instance.FourthCharS.Image;
            }
            else
            {
                doodle2.Image = form1Instance.FirstCharS.Image;
            }

            doodle2.Location = new Point(platformsRight[platformCount - 1].Left + (platformWidth - doodle2.Width) / 2, platformsRight[platformCount - 1].Top - doodle2.Height);
            this.Controls.Add(doodle2);

            // Метки для счета
            scoreLabel1 = new Label
            {
                Text = "Счет: 0",
                Font = new Font("Impact", 14, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true,
                ForeColor = Color.Black
            };
            this.Controls.Add(scoreLabel1);
            scoreLabel1.BringToFront(); // Перемещаем метку на передний план

            scoreLabel2 = new Label
            {
                Text = "Счет: 0",
                Font = new Font("Impact", 14, FontStyle.Bold),
                Location = new Point(this.ClientSize.Width - 100, 10),
                AutoSize = true,
                ForeColor = Color.Black
            };
            this.Controls.Add(scoreLabel2);
            scoreLabel2.BringToFront(); // Перемещаем метку на передний план

            // Создание метки для отсчета
            countdownLabel = new Label
            {
                Font = new Font("Impact", 150, FontStyle.Bold), // Измените шрифт на Impact
                Dock = DockStyle.Fill, // Заполнение всей формы
                TextAlign = ContentAlignment.MiddleCenter, // Выравнивание по центру
                ForeColor = Color.Black,
                BackColor = Color.LightBlue // Добавлено для лучшей видимости
            };
            this.Controls.Add(countdownLabel);

            // Таймер для отсчета
            countdownTimer = new Timer { Interval = 1000 }; // Каждую секунду
            countdownTimer.Tick += CountdownTimer_Tick;

            // Запуск отсчета
            countdownTimer.Start();
            UpdateCountdown();

            // Обработчики событий
            this.KeyDown += Form2_KeyDown;
            this.KeyUp += Form2_KeyUp;
            this.Resize += GameForm_Resize;
        }

        Timer startLabelTimer; // Таймер для удаления метки "Старт" через 2 секунды
        bool canMove = false; // Новый флаг для контроля движения

        // Дополнительные переменные для анимации
        float countdownFontSize = 150f; // Начальный размер шрифта
        float countdownFontTargetSize = 200f; // Целевой размер шрифта для увеличения
        float countdownFontIncrement = 5f; // Шаг изменения размера шрифта
        Timer fontAnimationTimer;

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            if (countdownValue == 0)
            {
                countdownLabel.Text = "Старт!";
                countdownTimer.Stop();

                gameStarted = true; // Игра начинается
                StartGame(); // Запуск основной логики игры (таймеры, прыжки)

                // Запускаем анимацию для слова "Старт"
                countdownFontSize = 150f;
                countdownFontTargetSize = 250f; // Увеличиваем размер для слова "Старт"
                StartFontAnimation();

                // Таймер для удаления слова "Старт" через 1.7 секунды
                Timer startLabelTimer = new Timer { Interval = 1700 };
                startLabelTimer.Tick += (s, ev) =>
                {
                    countdownLabel.Text = "";
                    startLabelTimer.Stop(); // Останавливаем таймер
                };
                startLabelTimer.Start();

                // Таймер для запуска игры после удаления слова "Старт"
                Timer startGameTimer = new Timer { Interval = 2000 }; // 2 секунды
                startGameTimer.Tick += (s, ev) =>
                {
                    startGameTimer.Stop();
                    canMove = true; // Разрешаем управление
                };
                startGameTimer.Start();
            }
            else
            {
                // Анимация для чисел отсчета
                countdownFontSize = 150f;
                countdownFontTargetSize = 200f; // Увеличиваем до 200
                StartFontAnimation();
                UpdateCountdown();
            }
        }

        private void StartFontAnimation()
        {

            if (fontAnimationTimer == null)
            {
                fontAnimationTimer = new Timer { Interval = 50 }; // Обновляем размер шрифта каждые 50 мс
                fontAnimationTimer.Tick += FontAnimationTimer_Tick;
            }
            fontAnimationTimer.Start();
        }

        private void FontAnimationTimer_Tick(object sender, EventArgs e)
        {
            if (countdownFontSize < countdownFontTargetSize)
            {
                countdownFontSize += countdownFontIncrement; // Увеличиваем размер шрифта
            }
            else
            {
                // Останавливаем анимацию, если достигнут целевой размер
                fontAnimationTimer.Stop();
            }

            // Обновляем размер шрифта на метке
            countdownLabel.Font = new Font("Impact", countdownFontSize, FontStyle.Bold);
        }

        private void StartLabelTimer_Tick(object sender, EventArgs e)
        {
            countdownLabel.Text = "";
            startLabelTimer.Stop();
        }

        private void UpdateCountdown()
        {
            countdownLabel.Text = countdownValue.ToString();
            countdownValue--;
            // Начинаем анимацию шрифта для каждого обновленного числа
            StartFontAnimation();
        }
        private void StartGame()
        {
            // Запуск таймеров для игрового процесса
            timer1 = new Timer { Interval = 20 };
            timer1.Tick += Timer1_Tick;
            timer3 = new Timer { Interval = 20 };
            timer3.Tick += Timer3_Tick;

            timer1.Start();
            timer3.Start();
        }
        private void ShowWaitingMessageForPlayer1()
        {
            timer1.Stop();
            waitingLabel1 = new Label
            {
                Text = "Ожидание...",
                Font = new Font("Impact", 36, FontStyle.Bold),
                AutoSize = true,
                ForeColor = Color.Black,
            };

            // Центрирование лейбла по центру экрана
            waitingLabel1.Location = new Point(
                (this.ClientSize.Width - waitingLabel1.Width) / 2 - 500,
                (this.ClientSize.Height - waitingLabel1.Height) / 2
            );

            this.Controls.Add(waitingLabel1);
            waitingLabel1.BringToFront();
        }

        private void ShowWaitingMessageForPlayer2()
        {
            timer3.Stop();
            waitingLabel2 = new Label
            {
                Text = "Ожидание...",
                Font = new Font("Impact", 36, FontStyle.Bold),
                AutoSize = true,
                ForeColor = Color.Black,
            };

            // Центрирование лейбла по центру экрана
            waitingLabel2.Location = new Point(
                (this.ClientSize.Width - waitingLabel2.Width) / 2 + 300,
                (this.ClientSize.Height - waitingLabel2.Height) / 2
            );

            this.Controls.Add(waitingLabel2);
            waitingLabel2.BringToFront();
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            if (gameOver) return;

            doodle2.Top -= jumpPower2;
            if (jumpPower2 > -15) jumpPower2--;

            if (doodle2.Top >= this.ClientSize.Height)
            {
                if (scores2 + 1 > scores1)
                {
                    ShowWaitingMessageForPlayer2();
                    if (doodle1.Top >= this.ClientSize.Height)
                    {
                        if (scores2 + 1 > scores1)
                        {
                            GameOver("Игрок 2 победил!");
                        }
                        else
                        {
                            GameOver("Игрок 1 победил!");
                        }

                    }
                }
                else
                {
                    GameOver("Игрок 1 победил!");
                }

            }


            // Логика столкновений с платформами
            bool onPlatform = false;
            foreach (var platform in platformsRight)
            {
                if (jumpPower2 < 0 && doodle2.Bounds.IntersectsWith(platform.Bounds))
                {
                    doodle2.Top = platform.Top - doodle2.Height;
                    jumpPower2 = 15;
                    onPlatform = true;
                    break;
                }
            }

            if (!onPlatform && doodle2.Top < this.ClientSize.Height / 2)
            {
                // Перемещаем платформы вниз
                foreach (var platform in platformsRight)
                {
                    platform.Top += 5;
                    if (platform.Top > this.ClientSize.Height)
                    {
                        platform.Top = -platformHeight;
                        platform.Left = rand.Next(this.ClientSize.Width / 2 + 10, this.ClientSize.Width - platformWidth - 10);
                        scores2++;
                        scoreLabel2.Text = "Счет: " + scores2;
                    }
                }
                // Перемещаем персонажа вниз
                doodle2.Top += 5;
            }

            // Горизонтальное перемещение
            if (horizontalD2 == "left") doodle2.Left -= 10;
            if (horizontalD2 == "right") doodle2.Left += 10;





            if (doodle2.Left + 51 > this.ClientSize.Width - doodle2.Width)  // Если персонаж выходит за правую границу экрана
            {
                doodle2.Left = this.ClientSize.Width / 2;  // Перемещаем к левой границе правой половины
            }

            if (doodle2.Right - 45 < this.ClientSize.Width / 2)  // Если персонаж пересекает центральную границу
            {
                doodle2.Left = this.ClientSize.Width - doodle2.Width - 50;  // Перемещаем к правому краю формы
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (gameOver) return;

            doodle1.Top -= jumpPower1;
            if (jumpPower1 > -15) jumpPower1--;

            if (doodle1.Top >= this.ClientSize.Height)
            {
                if (scores1 + 1 > scores2)
                {
                    ShowWaitingMessageForPlayer1();
                    if (doodle2.Top >= this.ClientSize.Height)
                    {
                        if (scores2 + 1 > scores1)
                        {
                            GameOver("Игрок 2 победил!");
                        }
                        else
                        {
                            GameOver("Игрок 1 победил!");
                        }
                    }
                }
                else
                {
                    GameOver("Игрок 2 победил!");
                }
            }

            // Логика столкновений с платформами
            bool onPlatform = false;
            foreach (var platform in platformsLeft)
            {
                if (jumpPower1 < 0 && doodle1.Bounds.IntersectsWith(platform.Bounds))
                {
                    doodle1.Top = platform.Top - doodle1.Height;
                    jumpPower1 = 15;
                    onPlatform = true;
                    break;
                }
            }

            if (!onPlatform && doodle1.Top < this.ClientSize.Height / 2)
            {
                // Перемещаем платформы вниз
                foreach (var platform in platformsLeft)
                {
                    platform.Top += 5;
                    if (platform.Top > this.ClientSize.Height)
                    {
                        platform.Top = -platformHeight;
                        platform.Left = rand.Next(10, this.ClientSize.Width / 2 - platformWidth - 10);
                        scores1++;
                        scoreLabel1.Text = "Счет: " + scores1;
                    }
                }
                // Перемещаем персонажа вниз
                doodle1.Top += 5;
            }

            // Горизонтальное перемещение
            if (horizontalD1 == "left") doodle1.Left -= 10;
            if (horizontalD1 == "right") doodle1.Left += 10;


            if (doodle1.Right - 51 < 0)  // Если персонаж выходит за левую границу экрана
            {
                doodle1.Left = this.ClientSize.Width / 2 - doodle1.Width;  // Перемещаем к правой границе левой половины
            }

            if (doodle1.Left + 45 > this.ClientSize.Width / 2)  // Если персонаж пересекает центральную границу
            {
                doodle1.Left = 0;  // Перемещаем к левому краю формы
            }

        }
        private void CreatePlatforms(PictureBox[] platforms, int minX, int maxX, Color color, bool isLeftSide)
        {
            int screenHeight = this.ClientSize.Height;
            int previousPlatformY = screenHeight + 800;

            for (int i = platforms.Length - 1; i >= 0; i--)
            {
                platforms[i] = new PictureBox
                {
                    Size = new Size(platformWidth, platformHeight),
                    BackColor = color,
                };

                // Позиция по вертикали (равномерно распределяем платформы)
                previousPlatformY -= rand.Next(80, 120);
                platforms[i].Top = previousPlatformY;

                // Генерация положения по горизонтали
                if (isLeftSide)
                {
                    // Позиции для левых платформ (границы левой части экрана)
                    platforms[i].Left = rand.Next(10, this.ClientSize.Width / 2 - platformWidth - 10);
                }
                else
                {
                    // Позиции для правых платформ (границы правой части экрана)
                    platforms[i].Left = rand.Next(this.ClientSize.Width / 2 + 1150, this.ClientSize.Width - platformWidth - 10 + 1150);
                }

                // Добавляем платформу на форму
                this.Controls.Add(platforms[i]);
            }
        }

        public int FinalScore1 { get; private set; }
        public int FinalScore2 { get; private set; }
        private void GameOver(string winnerMessage)
        {
            gameOver = true;
            timer1.Stop();
            timer3.Stop();
            MessageBox.Show(winnerMessage, "Игра окончена", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FinalScore1 = scores1;
            FinalScore2 = scores2;

            this.DialogResult = DialogResult.OK; // Указываем, что игра завершена успешно
            this.Close();
        }

        private void GameForm_Resize(object sender, EventArgs e)
        {
            // Обновляем расположение центральной границы и счетчиков при изменении размера формы
            boundary.Height = this.ClientSize.Height;
            boundary.Location = new Point(this.ClientSize.Width / 2 - boundary.Width / 2, 0);

            scoreLabel2.Location = new Point(this.ClientSize.Width - 100, 10);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        
    }
}
