using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDoser
{
    public interface ITerminal
    {
        /// <summary>
        /// Name of terminal
        /// </summary>
        string Name { get; }
        int Id { get; }
        CombinedAddress Address { get; }
        List<IBunker> Bunkers { get; }
        /// <summary>
        /// Текущий статус терминала
        /// </summary>
        int Status { get; }
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
        /// <summary>
        /// Целевой объем дозировки
        /// </summary>
        double DoseTargetVolume { get; }
        /// <summary>
        /// Значение порога (кг). Вес материала который может считаться условным нулем.
        /// </summary>
        double EmptyWeigth { get; set; }
        /// <summary>
        /// Текущий импользуемы бункер терминала
        /// </summary>
        IBunker CurrentUseBunker { get; }

        /// <summary>
        /// Инициализация терминала
        /// </summary>
        void Init();
        /// <summary>
        /// Загрузка рецепта в терминал
        /// </summary>
        void LoadRecipe();
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
        /// Возникает при подтверждении терминалом загрузки рецепта
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
