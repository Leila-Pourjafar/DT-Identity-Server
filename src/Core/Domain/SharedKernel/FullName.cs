using Dtat;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.SharedKernel;

[ComplexType]
public record FullName : object
{
    public const int MaxLength = 150;

    public Name FirstName { get; init; }
    public Name LastName { get; init; }

    public FullName(Name firstName, Name lastName) : base()
    {
        FirstName = firstName;
        LastName = lastName;
    }
    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}
