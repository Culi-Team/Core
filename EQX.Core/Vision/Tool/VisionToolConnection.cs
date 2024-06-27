namespace EQX.Core.Vision.Tool
{
    public class VisionToolConnection
    {
        public int OriginToolId { get; }
        public int TargetToolId { get; }
        public string OriginKey { get; }
        public string TargetKey { get; }

        public VisionToolConnection(int originToolId, int targetToolId, string key)
            : this(originToolId, targetToolId, key, key)
        {
        }

        public VisionToolConnection(int originToolId, int targetToolId, string originKey, string targetKey)
        {
            OriginToolId = originToolId;
            TargetToolId = targetToolId;
            OriginKey = originKey;
            TargetKey = targetKey;
        }
    }
}