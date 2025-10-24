using System.Collections.Generic;

namespace System.CommandLine.Parsing;

public interface IUserCommand
{
    string UserInput { get;}
    ulong UserId { get; }
    
    List<ulong>? RoleIds { get; } 
}