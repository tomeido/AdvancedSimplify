using System;
using System.Linq;
using SharpDX;
using System.Collections.Generic;

namespace HelixPlayground
{
    
    public partial class MainWindow
    {
        List<Vector3> p = new List<Vector3>();
        List<Vector3> OutPt = new List<Vector3>();

        public List<Vector3> SelfTrim(List<Vector3> x)
        {

            OutPt = new List<Vector3>();
            
            p = x;
            int N = x.Count - 2;

            Vector3 selfTrimmedPtA = new Vector3();
            Vector3 selfTrimmedPtB = new Vector3();
            Vector3 selfTrimmedPtC = new Vector3();

            for (int i = 0; i < N; i++)
            {
                Vector3 aPt = p[i];
                Vector3 bPt = p[i + 1];
                Vector3 cPt = p[i + 2];

                float aPtX = p[i].X;
                float aPtY = p[i].Y;
                float aPtZ = p[i].Z;
                float bPtX = p[i + 1].X;
                float bPtY = p[i + 1].Y;
                float bPtZ = p[i + 1].Z;
                float cPtX = p[i + 2].X;
                float cPtY = p[i + 2].Y;
                float cPtZ = p[i + 2].Z;

                if (i == N - 2)
                {
                    if ((aPtX == bPtX && bPtX == cPtX && aPtY == bPtY && bPtY == cPtY)
                      || (aPtY == bPtY && bPtY == cPtY && aPtZ == bPtZ && bPtZ == cPtZ)
                      || (aPtZ == bPtZ && bPtZ == cPtZ && aPtX == bPtX && bPtX == cPtX))
                    {
                        Vector3 dPt = p[i + 3];

                        selfTrimmedPtA = new Vector3(aPtX, aPtY, aPtZ);
                        selfTrimmedPtC = new Vector3(cPtX, cPtY, cPtZ);

                        OutPt.Add(selfTrimmedPtA);
                        OutPt.Add(selfTrimmedPtC);
                        OutPt.Add(dPt);

                        i++;
                    }
                    else
                    {
                        selfTrimmedPtA = new Vector3(aPtX, aPtY, aPtZ);

                        OutPt.Add(selfTrimmedPtA);
                    }
                }
                else
                {
                    if (i == N - 1)
                    {
                        if ((aPtX == bPtX && bPtX == cPtX && aPtY == bPtY && bPtY == cPtY)
                          || (aPtY == bPtY && bPtY == cPtY && aPtZ == bPtZ && bPtZ == cPtZ)
                          || (aPtZ == bPtZ && bPtZ == cPtZ && aPtX == bPtX && bPtX == cPtX))
                        {
                            selfTrimmedPtA = new Vector3(aPtX, aPtY, aPtZ);
                            selfTrimmedPtC = new Vector3(cPtX, cPtY, cPtZ);

                            OutPt.Add(selfTrimmedPtA);
                            OutPt.Add(selfTrimmedPtC);
                        }
                        else
                        {
                            selfTrimmedPtA = new Vector3(aPtX, aPtY, aPtZ);
                            selfTrimmedPtB = new Vector3(bPtX, bPtY, bPtZ);
                            selfTrimmedPtC = new Vector3(cPtX, cPtY, cPtZ);

                            OutPt.Add(selfTrimmedPtA);
                            OutPt.Add(selfTrimmedPtB);
                            OutPt.Add(selfTrimmedPtC);
                        }

                    }
                    else
                    {
                        if ((aPtX == bPtX && bPtX == cPtX && aPtY == bPtY && bPtY == cPtY)
                          || (aPtY == bPtY && bPtY == cPtY && aPtZ == bPtZ && bPtZ == cPtZ)
                          || (aPtZ == bPtZ && bPtZ == cPtZ && aPtX == bPtX && bPtX == cPtX))
                        {
                            selfTrimmedPtA = new Vector3(aPtX, aPtY, aPtZ);

                            OutPt.Add(selfTrimmedPtA);

                            i++;
                        }
                        else
                        {
                            selfTrimmedPtA = new Vector3(aPtX, aPtY, aPtZ);

                            OutPt.Add(selfTrimmedPtA);
                        }
                    }
                }
            }
            x = OutPt;
            originalPolyline = x;
            return x;
        }
    }
}
