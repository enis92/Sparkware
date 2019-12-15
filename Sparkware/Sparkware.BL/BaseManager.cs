using Sparkware.DAL;

namespace Sparkware.BL {
    public class BaseManager {
        private UsersRepository usersRepository;

        public UsersRepository UsersRepository {
            get { return usersRepository ?? (usersRepository = new UsersRepository()); }
        }
    }
}