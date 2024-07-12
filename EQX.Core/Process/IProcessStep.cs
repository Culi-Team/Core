namespace EQX.Core.Sequence
{
    public interface IProcessStep
    {
        int OriginStep { get; set; }
        int RunStep { get; set; }
    }
}
