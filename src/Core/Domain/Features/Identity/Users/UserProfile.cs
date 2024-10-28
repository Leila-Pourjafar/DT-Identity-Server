
using Domain.Seedwork;
using Domain.SharedKernel;
using System;

namespace Domain.Features.Identity.Users
{
    public class UserProfile : Entity
    {
#pragma warning disable CS8618
        [Obsolete]
        private UserProfile() : base()
        {
        }
#pragma warning restore CS8618

        public UserProfile(FullName fullName, Guid userId) : base()
        {
            FullName = fullName;
        }

        public byte UserProfileLevel { get; set; }
        public virtual User User { get; private set; } = null!;
        public Guid UserID { get; set; }
        public FullName FullName { get; set; }
    }
}
