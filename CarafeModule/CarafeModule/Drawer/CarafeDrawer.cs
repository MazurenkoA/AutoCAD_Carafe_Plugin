using System;
using System.Drawing;
using System.Windows.Forms;

namespace CarafeModule.Drawer
{
    /// <summary>
    /// Класс отрисовки чертежа графина.
    /// </summary>
    public class CarafeDrawer
    {
        /// <summary>
        /// Высота горла графина.
        /// </summary>
        private const float _throatHeight = 10;

        /// <summary>
        /// Начальная точка.
        /// </summary>
        private readonly PointF _startPoint = new PointF(120, 360);

        /// <summary>
        /// Поверхность отрисовки.
        /// </summary>
        private readonly PictureBox _picture;

        /// <summary>
        /// Перо.
        /// </summary>
        private readonly Pen _pen;

        /// <summary>
        /// Параметры графина.
        /// </summary>
        private readonly Parameters _parameters;

        /// <summary>
        /// Высота графина.
        /// </summary>
        private float _carafeHeight;

        /// <summary>
        /// Радиус основания графина.
        /// </summary>
        private float _baseRadius;

        /// <summary>
        /// Диаметр основания графина. 
        /// </summary>
        private float _baseDiameter;

        /// <summary>
        /// Радиус горла графина.
        /// </summary>
        private float _throatRadius;

        /// <summary>
        ///  Диаметр горла графина. 
        /// </summary>
        private float _throatDiameter;

        /// <summary>
        /// Поле, хранящее значение высоты пробки графина.
        /// </summary>
        private float _heightToThroat;

        /// <summary>
        /// Поля, хранящее значение высоты от основания до высоты горла графина.
        /// </summary>
        private float _heightAboveThroat;

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="parameters">Параметры графина.</param>
        /// <param name="picture">Поверхность отрисовки.</param>
        public CarafeDrawer(Parameters parameters, PictureBox picture)
        {
            _parameters = parameters;
            _picture = picture;

            _pen = new Pen(Color.Black, 2);
        }

        /// <summary>
        /// Задать новое значение параметра графина.
        /// </summary>
        /// <param name="parameterType">Параметр графина.</param>
        /// <param name="value">значение.</param>
        public void SetValue(ParameterType parameterType, double value)
        {
            _parameters.SetValue(parameterType, value);
        }


        /// <summary>
        /// Задать наличие параметра 'Пробка графина' при отрисовки. 
        /// </summary>
        /// <param name="state">Состояние параметра.</param>
        public void SetStopperState(ParameterState state)
        {
            _parameters.StopperState = state;
        }

        /// <summary>
        /// Задать наличие параметра 'Ручка графина' при отрисовки. 
        /// </summary>
        /// <param name="state">Состояние параметра.</param>
        public void SetHandleState(ParameterState state)
        {
            _parameters.HandleState = state;
        }

        /// <summary>
        /// Заполнение параметров для отрисовки графина.
        /// </summary>
        private void FillParameters()
        {
            _carafeHeight =
                Convert.ToSingle(_parameters.GetValue(ParameterType.CarafeHeight));

            _baseDiameter =
                Convert.ToSingle(_parameters.GetValue(ParameterType.BaseDiameter));

            _throatDiameter =
                Convert.ToSingle(_parameters.GetValue(ParameterType.ThroatDiameter));


            _heightToThroat =
                Convert.ToSingle(_carafeHeight - Math.Round(_carafeHeight / 10, 2));

            _baseRadius = _baseDiameter / 2;
            _throatRadius = _throatDiameter / 2;

            _heightAboveThroat = _heightToThroat + _throatHeight;
        }

        /// <summary>
        /// Отрисовка графина.
        /// </summary>
        public void Draw()
        {
            _picture.Update();
            using (Graphics graphics = Graphics.FromHwnd(_picture.Handle))
            {
                graphics.Clear(Color.White);

                FillParameters();

                DrawBase2d(graphics);

                if (_parameters.StopperState == ParameterState.Present)
                {
                    DrawStopper2d(graphics);
                }

                if (_parameters.HandleState == ParameterState.Present)
                {
                    DrawHandle2d(graphics);
                }
            }
        }

