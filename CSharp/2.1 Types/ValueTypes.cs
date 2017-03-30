using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._2._1_Types
{
    class ValueTypes
    {
        public static void Run()
        {
            //Value types are stored on the stack, does not require garbage collector

            //A custom value type should be

            //1. Smalle
            //2. Imutable
            //3 There are lots of objects (used a lot)
            //4. YOu cannot inherit from a struct

            //Value  types in herit from System.ValueType - but we must use Struct keywork

            Point3d point = new Point3d(1, 2, 3);

            //A new copy is created in memory
            Point3d point2 = point;
            point2.x = 29;

            //Point 1 remains the same
            Console.WriteLine(point.x);
        }

       
    }

    public struct Point3d
    {
        public int x, y, z;

        public Point3d(int p1, int p2, int p3)
        {
            x = p1;
            y = p2;
            z = p2;
        }

    }
}
