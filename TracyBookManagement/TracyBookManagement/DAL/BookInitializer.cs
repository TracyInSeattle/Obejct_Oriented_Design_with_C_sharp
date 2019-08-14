﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TracyBookManagement.Models;

namespace TracyBookManagement.DAL
{
    public class BookInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            var books = new List<Book>
            {
            new Book {ID = 1, Name = "Your Name", Genre = "Comic", Author = "Makoto Shinkai", Price = 19.99, Description ="High school girl Mitsuha Miyamizu lives in the fictional town of Itomori in Japan's mountainous Hida region. She is bored with the country life, and wishes to be a handsome boy in her next life. She begins switching bodies intermittently with Taki Tachibana, a high school boy in Tokyo, when they wake up."},
            new Book {ID = 2, Name = "TOEFL Official Guide", Genre = "Teaching Material", Author = "Anna", Price = 39.99, Description = "This book from ETS contains five more retired TOEFL® test forms with authentic reading, listening, speaking, and writing questions, plus an answer key for each form. This third edition reflects the all the latest changes and updates to the test. "},
            new Book {ID = 3, Name = "Stand at Bay", Genre = "Fiction", Author = "Karl Klontz", Price = 8.99, Description = "Either Troy Simon has the inside scoop on a dirty case of medical malpractice or he has unearthed a document that implicates the hospital in an insidious scheme to develop a pristine tract of land. In either case, the twenty-four year old medical student is forced to abandon his studies and run for his life. His flight keeps him in the cross hairs of an unyielding plot to end his life as he bolts from the San Francisco Bay area to the Sierras and on to a remote Caribbean island." },
            new Book {ID = 4, Name = "LongWalk to Freedom", Genre = "Autobiography", Author = "Nelson Mandela", Price = 30.79, Description = "Nelson Mandela is one of the great moral and political leaders of our time: an international hero whose lifelong dedication to the fight against racial oppression in South Africa won him the Nobel Peace Prize and the presidency of his country. Since his triumphant release in 1990 from more than a quarter-century of imprisonment, Mandela has been at the center of the most compelling and inspiring political drama in the world. As president of the African National Congress and head of South Africa's antiapartheid movement, he was instrumental in moving the nation toward multiracial government and majority rule. He is revered everywhere as a vital force in the fight for human rights and racial equality."},
            new Book {ID = 5, Name = "Ordinary Grace", Genre = "Novel", Author = "William Kent Krueger", Price = 27.99, Description = "Frank Drum, who is coming-of-age in 1961. During the summer of '61, Frank and his younger brother, Jake, learned the hard truths about death in various forms: accidental, natural, suicide, and murder. Frank was 13 years old during this time and the story is told from his point of view. "},
            new Book {ID = 6, Name = "Mrs. Everything", Genre = "Novel", Author = "Jennifer Weiner", Price = 13.99, Description = "Spanning sixty-five years, Jo and Bethie Kaufman are sisters whose story begins in 1951. They’re polar opposites—Jo, the intrepid jock, has an eye for adventure (and, as it so happens, women), and Bethie is the girlie-girl whose aspirations skew more on the conventional side. When tragedy befalls one of them, dreams get deferred, threatening to irreparably change not only the course of their lives, but who they are. "},
            new Book {ID = 7, Name = "The Adventure Zone", Genre = "Comic", Author = "Client McElroy", Price = 18.36, Description = "In the second Adventure Zone graphic novel (adapted from the McElroy family's wildly popular D&D podcast), we rejoin hero-adjacent sort-of-comrades-in-arms Taako, Magnus, and Merle on a wild careen through a D&D railroad murder mystery. This installment has a little of everything: a genius child detective, an axe-wielding professional wrestler, a surly wizard, cursed magical artifacts, and a pair of meat monsters."},
            new Book {ID = 8, Name = "The Winds of Avignon", Genre = "Fiction", Author = "Mary Alexandra Watt", Price = 12.99, Description = "Set in fourteenth century France and Italy, against the backdrop of the Albigensian Crusade, the Templar trials, and the Black Death, The Winds of Avignon is a sensuous and often violent tale of dreams pitted against desire, the struggle between survival and sacrifice and the never-ending conflict between ambition and integrity. Based on historical events, this is the story of Italian poet Francesco Petrarca’s troubled friendship with the Roman revolutionary Cola di Rienzo, and the disastrous consequences of Cola’s infatuation with Francesco’s muse, Laura. "},
            new Book {ID = 9, Name = "Where the Crawdads Sing", Genre = "Novel", Author = "Delis Owens", Price = 14.99, Description = "A painfully beautiful first novel that is at once a murder mystery, a coming-of-age narrative and a celebration of nature."},
            new Book {ID = 10, Name = "Celtic Thorn", Genre = "Novel", Author = "William R Crosgrove", Price = 15.00, Description = "Orphaned and adopted, Darcy grew up on an island off the coast of 4th century Britannia, leading a nearly-idyllic life until her kidnapping by Irish raiders. After years of servitude, she makes a harrowing escape and begins her odyssey through Ireland, the Isle of Man, and Scotland."},
            new Book {ID = 11, Name = "Infinity Gauntlet", Genre = "Comic", Author = "William R Crosgrove", Price = 15.45, Description = "Orphaned and adopted, Darcy grew up on an island off the coast of 4th century Britannia, leading a nearly-idyllic life until her kidnapping by Irish raiders. After years of servitude, she makes a harrowing escape and begins her odyssey through Ireland, the Isle of Man, and Scotland."},
            new Book {ID = 12, Name = "The Autobiography of Benjiamin Franklin", Genre = "Autobiography", Author = "Benjiamin Franklin", Price = 6.99, Description = "The Autobiography of Benjamin Franklin is the traditional name for the unfinished record of his own life written by Benjamin Franklin from 1771 to 1790; however, Franklin himself appears to have called the work his Memoirs. Although it had a tortuous publication history after Franklin's death, this work has become one of the most famous and influential examples of an autobiography ever written. Franklin's account of his life is divided into four parts, reflecting the different periods at which he wrote them. There are actual breaks in the narrative between the first three parts, but Part Three's narrative continues into Part Four without an authorial break." },
            new Book {ID = 13, Name = "Upside Down", Genre = "Poem", Author = "C.G. Metz", Price = 16.97, Description = "Come inside and be transported into the land of upside down! Take a gassy journey into space with Davey Sprocket, and meet a zebra who lost his stripes. The mischievous Chops the helicopter lives there - so does the world's strongest spider, a stubborn robot, and a political goat! This clever and unique collection of funny and creative poetry is sure to be enjoyed by children of all ages." },
            new Book {ID = 14, Name = "The Autobiography Gucci Mane", Genre = "Autobiography", Author = "Gucci Mane", Price = 16.00, Description = "For the first time Gucci Mane tells his extraordinary story in his own words. It is “as wild, unpredictable, and fascinating as the man himself” " },
            new Book {ID = 15, Name = "The Odd 1s Out", Genre = "Comic", Author = "James Rallison", Price = 10.99, Description = "Like any shy teen turned young adult, YouTube star James Rallison (\"The Odd 1s Out\") is used to being on the outside looking in. He wasn't partying in high school or winning football games like his older brother. Instead, he posted comics on the Internet. Now, he's ready to share his hard-earned advice from his 21 years of life in the funny, relatable voice his fans love. " },
            new Book {ID = 16, Name = "The Sun and Her Flowers", Genre = "Poem", Author = "Pupi Kaur", Price = 9.99 ,Description ="Divided into five chapters and illustrated by Kaur, the sun and her flowers is a journey of wilting, falling, rooting, rising, and blooming. A celebration of love in all its forms." },
        };

            books.ForEach(b => context.Books.Add(b));
            context.SaveChanges();
        }
    }
}