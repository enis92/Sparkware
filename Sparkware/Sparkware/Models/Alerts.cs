namespace Sparkware.Models {
    public class Alerts {
        public const string SUCCESS = "success";
        public const string WARNING = "warning";
        public const string ERROR = "error";
        public const string INFO = "info";

        public static string[] All {
            get {
                return new[] {
                    SUCCESS,
                    WARNING,
                    INFO,
                    ERROR
                };
            }
        }

    }
}