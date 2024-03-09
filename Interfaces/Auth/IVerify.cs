namespace Shared.Interfaces.Auth {
    public class IVerifyRequest {
        public string Token { get; set; }
    }

    public class IVerifyResponse {
        public uint Id { get; set; }
    }
}
