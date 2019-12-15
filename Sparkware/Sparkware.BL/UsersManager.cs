using System;
using System.Collections.Generic;

namespace Sparkware.BL {
    public class UsersManager : BaseManager, IUsersManager {
        public List<DM.User> GetAllUsers() {
            return UsersRepository.GetAllUsers();
        }

        public DM.User GetUserById(Guid id) {
            return UsersRepository.GetUserById(id);
        }

        public Guid SaveUser(DM.User user) {
            return UsersRepository.SaveUser(user);
        }
    }
}