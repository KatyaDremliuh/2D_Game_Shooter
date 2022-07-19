using System;
using System.Drawing;
using System.Windows.Forms;

namespace _2D_Game_Shooter
{
    public partial class Form1 : Form
    {
        private PictureBox[] _clouds;
        private int _backgroundSpeed;
        private Random _random;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
    }
}