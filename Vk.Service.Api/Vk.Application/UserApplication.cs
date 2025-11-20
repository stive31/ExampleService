using System.ComponentModel.Design;
using Vk.Domain.Dictionary.Models;
using Vk.Domain.User.Models;
using Vk.Domain.User.Models.Models;

using System;
using Microsoft.Extensions.Logging;
using Vk.Domain.Repositories.EntryUser;

namespace Vk.Application;

public class UserApplication : IUserApplication
{
    private readonly IDictionaryService _dictionaryService;
    private readonly IUserService _userService;
    private readonly IConnectionFactory _userRep;
    private readonly IEntryUserRepository _entryUserRepo;
    private readonly IGeneralService _generalService;
    private readonly ILogger<UserApplication> _logger;
    public UserApplication(
        IDictionaryService dictionaryService,
        IUserService userService,
        ILogger<UserApplication> logger,
        IConnectionFactory userRepo,
        IEntryUserRepository entryUserRepo,
        IGeneralService generalService)
    {

    }
    public Task<UserModel> GetAsync(string winLogin)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DomainDrTypeItemFull>> GetRolesAsync(string winLogin)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<UserModel>> ImportAsync(IEnumerable<string> winLogins)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<UserCredentials>> SearchUserAsync(string filter)
    {
        throw new NotImplementedException();
    }

    public Task<UserModel> SuncAsync(string winLogin)
    {
        throw new NotImplementedException();
    }
}
