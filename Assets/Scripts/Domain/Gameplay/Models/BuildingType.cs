namespace Domain.Gameplay.Models
{
    /// <summary>
    /// Перечисление типов зданий
    /// </summary>
    public enum BuildingType : byte
    {
        /// <summary>
        /// Не определено
        /// </summary>
        None = 0,
        
        /// <summary>
        /// Жилой дом - базовое здание для жителей 
        /// </summary>
        House = 1,
        
        /// <summary>
        /// Ферма - производит золото
        /// </summary>
        Farm = 2,
        
        /// <summary>
        /// Шахта - производит золото
        /// </summary>
        Mine = 3
    }
}