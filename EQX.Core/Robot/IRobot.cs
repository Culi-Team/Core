using EQX.Core.Common;

namespace EQX.Core.Robot
{
    public delegate void RobotResponseHandler(object sender, string response);

    public interface IRobot : IIdentifier, IHandleConnection
    {
        /// <summary>
        /// Send command from PC to Robot
        /// </summary>
        /// <param name="command">Command</param>
        /// <returns>true if success; false if fail</returns>
        bool SendCommand(string command);
        /// <summary>
        /// Read response from Robot
        /// </summary>
        /// <param name="timeoutMs">Time out in millisecond</param>
        /// <returns></returns>
        string ReadResponse(int timeoutMs);
        bool ReadResponse(int timeoutMs, string expectedResponse);
        /// <summary>
        /// Read response from Robot asynchronous
        /// </summary>
        /// <param name="timeoutMs">Time out in millisecond</param>
        /// <returns></returns>
        Task<string> ReadResponseAsync(int timeoutMs);

        RobotResponseHandler? OnRobotResponsed { get; }
    }
}
