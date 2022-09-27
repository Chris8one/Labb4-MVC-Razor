﻿using Labb4_MVC_Razor.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb4_MVC_Razor
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<BookCustomer> BookCustomers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Books
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 1,
                BookTitle = "The War of the Worlds (Signet Classics)",
                BookAuthor = "H. G. Wells",
                BookDescription = "So begins The War of the Worlds, the science fiction classic that first proposed the possibility of intelligent life on other planets and has enthralled readers for generations. This compelling tale describes the Martian invasion of earth. When huge, tireless creatures land in England, complete chaos erupts. Using their fiery heat rays and crushing strength, the aliens just may succeed in silencing all opposition. Is life on earth doomed? Will mankind survive? A timeless view of a universe turned upside down, The War of the Worlds is an ingenious and imaginative look into the possibilities of the future and the secrets yet to be revealed.",
                BookLanguage = "English",
                BookPublisher = "Signet Classics",
                PublicationDate = new DateTime(2007, 09, 04),
                BookISBN = "9780451530653",
                BookCoverImage = "\\Images\\TheWarOfTheWorlds.jpg",
                BookFormat = "Paperback",
                NoOfPages = 224,
                BookIsCheckedOut = false
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 2,
                BookTitle = "Patient Zero",
                BookAuthor = "Marilee Peters",
                BookDescription = "More people have died in disease epidemics than in wars or other disasters, but the process of identifying these diseases and determining how they spread is often a terrifying gamble. Epidemiologists have been ignored, mocked, or silenced all while trying to protect the population and identify “patient zero”—the first person to have contracted the disease, and a key piece in solving the epidemic puzzle.",
                BookLanguage = "English",
                BookPublisher = "Annick Press",
                PublicationDate = new DateTime(2021, 04, 06),
                BookISBN = "9781773215167",
                BookCoverImage = "\\Images\\PatientZero.jpg",
                BookFormat = "Hardcover",
                NoOfPages = 192,
                BookIsCheckedOut = false
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 3,
                BookTitle = "The Space Between Worlds",
                BookAuthor = "Micaiah Johnson",
                BookDescription = "Multiverse travel is finally possible, but there’s just one catch: No one can visit a world where their counterpart is still alive. Enter Cara, whose parallel selves happen to be exceptionally good at dying—from disease, turf wars, or vendettas they couldn’t outrun. Cara’s life has been cut short on 372 worlds in total." +
                "On this dystopian Earth, however, Cara has survived.Identified as an outlier and therefore a perfect candidate for multiverse travel, Cara is plucked from the dirt of the wastelands.Now what once made her marginalized has finally become an unexpected source of power. She has a nice apartment on the lower levels of the wealthy and walled-off Wiley City. She works—and shamelessly flirts—with her enticing yet aloof handler, Dell, as the two women collect off-world data for the Eldridge Institute.She even occasionally leaves the city to visit her family in the wastes, though she struggles to feel at home in either place.So long as she can keep her head down and avoid trouble, Cara is on a sure path to citizenship and security." +
                "But trouble finds Cara when one of her eight remaining doppelgängers dies under mysterious circumstances, plunging her into a new world with an old secret.What she discovers will connect her past and her future in ways she could have never imagined—and reveal her own role in a plot that endangers not just her world but the entire multiverse.",
                BookLanguage = "English",
                BookPublisher = "Random House",
                PublicationDate = new DateTime(2021, 06, 01),
                BookISBN = "9780593156919",
                BookCoverImage = "\\Images\\TheSpaceBetweenWorlds.jpg",
                BookFormat = "Paperback",
                NoOfPages = 336,
                BookIsCheckedOut = true
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 4,
                BookTitle = "Red Rising #1",
                BookAuthor = "Pierce Brown",
                BookDescription = "Darrow is a Red, a member of the lowest caste in the color-coded society of the future. Like his fellow Reds, he works all day, believing that he and his people are making the surface of Mars livable for future generations. Yet he toils willingly, trusting that his blood and sweat will one day result in a better world for his children." +
                "But Darrow and his kind have been betrayed.Soon he discovers that humanity reached the surface generations ago.Vast cities and lush wilds spread across the planet.Darrow—and Reds like him—are nothing more than slaves to a decadent ruling class." +
                "Inspired by a longing for justice, and driven by the memory of lost love, Darrow sacrifices everything to infiltrate the legendary Institute, a proving ground for the dominant Gold caste, where the next generation of humanity’s overlords struggle for power.He will be forced to compete for his life and the very future of civilization against the best and most brutal of Society’s ruling class. There, he will stop at nothing to bring down his enemies. . .even if it means he has to become one of them to do so.",
                BookLanguage = "English",
                BookPublisher = "Random House",
                PublicationDate = new DateTime(2014, 01, 01),
                BookISBN = "9780345539809",
                BookCoverImage = "\\Images\\RedRising1.jpg",
                BookFormat = "Paperback",
                NoOfPages = 416,
                BookIsCheckedOut = false
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 5,
                BookTitle = "The Adventures of Huckleberry Finn",
                BookAuthor = "Mark Twain",
                BookDescription = "Hilariously picaresque, epic in scope, alive with the poetry and vigor of the American people, Mark Twain's story about a young boy and his journey down the Mississippi was the first great novel to speak in a truly American voice. Influencing subsequent generations of writers -- from Sherwood Anderson to Twain's fellow Missourian, T.S. Eliot, from Ernest Hemingway and William Faulkner to J.D. Salinger -- Huckleberry Finn, like the river which flows through its pages, is one of the great sources which nourished and still nourishes the literature of America.",
                BookLanguage = "English",
                BookPublisher = "Bantam Classics",
                PublicationDate = new DateTime(1981, 02, 01),
                BookISBN = "9780553210798",
                BookCoverImage = "\\Images\\HuckleberryFinn.jpg",
                BookFormat = "Mass Market Paperback",
                NoOfPages = 320,
                BookIsCheckedOut = false
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 6,
                BookTitle = "Social Engineering: The Science of Human Hacking",
                BookAuthor = "Christopher Hadnagy",
                BookDescription = "arden the human firewall against the most current threats Social Engineering: The Science of Human Hacking reveals the craftier side of the hacker’s repertoire—why hack into something when you could just ask for access? Undetectable by firewalls and antivirus software, social engineering relies on human fault to gain access to sensitive spaces; in this book, renowned expert Christopher Hadnagy explains the most commonly-used techniques that fool even the most robust security personnel, and shows you how these techniques have been used in the past. The way that we make decisions as humans affects everything from our emotions to our security. Hackers, since the beginning of time, have figured out ways to exploit that decision making process and get you to take an action not in your best interest. This new Second Edition has been updated with the most current methods used by sharing stories, examples, and scientific study behind how those decisions are exploited. Networks and systems can be hacked, but they can also be protected; when the “system” in question is a human being, there is no software to fall back on, no hardware upgrade, no code that can lock information down indefinitely. Human nature and emotion is the secret weapon of the malicious social engineering, and this book shows you how to recognize, predict, and prevent this type of manipulation by taking you inside the social engineer’s bag of tricks. Examine the most common social engineering tricks used to gain access Discover which popular techniques generally don’t work in the real world Examine how our understanding of the science behind emotions and decisions can be used by social engineers Learn how social engineering factors into some of the biggest recent headlines Learn how to use these skills as a professional social engineer and secure your company Adopt effective counter-measures to keep hackers at bay By working from the social engineer’s playbook, you gain the advantage of foresight that can help you protect yourself and others from even their best efforts. Social Engineering gives you the inside information you need to mount an unshakeable defense.",
                BookLanguage = "English",
                BookPublisher = "Wiley",
                PublicationDate = new DateTime(2018, 07, 31),
                BookISBN = "9781119433385",
                BookCoverImage = "\\Images\\SocialEngineering.jpg",
                BookFormat = "Paperback",
                NoOfPages = 320,
                BookIsCheckedOut = true
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 7,
                BookTitle = "The God Equation: The Quest for a Theory of Everything",
                BookAuthor = "Michio Kaku",
                BookDescription = "Michio Kaku, renowned theoretical physicist and author of Hyperspace and The Future of Humanity, tells the story of the greatest quest in science. When Newton discovered the laws of motion and gravity, he unified the rules of heaven and earth. From then on, physicists have been discovering new forces and incorporating them into ever-greater theories. But the major breakthroughs of the 20th century--relativity and quantum mechanics--are incompatible, and so since then, physicists have been endeavoring to combine these two theories. This would ultimately tie all the forces in the universe together into one beautiful equation that can unlock the deepest mysteries of space and time. That epic journey is the story of this book.",
                BookLanguage = "English",
                BookPublisher = "Doubleday Books",
                PublicationDate = new DateTime(2021, 04, 06),
                BookISBN = "9780385542746",
                BookCoverImage = "\\Images\\TheGodEquation.jpg",
                BookFormat = "Hardcover",
                NoOfPages = 240,
                BookIsCheckedOut = false
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 8,
                BookTitle = "You Are a Badass Every Day: How to Keep Your Motivation Strong, Your Vibe High, and Your Quest for Transformation Unstoppable (Pocket Size)",
                BookAuthor = "Jen Sincero",
                BookDescription = "From the #1 New York Times bestselling author, pocket-size inspiration and guidance to keep your transformation on track For anyone who has ever had trouble staying motivated while trailblazing towards badassery, You Are a Badass Every Day is the companion to keep you fresh, grateful, mighty, and driven. In one hundred exercises, reflections, and cues that you can use to immediately realign your mind and keep your focus unwavering, this guide will show you how to keep the breakthroughs catalyzed by Sincero’s iconic books You Are a Badass and You Are a Badass at Making Money going. Owning your power to ascend to badassery is just the first step in creating the life you deserve—You Are A Badass Every Day is the accountability buddy you can keep in your back pocket to power through obstacles, overcome the doubts that hold you back from greatness, and keep the fires of determination roaring while you reach your goals.",
                BookLanguage = "English",
                BookPublisher = "Viking Books",
                PublicationDate = new DateTime(2018, 12, 04),
                BookISBN = "9780525561644",
                BookCoverImage = "\\Images\\YouAreABadAssEveryDay.jpg",
                BookFormat = "Hardcover",
                NoOfPages = 224,
                BookIsCheckedOut = true
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 9,
                BookTitle = "Irresistible: The Rise of Addictive Technology and the Business of Keeping Us Hooked",
                BookAuthor = "Adam Alter",
                BookDescription = "Welcome to the age of behavioral addiction—an age in which half of the American population is addicted to at least one behavior. We obsess over our emails, Instagram likes, and Facebook feeds; we binge on TV episodes and YouTube videos; we work longer hours each year; and we spend an average of three hours each day using our smartphones. Half of us would rather suffer a broken bone than a broken phone, and Millennial kids spend so much time in front of screens that they struggle to interact with real, live humans. In this revolutionary book, Adam Alter, a professor of psychology and marketing at NYU, tracks the rise of behavioral addiction, and explains why so many of today's products are irresistible. Though these miraculous products melt the miles that separate people across the globe, their extraordinary and sometimes damaging magnetism is no accident. The companies that design these products tweak them over time until they become almost impossible to resist. By reverse engineering behavioral addiction, Alter explains how we can harness addictive products for the good—to improve how we communicate with each other, spend and save our money, and set boundaries between work and play—and how we can mitigate their most damaging effects on our well-being, and the health and happiness of our children.",
                BookLanguage = "English",
                BookPublisher = "BookPal, LLC",
                PublicationDate = new DateTime(2018, 04, 06),
                BookISBN = "9780735222847",
                BookCoverImage = "\\Images\\Irresistible.jpg",
                BookFormat = "Paperback",
                NoOfPages = 368,
                BookIsCheckedOut = false
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 10,
                BookTitle = "The Dark Rising",
                BookAuthor = "Susan Cooper",
                BookDescription = "On the Midwinter Day that is his eleventh birthday, Will Stanton discovers a special gift -- that he is the last of the Old Ones, immortals dedicated to keeping the world from domination by the forces of evil, the Dark. At once, he is plunged into a...",
                BookLanguage = "English",
                BookPublisher = "McElderry Books, Margaret K.",
                PublicationDate = new DateTime(1999, 10, 01),
                BookISBN = "9780689829833",
                BookCoverImage = "\\Images\\TheDarkIsRising.jpg",
                BookFormat = "Paperback",
                NoOfPages = 232,
                BookIsCheckedOut = false
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 11,
                BookTitle = "Algorithms to Live by: The Computer Science of Human Decisions",
                BookAuthor = "Brian Christian",
                BookDescription = "A fascinating exploration of how insights from computer algorithms can be applied to our everyday lives, helping to solve common decision-making problems and illuminate the workings of the human mind All our lives are constrained by limited space and time, limits that give rise to a particular set of problems. What should we do, or leave undone, in a day or a lifetime? How much messiness should we accept? What balance of new activities and familiar favorites is the most fulfilling? These may seem like uniquely human quandaries, but they are not: computers, too, face the same constraints, so computer scientists have been grappling with their version of such issues for decades. And the solutions they've found have much to teach us. In a dazzlingly interdisciplinary work, acclaimed author Brian Christian and cognitive scientist Tom Griffiths show how the algorithms used by computers can also untangle very human questions. They explain how to have better hunches and when to leave things to chance, how to deal with overwhelming choices and how best to connect with others. From finding a spouse to finding a parking spot, from organizing one's inbox to understanding the workings of memory, Algorithms to Live By transforms the wisdom of computer science into strategies for human living.",
                BookLanguage = "English",
                BookPublisher = "Henry Holt & Company",
                PublicationDate = new DateTime(2016, 04, 19),
                BookISBN = "9781627790369",
                BookCoverImage = "\\Images\\AlgorithmsToLiveBy.jpg",
                BookFormat = "Hardcover",
                NoOfPages = 368,
                BookIsCheckedOut = false
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 12,
                BookTitle = "All the President's Men",
                BookAuthor = "Carl Bernstein",
                BookDescription = "In the most devastating political detective story of the century, twoWashington Postreporters, whose brilliant, Pulitzer Prize-winning investigation smashed the Watergate scandal wide open, tell the behind-the-scenes drama the way it really happened..",
                BookLanguage = "English",
                BookPublisher = "Simon & Schuster",
                PublicationDate = new DateTime(1994, 06, 16),
                BookISBN = "9780671894412",
                BookCoverImage = "\\Images\\AllThePresidentsMen.jpg",
                BookFormat = "Paperback",
                NoOfPages = 352,
                BookIsCheckedOut = false
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 13,
                BookTitle = "The Maze Runner Triology #1",
                BookAuthor = "James Dashner",
                BookDescription = "Read the first book in the #1 New York Times bestselling Maze Runner series, perfect for fans of The Hunger Games and Divergent. The Maze Runner, and its sequel The Maze Runner: The Scorch Trials, are now major motion pictures featuring the star of MTV's Teen Wolf, Dylan O’Brien; Kaya Scodelario; Aml Ameen; Will Poulter; and Thomas Brodie-Sangster! Also look for James Dashner’s newest novels, The Eye of Minds and The Rule of Thoughts, the first two books in the Mortality Doctrine series. If you ain’t scared, you ain’t human. When Thomas wakes up in the lift, the only thing he can remember is his name. He’s surrounded by strangers—boys whose memories are also gone. Nice to meet ya, shank. Welcome to the Glade. Outside the towering stone walls that surround the Glade is a limitless, ever-changing maze. It’s the only way out—and no one’s ever made it through alive. Everything is going to change. Then a girl arrives. The first girl ever. And the message she delivers is terrifying. Remember. Survive. Run.",
                BookLanguage = "English",
                BookPublisher = "Random House Children's Books",
                PublicationDate = new DateTime(2010, 08, 24),
                BookISBN = "9780385737951",
                BookCoverImage = "\\Images\\TheMazeRunner.jpg",
                BookFormat = "Paperback",
                NoOfPages = 375,
                BookIsCheckedOut = false
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 14,
                BookTitle = "The Outsiders",
                BookAuthor = "S. E. Hinton",
                BookDescription = "A heroic story of friendship and belonging No one ever said life was easy.But Ponyboy is pretty sure that he's got things figured out. He knows that he can count on his brothers, Darry and Sodapop. And he knows that he can count on his friends—true friends who would do anything for him, like Johnny and Two-Bit. And when it comes to the Socs—a vicious gang of rich kids who enjoy beating up on 'greasers' like him and his friends—he knows that he can count on them for trouble. But one night someone takes things too far, and Ponyboy's world is turned upside down...",
                BookLanguage = "English",
                BookPublisher = "Viking Books",
                PublicationDate = new DateTime(2006, 04, 20),
                BookISBN = "9780142407332",
                BookCoverImage = "\\Images\\TheOutsiders.jpg",
                BookFormat = "Paperback",
                NoOfPages = 180,
                BookIsCheckedOut = true
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 15,
                BookTitle = "An American Sunrise: Poems",
                BookAuthor = "Joy Harjo",
                BookDescription = "In the early 1800s, the Mvskoke people were forcibly removed from their original lands east of the Mississippi to Indian Territory, which is now part of Oklahoma. Two hundred years later, Joy Harjo returns to her family’s lands and opens a dialogue with history. In An American Sunrise, Harjo finds blessings in the abundance of her homeland and confronts the site where her people, and other indigenous families, essentially disappeared. From her memory of her mother’s death, to her beginnings in the native rights movement, to the fresh road with her beloved, Harjo’s personal life intertwines with tribal histories to create a space for renewed beginnings. Her poems sing of beauty and survival, illuminating a spirituality that connects her to her ancestors and thrums with the quiet anger of living in the ruins of injustice. A descendent of storytellers and “one of our finest―and most complicated―poets” (Los Angeles Review of Books), Joy Harjo continues her legacy with this latest powerful collection.",
                BookLanguage = "English",
                BookPublisher = "BookPal, LLC",
                PublicationDate = new DateTime(2020, 08, 18),
                BookISBN = "9780393358483",
                BookCoverImage = "\\Images\\AnAmericanSunrise.jpg",
                BookFormat = "Paperback",
                NoOfPages = 144,
                BookIsCheckedOut = false
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 16,
                BookTitle = "Weapons of Math Destruction: How Big Data Increases Inequality and Threatens Democracy",
                BookAuthor = "Cathy O'Neil",
                BookDescription = "A former Wall Street quant sounds an alarm on the mathematical models that pervade modern life — and threaten to rip apart our social fabric We live in the age of the algorithm.Increasingly, the decisions that affect our lives—where we go to school, whether we get a car loan, how much we pay for health insurance—are being made not by humans, but by mathematical models." +
                "In theory, this should lead to greater fairness: Everyone is judged according to the same rules, and bias is eliminated." +
                "But as Cathy O’Neil reveals in this urgent and necessary book, the opposite is true.The models being used today are opaque, unregulated, and uncontestable, even when they’re wrong.Most troubling, they reinforce discrimination: If a poor student can’t get a loan because a lending model deems him too risky(by virtue of his zip code), he’s then cut off from the kind of education that could pull him out of poverty, and a vicious spiral ensues." + 
                "Models are propping up the lucky and punishing the downtrodden, creating a “toxic cocktail for democracy.” Welcome to the dark side of Big Data." +
                "Tracing the arc of a person’s life, O’Neil exposes the black box models that shape our future, both as individuals and as a society." +
                "These “weapons of math destruction” score teachers and students, sort résumés, grant(or deny) loans, evaluate workers, target voters, set parole, and monitor our health." +
                "O’Neil calls on modelers to take more responsibility for their algorithms and on policy makers to regulate their use.But in the end, it’s up to us to become more savvy about the models that govern our lives.This important book empowers us to ask the tough questions, uncover the truth, and demand change.",
                BookLanguage = "English",
                BookPublisher = "Broadway Books",
                PublicationDate = new DateTime(2017, 09, 05),
                BookISBN = "9780553418835",
                BookCoverImage = "\\Images\\WeaponsOfMathDestruction.jpg",
                BookFormat = "Paperback",
                NoOfPages = 288,
                BookIsCheckedOut = false
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 17,
                BookTitle = "The Art of War",
                BookAuthor = "Sun Tzu",
                BookDescription = "Conflict is an inevitable part of life, according to this ancient Chinese classic of strategy, but everything necessary to deal with conflict wisely, honorably, victoriously, is already present within us. Compiled more than two thousand years ago by..",
                BookLanguage = "English",
                BookPublisher = "Shambhala Publications",
                PublicationDate = new DateTime(2005, 01, 11),
                BookISBN = "9781590302255",
                BookCoverImage = "\\Images\\TheArtOfwar.jpg",
                BookFormat = "Mass Market Paperback",
                NoOfPages = 224,
                BookIsCheckedOut = true
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 18,
                BookTitle = "Coraline",
                BookAuthor = "Neil Gainman",
                BookDescription = "Now available in a rack-sized edition for older readers--Gaiman's 'New York Times' bestselling novel that takes readers over the threshold of imagination. A 'Publishers Weekly' Best Book and winner of the Hugo Award for Best Novella.",
                BookLanguage = "English",
                BookPublisher = "HarperCollins Publishers",
                PublicationDate = new DateTime(2004, 05, 04),
                BookISBN = "9780060575915",
                BookCoverImage = "\\Images\\Coraline.jpg",
                BookFormat = "Mass Market Paperback",
                NoOfPages = 194,
                BookIsCheckedOut = true
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 19,
                BookTitle = "Prodigy (Legend Triology #2)",
                BookAuthor = "Marie Lu",
                BookDescription = "The second book in Marie Lu’s New York Times bestselling LEGEND trilogy—perfect for fans of THE HUNGER GAMES and DIVERGENT! June and Day arrive in Vegas just as the unthinkable happens: the Elector Primo dies, and his son Anden takes his place. With the Republic edging closer to chaos, the two join a group of Patriot rebels eager to help Day rescue his brother and offer passage to the Colonies. They have only one request—June and Day must assassinate the new Elector. It’s their chance to change the nation, to give voice to a people silenced for too long. But as June realizes this Elector is nothing like his father, she’s haunted by the choice ahead. What if Anden is a new beginning? What if revolution must be more than loss and vengeance, anger and blood—what if the Patriots are wrong? In this highly-anticipated sequel to the New York Times bestseller Legend, Lu delivers a breathtaking thriller with high stakes and cinematic action.",
                BookLanguage = "English",
                BookPublisher = "Penguin Random House",
                PublicationDate = new DateTime(2014, 04, 08),
                BookISBN = "9780142427552",
                BookCoverImage = "\\Images\\Prodigy.jpg",
                BookFormat = "Paperback",
                NoOfPages = 373,
                BookIsCheckedOut = false
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 20,
                BookTitle = "Do Androids Dream of Electric Sheep?",
                BookAuthor = "Philip K. Dirk",
                BookDescription = "The most consistently brilliant science fiction writer in the world. --John Brunner THE INSPIRATION FORBLADERUNNER. . .Do Androids Dream of Electric Sheep was published in 1968. Grim and foreboding, even today it is a masterpiece ahead of its time..",
                BookLanguage = "English",
                BookPublisher = "Random House Publishing Group",
                PublicationDate = new DateTime(1996, 05, 28),
                BookISBN = "9780345404473",
                BookCoverImage = "\\Images\\DoAndroidsDream.jpg",
                BookFormat = "Paperback",
                NoOfPages = 256,
                BookIsCheckedOut = true
            });

            // Seed Customers
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerId = 1,
                CustomerName = "Chris Munson",
                CustomerEmail = "chris.munson@softwareengineer.dev",
                CustomerPhone = "555-123-4567"
            });

            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerId = 2,
                CustomerName = "Malin Barbwire",
                CustomerEmail = "malin.barbwire@nurse.com",
                CustomerPhone = "555-123-7564"
            });

            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerId = 3,
                CustomerName = "Novalee Electra",
                CustomerEmail = "novalee.electra@school.com",
                CustomerPhone = "555-123-4657"
            });

            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerId = 4,
                CustomerName = "Kelly Roblox",
                CustomerEmail = "kelly.roblox@school.com",
                CustomerPhone = "555-123-7654"
            });

            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerId = 5,
                CustomerName = "Michelle Pandora",
                CustomerEmail = "michelle.pandora@kindergarten.com",
                CustomerPhone = "555-321-4567"
            });

            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerId = 6,
                CustomerName = "Vincent Hurricane",
                CustomerEmail = "vincent.hurricane@kindergarten.com",
                CustomerPhone = "555-312-7654"
            });

            modelBuilder.Entity<BookCustomer>().HasData(new BookCustomer
            {
                Id = 1,
                BookId = 3,
                CustomerId = 4
            });

            modelBuilder.Entity<BookCustomer>().HasData(new BookCustomer
            {
                Id = 2,
                BookId = 6,
                CustomerId = 2
            });

            modelBuilder.Entity<BookCustomer>().HasData(new BookCustomer
            {
                Id = 3,
                BookId = 8,
                CustomerId = 6
            });

            modelBuilder.Entity<BookCustomer>().HasData(new BookCustomer
            {
                Id = 4,
                BookId = 17,
                CustomerId = 1
            });

            modelBuilder.Entity<BookCustomer>().HasData(new BookCustomer
            {
                Id = 5,
                BookId = 18,
                CustomerId = 4
            });

            modelBuilder.Entity<BookCustomer>().HasData(new BookCustomer
            {
                Id = 6,
                BookId = 20,
                CustomerId = 3
            });

            modelBuilder.Entity<BookCustomer>().HasData(new BookCustomer
            {
                Id = 7,
                BookId = 14,
                CustomerId = 5
            });
        }
    }
}
