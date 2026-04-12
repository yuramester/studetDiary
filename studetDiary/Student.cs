using System;
using System.Security.Cryptography; 
using System.Text;

namespace studetDiary
{
    public class Student
    {
        public string Login { get; set; }

        
        private string _passwordHash;

        public Student(string login, string password)
        {
            Login = login;
            _passwordHash = HashPassword(password);
        }

        
        public bool Authenticate(string enteredPassword)
        {
            
            return _passwordHash == HashPassword(enteredPassword);
        }

        
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }
    }
}