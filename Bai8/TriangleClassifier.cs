using System;
using System.Collections.Generic;
using System.Text;

namespace Bai8
{
    public class TriangleClassifier
    {
        public string TriangleTest(double side1, double side2, double side3)
        {
            if (side1 + side2 > side3
                && side1 + side3 > side2
                && side2 + side3 > side1)
            {
                if (side1 == side2
                    && side1 == side3
                    && side2 == side3)
                {
                    return "tam giac deu";
                }
                else if (side1 == side2
                    || side1 == side3
                    || side2 == side3)
                {
                    return "tam giac can";
                }
                return "tam giac thuong";

            }
            return "khong phai tam giac";
        }
    }
}
