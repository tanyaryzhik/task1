using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing
{
    public class Renderer
    {
        public Field Field { get; set; }
        public Renderer()
        {
            this.Field = new Field();
            Console.WindowHeight = Field.Heigth;
            Console.WindowWidth = Field.Width;
        }
        public void Render()
        {
            foreach (var item in this.Field.)
            {

            }
        }
    }
}
