namespace Vk.Domain.EntryUser;

public interface IEntryUserRepository
{
    void ChangeUser(EntryUserModel user);
    EntryUserModel GetUser(string token);
}
