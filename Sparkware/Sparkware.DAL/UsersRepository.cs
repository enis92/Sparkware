using System;
using System.Collections.Generic;
using System.Linq;

namespace Sparkware.DAL {
    public class UsersRepository : BaseRepository {
        public List<DM.User> GetAllUsers() {
            return DataContext.Users.OrderBy(el => el.Id).Select(el => new DM.User() {
                Id = el.Id,
                FirstName = el.FirstName,
                LastName = el.LastName,
                Username = el.Username,
                DateOfBirth = el.DateOfBirth
            }).ToList();
        }

        public DM.User GetUserById(Guid id) {
            var user = DataContext.Users.FirstOrDefault(el => el.Id == id);

            if (user != null) {
                return new DM.User() {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Username = user.Username,
                    DateOfBirth = user.DateOfBirth
                };
            }
            else return null;
        }

        public Guid SaveUser(DM.User user) {
            var existingUser = DataContext.Users.FirstOrDefault(el => el.Id == user.Id);

            if (existingUser == null) {
                var newUser = new DM.User() {
                    Id = Guid.NewGuid(),
                    FirstName = existingUser.FirstName,
                    LastName = existingUser.LastName,
                    Username = user.Username,
                    DateOfBirth = user.DateOfBirth
                };

                DataContext.Users.Add(existingUser);
                DataContext.SaveChanges();
            }

            return existingUser.Id;
        }
    }
}