namespace BallApp {
    public partial class Form1 : Form {
        Obj Ball;  
        PictureBox pb;
        //コンストラクタ
        public Form1() {
            InitializeComponent();


        }

        //フォームが最初にロードされるとき一度だけ実行される
        private void Form1_Load(object sender, EventArgs e) {

        }

        private void timer1_Tick(object sender, EventArgs e) {
            
                Ball.Move();
            pb.Location = new Point((int)Ball.PosX, (int)Ball.PosY);

            
        }
       

            private void Form1_MouseClick(object sender, MouseEventArgs e) {
            //サッカーボール出現
            
                pb = new PictureBox();// 画像を表示するコントロール


            if (e.Button == MouseButtons.Left) {
                Ball = new SoccerBall(e.X, e.Y);
                pb.Size = new Size(50, 50);


            } else if (e.Button == MouseButtons.Right) {     //テニスボール出現
               
                Ball = new TennisBall(e.Location.X, e.Location.Y);
                pb.Size = new Size(30, 30);
            }
               

                pb.Image = Ball.Image;
                pb.Location = new Point((int)Ball.PosX, (int)Ball.PosY);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Parent = this;
                timer1.Start();
            }
        }

    }

