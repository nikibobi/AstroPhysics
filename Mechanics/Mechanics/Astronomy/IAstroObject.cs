namespace AstroPhysics.Astronomy
{
    interface IAstroObject : ITickable
    {
        float SpeedModiffer { get; set; }

        void RestartPosition();
    }
}