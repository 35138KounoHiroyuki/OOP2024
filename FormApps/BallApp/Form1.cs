using System.Windows.Forms.ComponentModel.Com2Interop;

namespace BallApp {
    public partial class Form1 : Form {


        //���X�g�R���N�V����
        private List<Obj> balls = new List<Obj>();//�{�[���C���X�^���X�i�[�p
        private List<PictureBox> pbs = new List<PictureBox>();//�\���p


        //�΁[�p
        private Bar bar;
        private PictureBox pbBar;
        //�R���X�g���N�^
        public Form1() {
            InitializeComponent();


        }

        //�t�H�[�����ŏ��Ƀ��[�h�����Ƃ���x�������s�����
        private void Form1_Load(object sender, EventArgs e) {

            bar = new Bar(340, 500);
            pbBar = new PictureBox();

            pbBar.Image = bar.Image;
            pbBar.Size = new Size(150, 10);
            pbBar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBar.Parent = this;
        }

        private void timer1_Tick(object sender, EventArgs e) {
            // ball.Move();
            //pb.Location = new Point((int)ball.PosX, (int)ball.PosY);
            for (int i = 0; i < balls.Count; i++) {
                balls[i].Move(pbBar, pbs[i]);
                pbs[i].Location = new Point((int)balls[i].PosX, (int)balls[i].PosY);
            }
        }

        //�}�E�X�N���b�N�C�x���g�n���h��
        private void Form1_MouseClick(object sender, MouseEventArgs e) {
            PictureBox pb = new PictureBox(); // �摜��\������R���g���[��
            Obj ball = null;

            if (e.Button == MouseButtons.Left) {�@�@//�T�b�J�[�{�[���o��
                ball = new SoccerBall(e.X, e.Y);
                pb.Size = new Size(50, 50);


            } else if (e.Button == MouseButtons.Right) {     //�e�j�X�{�[���o��

                ball = new TennisBall(e.Location.X, e.Location.Y);
                pb.Size = new Size(30, 30);
            }


            pb.Image = ball.Image;
            pb.Location = new Point((int)ball.PosX, (int)ball.PosY);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Parent = this;
            timer1.Start();

            balls.Add(ball);
            pbs.Add(pb);

            this.Text = "BallApps SoccerBall:" + SoccerBall.Count + " TennisBall:" + TennisBall.Count;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) { 
                bar.Move(e.KeyCode);
            pbBar.Location = new Point((int)bar.PosX, (int)bar.PosY);


        }
       }
    }



