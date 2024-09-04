using OCPExamples.Example1.Cook.StrategyPattern.Interfaces;

namespace OCPExamples.Example1.Cook.StrategyPattern
{
    public class Context
    {
        public IStrategy ContextStrategy { get; set; }

        public Context(IStrategy _strategy)
        {
            ContextStrategy = _strategy;
        }

        public void ExecuteAlgorithm()
        {
            ContextStrategy.Algorithm();
        }
    }
}
