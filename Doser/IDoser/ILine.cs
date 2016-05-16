using System;
using System.Collections.Generic;

namespace IDoser
{
    public interface ILine
    {
        int Id { get; }
        string Name { get; }
        CombinedAddress Address { get; }
        List<ITerminal> Terminals { get; }
        LineMode Mode { get; }
        double TargetVolume { get; }
        /// <summary>
        /// Суммарная масса всех компонентов рецепта
        /// </summary>
        double DoseRecipeWeigth { get; }
        /// <summary>
        /// Расчетная сумарная масса всех компонентов
        /// </summary>
        double DoseTargetWeigth { get; }
        /// <summary>
        /// Сумма фактически сдозированных компонентов
        /// </summary>
        double DoseResultWeigth { get; }
        bool RecipeIsLoad { get; }
        bool IsDosage { get; }
        bool IsFull { get; }

        /// <summary>
        /// Инициализация линии
        /// </summary>
        void Init();
        /// <summary>
        /// Загрузка рецептов в терминалы
        /// </summary>
        void LoadRecipes();
        /// <summary>
        /// Проверка рецепта относительно линии
        /// </summary>
        /// <returns></returns>
        bool CheckRecipes();
        /// <summary>
        /// Старт дозировки
        /// </summary>
        void StartDosage();
        /// <summary>
        /// Приостановить дозировку
        /// </summary>
        void PauseDosage();
        /// <summary>
        /// Прервать дозировку
        /// </summary>
        void AbortDosage();

        /// <summary>
        /// Возникает при подтверждении всех терминалов о загрузке рецепта
        /// </summary>
        event EventHandler OnRecipeSent;
        /// <summary>
        /// Возникает при старте дозировки
        /// </summary>
        event EventHandler OnStart;
        /// <summary>
        /// Возникает при вызове метода PauseDosage()
        /// </summary>
        event EventHandler OnPause;
        /// <summary>
        /// Возникает при успешном окончании дозирования
        /// </summary>
        event EventHandler OnFinished;
        /// <summary>
        /// Возникает при ненормальном окончании дозирования (авария или вызов AbortDosage())
        /// </summary>
        event EventHandler OnAbort;

    }
}