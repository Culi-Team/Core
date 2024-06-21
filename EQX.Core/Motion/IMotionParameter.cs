namespace EQX.Core.Motion
{
    public interface IMotionParameter
    {
        /// <summary>
        /// PulsePerUnit = <see cref="Pulse"/> / <see cref="Unit"/>
        /// </summary>
        int Pulse { get; set; }
        /// <summary>
        /// PulsePerUnit = <see cref="Pulse"/> / <see cref="Unit"/>
        /// </summary>
        uint Unit { get; set; }

        double MaxVelocity { get; set; }

        /// <summary>
        /// Acceleration, it can be mm/s or msec
        /// </summary>
        double Acceleration { get; set; }
        /// <summary>
        /// Deceleration, it can be mm/s or msec
        /// </summary>
        double Deceleration { get; set; }
    }
}