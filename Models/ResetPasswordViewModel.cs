using System.ComponentModel.DataAnnotations;

namespace NikeStyle.Models;
public class ResetPasswordViewModel
{
    [Required]
    public string Token {get;set;}
    [Required]
    [EmailAddress]
    public string Email {get;set;}
    [Required]
    [DataType(DataType.Password)]
    public string Password {get;set;}
};