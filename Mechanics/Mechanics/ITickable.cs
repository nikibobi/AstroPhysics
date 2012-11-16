namespace AstroPhysics
{
    /// <summary>
    /// Интерфейс със един единствен метод Tick().
    /// </summary>
    interface ITickable
    {
        /// <summary>
        /// Изпълнява се много често и обновява обектите които го имплементират
        /// </summary>
        void Tick();
    }
}
