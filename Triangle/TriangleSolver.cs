using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class TriangleSolver
    {

        public static string Analyze(int Tside1, int Tside2, int Tside3)
        {

            String triangleType = "";

            if (Tside1 > 0 && Tside2 > 0 && Tside3 > 0) //ALL SIDES SHOULD BE GREATER THAN 0
            {
                
                //CHECK IF TRAINGLE IS VALID
                if (Tside1 + Tside2 > Tside3
                    && Tside3 + Tside1 > Tside2
                    && Tside2 + Tside3 > Tside1)
                {
                    if (Tside1 == Tside2 && Tside2 == Tside3) //EQUILATERAL TRIANGLE
                    {
                        triangleType = "EQUILATERAL TRIANGLE";
                    }
                    else if (Tside1 == Tside2 || Tside2 == Tside3 || Tside3 == Tside1) //ISOCELES TRIANGLE
                    {
                        triangleType = "ISOCELES TRIANGLE";
                    }
                    else //SCALENE TRIANGLE
                    {
                        triangleType = "SCALENE TRIANGLE";
                    }
                }
            }else //INVALID TRIANGLE
            {
                triangleType = "INVALID TRIANGLE";
            }

            //RETURN TRIANG
            return triangleType;
        }
    }
}
