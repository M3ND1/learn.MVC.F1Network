using F1Network.Models;

namespace F1Network.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                if (!context.Drivers.Any())
                {
                    var mercedes = new Manufacturer
                    {
                        Name = "Mercedes-AMG Petronas F1 Team",
                        PictureURL = "https://i.pinimg.com/originals/fb/29/3d/fb293d8f472824f541de596f3d2a54d6.png",
                        Description = "Mercedes-Benz's Formula One team."
                    };

                    var ferrari = new Manufacturer
                    {
                        Name = "Scuderia Ferrari Mission Winnow",
                        PictureURL = "https://i.pinimg.com/originals/c6/35/f1/c635f14b99a4a3645b1d992a20cbfd52.jpg",
                        Description = "Ferrari's Formula One team."
                    };
                    var redBull = new Manufacturer 
                    { 
                        Name = "Red Bull Racing", 
                        PictureURL = "https://cdn-6.motorsport.com/images/mgl/Y99JQRbY/s8/red-bull-racing-logo-1.jpg", 
                        Description = "Red Bull Racing is a Formula One racing team, racing under an Austrian licence and based in the United Kingdom." 
                    };

                    context.Manufacturers.AddRange(mercedes, ferrari, redBull);
                    context.SaveChanges();

                    var lewis = new Driver
                    {
                        FullName = "Lewis Hamilton",
                        PictureURL = "https://media.formula1.com/content/dam/fom-website/drivers/2023Drivers/hamilton.jpg.img.1536.high.jpg",
                        Description = "British racing driver and seven-time Formula One World Champion.",
                        Manufacturer = mercedes,
                        Car = new Car
                        {
                            Model = "Mercedes-AMG F1 W13 E Performance",
                            PictureURL = "https://cdn-3.motorsport.com/images/amp/YMdyjMg2/s6/mercedes-w14-1.jpg",
                            Description = "The Mercedes-AMG F1 W13 E Performance is a Formula One racing car designed and constructed by Mercedes-AMG Petronas F1 Team for use in the 2022 Formula One World Championship.",
                            Manufacturer = mercedes
                        }
                    };

                    var max = new Driver
                    {
                        FullName = "Max Verstappen",
                        PictureURL = "https://media.formula1.com/content/dam/fom-website/drivers/2023Drivers/verstappen.jpg.img.1536.high.jpg",
                        Description = "Dutch racing driver and two-time Formula One World Champion.",
                        Manufacturer = redBull,
                        Car = new Car
                        {
                            Model = "Red Bull Racing RB18",
                            PictureURL = "https://cdn-8.motorsport.com/images/mgl/6n9RnBeY/s8/red-bull-racing-rb18-1.jpg",
                            Description = "The Red Bull Racing RB18 is a Formula One racing car designed and constructed by Red Bull Racing for use in the 2022 Formula One World Championship.",
                            Manufacturer = redBull
                        }
                    };

                    var charles = new Driver
                    {
                        FullName = "Charles Leclerc",
                        PictureURL = "https://media.formula1.com/content/dam/fom-website/drivers/2023Drivers/leclerc.jpg.img.1536.high.jpg",
                        Description = "Monegasque racing driver currently competing in Formula One for Scuderia Ferrari.",
                        Manufacturer = ferrari,
                        Car = new Car
                        {
                            Model = "Ferrari SF22",
                            PictureURL = "https://motorsportmagazine.b-cdn.net/wp-content/uploads/2023/02/Ferrari.jpg",
                            Description = "The Ferrari SF22 is a Formula One racing car designed and constructed by Scuderia Ferrari for use in the 2022 Formula One World Championship.",
                            Manufacturer = ferrari
                        }
                    };

                    context.Drivers.AddRange(lewis, max, charles);
                    context.SaveChanges();
                }
            }
        }
    }
}
