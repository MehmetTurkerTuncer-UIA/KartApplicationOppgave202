using System.ComponentModel.DataAnnotations;

public class FormModel
{
    [Required]
    public required string Name { get; set; }

    [Required]
    [EmailAddress]
    public required string Email { get; set; }

    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }
}
