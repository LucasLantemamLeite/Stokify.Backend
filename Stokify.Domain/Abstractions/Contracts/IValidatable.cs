using System.Collections.ObjectModel;
using Flunt.Notifications;

namespace Stokify.Domain.Abstractions.Contracts;

public interface IValidatable
{
    ReadOnlyCollection<Notification> Notification { get; }
    bool Validate();
}