using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Username is required.")]
    [Column(TypeName = "VarChar(20)")]
    public string Username { get; set; }

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
    [Column(TypeName = "VarChar(50)")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Password is required.")]
    [MinLength(6, ErrorMessage = "Password must be at least 6 characters long.")]
    [DataType(DataType.Password)]
    [Column(TypeName = "VarChar(20)")]
    public string Password { get; set; }

    [NotMapped]
    [Required(ErrorMessage = "Password confirmation is required.")]
    [Compare("Password", ErrorMessage = "Passwords do not match.")]
    [DataType(DataType.Password)]
    [Column(TypeName = "VarChar(20)")]
    public string ConfirmPassword { get; set; }

    [Required(ErrorMessage = "Student/Teacher option is required.")]
    public bool IsStudent { get; set; }
}
