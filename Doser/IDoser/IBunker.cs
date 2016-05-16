using System;

namespace IDoser
{
    public interface IBunker
    {
        string Name { get; } 
        int Id { get; }
        /// <summary>
        /// Адрес бункера
        /// </summary>
        CombinedAddress Address { get; }
        /// <summary>
        /// Управляющий терминал
        /// </summary>
        ITerminal OwnTerminal { get; }
        /// <summary>
        /// Материал в бункере
        /// </summary>
        Material Material { get; }
        /// <summary>
        /// Расчетная масса компонента по рецепту
        /// </summary>
        double DoseTargetWeigth { get; }
        /// <summary>
        /// Фактически сдозированая масса компонента
        /// </summary>
        double DoseResultWeigth { get; }
        /// <summary>
        /// Упреждение бункера
        /// </summary>
        double Prevention { get; }
        /// <summary>
        /// Текущая масса материала в бункере
        /// </summary>
        double CurrentWeigth { get; }
        /// <summary>
        /// Время начала дозирования
        /// </summary>
        DateTime TimeStart { get; }
        /// <summary>
        /// Время завершения дозирования
        /// </summary>
        DateTime TimeFinish { get; }

        int Status { get; }



    }
}