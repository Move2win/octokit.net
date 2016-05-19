#if NET_45
using System.Collections.Generic;
using System.Threading.Tasks;
#endif

namespace Octokit
{
    /// <summary>
    /// A client for GitHub's Collaborators on a Repository.
    /// </summary>
    /// <remarks>
    /// See the <a href="http://developer.github.com/v3/repos/collaborators/">Collaborators API documentation</a> for more details.
    /// </remarks>
    public interface IRepoCollaboratorsClient
    {
        /// <summary>
        /// Gets all the collaborators on a repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/collaborators/#list">API documentation</a> for more information.
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        /// <returns>A <see cref="IReadOnlyPagedCollection{User}"/> of <see cref="User"/>.</returns>
        Task<IReadOnlyList<User>> GetAll(string owner, string name);

        /// <summary>
        /// Gets all the collaborators on a repository.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/collaborators/#list">API documentation</a> for more information.
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="options">Options for changing the API response</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        /// <returns>A <see cref="IReadOnlyPagedCollection{User}"/> of <see cref="User"/>.</returns>
        Task<IReadOnlyList<User>> GetAll(string owner, string name, ApiOptions options);

        /// <summary>
        /// Checks if a user is a collaborator on a repo
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/collaborators/#get">API documentation</a> for more information.
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="user">The name of the user</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        /// <returns><see cref="bool"/>True if user is a collaborator else false</returns>
        Task<bool> IsCollaborator(string owner, string name, string user);

        /// <summary>
        /// Adds a new collaborator to the repo
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/collaborators/#add-collaborator">API documentation</a> for more information.
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="user">The name of the user</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        /// <returns><see cref="Task"/></returns>
        Task Add(string owner, string name, string user);

        /// <summary>
        /// Deletes a collaborator from the repo
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/repos/collaborators/#remove-collaborator">API documentation</a> for more information.
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="user">The name of the user</param>
        /// <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        /// <returns><see cref="Task"/></returns>
        Task Delete(string owner, string name, string user);
    }
}
