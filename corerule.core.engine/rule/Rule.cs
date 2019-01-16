namespace corerule.core.engine.rule
{
    public abstract class Rule
    {
        public IAction Action {get;}
        public Rule(IAction action) => Action = action;

        public abstract Evaluation Evaluate();
    }
}