using Domain.Seedwork;
using Domain.SharedKernel;
using Dtat.Seedwork.Abstractions;
using System.Collections.Generic;
using Domain.Features.Identity.Companies;
using Domain.Features.Identity.UserAccesses;
using System;

namespace Domain.Features.Identity.Users;

public class User : AggregateRoot, IEntityHasIsActive
{
    public const byte SystemProfileLevel = 3;

#pragma warning disable CS8618
    [Obsolete]
    private User() : base()
    {
    }
#pragma warning restore CS8618
   
    public User(Username username, Password password, EmailAddress emailAddress) : base()
    {
        Password = password;
        Username = username;
        EmailAddress = emailAddress;
    }

    public Username Username { get; set; }
    //public Username Username { get; private set; }

    public Password Password { get; private set; }

    public EmailAddress EmailAddress { get; private set; }

    public bool IsActive { get; private set; }

    /// <summary>
    /// آیا کاربر میتواند کمپانی تعریف کند؟
    /// </summary>
    public bool UserCanDefineCompany { get; private set; }

    /// <summary>
    /// با نگاه طراحی دامنه محور، مطلقا غلط است
    /// </summary>
    public virtual IList<Company> Companies { get; } = [];

    /// <summary>
    /// با نگاه طراحی دامنه محور، مطلقا غلط است
    /// </summary>
    public virtual IList<UserAccess> UserAccesses { get; } = [];

    /// <summary>
    /// با نگاه طراحی دامنه محور، اوکی است، ولی نحوه پیاده‌سازی آن مطلقا غلط است
    /// </summary>
    public virtual IList<UserAddress> UserAddresses { get; } = [];

    public virtual UserProfile? UserProfile { get; set; }

    //private readonly IList<UserAddress> _userAddresses = [];

    //public IReadOnlyCollection<UserAddress> UserAddresses
    //{
    //	get
    //	{
    //		return _userAddresses.AsReadOnly();
    //	}
    //}

    //public void AddUserAddress(UserAddress userAddress)
    //{
    //	if (_userAddresses.Count < 3)
    //	{
    //		_userAddresses.Add(item: userAddress);
    //	}
    //}

    public void UpdateProfile(Guid userID)
    {
        if (UserProfile.UserProfileLevel <SystemProfileLevel)
        {
            //To do ...
        }
    }
}
