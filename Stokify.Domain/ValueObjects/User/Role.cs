namespace Stokify.Domain.ValueObjects.User;

public sealed class Role : IValueObject
{
    public ERole Value { get; } = ERole.User;

    public Role(int role)
    {
        Value = (ERole)role;
    }

    private Role() { }
}