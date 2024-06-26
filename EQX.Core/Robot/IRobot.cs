using EQX.Core.Common;

namespace EQX.Core.Robot
{
    public delegate void RobotResponseHandler(object sender, string response);

    public interface IRobot : IIdentifier, IHandleConnection
    {
        bool SendCommand(string command);
        string ReadResponse(int timeoutMs);
        Task<string> ReadResponseAsync(int timeoutMs);

        RobotResponseHandler? OnRobotResponsed { get; }
    }
}
