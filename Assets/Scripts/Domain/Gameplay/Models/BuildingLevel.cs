namespace Domain.Gameplay.Models
{
    /// <summary>
    /// Уровень здания с его стоимостью и заработком
    /// </summary>
    public struct BuildingLevel
    {
        public int Level;
        public Cost UpgradeCost;
        public Income Income;
    }
}