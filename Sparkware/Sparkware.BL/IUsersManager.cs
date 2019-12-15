using System;
using System.Collections.Generic;

namespace Sparkware.BL {
    public interface IUsersManager {
        List<DM.User> GetAllUsers();
        DM.User GetUserById(Guid id);
        Guid SaveUser(DM.User user);
    }
}