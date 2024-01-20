namespace EQX.Core.Common
{
    public interface IInitializable
    {
        /// <summary>
        /// Initialize setting before call the Connect function
        /// </summary>
        /// <returns>Initialize result</returns>
        bool Initialize();
    }
}
