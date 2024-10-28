using System;
using Microsoft.EntityFrameworkCore;
using Domain.Features.Identity.Users;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.SharedKernel;
using Domain.Seedwork;

namespace Persistence.Configurations.Features.Identity.Users;

internal sealed class UserAddressConfiguration : object, IEntityTypeConfiguration<UserAddress>
{
    public UserAddressConfiguration() : base()
    {
    }

    public void Configure
        (EntityTypeBuilder<UserAddress> builder)
    {
        builder.ToTable(name: "UserAddresses");

        // **************************************************
        // **************************************************
        // **************************************************
        builder
            .HasKey(current => current.Id)
            .IsClustered(clustered: false)
            ;

        builder
            .HasKey(d => d.Id);

        //builder
        //	.Property(p => p.Id)
        //	.HasConversion(id => id.Value,
        //	value => new UserAddressId(value));
        // **************************************************

        // **************************************************
        builder
            .Property(e => e.Address.Country)
            .HasColumnName(nameof(UserAddress.Address.Country))
            .HasMaxLength(Name.MaxLength)
            .IsRequired();

        // **************************************************

        // **************************************************
        builder
            .Property(e => e.Address.State)
            .HasColumnName(nameof(UserAddress.Address.State))
            .HasMaxLength(Name.MaxLength)
            .IsRequired();

        // **************************************************

        // **************************************************
        builder
            .Property(e => e.Address.City)
            .HasColumnName(nameof(UserAddress.Address.City))
            .HasMaxLength(Name.MaxLength)
            .IsRequired();

        // **************************************************

        // **************************************************
        builder
            .Property(p => p.Address.PostalCode)
            .HasMaxLength(maxLength: PostalCode.MaxLength)
            .HasConversion(id => id.Value, value => new PostalCode(value));

        // **************************************************

        // **************************************************
        builder
            .Property(current => current.Address.PostalCode)
            .IsUnicode(unicode: false)
             ;

        // **************************************************

        // **************************************************
        builder
            .Property<Guid>(propertyName: "UserId")
            ;

        builder
            .HasIndex("UserId", nameof(UserAddress.Address.PostalCode))
            .IsUnique(unique: true)
            ;
        // **************************************************
        // **************************************************
        // **************************************************
    }
}
