namespace Picturra.Presenter.Commands
{
    public interface ICommand<TInput, TValue>
    {
        TInput Input { get; set; }
        TValue Value { get; set; }
        void Execute();
    }

    public interface IWriteCommand<TInput>
    {
        TInput Input { get; set; }
        void Execute();
    }

    public interface IReadCommand<TValue>
    {
        TValue Value { get; set; }
        void Execute();
    }

    public interface ICommand
    {
        void Execute();
    }
}
