using DR.Packages.MassTransit;
using System;
using System.Collections.Generic;
using System.Text;

namespace DR.Components.Users.Commands
{
    public interface AddUser : ICommand
    {
        Guid Id { get; }
    }
}
