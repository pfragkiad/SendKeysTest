namespace SendKeysTest
{
    public partial class Form1
    {
        public readonly struct ColorPoint
        {
            /// <summary>
            /// X is in the range [0, 1]
            /// </summary>
            public float X { get; init; }

            /// <summary>
            /// Y is in the range [0, 1]
            /// </summary>
            public float Y { get; init; }   
            public Color Color { get; init; }

            public PointF ToPointF(System.Drawing.Size size)
            {
                return new PointF(X * size.Width, Y * size.Height);
            }
        }
    }
}
