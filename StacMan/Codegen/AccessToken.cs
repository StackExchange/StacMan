// <auto-generated>
//     This file was generated by a T4 template.
//     Don't change it directly as your change would get overwritten. Instead, make changes
//     to the .tt file (i.e. the T4 template) and save it to regenerate this file.
// </auto-generated>

using System;

namespace StackExchange.StacMan
{
    /// <summary>
    /// StacMan AccessToken, corresponding to Stack Exchange API v2's access_token type
    /// http://api.stackexchange.com/docs/types/access-token
    /// </summary>
    public partial class AccessToken : StacManType
    {
        /// <summary>
        /// access_token
        /// </summary>
        [Field("access_token")]
        public string AccessTokenName { get; internal set; }

        /// <summary>
        /// account_id
        /// </summary>
        [Field("account_id")]
        public int AccountId { get; internal set; }

        /// <summary>
        /// expires_on_date
        /// </summary>
        [Field("expires_on_date")]
        public DateTime? ExpiresOnDate { get; internal set; }

        /// <summary>
        /// scope
        /// </summary>
        [Field("scope")]
        public string[] Scope { get; internal set; }

    }
}
