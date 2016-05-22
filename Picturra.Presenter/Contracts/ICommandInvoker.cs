using Picturra.Presenter.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picturra.Presenter.Contracts
{
    public interface ICommandInvoker
    {
        TValue Invoke<TValue, TInput>(ICommand<TInput, TValue> command, TInput value);
        TValue Invoke<TValue>(IReadCommand<TValue> command);
        void Invoke<TInput>(IWriteCommand<TInput> command, TInput value);
        void Invoke(ICommand command);
    }
}
