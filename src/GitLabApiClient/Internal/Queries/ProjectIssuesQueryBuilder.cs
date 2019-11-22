using GitLabApiClient.Models.Issues.Requests;

namespace GitLabApiClient.Internal.Queries
{
    internal sealed class ProjectIssuesQueryBuilder : IssuesQueryBuilder
    {
        protected override void BuildCore(IssuesQueryOptions options)
        {
            if (!(options is ProjectIssuesQueryOptions projectIssuesQueryOptions))
            {
                base.BuildCore(options);
                return;
            }

            base.BuildCore(options);
        }
    }
}
