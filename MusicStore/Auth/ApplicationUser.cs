using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;


namespace MusicStore.Auth
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime Birthdate { get; set; } = new DateTime(1985, 1, 1);
        public string City { get; set; } = "Orlando";
        public string Country { get; set; } = "USA";

        /// <summary>
        /// Navigation property for the claims this user possesses.
        /// </summary>
        public virtual ICollection<IdentityUserClaim<string>> Claims { get; } = new List<IdentityUserClaim<string>>();

    }
}