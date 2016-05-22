using Picturra.Presenter.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Picturra.Presenter.Commands;

namespace Picturra.Presenter
{
    public class CommandInvoker : ICommandInvoker
    {
        public void Invoke(ICommand command)
        {
            command.Execute();
        }

        public TValue Invoke<TValue>(IReadCommand<TValue> command)
        {
            command.Execute();
            return command.Value;
        }

        public void Invoke<TInput>(IWriteCommand<TInput> command, TInput value)
        {
            command.Input = value;
            command.Execute();
        }

        public TValue Invoke<TValue, TInput>(ICommand<TInput, TValue> command, TInput value)
        {
            command.Input = value;
            command.Execute();
            return command.Value;
        }
    }
}
