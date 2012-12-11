// <auto-generated>
//     This file was generated by a T4 template.
//     Don't change it directly as your change would get overwritten. Instead, make changes
//     to the .tt file (i.e. the T4 template) and save it to regenerate this file.
// </auto-generated>

using System;

namespace StackExchange.StacMan
{
    /// <summary>
    /// StacMan Answer, corresponding to Stack Exchange API v2's answer type
    /// http://api.stackexchange.com/docs/types/answer
    /// </summary>
    public partial class Answer : StacManType
    {
        /// <summary>
        /// answer_id
        /// </summary>
        [Field("answer_id")]
        public int AnswerId { get; internal set; }

        /// <summary>
        /// body
        /// </summary>
        [Field("body")]
        public string Body { get; internal set; }

        /// <summary>
        /// comments
        /// </summary>
        [Field("comments")]
        public Comment[] Comments { get; internal set; }

        /// <summary>
        /// community_owned_date
        /// </summary>
        [Field("community_owned_date")]
        public DateTime? CommunityOwnedDate { get; internal set; }

        /// <summary>
        /// creation_date
        /// </summary>
        [Field("creation_date")]
        public DateTime CreationDate { get; internal set; }

        /// <summary>
        /// down_vote_count
        /// </summary>
        [Field("down_vote_count")]
        public int DownVoteCount { get; internal set; }

        /// <summary>
        /// is_accepted
        /// </summary>
        [Field("is_accepted")]
        public bool IsAccepted { get; internal set; }

        /// <summary>
        /// last_activity_date
        /// </summary>
        [Field("last_activity_date")]
        public DateTime LastActivityDate { get; internal set; }

        /// <summary>
        /// last_edit_date
        /// </summary>
        [Field("last_edit_date")]
        public DateTime? LastEditDate { get; internal set; }

        /// <summary>
        /// link
        /// </summary>
        [Field("link")]
        public string Link { get; internal set; }

        /// <summary>
        /// locked_date
        /// </summary>
        [Field("locked_date")]
        public DateTime? LockedDate { get; internal set; }

        /// <summary>
        /// owner
        /// </summary>
        [Field("owner")]
        public ShallowUser Owner { get; internal set; }

        /// <summary>
        /// question_id
        /// </summary>
        [Field("question_id")]
        public int QuestionId { get; internal set; }

        /// <summary>
        /// score
        /// </summary>
        [Field("score")]
        public int Score { get; internal set; }

        /// <summary>
        /// title
        /// </summary>
        [Field("title")]
        public string Title { get; internal set; }

        /// <summary>
        /// up_vote_count
        /// </summary>
        [Field("up_vote_count")]
        public int UpVoteCount { get; internal set; }

    }
}
