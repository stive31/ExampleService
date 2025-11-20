namespace Vk.Domain.Services.General;

public interface IGeneralService
{
    Task ClearMapAsync(string mapName);

    Task ClearRecordsAsync(string mapName, IEnumerable<string> recordKeys);

    Task ClearRecordsAsync(string mapName, string recordKeyPart);
}
