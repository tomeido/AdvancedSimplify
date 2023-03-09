using System;
using System.Linq;
using SharpDX;
using System.Collections.Generic;

namespace HelixPlayground
{
    public partial class MainWindow
    {
        List<Vector3> originalPolyline = new List<Vector3>();
        List<Vector3> continuitedPolyline = new List<Vector3>();

        public List<Vector3> Discontinuity(List<Vector3> originalPolylineVectors)
        {
            originalPolyline = originalPolylineVectors;
            
            continuitedPolyline.Add(originalPolyline[0]);

            for(int i = 1; i < originalPolyline.Count()-1; i++)
            {
                //continuitedPolyline.Add(originalPolyline[i]);
                if ((originalPolyline[i-1] - originalPolyline[i]).Length() 
                    + (originalPolyline[i] - originalPolyline[i+1]).Length()
                    != (originalPolyline[i-1] - originalPolyline[i + 1]).Length())
                {
                    continuitedPolyline.Add(originalPolyline[i]);
                }
            }

            continuitedPolyline.Add(originalPolyline[originalPolyline.Count()-1]);
            originalPolylineVectors = continuitedPolyline;
            return originalPolylineVectors;
        }



        public void InitoriginalPolyline()
        {
            originalPolyline.Add(new Vector3(-11f, -16f, 0f));
            originalPolyline.Add(new Vector3(-11f, -10f, 0f));
            originalPolyline.Add(new Vector3(-11f, -3f, 0f));
            originalPolyline.Add(new Vector3(-11f, 4f, 0f));
            originalPolyline.Add(new Vector3(-11f, 12f, 0f));
            originalPolyline.Add(new Vector3(-11f, 19f, 0f));
            originalPolyline.Add(new Vector3(9f, 19f, 0f));
            originalPolyline.Add(new Vector3(9f, 19f, 4f));
            originalPolyline.Add(new Vector3(9f, 19f, 7f));
            originalPolyline.Add(new Vector3(9f, 19f, 12f));
            originalPolyline.Add(new Vector3(9f, 19f, 17f));
            originalPolyline.Add(new Vector3(9f, -12f, 17f));
            originalPolyline.Add(new Vector3(9f, 5f, 17f));
            originalPolyline.Add(new Vector3(18f, 5f, 17f));
            originalPolyline.Add(new Vector3(18f, 5f, 22f));
            originalPolyline.Add(new Vector3(18f, 5f, 26f));
            originalPolyline.Add(new Vector3(18f, 5f, 31f));
            originalPolyline.Add(new Vector3(4f, 5f, 31f));
            originalPolyline.Add(new Vector3(-6f, 5f, 31f));
            originalPolyline.Add(new Vector3(-14f, 5f, 31f));
            originalPolyline.Add(new Vector3(-14f, 4f, 31f));
            originalPolyline.Add(new Vector3(-14f, 1f, 31f));
            originalPolyline.Add(new Vector3(-14f, -9f, 31f));
        }
    }
}


