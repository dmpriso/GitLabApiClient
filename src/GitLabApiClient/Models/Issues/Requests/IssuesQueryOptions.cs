using System;
using System.Collections.Generic;
using GitLabApiClient.Models.Issues.Responses;

namespace GitLabApiClient.Models.Issues.Requests
{
    /// <summary>
    /// Options for issues listing
    /// </summary>
    public class IssuesQueryOptions
    {
        internal IssuesQueryOptions() { }

        /// <summary>
        /// Return all issues or just those that are opened or closed.
        /// Default is Opened.
        /// </summary>
        public IssueState State { get; set; }

        /// <summary>
        /// List of label names, issues must have all labels to be returned. 
        /// No+Label lists all issues with no labels.
        /// </summary>
        public IList<string> Labels { get; set; } = new List<string>();

        /// <summary>
        /// List of label names which may not be included
        /// </summary>
        public IList<string> NotLabels { get; set; } = new List<string>();

        /// <summary>
        /// The milestone title.
        /// </summary>
        public string MilestoneTitle { get; set; }

        /// <summary>
        /// Return issues for the given scope.
        /// Defaults to issues created by anyone. (Introduced in GitLab 9.5).
        /// </summary>
        public Scope Scope { get; set; }

        /// <summary>
        /// Return issues created by the given user id.
        /// </summary>
        public int? AuthorId { get; set; }

        /// <summary>
        /// Return issues assigned to the given user id (Introduced in GitLab 9.5).
        /// </summary>
        public int? AssigneeId { get; set; }

        /// <summary>
        /// Return only the issues having the given iid.
        /// </summary>
        public IList<int> IssueIds { get; set; } = new List<int>();

        /// <summary>
        /// Specifies issues order. Default is Creation time.
        /// </summary>
        public IssuesOrder Order { get; set; }

        /// <summary>
        /// Specifies project sort order. Default is desending.
        /// </summary>
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Search issues against their title and description
        /// </summary>
        public string Filter { get; set; }

        /// <summary>
        /// Return issues created after the given time (inclusive)
        /// </summary>
        public DateTime? CreatedAfter { get; set; }

        /// <summary>
        /// Return issues created before the given time (inclusive)
        /// </summary>
        public DateTime? CreatedBefore { get; set; }

        /// <summary>
        /// Return issues created after the given time (inclusive)
        /// </summary>
        public DateTime? UpdatedAfter { get; set; }

        /// <summary>
        /// Return issues created before the given time (inclusive)
        /// </summary>
        public DateTime? UpdatedBefore { get; set; }                
    }
}
