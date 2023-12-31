﻿namespace Xerveit.Core.Interfaces.Commands
{
    public interface ICommand<TRequest> where TRequest : class
    {
        Task<int> Execute();
        Task Undo();
    }
}
