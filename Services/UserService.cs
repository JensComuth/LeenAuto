using testLeenAuto.Shared;
using testLeenAUto.Context;
using testLeenAUto.Entities;

namespace testLeenAUto.Services
{
    public class UserService
    {
        private readonly leenAutoDbContext dbContext;

        public IEnumerable<UserDto> getUsers()
        {
            return dbContext.Users.Select(x => new UserDto
            {
                Id = x.Id,
                Name = x.Name,
                Email = x.Email
            });
        }

        public UserDto CreateUser(User user)
        {
            dbContext.Users.Add(user);
            dbContext.SaveChanges();

            return new UserDto
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email
            };
        }
    }
}
