namespace ContaCerta.Api.Application.DTOs.Auth
{
    public class AuthResponse
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Token { get; set; }
    }
}
