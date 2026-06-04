using System.Collections.Concurrent;
using System.Security.Cryptography;
using System.Text;

namespace Time2Cook.Models
{
    public static class UserStore
    {
        private static readonly ConcurrentDictionary<string, string> _users =
            new(StringComparer.OrdinalIgnoreCase);

        public static bool Register(string email, string password, out string error)
        {
            email = email.Trim().ToLower();
            if (!email.Contains('@') || !email.Contains('.'))
            {
                error = "Please enter a valid email address.";
                return false;
            }
            if (password.Length < 6)
            {
                error = "Password must be at least 6 characters.";
                return false;
            }
            if (!_users.TryAdd(email, Hash(password)))
            {
                error = "An account with that email already exists.";
                return false;
            }
            error = "";
            return true;
        }

        public static bool Validate(string email, string password)
        {
            return _users.TryGetValue(email.Trim().ToLower(), out var hash)
                   && hash == Hash(password);
        }

        private static string Hash(string password)
        {
            var bytes = SHA256.HashData(Encoding.UTF8.GetBytes("t2c_salt:" + password));
            return Convert.ToHexString(bytes);
        }
    }
}
