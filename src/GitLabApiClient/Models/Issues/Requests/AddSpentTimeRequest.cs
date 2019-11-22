using Newtonsoft.Json;

namespace GitLabApiClient.Models.Issues.Requests
{
    /// <summary>
    /// Used to add time to an issue
    /// </summary>
    public sealed class AddSpentTimeRequest
    {
        public AddSpentTimeRequest(int durationSeconds)
        {
            Duration = $"{durationSeconds}s";
        }

        /// <summary>
        /// The title of an issue.
        /// </summary>
        [JsonProperty("duration")]
        public string Duration { get; }

    }
}
