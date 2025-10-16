using System;
using System.Collections.Generic;

namespace Domain.Gameplay.Models
{
    /// <summary>
    /// Модель сетки карты с размещенными зданиями
    /// </summary>
    public class Grid
    {
        private Dictionary<Guid, Building> _buildings = new();
        private Dictionary<GridPosition, Guid> _occupied = new();
        
        public Grid()
        {
           
        }
    }
}