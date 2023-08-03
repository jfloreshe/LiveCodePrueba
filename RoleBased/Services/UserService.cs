using RoleBased.Data;
using RoleBased.DTO;

namespace RoleBased.Services;

public class UserService
{
    private RoleBasedContext _ctx;

    public UserService(RoleBasedContext ctx)
    {
        _ctx = ctx;
    }
    public async Task<int> CreateUser(UserDTO user, string userSession)
    {
        var entity = new User()
        {
            Name = user.Name,
            LastName = user.LastName,
            Gender = user.Gender,
            Mail = user.Email,
            LogDateCreation = DateTime.Now,
            LogDateModification = DateTime.Now,
            LogUserCreation = userSession,
            LogUserModification = userSession
        };
        await _ctx.AddAsync(entity);
        await _ctx.SaveChangesAsync();
        return entity.IdUser;
    }

    //public Task UpdateUser()
    //{

    //}

    //public Task DeleteUser()
    //{

    //}

    //public Task FindUser()
    //{

    //}

    public Task FindAllUsers()
    {

    }
}
