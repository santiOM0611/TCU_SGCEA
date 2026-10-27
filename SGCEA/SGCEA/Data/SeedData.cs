using Microsoft.AspNetCore.Identity;

namespace SGCEA.Data
{
    public static class SeedData
    {
        public static async Task InicializarAsync(IServiceProvider servicios)
        {
            var userManager = servicios.GetRequiredService<UserManager<IdentityUser>>();
            var roleManager = servicios.GetRequiredService<RoleManager<IdentityRole>>();

            // Crear rol Admin si no existe
            if (!await roleManager.RoleExistsAsync("Admin"))
            {
                await roleManager.CreateAsync(new IdentityRole("Admin"));
            }

            // Crear usuario admin si no existe
            string correo = "admin@sgcea.cr";
            string password = "Admin1234";

            if (await userManager.FindByEmailAsync(correo) == null)
            {
                var usuario = new IdentityUser
                {
                    UserName = correo,
                    Email = correo,
                    EmailConfirmed = true
                };

                var resultado = await userManager.CreateAsync(usuario, password);

                if (resultado.Succeeded)
                {
                    await userManager.AddToRoleAsync(usuario, "Admin");
                }
            }
        }
    }
}