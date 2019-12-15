namespace Sparkware.DAL {
    public class BaseRepository {
        private SparkwareEntities _dataContext;
        public SparkwareEntities DataContext => _dataContext ?? (_dataContext = new SparkwareEntities());

        public string ConnectionString { get; private set; }

        public BaseRepository(string connectionString = null) {
            ConnectionString = connectionString;
        }
    }
}