namespace corerule.core.engine.rule
{
    public interface IAction
    {
         IRuleContext Apply(IRuleContext context);
    }
}