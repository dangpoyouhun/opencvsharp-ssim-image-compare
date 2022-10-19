using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSIM_Image_Compare
{
    public class SSIMResult
    {
        public double score
        {
            get
            {
                return (mssim.Val0 + mssim.Val1 + mssim.Val2) / 3;
            }
        }
        public Scalar mssim;
        public Mat diff;
    }    
}
