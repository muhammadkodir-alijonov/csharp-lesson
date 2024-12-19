using abstarct_class.Models;
using System;

namespace abstarct_class
{
    public class Program
    {
        static void Main(string[] args)
        {
            Shape[] shape = new Shape[2];
            shape[0] = new Triange();
            shape[1] = new Rectangle();

            foreach (var shapes in shape) 
            {
                shapes.Draw();
            }

        }
    }
}