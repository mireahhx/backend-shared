namespace Shared.Configuration.Exceptions {
    public class ConfigMissFieldException(string field) : Exception($"{field} missing") { }
}