namespace Lib.MVU;

public static class Cmd<TMessage>
{
    public static Command<TMessage> None { get; } = (Dispatch<TMessage> _) => Task.CompletedTask;
}
