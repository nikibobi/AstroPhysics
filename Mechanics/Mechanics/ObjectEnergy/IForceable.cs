namespace AstroPhysics.ObjectEnergy
{
    /// <summary>
    /// Интерфейс за тяло на което може да се прилага сила
    /// </summary>
    interface IForceable
    {
        /// <summary>
        /// Масата на тялото
        /// </summary>
        float Mass { get; set; }
        /// <summary>
        /// Ускорението на обекта
        /// </summary>
        Vector Acceleration { get; set; }
    }
}
