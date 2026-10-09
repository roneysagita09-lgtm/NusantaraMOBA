namespace NusantaraMOBA.Core
{
    /// <summary>Implemented by gameplay objects that can receive damage.</summary>
    public interface IDamageable
    {
        bool IsAlive { get; }
        void TakeDamage(float amount);
    }
}
