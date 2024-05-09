using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    internal class SoccerBall : Obj {
        Random random = new Random();
        

        public static int Count { get; set; }
      public SoccerBall(double xp, double yp)
            : base(xp -25, yp-25, @"Picture\soccer_ball.png") {
           
            MoveX =  random.Next(-25,30); ;//移動量設定
            MoveY = random.Next(-25, 30);

            Count++;
        }

        public override bool Move() {
            if(PosX > 750 || PosX < 0) {
                MoveX = -MoveX;
            }
            if (PosY > 500 || PosY < 0) {
                MoveY = -MoveY;
            }
            



            PosX += MoveX;
            PosY += MoveY;

            return true;
        
        }

        public override bool Move(Keys direction) {
            return true;
        }
    }
}
