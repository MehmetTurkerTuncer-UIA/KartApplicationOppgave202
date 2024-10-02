using System.ComponentModel.DataAnnotations;

public class FormModel
{
    [Required]
    public string Name { get; set; }

    [Required]
    public string Email { get; set; }
}

