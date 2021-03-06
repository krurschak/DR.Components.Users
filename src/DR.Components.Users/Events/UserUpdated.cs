using DR.Packages.MassTransit;
using System;
using System.Collections.Generic;
using System.Text;

namespace DR.Components.Users.Events
{
    public interface UserUpdated : IEvent
    {
        Guid Id { get; }
        string IdentitySub { get; }
        string IdentityIss { get; }
        string Email { get; }
        int? Salutation { get; }
        string Title { get; }
        string LastName { get; }
        string FirstName { get; }
    }
}
