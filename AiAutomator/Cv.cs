using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenCvSharp.Extensions;
using AiAutomator.Colors;
using Size = OpenCvSharp.Size;

namespace AiAutomator;

public static class Cv
{
    public static Mat ToOpenCvMat(this Bitmap bitmap) => BitmapConverter.ToMat(bitmap);

    public static Bitmap ToBitmap(this Mat mat) => BitmapConverter.ToBitmap(mat);


    public static Bitmap GetMask(this Bitmap image, Color from, Color to)
    {
        Mat matSource = BitmapConverter.ToMat(image);

        Mat matHsv = new();
        Cv2.CvtColor(matSource,matHsv, ColorConversionCodes.BGR2HSV);

        Scalar cvFrom = from.ToCvHsv();
        Scalar cvTo = to.ToCvHsv();

        Scalar cvLower2 = new(Math.Min(cvFrom.Val0,cvTo.Val0),
            Math.Min(cvFrom.Val1, cvTo.Val1),
            Math.Min(cvFrom.Val2, cvTo.Val2));

        Scalar cvUpper2 = new(Math.Max(cvFrom.Val0, cvTo.Val0),
                       Math.Max(cvFrom.Val1, cvTo.Val1),
                                  Math.Max(cvFrom.Val2, cvTo.Val2));

        //Scalar cvLower = new Scalar(0, 110, 121);
        //Scalar cvUpper = new Scalar(3, 255, 255);


        Mat matMask = new();
        Cv2.InRange(matHsv, cvLower2, cvUpper2, matMask);

        //var kernel =Mat.Ones(rows:5,5, MatType.CV_8U);
        var kernel = Cv2.GetStructuringElement(MorphShapes.Rect, new Size(5, 5));

        //Cv2.MorphologyEx(matMask, matMask, MorphTypes.Open,kernel);

        return BitmapConverter.ToBitmap(matMask);
        //return GetMask(mat, cvLower, cvUpper).ToBitmap();
    }

   


    public static Mat GetMask(Mat mat, Scalar lower, Scalar upper)
    {
        Mat mask = new Mat();
        Cv2.InRange(mat, lower, upper, mask);

        return mask;
    }
}
