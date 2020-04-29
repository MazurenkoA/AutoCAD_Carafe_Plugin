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
                Math.Round((3 * _parameters[ParameterType.BaseDiameter].Value) / 2, 2);
        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        public Parameters()
        {
            double maxThroatDiameter =
                Math.Round(((3 * ParametersConstant.MinBaseDiameter) / 2), 2);

            double maxHandleLength =
                Math.Round(((2 * ParametersConstant.MinCarafeHeight) / 3), 2);

            _parameters =
                new Dictionary<ParameterType, Parameter>
                {
                    {
                        ParameterType.BaseDiameter, new Parameter(
                            ParameterState.Present,
                            ParametersConstant.MinBaseDiameter,
                            ParametersConstant.MaxBaseDiameter,
                            ParametersConstant.MinBaseDiameter)
                    },
                    {
                        ParameterType.CarafeHeight, new Parameter(
                            ParameterState.Present,
                            ParametersConstant.MinCarafeHeight,
                            ParametersConstant.MaxCarafeHeight,
                            ParametersConstant.MinCarafeHeight)
                    },
                    {
                        ParameterType.ThroatDiameter, new Parameter(
                            ParameterState.Present,
                            ParametersConstant.MinThroatDiameter, maxThroatDiameter,
                            ParametersConstant.MinThroatDiameter)
                    },
                    {
                        ParameterType.StopperHeight, new Parameter(
                            ParameterState.Present,
                            ParametersConstant.MinStopperHeight,
                            ParametersConstant.MaxStopperHeight,
                            ParametersConstant.MinStopperHeight)
                    },
                    {
                        ParameterType.HandleAngle, new Parameter(
                            ParameterState.Present,
                            ParametersConstant.MinHandleAngle,
                            ParametersConstant.MaxHandleAngle,
                            ParametersConstant.MinHandleAngle)
                    },
                    {
                        ParameterType.HandleLength, new Parameter(
                            ParameterState.Missing,
                            ParametersConstant.MinHandleLength, maxHandleLength,
                            ParametersConstant.MinHandleLength)
                    }
                };
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

        /// <summary>
        /// Получить / задать наличие параметра 'Пробка' при построении.
        /// </summary>
        public ParameterState StopperState
        {
            get => _parameters[ParameterType.StopperHeight].State;
            set => _parameters[ParameterType.StopperHeight].State =
                value;
        }

        /// <summary>
        /// Получить / задать наличие параметра 'Ручка графина' при построении.
        /// </summary>
        public ParameterState HandleState
        {
            get
            {
                if (_parameters[ParameterType.HandleAngle].State ==
                    ParameterState.Present &&
                    _parameters[ParameterType.HandleLength].State ==
                    ParameterState.Present)
                {
                    return ParameterState.Present;
                }

                return ParameterState.Missing;
            }
            set
            {
                _parameters[ParameterType.HandleLength].State = value;
                _parameters[ParameterType.HandleAngle].State = value;
            }
        }
    }
}