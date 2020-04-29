namespace CarafeModule
{
    /// <summary>
    /// Класс, хранящий информацию о параметрах графина.
    /// </summary>
    public class Parameter
    {
        /// <summary>
        /// Значение параметра.
        /// </summary>
        private double _value;

        /// <summary>
        /// Получить / задать максимально допустимое значение параметра.
        /// </summary>
        public double MaxValue { get; set; }

        /// <summary>
        /// Получить / задать минимально допустимое значение параметра.
        /// </summary>
        public double MinValue { get; private set; }

        /// <summary>
        /// Получить / задать текущее значение параметра.
        /// </summary>
        public double Value
        {
            get => _value;
            set
            {
                if (value >= MaxValue)
                {
                    _value = MaxValue;
                }
                else if (value <= MinValue)
                {
                    _value = MinValue;
                }
                else
                {
                    _value = value;
                }
            }
        }

        /// <summary>
        /// Получить / задать, будет ли параметр учитываться при построении..
        /// </summary>
        public ParameterState State { get; set; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="state">Наличие параметра при построении.</param>
        /// <param name="minValue">Минимально допустимное значение параметра.</param>
        /// <param name="maxValue">Максимально допустимное значение параметра.</param>
        /// <param name="value">Текущее значение параметра.</param>
        public Parameter(ParameterState state, double minValue,
            double maxValue,
            double value)
        {
            State = state;
            MinValue = minValue;
            MaxValue = maxValue;
            Value = value;
        }
    }
}