namespace corerule.core.engine.rule
{
    public interface IRuleContext<T>
    {
         T Target {get;}
         IDictionary<string, object> Variables {get;}
    }
}