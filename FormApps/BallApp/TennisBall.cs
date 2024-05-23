using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {

    internal class TennisBall : Obj {
        Random random = new Random();   //乱数インスタンス

        public static int Count { get; set; }

        public TennisBall(double xp, double yp)
                : base(xp,yp, @"Properties\Picture\tennis_ball.png") {


            MoveX = random.Next(-15, 15); //移動量設定
            MoveY = random.Next(-15, 15);

            Count++;
        }

        //戻り値:0…移動OK,1…落下,2…バーに当たった
        public override int Move(PictureBox pbBar, PictureBox pbBall) {
            int ret = 0;

            Rectangle rBar = new Rectangle(pbBar.Location.X, pbBar.Location.Y,
                pbBar.Width, pbBar.Height);

            Rectangle rBall = new Rectangle(pbBall.Location.X, pbBall.Location.Y,
                pbBall.Width, pbBall.Height);

            if (PosX > 750 || PosX < 0) {
                MoveX = -MoveX;
            }

            if (PosY < 0) {
                MoveY = -MoveY;
            }

            //バーの当たり判定
            if (rBar.IntersectsWith(rBall)) {
                MoveY = -MoveY;

                ret = 2;
            }

            PosX += MoveX;
            PosY += MoveY;

            //落下
            if (PosY > 500)
                ret = 1;



            //移動完了
            return ret;
        }
        public override bool Move(Keys direction) {
            return true;
        }
    }
}