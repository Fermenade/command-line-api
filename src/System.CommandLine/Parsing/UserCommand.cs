namespace System.CommandLine.Parsing;

public interface IUserCommand
{
    string UserInput { get;}
    ulong UserId { get; }
}