using Domain.SharedKernel;
using Microsoft.EntityFrameworkCore;
using Domain.Features.Identity.Applications;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Features.Identity.Users;
using System;
using Domain.Seedwork;
using Dtat.Seedwork.Abstractions;

namespace Persistence.Configurations.Features.Identity.Applications;

internal sealed class UserProfileConfiguration : object, IEntityTypeConfiguration<UserProfile>
{
    public void Configure(EntityTypeBuilder<UserProfile> builder)
    {
        // **************************************************
        // **************************************************
        // **************************************************
        builder
            .HasKey(current => current.Id)
            .IsClustered(clustered: false)
            ;
        // **************************************************

        // **************************************************
        builder
           .Property(current => current.UserProfileLevel)
           ;

        // **************************************************

        // **************************************************
        builder
          .Property(e => e.FullName.FirstName.Value)
          .HasColumnName(nameof(UserProfile.FullName.FirstName.Value))
          .HasMaxLength(Name.MaxLength)
          .IsRequired();

        // **************************************************

        // **************************************************
        builder
            .Property(e => e.FullName.LastName.Value)
            .HasColumnName(nameof(UserProfile.FullName.LastName.Value))
            .HasMaxLength(Name.MaxLength)
            .IsRequired();

        // **************************************************

        // **************************************************
        builder
            .Property<Guid>(propertyName: nameof(UserProfile.UserID))
            ;

        // **************************************************
        // **************************************************
        // **************************************************
    }
}
