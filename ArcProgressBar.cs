using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;

namespace ZOYI
{
    public class ArcProgressBar : Control
    {
        #region Enums

        public enum _ProgressShape
        {
            Round,
            Flat
        }

        public enum _TextMode
        {
            None,
            Value,
            Percentage,
            Custom
        }

        #endregion

        #region Private Variables

        private float _Value;
        private float _MaximumTick = 100;
        private long _MajorThicksCount = 10;
        private int _LineWidth = 1;
        private float _BarWidth = 14f;

        private Color _ProgressColor1 = Color.Orange;
        private Color _ProgressColor2 = Color.Orange;
        private Color _LineColor = Color.Silver;
        private LinearGradientMode _BarGradientMode = LinearGradientMode.ForwardDiagonal;
        private _ProgressShape ProgressShapeVal;
        private _TextMode ProgressTextMode;

        #endregion

        #region Constructor

        public ArcProgressBar()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.Opaque, true);
            this.BackColor = Color.Transparent;
            this.ForeColor = Color.DimGray;

            this.Size = new Size(130, 50);
            this.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.MinimumSize = new Size(100, 40);
            this.DoubleBuffered = true;

            this.LineWidth = 1;
            this.LineColor = Color.DimGray;

            Value = 57;
            ProgressShape = _ProgressShape.Flat;
            TextMode = _TextMode.None;
        }

        #endregion

        #region Public Custom Properties

        /// <summary>Determines the Progress Bar Value</summary>
        [Description("Integer value that determines the position of the Progress Bar."), Category("Behavior")]
        public float Value
        {
            get { return _Value; }
            set
            {
                _Value = value;
                Invalidate();
            }
        }

        [Description("Gets or sets the MaximumTick Value of the progress bar."), Category("Behavior")]
        public float MaximumTick
        {
            get { return _MaximumTick; }
            set
            {
                if (value < 1)
                    value = 1;
                _MaximumTick = value;
                Invalidate();
            }
        }

        [Description("Gets or sets the Major ticks of the progress bar."), Category("Behavior")]
        public long MajorThicksCount
        {
            get { return _MajorThicksCount; }
            set
            {
                if (value < 5)
                    value = 5;
                _MajorThicksCount = value;
                Invalidate();
            }
        }

        [Description("Starting Color of the Progress Bar"), Category("Appearance")]
        public Color BarColor1
        {
            get { return _ProgressColor1; }
            set
            {
                _ProgressColor1 = value;
                Invalidate();
            }
        }

        [Description("Ending Color of the Progress Bar"), Category("Appearance")]
        public Color BarColor2
        {
            get { return _ProgressColor2; }
            set
            {
                _ProgressColor2 = value;
                Invalidate();
            }
        }

        [Description("Width of the Progress Bar"), Category("Appearance")]
        public float BarWidth
        {
            get { return _BarWidth; }
            set
            {
                _BarWidth = value;
                Invalidate();
            }
        }

        [Description("Color Gradient Mode"), Category("Appearance")]
        public LinearGradientMode BarGradientMode
        {
            get { return _BarGradientMode; }
            set
            {
                _BarGradientMode = value;
                Invalidate();
            }
        }

        [Description("Color of the Middle Line"), Category("Appearance")]
        public Color LineColor
        {
            get { return _LineColor; }
            set
            {
                _LineColor = value;
                Invalidate();
            }
        }

        [Description("Width of the Middle Line"), Category("Appearance")]
        public int LineWidth
        {
            get { return _LineWidth; }
            set
            {
                _LineWidth = value;
                Invalidate();
            }
        }

        [Description("Gets or sets the shape of the progress bar ends."), Category("Appearance")]
        public _ProgressShape ProgressShape
        {
            get { return ProgressShapeVal; }
            set
            {
                ProgressShapeVal = value;
                Invalidate();
            }
        }

        [Description("Gets or sets how the text is displayed inside the progress bar."), Category("Behavior")]
        public _TextMode TextMode
        {
            get { return ProgressTextMode; }
            set
            {
                ProgressTextMode = value;
                Invalidate();
            }
        }

        [Description("Gets the text displayed inside the Control"), Category("Behavior")]
        public override string Text { get; set; }

        #endregion

        #region EventArgs

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SetStandardSize();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            SetStandardSize();
        }

        protected override void OnPaintBackground(PaintEventArgs p)
        {
            base.OnPaintBackground(p);
        }

        #endregion

        #region Methods

        private void SetStandardSize()
        {
            int _Size = Math.Max(Width, Height);
            Size = new Size(Width, Height);
        }

        public void Increment(int Val)
        {
            this._Value += Val;
            Invalidate();
        }

        public void Decrement(int Val)
        {
            this._Value -= Val;
            Invalidate();
        }
        #endregion

        #region Events

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Bitmap bitmap = new Bitmap(this.Width, this.Height))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
                    graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                    graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                    graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                    PaintTransparentBackground(this, e);

                    // Draw the Progress Bar and the ticks (marks) behind the progress bar
                    DrawTicks(graphics, this.Value);


                    #region Draw Progress Text
                    if (TextMode == _TextMode.Percentage)
                    {
                        string percentageText = Convert.ToString(Convert.ToInt32((100 / _MaximumTick) * _Value)) + "%";
                        using (Brush FontColor = new SolidBrush(this.ForeColor))
                        {
                            SizeF MS = graphics.MeasureString(percentageText, this.Font);
                            SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(100, this.ForeColor));

                            // Text Shadow:
                            graphics.DrawString(percentageText, this.Font, shadowBrush,
                                Convert.ToInt32(Width / 2 - MS.Width / 2) + 2,
                                Convert.ToInt32(Height / 2 - MS.Height / 2) + 2
                            );

                            // Control Text:
                            graphics.DrawString(percentageText, this.Font, FontColor,
                                Convert.ToInt32(Width / 2 - MS.Width / 2),
                                Convert.ToInt32(Height / 2 - MS.Height / 2));
                        }
                    }
                    #endregion

                    //This is where the entire Control is drawn:
                    e.Graphics.DrawImage(bitmap, 0, 0);
                    graphics.Dispose();
                    bitmap.Dispose();
                }
            }
        }
        private void DrawTicks1(Graphics graphics, float value = 20f)
        {
            // Otomatik ölçeklendirme faktörünü belirle
            float scaleFactor = 1f;
            float scaledMaxTick = _MaximumTick;

            if (value > _MaximumTick)
            {
                // Değer maximumun üzerindeyse, 10'un katlarına yuvarla
                scaleFactor = (float)Math.Pow(10, Math.Floor(Math.Log10(value / _MaximumTick)));
                scaledMaxTick = _MaximumTick * scaleFactor;
            }
            else if (value > 0 && value < _MaximumTick / 10f)
            {
                // Değer çok küçükse, 10'un katlarına böl
                scaleFactor = 1f / (float)Math.Pow(10, Math.Ceiling(Math.Log10(_MaximumTick / value)));
                scaledMaxTick = _MaximumTick * scaleFactor;
            }

            float endProgressAngle = (float)((value * 60f) / scaledMaxTick);
            // Configurable parameters
            float totalTicks = this.MajorThicksCount + 1; // Total number of major ticks (including start and end)
            float arcAngle = 60f; // Total angle for the arc (in degrees)

            float baseRadius = ((Width - 32) * 0.98f);
            float centerX = Width / 2f;
            float centerY = Width;

            // Tick configuration
            float shortTickLength = Width * 0.02f;
            float longTickLength = Width * 0.04f;
            float shortTickWidth = Width * 0.005f;
            float longTickWidth = Width * 0.01f;
            Color shortTickColor = Color.LightGray;
            Color longTickColor = Color.Gray;

            PointF arcStartPoint = new PointF();
            PointF arcEndPoint = new PointF();

            // Calculate angle between ticks
            float angleBetweenTicks = arcAngle / (totalTicks - 1);

            for (int i = 0; i < totalTicks; i++)
            {
                // Calculate angle for this tick (starting from -120 degrees)
                float angle = -120f + (i * angleBetweenTicks);
                double angleInRadians = angle * Math.PI / 180;
                float cosAngle = (float)Math.Cos(angleInRadians);
                float sinAngle = (float)Math.Sin(angleInRadians);

                // Calculate tick points
                PointF startPoint = new PointF(
                    centerX + baseRadius * cosAngle,
                    centerY + baseRadius * sinAngle);

                if (i == totalTicks - 1) arcEndPoint = startPoint;
                if (i == 0) arcStartPoint = startPoint;

                // Always draw major ticks
                PointF endPoint = new PointF(
                    centerX + (baseRadius + longTickLength) * cosAngle,
                    centerY + (baseRadius + longTickLength) * sinAngle);

                using (Pen tickPen = new Pen(longTickColor, longTickWidth))
                {
                    graphics.DrawLine(tickPen, startPoint, endPoint);
                }

                // Add numbers for major ticks
                float tickValue = i * (scaledMaxTick / (totalTicks - 1));
                string text;

                // Format the text based on the scale
                if (scaleFactor >= 1)
                {
                    text = tickValue.ToString("0");
                }
                else
                {
                    // For small values, show decimal places
                    int decimalPlaces = (int)Math.Ceiling(Math.Log10(1 / scaleFactor));
                    text = tickValue.ToString("0." + new string('0', decimalPlaces));
                }

                float textRadius = baseRadius + longTickLength + 8;
                PointF textPoint = new PointF(
                    centerX + textRadius * cosAngle,
                    centerY + textRadius * sinAngle);

                SizeF textSize = graphics.MeasureString(text, this.Font);

                textPoint.X -= textSize.Width / 2;
                textPoint.Y -= textSize.Height / 2;

                using (Brush textBrush = new SolidBrush(this.ForeColor))
                {
                    graphics.DrawString(text, this.Font, textBrush, textPoint);
                }
            }

            // Rest of the drawing code remains the same...
            using (Pen pen2 = new Pen(LineColor, shortTickWidth))
            {
                RectangleF rect = new RectangleF(
                    centerX - baseRadius,
                    centerY - baseRadius,
                    baseRadius * 2,
                    baseRadius * 2
                );

                float startAngle = (float)(Math.Atan2(arcStartPoint.Y - centerY, arcStartPoint.X - centerX) * 180 / Math.PI);
                float endAngle = (float)(Math.Atan2(arcEndPoint.Y - centerY, arcEndPoint.X - centerX) * 180 / Math.PI);

                float angleAdjustment = (float)(Math.Atan2(longTickWidth / 2, baseRadius) * 180 / Math.PI);
                startAngle -= angleAdjustment;
                endAngle += angleAdjustment;

                float sweepAngle = endAngle - startAngle;
                if (sweepAngle < 0) sweepAngle += 360;

                graphics.DrawArc(pen2, rect, startAngle, sweepAngle);
            }

            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                this._ProgressColor1, this._ProgressColor2, this.BarGradientMode))
            {
                RectangleF rect = new RectangleF(
                    centerX - baseRadius,
                    centerY - baseRadius,
                    baseRadius * 2,
                    baseRadius * 2
                );

                float startAngle = (float)(Math.Atan2(arcStartPoint.Y - centerY, arcStartPoint.X - centerX) * 180 / Math.PI);
                float endAngle = endProgressAngle <= 0 ? 0.3F : endProgressAngle;
                float angleAdjustment = (float)(Math.Atan2(longTickWidth / 2, baseRadius) * 180 / Math.PI);
                startAngle -= angleAdjustment;
                endAngle += angleAdjustment;
                using (Pen pen = new Pen(brush, this.BarWidth))
                {
                    switch (this.ProgressShapeVal)
                    {
                        case _ProgressShape.Round:
                            pen.StartCap = LineCap.Round;
                            pen.EndCap = LineCap.Round;
                            break;
                        case _ProgressShape.Flat:
                            pen.StartCap = LineCap.Flat;
                            pen.EndCap = LineCap.Flat;
                            break;
                    }

                    graphics.DrawArc(pen, rect, startAngle, endAngle + 0.1f);
                }
            }
        }
        private void DrawTicks(Graphics graphics, float value = 20f)
        {
            float scaleFactor = 1f;
            float scaledMaxTick = _MaximumTick;
            value = MathF.Abs(value);
            if (value > _MaximumTick)
            {
                // Değer maximumun üzerindeyse, 10'un katlarına yuvarla
                var pow = Math.Ceiling(Math.Log10(value / _MaximumTick));
                scaleFactor = (float)Math.Pow(10, pow);
                scaledMaxTick = _MaximumTick * scaleFactor;
            }
            else if (value > 0 && value < _MaximumTick / 10f)
            {
                // Değer çok küçükse, 10'un katlarına böl
                var pow = Math.Floor(Math.Log10(_MaximumTick / value));
                scaleFactor = 1f / (float)Math.Pow(10, pow);
                scaledMaxTick = _MaximumTick * scaleFactor;
            }
            float endProgressAngle = (float)((value * 60f) / scaledMaxTick);
            // Configurable parameters
            float totalTicks = this.MaximumTick + 1; // Total number of ticks (including start and end)
            long majorTickInterval = (long)(this.MaximumTick / this.MajorThicksCount); // Every Nth tick is a major tick
            float arcAngle = 60f; // Total angle for the arc (in degrees)

            float baseRadius = ((Width - 32) * 0.98f);
            float centerX = Width / 2f;
            float centerY = Width;

            // Tick configuration
            float shortTickLength = Width * 0.02f;
            float longTickLength = Width * 0.04f;
            float shortTickWidth = Width * 0.005f;
            float longTickWidth = Width * 0.01f;
            Color shortTickColor = Color.LightGray;
            Color longTickColor = Color.Gray;

            PointF arcStartPoint = new PointF();
            PointF arcEndPoint = new PointF();

            // Calculate angle between ticks
            float angleBetweenTicks = arcAngle / (totalTicks - 1);

            for (int i = 0; i < totalTicks; i++)
            {
                // Calculate angle for this tick (starting from -120 degrees)
                float angle = -120f + (i * angleBetweenTicks);
                double angleInRadians = angle * Math.PI / 180;
                float cosAngle = (float)Math.Cos(angleInRadians);
                float sinAngle = (float)Math.Sin(angleInRadians);

                bool isMajorTick = (i % majorTickInterval == 0);

                // Determine if this is a minor tick (not major but follows the minor tick pattern)
                bool isMinorTick = false;
                int minorTicksBetweenMajor;

                // Set number of minor ticks based on majorTickInterval
                if (majorTickInterval % 10 == 0)
                {
                    minorTicksBetweenMajor = 9; // For intervals like 10, 100, 1000
                }
                else
                {
                    minorTicksBetweenMajor = 4; // For intervals like 5, 50, 500
                }

                // Check if this is a minor tick
                if (!isMajorTick && majorTickInterval > 1)
                {
                    long positionInInterval = i % majorTickInterval;
                    long minorTickSpacing = majorTickInterval / (minorTicksBetweenMajor + 1);

                    if (minorTickSpacing > 0 && positionInInterval % minorTickSpacing == 0)
                    {
                        isMinorTick = true;
                    }
                }

                // Calculate tick points
                PointF startPoint = new PointF(
                    centerX + baseRadius * cosAngle,
                    centerY + baseRadius * sinAngle);

                if (i == totalTicks - 1) arcEndPoint = startPoint;
                if (i == 0) arcStartPoint = startPoint;

                // Only draw if it's a major or minor tick (skip others)
                if (isMajorTick || isMinorTick)
                {
                    float tickLength = isMajorTick ? longTickLength : shortTickLength;
                    PointF endPoint = new PointF(
                        centerX + (baseRadius + tickLength) * cosAngle,
                        centerY + (baseRadius + tickLength) * sinAngle);

                    using (Pen tickPen = new Pen(
                        isMajorTick ? longTickColor : shortTickColor,
                        isMajorTick ? longTickWidth : shortTickWidth))
                    {
                        graphics.DrawLine(tickPen, startPoint, endPoint);
                    }
                }

                // Add numbers for major ticks
                if (isMajorTick)
                {
                    // Add numbers for major ticks
                    float tickValue = i * (scaledMaxTick / (totalTicks - 1));
                    string text;

                    // Format the text based on the scale
                    if (scaleFactor >= 1)
                    {
                        text = tickValue.ToString("0");
                    }
                    else
                    {
                        // For small values, show decimal places
                        int decimalPlaces = (int)Math.Ceiling(Math.Log10(1 / scaleFactor));
                        text = tickValue.ToString("0." + new string('0', decimalPlaces));
                    }
                    float textRadius = baseRadius + longTickLength + 8;
                    PointF textPoint = new PointF(
                        centerX + textRadius * cosAngle,
                        centerY + textRadius * sinAngle);

                    //string text = (i).ToString();
                    SizeF textSize = graphics.MeasureString(text, this.Font);

                    textPoint.X -= textSize.Width / 2;
                    textPoint.Y -= textSize.Height / 2;

                    using (Brush textBrush = new SolidBrush(this.ForeColor))
                    {
                        graphics.DrawString(text, this.Font, textBrush, textPoint);
                    }
                }
            }

            // Rest of the drawing code remains the same...
            using (Pen pen2 = new Pen(LineColor, shortTickWidth))
            {
                RectangleF rect = new RectangleF(
                    centerX - baseRadius,
                    centerY - baseRadius,
                    baseRadius * 2,
                    baseRadius * 2
                );

                float startAngle = (float)(Math.Atan2(arcStartPoint.Y - centerY, arcStartPoint.X - centerX) * 180 / Math.PI);
                float endAngle = (float)(Math.Atan2(arcEndPoint.Y - centerY, arcEndPoint.X - centerX) * 180 / Math.PI);

                float angleAdjustment = (float)(Math.Atan2(longTickWidth / 2, baseRadius) * 180 / Math.PI);
                startAngle -= angleAdjustment;
                endAngle += angleAdjustment;

                float sweepAngle = endAngle - startAngle;
                if (sweepAngle < 0) sweepAngle += 360;

                graphics.DrawArc(pen2, rect, startAngle, sweepAngle);
            }

            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                this._ProgressColor1, this._ProgressColor2, this.BarGradientMode))
            {
                RectangleF rect = new RectangleF(
                    centerX - baseRadius,
                    centerY - baseRadius,
                    baseRadius * 2,
                    baseRadius * 2
                );

                float startAngle = (float)(Math.Atan2(arcStartPoint.Y - centerY, arcStartPoint.X - centerX) * 180 / Math.PI);
                float endAngle = endProgressAngle <= 0 ? 0.3F : endProgressAngle;
                float angleAdjustment = (float)(Math.Atan2(longTickWidth / 2, baseRadius) * 180 / Math.PI);
                startAngle -= angleAdjustment;
                endAngle += angleAdjustment;
                using (Pen pen = new Pen(brush, this.BarWidth))
                {
                    switch (this.ProgressShapeVal)
                    {
                        case _ProgressShape.Round:
                            pen.StartCap = LineCap.Round;
                            pen.EndCap = LineCap.Round;
                            break;
                        case _ProgressShape.Flat:
                            pen.StartCap = LineCap.Flat;
                            pen.EndCap = LineCap.Flat;
                            break;
                    }

                    graphics.DrawArc(pen, rect, startAngle, endAngle + 0.1f);
                }
            }
        }
        private static void PaintTransparentBackground(Control c, PaintEventArgs e)
        {
            if (c.Parent == null || !Application.RenderWithVisualStyles)
                return;

            ButtonRenderer.DrawParentBackground(e.Graphics, c.ClientRectangle, c);
        }


        #endregion
    }
}