
using Shared.Common.Entities;

namespace SharedAPI.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }


        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckUsersAsync();
        }

        private async Task CheckUsersAsync()
        {
            if (!_context.Users.Any())
            {

                _context.Users.Add(new User { Email ="heber76@hotmail.com",FirstName="Heber",LastName="Ochoa Prieto",Password="123456",Phone="614 140 21 25"});
                _context.Users.Add(new User { Email = "Ladys76@yogmail.com", FirstName = "Ladys", LastName = "Bedoya", Password = "123456", Phone = "614 140 21 25" });
                _context.Users.Add(new User { Email = "Chombo76@hotmail.com", FirstName = "Adrian", LastName = "Ochoa Prieto", Password = "123456", Phone = "614 140 21 25" });
                _context.Users.Add(new User { Email = "oscar81@hotmail.com", FirstName = "Oscar alejandro", LastName = "Ochoa Prieto", Password = "123456", Phone = "614 140 21 25" });
                await _context.SaveChangesAsync();
            }

        }
    }
}
