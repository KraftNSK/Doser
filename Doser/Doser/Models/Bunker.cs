using System;

namespace IDoser.Models
{
    public class Bunker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Material Material { get; set; }
        /// <summary>
        /// Дискретный выход терминала
        /// </summary>
        public int Output { get; set; }
        public Terminal Terminal { get; set; }
        /// <summary>
        /// Активность бункера
        /// </summary>
        public bool isActive { get; set; }
        /// <summary>
        /// Использовать импульсный режим
        /// </summary>
        public bool UseImpulseMode { get; set; }
        /// <summary>
        /// Упреждение
        /// </summary>
        public int Prevention { get; set; }
        /// <summary>
        /// Длительность паузы в импульсном режиме
        /// </summary>
        public int PauseInterval { get; set; }
        /// <summary>
        /// Минимальная длительность импульса (мс)
        /// </summary>
        public int ImpMin { get; set; }
        /// <summary>
        /// Максимальная длительность импульса (мс)
        /// </summary>
        public int ImpMax { get; set; }
        /// <summary>
        /// Длительность паузы в импульсном режиме для малых доз
        /// </summary>
        public int PauseIntervalSmall { get; set; }
        /// <summary>
        /// Минимальная длительность импульса (мс) для малых доз
        /// </summary>
        public int ImpMinSmall { get; set; }
        /// <summary>
        /// Максимальная длительность импульса (мс) для малых доз
        /// </summary>
        public int ImpMaxSmall { get; set; }
        /// <summary>
        /// Значение веса (в %) при котором дозирование переходит в импульсный режим
        /// </summary>
        public double EnterImpModeValue { get; set; }
        /// <summary>
        /// Дозы (в кг) которую необходимо считать малой
        /// </summary>
        public double SmallDose { get; set; }

        /// <summary>
        /// Допустимая погрешность (в %)
        /// </summary>
        public double Inaccuracy { get; set; }


        public DateTime TimeCreate { get; set; }
        public DateTime TimeDeleted { get; set; }
        public User UserCreate { get; set; }
        public User UserDeleted { get; set; }
        public bool isDeleted { get; set; }
        public string Description { get; set; }
    }
}