using System.Collections.Generic;

namespace System.CommandLine.Parsing;

public interface IUserCommand
{
    string UserInput { get;}
    object Author { get; }

    /// <summary>
    /// Determines if the current user has access to the specified permission.
    /// </summary>
    /// <param name="permissionId">The unique identifier of the permission.</param>
    /// <returns>True if the user has access, false otherwise.</returns>
    bool HasAccess(Guid permissionId);
}