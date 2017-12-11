﻿using ProjectManagement.Api.Commands.Core;

namespace ProjectManagement.Api.Handlers.Core
{
    /// <summary>
    /// Contract used to handle a specific command
    /// </summary>
    public interface ICommandHandler<in TCommand>
    {
        ICommandResult Execute(TCommand command);
    }
}