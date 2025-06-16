using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace Event_Management_System
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            SeedAdminAndRoles(); 
        }

        private void SeedAdminAndRoles()
        {
            using (var context = new ApplicationDbContext())
            {
                var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
                var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

             
                if (!roleManager.RoleExists("Admin"))
                    roleManager.Create(new IdentityRole("Admin"));

                if (!roleManager.RoleExists("User"))
                    roleManager.Create(new IdentityRole("User"));

           
                var adminEmail = "ojha0205@gmail.com";
                var adminPassword = "Admin@123";

                
                var existingAdmin = userManager.FindByEmail(adminEmail);
                if (existingAdmin != null)
                {
                    
                    var roles = userManager.GetRoles(existingAdmin.Id);
                    foreach (var role in roles)
                    {
                        userManager.RemoveFromRole(existingAdmin.Id, role);
                    }

                    
                    userManager.Delete(existingAdmin);
                }

             
                var newAdmin = new ApplicationUser
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    FirstName = "Admin",
                    LastName = "User",
                    Age = 30,
                    ContactNumber = "1234567890",
                    EmailConfirmed = true 
                };

                var createResult = userManager.Create(newAdmin, adminPassword);
                if (createResult.Succeeded)
                {
                    userManager.AddToRole(newAdmin.Id, "Admin");
                }
                else
                {
                    throw new Exception("Failed to create admin: " + string.Join("; ", createResult.Errors));
                }

            }
            
        }

    }
}
