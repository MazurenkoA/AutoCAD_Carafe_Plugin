using System;
using System.Collections.Generic;

namespace CarafeModule
{
    /// <summary>
    /// Класс, для хранения данных о параметрах.
    /// </summary>
    public class Parameters
    {
        /// <summary>
        /// Словарь, хранящий тип параметра и его характеристики.
        /// </summary>
        private Dictionary<ParameterType, Parameter> _parameters;

        /// <summary>
        /// Поля, хранящее состояние параметра 'Пробка графина' при построение.
        /// </summary>
        private ParameterState _stopperState;

        /// <summary>
        /// Поля, хранящее состояние параметра 'Ручка графина' при построение.
        /// </summary>
        private ParameterState _handleState;

        /// <summary>
        /// Метод, который обновляет максимально допустимое значение для длины ручки графина.
        /// </summary>
        private void UpdateMaxHandleLength()
        {
            _parameters[ParameterType.HandleLength].MaxValue =
                Math.Round((2 * _parameters[ParameterType.CarafeHeight].Value) / 3, 2);
        }

        /// <summary>
        /// Метод, который обновляет максимально допустимое значение для диаметра горла гарфина.
        /// </summary>
        private void UpdateMaxThroatDiameter()
        {
            _parameters[ParameterType.ThroatDiameter].MaxValue =
                _parameters[ParameterType.BaseDiameter].Value;
        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        public Parameters()
        {
            HandleState = ParameterState.Present;
            StopperState = ParameterState.Present;

            double maxThroatDiameter =
                ParametersConstant.MinBaseDiameter;

            double maxHandleLength =
                Math.Round(((2 * ParametersConstant.MinCarafeHeight) / 3), 2);

            _parameters =
                new Dictionary<ParameterType, Parameter>
                {
                    {
                        ParameterType.BaseDiameter, new Parameter(
                            ParametersConstant.MinBaseDiameter,
                            ParametersConstant.MaxBaseDiameter,
                            ParametersConstant.MinBaseDiameter)
                    },
                    {
                        ParameterType.CarafeHeight, new Parameter(
                            ParametersConstant.MinCarafeHeight,
                            ParametersConstant.MaxCarafeHeight,
                            ParametersConstant.MinCarafeHeight)
                    },
                    {
                        ParameterType.ThroatDiameter, new Parameter(
                            ParametersConstant.MinThroatDiameter, maxThroatDiameter,
                            ParametersConstant.MinThroatDiameter)
                    },
                    {
                        ParameterType.StopperHeight, new Parameter(
                            ParametersConstant.MinStopperHeight,
                            ParametersConstant.MaxStopperHeight,
                            ParametersConstant.MinStopperHeight)
                    },
                    {
                        ParameterType.HandleAngle, new Parameter(
                            ParametersConstant.MinHandleAngle,
                            ParametersConstant.MaxHandleAngle,
                            ParametersConstant.MinHandleAngle)
                    },
                    {
                        ParameterType.HandleLength, new Parameter(
                            ParametersConstant.MinHandleLength, maxHandleLength,
                            ParametersConstant.MinHandleLength)
                    }
                };
        }

        /// <summary>
        /// Получить / задать наличие параметра 'Пробка графина' при построении.
        /// </summary>
        public ParameterState StopperState
        {
            get => _stopperState;
            set => _stopperState = value;
        }

        /// <summary>
        /// Получить / задать наличие параметра 'Ручка графина' при построении.
        /// </summary>
        public ParameterState HandleState
        {
            get => _handleState;
            set => _handleState = value;
        }

        /// <summary>
        /// Получить минимально допустимое значение параметра.
        /// </summary>
        /// <param name="parameterType">Тип параметра.</param>
        /// <returns>Минимально допустимоезначение параметра.</returns>
        public double GetMinValue(ParameterType parameterType)
        {
            return _parameters[parameterType].MinValue;
        }

        /// <summary>
        /// Получить максимально допустимое значение параметра.
        /// </summary>
        /// <param name="parameterType">Тип параметра</param>
        /// <returns>Максимально допустимое параметра.</returns>
        public double GetMaxValue(ParameterType parameterType)
        {
            return _parameters[parameterType].MaxValue;
        }

        /// <summary>
        /// Получить значение параметра.
        /// </summary>
        /// <param name="parameterType">Тип параметра.</param>
        /// <returns>Значение параметра.</returns>
        public double GetValue(ParameterType parameterType)
        {
            return _parameters[parameterType].Value;
        }

        /// <summary>
        /// Задать значение параметра.
        /// </summary>
        /// <param name="parameterType">Тип параметра.</param>
        /// <param name="newValue">Новое значение параметра.</param>
        public void SetValue(ParameterType parameterType, double newValue)
        {
            _parameters[parameterType].Value = newValue;
            if (parameterType == ParameterType.BaseDiameter)
            {
                UpdateMaxThroatDiameter();
            }

            if (parameterType == ParameterType.CarafeHeight)
            {
                UpdateMaxHandleLength();
            }
        }

        /// <summary>
        /// Проверка полученного числа.
        /// </summary>
        /// <param name="parameterType">Название параметра, значение которого проверяется.</param>
        /// <param name="value">Само значение параметра.</param>
        /// <returns>Возвращает результат, входит ли число в диапазон допустимых значений.</returns>
        public bool IsCorrectValue(ParameterType parameterType, double value)
        {
            return !(value > _parameters[parameterType].MaxValue) &&
                   !(value < _parameters[parameterType].MinValue);
        }
    }
}