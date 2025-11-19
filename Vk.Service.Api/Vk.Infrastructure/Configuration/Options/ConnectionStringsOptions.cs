using System.ComponentModel.DataAnnotations;

namespace Vk.Infrastructure.Configuration.Options;

public class ConnectionStringsOptions
{
    [Required(ErrorMessage = "Обязательный параметр")]
    public string LM { get; set; }

    public string KK { get; set; }

    public string EntryConnectionString { get; set; }
}
