
using Relations.DataContext;
using Relations.Entities;

using (AppDbContext db = new AppDbContext())
{
    User user1 = new User { Name = "Khurhsed" };
    User user2 = new User { Name = "Musik" };
    db.Users.AddRange(user1, user2);
    db.SaveChanges();
    
    
    Profile profile1 = new Profile { UserName = "khurhsed123",User = user1 };
    Profile profile2 = new Profile { UserName = "musik456", User = user2 };
    db.Profiles.AddRange(profile1, profile2);
    db.SaveChanges();

    foreach (var user in db.Users.ToList())
    {
        Console.WriteLine($"User {user.Name}, his profile {user.Profile.UserName}");
    }
}