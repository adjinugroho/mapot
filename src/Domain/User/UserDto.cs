namespace Domain.User
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Name { get; set; }
    }
}
