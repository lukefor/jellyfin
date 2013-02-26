using System.Threading.Tasks;
using Mediabrowser.Model.Entities;

namespace MediaBrowser.Common.Security
{
    public interface ISecurityManager
    {
        /// <summary>
        /// Gets a value indicating whether this instance is MB supporter.
        /// </summary>
        /// <value><c>true</c> if this instance is MB supporter; otherwise, <c>false</c>.</value>
        bool IsMBSupporter { get; }

        /// <summary>
        /// Gets or sets the supporter key.
        /// </summary>
        /// <value>The supporter key.</value>
        string SupporterKey { get; set; }

        /// <summary>
        /// Gets or sets the legacy key.
        /// </summary>
        /// <value>The legacy key.</value>
        string LegacyKey { get; set; }

        /// <summary>
        /// Gets the registration status.
        /// </summary>
        /// <param name="feature">The feature.</param>
        /// <param name="mb2Equivalent">The MB2 equivalent.</param>
        /// <returns>Task{MBRegistrationRecord}.</returns>
        Task<MBRegistrationRecord> GetRegistrationStatus(string feature, string mb2Equivalent = null);
    }
}