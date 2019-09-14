using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing
{
    public class Field
    {
        private RoadBorder roadBorder;

        private MyCar myCar;

        private OtherCar otherCar;

        public Key key { get; set; }

        public Field()
        {
           
            Initialize();
            
            Move();
            
        }

        public void Move()
        {
            Task[] tasks = new Task[2];
            tasks[0] = Task.Factory.StartNew(this.roadBorder.Move);
            tasks[1] = Task.Factory.StartNew(this.key.StartReadKey);

            Task.WaitAll(tasks);
            
           
            //this.otherCar.Move(MoveDirection.Down);
        }

        private void Initialize()
        {
            this.roadBorder = new RoadBorder();
            this.myCar = new MyCar('8');
            this.myCar.Draw();
            this.otherCar = new OtherCar('$');
            this.key = new Key();
            this.key.KeyPressEvent += KeyPressEventHandler;
        }

        private void KeyPressEventHandler(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyInfo.Key == ConsoleKey.LeftArrow) || (e.KeyInfo.Key == ConsoleKey.RightArrow))
            {
                this.myCar.Move(e.KeyInfo);
            }

        }
    }
}
