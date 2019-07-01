namespace Chimper.Migrations
{
    using Chimper.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Chimper.DAL.ChimperContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Chimper.DAL.ChimperContext context)
        {
            context.AboutSayings.AddOrUpdate(x => x.Id,
        new AboutSayings() { Id = 1, Name = "Christine Rooster", Position = "CO-FOUNDER, PRESIDENT", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Nisi at consequatur unde molestiae quidem provident voluptatum deleniti quo iste error eos est praesentium distinctio cupiditate tempore suscipit inventore deserunt tenetur." },
        new AboutSayings() { Id = 2, Name = "Brandon Sharp", Position = "CO-FOUNDER, PRESIDENT", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Nisi at consequatur unde molestiae quidem provident voluptatum deleniti quo iste error eos est praesentium distinctio cupiditate tempore suscipit inventore deserunt tenetur." },
        new AboutSayings() { Id = 3, Name = "Christine Rooster", Position = "CO-FOUNDER, PRESIDENT", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Nisi at consequatur unde molestiae quidem provident voluptatum deleniti quo iste error eos est praesentium distinctio cupiditate tempore suscipit inventore deserunt tenetur." }
        );

            context.CompanyFeatures.AddOrUpdate(x => x.Id,
        new CompanyFeatures() { Id = 1, Title = "Our Values", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Et praesentium eos nulla qui commodi consectetur beatae fugiat. Veniam iste rerum perferendis." },
        new CompanyFeatures() { Id = 2, Title = "Our Mission", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Et praesentium eos nulla qui commodi consectetur beatae fugiat. Veniam iste rerum perferendis." },
        new CompanyFeatures() { Id = 3, Title = "Our Philosophy", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Et praesentium eos nulla qui commodi consectetur beatae fugiat. Veniam iste rerum perferendis." }
        );

            context.ContactInfos.AddOrUpdate(x => x.Id,
        new ContactInfo() { Id = 1, Adress = "203 Fake St. Mountain View, San Francisco, California, USA", Phone = "+1 232 3235 324", Email = "youremail@domain.com" }

        );

            context.HomeBlogs.AddOrUpdate(x => x.Id,
        new HomeBlog() { Id = 1, Title = "Create Beautiful Website In Less Than An Hour", AuthorName = "Ham Brook", Date = DateTime.Parse("01-18-2019"), Category = "News", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Natus eligendi nobis ea maiores sapiente veritatis reprehenderit suscipit quaerat rerum voluptatibus a eius." },
        new HomeBlog() { Id = 2, Title = "Create Beautiful Website In Less Than An Hour", AuthorName = "James Phelps", Date = DateTime.Parse("01-18-2019"), Category = "News", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Natus eligendi nobis ea maiores sapiente veritatis reprehenderit suscipit quaerat rerum voluptatibus a eius." },
        new HomeBlog() { Id = 3, Title = "Create Beautiful Website In Less Than An Hour", AuthorName = "Ham Brook", Date = DateTime.Parse("01-18-2019"), Category = "News", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Natus eligendi nobis ea maiores sapiente veritatis reprehenderit suscipit quaerat rerum voluptatibus a eius." }

        );

            context.HomeCharaches.AddOrUpdate(x => x.Id,
        new HomeCharach() { Id = 1, Icon = "phonelink ", Title = "Web Design", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Cumque ab nihil quam nesciunt." },
        new HomeCharach() { Id = 2, Icon = "format_paint  ", Title = "Art Direction", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Cumque ab nihil quam nesciunt." },
        new HomeCharach() { Id = 3, Icon = "extension  ", Title = "Web Design", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Cumque ab nihil quam nesciunt." },
        new HomeCharach() { Id = 4, Icon = "question_answer  ", Title = "Web Design", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Cumque ab nihil quam nesciunt." }
        );

            context.HomeProjects.AddOrUpdate(x => x.Id,
        new HomeProjects() { Id = 1, ProjectName = "Project Name 1", ProjectType = "Web Application" },
        new HomeProjects() { Id = 2, ProjectName = "Project Name 1", ProjectType = "Web Application" },
        new HomeProjects() { Id = 3, ProjectName = "Project Name 1", ProjectType = "Web Application" }
        );

            context.MoreInfos.AddOrUpdate(x => x.Id,
                new MoreInfo { Id = 1, Title = "More Info", Text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ipsa ad iure porro mollitia architecto hic consequuntur. Distinctio nisi perferendis dolore, ipsa consectetur? Fugiat quaerat eos qui, libero neque sed nulla." }
        );

            context.PopularPosts.AddOrUpdate(x => x.Id,
        new PopularPosts() { Id = 1, LinkText = "Lorem ipsum dolor sit amet" },
        new PopularPosts() { Id = 2, LinkText = "Quaerat rerum voluptatibus veritatis" },
        new PopularPosts() { Id = 3, LinkText = "Maiores sapiente veritatis reprehenderit" },
        new PopularPosts() { Id = 4, LinkText = "Natus eligendi nobis" }
        );

            context.RealBogs.AddOrUpdate(x => x.Id,
        new RealBog() { Id = 1, Title = "Create Beautiful Website In Less Than An Hour", AuthorName = "Ham Brook", Date = DateTime.Parse("01-18-2019"), Category = "News", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Natus eligendi nobis ea maiores sapiente veritatis reprehenderit suscipit quaerat rerum voluptatibus a eius." },
        new RealBog() { Id = 2, Title = "Create Beautiful Website In Less Than An Hour", AuthorName = "James Phelps", Date = DateTime.Parse("01-18-2019"), Category = "News", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Natus eligendi nobis ea maiores sapiente veritatis reprehenderit suscipit quaerat rerum voluptatibus a eius." },
        new RealBog() { Id = 3, Title = "Create Beautiful Website In Less Than An Hour", AuthorName = "Ham Brook", Date = DateTime.Parse("01-18-2019"), Category = "News", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Natus eligendi nobis ea maiores sapiente veritatis reprehenderit suscipit quaerat rerum voluptatibus a eius." },
        new RealBog() { Id = 4, Title = "Create Beautiful Website In Less Than An Hour", AuthorName = "Ham Brook", Date = DateTime.Parse("01-18-2019"), Category = "News", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Natus eligendi nobis ea maiores sapiente veritatis reprehenderit suscipit quaerat rerum voluptatibus a eius." },
        new RealBog() { Id = 5, Title = "Create Beautiful Website In Less Than An Hour", AuthorName = "James Phelps", Date = DateTime.Parse("01-18-2019"), Category = "News", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Natus eligendi nobis ea maiores sapiente veritatis reprehenderit suscipit quaerat rerum voluptatibus a eius." },
        new RealBog() { Id = 6, Title = "Create Beautiful Website In Less Than An Hour", AuthorName = "Ham Brook", Date = DateTime.Parse("01-18-2019"), Category = "News", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Natus eligendi nobis ea maiores sapiente veritatis reprehenderit suscipit quaerat rerum voluptatibus a eius." }

        );

            context.ServicesResps.AddOrUpdate(x => x.Id,
        new ServicesResp() { Id = 1, Title = "Web Design", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Et praesentium eos nulla qui commodi consectetur beatae fugiat. Veniam iste rerum perferendis." },
        new ServicesResp() { Id = 2, Title = "Web Design", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Et praesentium eos nulla qui commodi consectetur beatae fugiat. Veniam iste rerum perferendis." },
        new ServicesResp() { Id = 3, Title = "Web Design", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Et praesentium eos nulla qui commodi consectetur beatae fugiat. Veniam iste rerum perferendis." },
        new ServicesResp() { Id = 4, Title = "Web Design", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Et praesentium eos nulla qui commodi consectetur beatae fugiat. Veniam iste rerum perferendis." },
        new ServicesResp() { Id = 5, Title = "Web Design", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Et praesentium eos nulla qui commodi consectetur beatae fugiat. Veniam iste rerum perferendis." },
        new ServicesResp() { Id = 6, Title = "Web Design", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Et praesentium eos nulla qui commodi consectetur beatae fugiat. Veniam iste rerum perferendis." }
        );

            context.ServicesUppers.AddOrUpdate(x => x.Id,
        new ServicesUpper() { Id = 1, Title = "Web Design", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Et praesentium eos nulla qui commodi consectetur beatae fugiat. Veniam iste rerum perferendis." , Icon = "laptop2" },
        new ServicesUpper() { Id = 2, Title = "Web Design", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Et praesentium eos nulla qui commodi consectetur beatae fugiat. Veniam iste rerum perferendis.", Icon = "laptop2" },
        new ServicesUpper() { Id = 3, Title = "Web Design", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Et praesentium eos nulla qui commodi consectetur beatae fugiat. Veniam iste rerum perferendis.", Icon = "laptop2" },
        new ServicesUpper() { Id = 4, Title = "Web Design", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Et praesentium eos nulla qui commodi consectetur beatae fugiat. Veniam iste rerum perferendis.", Icon = "laptop2" },
        new ServicesUpper() { Id = 5, Title = "Web Design", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Et praesentium eos nulla qui commodi consectetur beatae fugiat. Veniam iste rerum perferendis.", Icon = "laptop2" },
        new ServicesUpper() { Id = 6, Title = "Web Design", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Et praesentium eos nulla qui commodi consectetur beatae fugiat. Veniam iste rerum perferendis.", Icon = "laptop2" }
        );

            context.Specialities.AddOrUpdate(x => x.Id,
        new Specialities { Id = 1, Icon = "phonelink" , Title = "Web & Mobile Specialties", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Perferendis quis consect." },
        new Specialities { Id = 2, Icon = "extension", Title = "Intuitive Thinkers", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Perferendis quis consect." }

        );

            context.Testimonials.AddOrUpdate(x => x.Id,
        new Testimonials() { Id = 1, PersonName = "John Smith", Text = "“Lorem ipsum dolor sit amet consectetur adipisicing elit. Consectetur unde reprehenderit aperiam quaerat fugiat repudiandae explicabo animi minima fuga beatae illum eligendi incidunt consequatur. Amet dolores excepturi earum unde iusto.”" },
        new Testimonials() { Id = 2, PersonName = "John Smith", Text = "“Lorem ipsum dolor sit amet consectetur adipisicing elit. Consectetur unde reprehenderit aperiam quaerat fugiat repudiandae explicabo animi minima fuga beatae illum eligendi incidunt consequatur. Amet dolores excepturi earum unde iusto.”" },
        new Testimonials() { Id = 3, PersonName = "John Smith", Text = "“Lorem ipsum dolor sit amet consectetur adipisicing elit. Consectetur unde reprehenderit aperiam quaerat fugiat repudiandae explicabo animi minima fuga beatae illum eligendi incidunt consequatur. Amet dolores excepturi earum unde iusto.”" },
        new Testimonials() { Id = 4, PersonName = "John Smith", Text = "“Lorem ipsum dolor sit amet consectetur adipisicing elit. Consectetur unde reprehenderit aperiam quaerat fugiat repudiandae explicabo animi minima fuga beatae illum eligendi incidunt consequatur. Amet dolores excepturi earum unde iusto.”" }
        );
        }
    }
}
