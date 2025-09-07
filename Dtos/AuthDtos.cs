using System.ComponentModel.DataAnnotations;

namespace DoConnect.Api.Dtos
{
    // DTO for user registration request.
    public class RegisterDto
    {
        // The username chosen by the user.
        // Must be provided and cannot exceed 40 characters.
        [Required, MaxLength(40)]
        public string Username { get; set; } = default!;

        // The user's email address.
        // Must be a valid email format.
        [Required, EmailAddress]
         public string Email { get; set; } = default!;

         //The password chosen by the user.
        // Must be at least 6 characters long.
        [Required, MinLength(6)]
         public string Password { get; set; } = default!;
    }

    // DTO for user login request.
    public class LoginDto
    {

        // The username or email entered by the user for authentication.
        [Required]
         public string UsernameOrEmail { get; set; } = default!;

         // The password entered by the user for authentication.
        [Required]
        public string Password { get; set; } = default!;
    }
}
