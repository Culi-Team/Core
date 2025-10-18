namespace EQX.Core.Interlock
{
    public class InterlockService
    {
        private readonly List<IInterlockRule> _rules = new();
        public static InterlockService Default { get; } = new();
        public event Action<string, bool>? InterlockChanged;
        public void RegisterRule(IInterlockRule rule) => _rules.Add(rule);
        public void Reevaluate() => Evaluate();
        private void Evaluate()
        {
            foreach (var rule in _rules)
            {
                bool satisfied = rule.IsSatisfied();
                InterlockChanged?.Invoke(rule.Key, satisfied);
            }
        }
    }
}
