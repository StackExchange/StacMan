// <auto-generated>
//     This file was generated by a T4 template.
//     Don't change it directly as your change would get overwritten. Instead, make changes
//     to the .tt file (i.e. the T4 template) and save it to regenerate this file.
// </auto-generated>

using System;

namespace StackExchange.StacMan
{
    /// <summary>
    /// StacMan Badge, corresponding to Stack Exchange API v2's badge type
    /// http://api.stackexchange.com/docs/types/badge
    /// </summary>
    public partial class Badge : StacManType
    {
        /// <summary>
        /// award_count
        /// </summary>
        [Field("award_count")]
        public int AwardCount { get; internal set; }

        /// <summary>
        /// badge_id
        /// </summary>
        [Field("badge_id")]
        public int BadgeId { get; internal set; }

        /// <summary>
        /// badge_type
        /// </summary>
        [Field("badge_type")]
        public Badges.BadgeType BadgeType { get; internal set; }

        /// <summary>
        /// description
        /// </summary>
        [Field("description")]
        public string Description { get; internal set; }

        /// <summary>
        /// link
        /// </summary>
        [Field("link")]
        public string Link { get; internal set; }

        /// <summary>
        /// name
        /// </summary>
        [Field("name")]
        public string Name { get; internal set; }

        /// <summary>
        /// rank
        /// </summary>
        [Field("rank")]
        public Badges.Rank Rank { get; internal set; }

        /// <summary>
        /// user
        /// </summary>
        [Field("user")]
        public ShallowUser User { get; internal set; }

    }
}