        /// <summary>
        /// Отрисовка основы графина.
        /// </summary>
        private void DrawBase2d(Graphics graphics)
        {
            var minHeightFigure = Math.Round((_carafeHeight / 1.5), 2);
            float heightBaseFigure = Convert.ToSingle(minHeightFigure);

            graphics.DrawRectangle(_pen, _startPoint.X - _baseRadius,
                _startPoint.Y - heightBaseFigure,
                _baseDiameter, heightBaseFigure);

            graphics.DrawLine(_pen, _startPoint.X - _baseRadius,
                _startPoint.Y - heightBaseFigure, _startPoint.X - _throatRadius,
                _startPoint.Y - _heightToThroat);

            graphics.DrawLine(_pen, _startPoint.X + _baseRadius,
                _startPoint.Y - heightBaseFigure, _startPoint.X + _throatRadius,
                _startPoint.Y - _heightToThroat);

            graphics.DrawLine(_pen, _startPoint.X - _throatRadius,
                _startPoint.Y - _heightToThroat, _startPoint.X + _throatRadius,
                _startPoint.Y - _heightToThroat);

            graphics.DrawRectangle(_pen, _startPoint.X - _throatRadius,
                _startPoint.Y - _heightAboveThroat,
                _throatDiameter, _throatHeight);
        }

        /// <summary>
        /// Отрисовка пробки графина.
        /// </summary>
        private void DrawStopper2d(Graphics graphics)
        {
            const float Thickness = 1;
            float stopperHeight =
                Convert.ToSingle(_parameters.GetValue(ParameterType.StopperHeight));

            stopperHeight += _carafeHeight;

            var inRadius = Math.Round((_throatRadius / 2), 2);
            var innerRadius = Convert.ToSingle(inRadius);
            var stopperDownHeader = _heightAboveThroat + Thickness;

            graphics.DrawRectangle(_pen, _startPoint.X - innerRadius,
                _startPoint.Y - _heightAboveThroat, 2 * innerRadius,
                _throatHeight);

            graphics.DrawRectangle(_pen, _startPoint.X - _throatRadius,
                _startPoint.Y - stopperDownHeader, _throatDiameter, Thickness);


            graphics.DrawLine(_pen, _startPoint.X - innerRadius,
                _startPoint.Y - _heightAboveThroat,
                _startPoint.X - _throatRadius, _startPoint.Y - stopperHeight);

            graphics.DrawLine(_pen, _startPoint.X + innerRadius,
                _startPoint.Y - _heightAboveThroat,
                _startPoint.X + _throatRadius, _startPoint.Y - stopperHeight);

            graphics.DrawLine(_pen, _startPoint.X - _throatRadius,
                _startPoint.Y - stopperHeight,
                _startPoint.X + _throatRadius, _startPoint.Y - stopperHeight);
        }


        /// <summary>
        /// Отрисовка ручки графина.
        /// </summary>
        private void DrawHandle2d(Graphics graphics)
        {
            const float ArcLength = 5;

            var handleLength =
                Convert.ToSingle(_parameters.GetValue(ParameterType.HandleLength));

            var handleAngle =
                Convert.ToSingle(_parameters.GetValue(ParameterType.HandleAngle));

            var handleWidth = _startPoint.X + _baseRadius + 10;
            var arcValue = Convert.ToSingle(handleAngle * Math.PI) / 180;

            var valueCos = Convert.ToSingle(ArcLength * Math.Cos(arcValue));
            var valueSin = Convert.ToSingle(ArcLength * Math.Sin(arcValue));

            var positionY = _startPoint.Y - _heightToThroat;

            if (handleAngle != 0.0F)
            {
                handleLength -= Convert.ToSingle(ArcLength * Math.Sin(arcValue));
            }

            graphics.DrawLine(_pen, _startPoint.X + _throatRadius, positionY,
                handleWidth, positionY);

            graphics.DrawLine(_pen, handleWidth, positionY, handleWidth + valueCos,
                positionY + valueSin);

            graphics.DrawLine(_pen, handleWidth + valueCos, positionY + valueSin,
                handleWidth + valueCos, positionY + valueSin + handleLength);
        }
    }
}