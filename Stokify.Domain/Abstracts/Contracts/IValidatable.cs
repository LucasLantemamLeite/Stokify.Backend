namespace Stokify.Domain.Abstracts.Contracts;

public interface IValidatable
{
    bool IsValid { get; }
    IReadOnlyCollection<Notification> Notifications { get; }
    bool Validate();
}