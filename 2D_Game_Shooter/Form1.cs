using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;

namespace _2D_Game_Shooter
{
    public partial class Form1 : Form
    {
        private PictureBox[] _clouds;
        private int _backgroundSpeed;
        private Random _random;

        private const int PlayersSpeed = 1;

        private PictureBox[] _bullets; // патроны
        private int _bulletSpeed;

        private WindowsMediaPlayer _shootSound;
        private WindowsMediaPlayer _gameSound;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Clouds

            const int countOfClouds = 20;

            _backgroundSpeed = 5;
            _clouds = new PictureBox[countOfClouds];
            _random = new Random();

            for (int i = 0; i < _clouds.Length; i++)
            {
                _clouds[i] = new PictureBox()
                {
                    BorderStyle = BorderStyle.None,
                    Location = new Point(_random.Next(-1000, 1280), _random.Next(140, 320)),
                };

                if (i % 2 == 1)
                {
                    _clouds[i].Size = new Size(_random.Next(100, 255), _random.Next(30, 70));
                    _clouds[i].BackColor = Color.FromArgb(_random.Next(50, 125), red: 255, green: 200, blue: 200);
                }
                else
                {
                    _clouds[i].Size = new Size(150, 25);
                    _clouds[i].BackColor = Color.FromArgb(_random.Next(50, 125), red: 255, green: 205, blue: 205);
                }

                this.Controls.Add(_clouds[i]);
            }

            #endregion

            #region BulletsShooting

            int countOfShots = 1;
            _bullets = new PictureBox[countOfShots];
            _bulletSpeed = 80;

            for (int i = 0; i < _bullets.Length; i++)
            {
                _bullets[i] = new PictureBox();
                _bullets[i].BorderStyle = BorderStyle.None;
                _bullets[i].Size = new Size(20, 5);
                _bullets[i].BackColor = Color.GhostWhite;

                this.Controls.Add(_bullets[i]);
            }

            #endregion

            #region Sound

            _shootSound = new WindowsMediaPlayer
            {
                URL = "Sound\\ShootSound.wav",
                settings = { volume = 5, },
            };

            _gameSound = new WindowsMediaPlayer();
            _gameSound.URL = "Sound\\Kane_Brown_Like_I_Love_Country_Music.wav";
            _gameSound.settings.setMode("loop", true);
            _gameSound.settings.volume = 5;

            _gameSound.controls.play();

            #endregion
        }

        private void MoveBigTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < _clouds.Length; i++)
            {
                _clouds[i].Left += _backgroundSpeed;

                if (_clouds[i].Left >= this.Width) // Form1.Width = 1280
                {
                    _clouds[i].Left = _clouds[i].Height;
                }
            }

            for (int i = _clouds.Length; i < _clouds.Length; i++)
            {
                _clouds[i].Left += _backgroundSpeed - 10;

                if (_clouds[i].Left >= this.Width) // 1280
                {
                    _clouds[i].Left = _clouds[i].Left;
                }
            }
        }

        private void LeftMoveTimer_Tick(object sender, EventArgs e)
        {
            if (picBoxCowBoy.Left > 10)
            {
                picBoxCowBoy.Left -= PlayersSpeed;
            }
        }

        private void RightMoveTimer_Tick(object sender, EventArgs e)
        {
            if (picBoxCowBoy.Right < 1150)
            {
                picBoxCowBoy.Left += PlayersSpeed;
            }
        }

        private void UpMoveTimer_Tick(object sender, EventArgs e)
        {
            picBoxCowBoy.Top -= PlayersSpeed;
        }

        private void DownMoveTimer_Tick(object sender, EventArgs e)
        {
            picBoxCowBoy.Top += PlayersSpeed;
        }


        /// <summary>
        /// Когда нажимаем клавиши (стрелки): меняется стоящая картинка ковбоя на идущего ковбоя, и запускаются таймеры.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">нажатая клавиша</param>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            #region CowboyControl

            picBoxCowBoy.Image = Properties.Resources.Cowboy_Run;

            switch (e.KeyCode)
            {
                case Keys.Left:
                case Keys.A:
                    LeftMoveTimer.Start();
                    break;

                case Keys.Right:
                case Keys.D:
                    RightMoveTimer.Start();
                    break;

                case Keys.Up:
                case Keys.W:
                    UpMoveTimer.Start();
                    break;

                case Keys.Down:
                case Keys.S:
                    DownMoveTimer.Start();
                    break;
            }

            #endregion

            #region BulletsControl

            if (e.KeyCode == Keys.Space)
            {
                _shootSound.controls.play();

                for (int i = 0; i < _bullets.Length; i++)
                {
                    if (_bullets[i].Left > this.Width)
                    {
                        _bullets[i].Location = new Point(picBoxCowBoy.Location.X + 100 + i * 50, picBoxCowBoy.Location.Y + 50);
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// Когда отпускаем клавиши (стрелки): меняется идущая картинка ковбоя на стоящего ковбоя, и останавливаются все таймеры.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            picBoxCowBoy.Image = Properties.Resources.Cowboy_Static;

            LeftMoveTimer.Stop();
            RightMoveTimer.Stop();
            UpMoveTimer.Stop();
            DownMoveTimer.Stop();
        }

        private void MoveBulletsTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < _bullets.Length; i++)
            {
                _bullets[i].Left += _bulletSpeed; // придать ускорение пуле
            }
        }
    }
}