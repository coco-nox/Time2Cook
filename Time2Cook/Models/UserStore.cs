using System.Collections.Concurrent;
using System.Security.Cryptography;
using System.Text;

namespace Time2Cook.Models
{
    public record UserRecord(string PasswordHash, DateTime JoinedAt);

    public static class UserStore
    {
        private static readonly ConcurrentDictionary<string, UserRecord> _users =
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
            if (!_users.TryAdd(email, new UserRecord(Hash(password), DateTime.UtcNow)))
            {
                error = "An account with that email already exists.";
                return false;
            }
            error = "";
            return true;
        }

        public static bool Validate(string email, string password)
        {
            return _users.TryGetValue(email.Trim().ToLower(), out var record)
                   && record.PasswordHash == Hash(password);
        }

        public static bool ChangePassword(string email, string currentPassword, string newPassword, out string error)
        {
            email = email.Trim().ToLower();
            if (!_users.TryGetValue(email, out var record))
            {
                error = "Account not found.";
                return false;
            }
            if (record.PasswordHash != Hash(currentPassword))
            {
                error = "Current password is incorrect.";
                return false;
            }
            if (newPassword.Length < 6)
            {
                error = "New password must be at least 6 characters.";
                return false;
            }
            _users[email] = record with { PasswordHash = Hash(newPassword) };
            error = "";
            return true;
        }

        public static DateTime? GetJoinDate(string email) =>
            _users.TryGetValue(email.Trim().ToLower(), out var record) ? record.JoinedAt : null;

        private static string Hash(string password)
        {
            var bytes = SHA256.HashData(Encoding.UTF8.GetBytes("t2c_salt:" + password));
            return Convert.ToHexString(bytes);
        }
    }
}
