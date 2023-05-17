namespace API_JWT.Models
{
    public class UserToken
    {
        public string Token { get; set; } = default!;
        public DateTime Expiration { get; set; }
    }
}
