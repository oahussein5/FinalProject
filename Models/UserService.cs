using FinalProject.Data;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class UserService
    {
        private readonly FinalProjectContext _context;

        public UserService(FinalProjectContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateUserAsync(User user)
        {
            try
            {
                _context.User.Add(user); // Assuming you have a DbSet<User> in your ApplicationDbContext
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
