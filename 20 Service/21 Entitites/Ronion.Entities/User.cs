namespace Ronion.Entities
{
    /// <summary>
    /// Represent a user
    /// </summary>
    public class User
    {
        /// <summary>
        /// User's username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Users' password credential
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// User's email
        /// </summary>
        public string Email { get; set; }
    }
}
