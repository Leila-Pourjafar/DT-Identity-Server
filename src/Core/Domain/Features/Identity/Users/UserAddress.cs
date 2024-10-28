using Domain.Seedwork;
using Domain.SharedKernel;
using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Features.Identity.Users;

public class UserAddress : Entity
{
#pragma warning disable CS8618
    [Obsolete]
    private UserAddress() : base()
    {
    }
#pragma warning restore CS8618

    public UserAddress(Address address, Guid userId) : base()
    {
        Address = address;
    }

    [Required]
    public Guid UserId { get; private set; }

    public virtual User? User { get; private set; }

    public Address Address { get; set; }
}
