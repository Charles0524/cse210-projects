

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("Moses", 1, 39), "“This is my work and my glory—to bring to pass the immortality and eternal life of man.”."),
            new Scripture(new Reference("Joshua", 24, 15), "“Choose you this day whom ye will serve.”"),
            new Scripture(new Reference("1 Nephi", 3, 7), "“I will go and do the things which the Lord hath commanded.”"),
            new Scripture(new Reference("Ether", 12, 27), "“My grace is sufficient for all men that humble themselves before me.”"),
            new Scripture(new Reference("Alma", 37, 6), "“By small and simple things are great things brought to pass.”"),
            new Scripture(new Reference("D&C", 58, 26, 27), "“For behold, it is not meet that I should command in all things; for he that is compelled in all things, the same is a slothful and not a wise servant; wherefore he receiveth no reward. Verily I say, men should be anxiously engaged in a good cause, and do many things of their own free will, and bring to pass much righteousness; For the power is in them, wherein they are agents unto themselves.”"),
            new Scripture(new Reference("D&C", 18, 10), "“Remember the worth of souls is great in the sight of God.”"),
            new Scripture(new Reference("D&C", 58, 42), "“Behold, he who has repented of his sins, the same is forgiven, and I, the Lord, remember them no more.”"),
            new Scripture(new Reference("D&C", 121, 7, 8), "“My son, peace be unto thy soul; thine adversity and thine afflictions shall be but a small moment; And then, if thou endure it well, God shall exalt thee on high; thou shalt triumph over all thy foes.”"),
            new Scripture(new Reference("D&C", 130, 20, 21), "“There is a law, irrevocably decreed in heaven before the foundations of this world, upon which all blessings are predicated—And when we obtain any blessing from God, it is by obedience to that law upon which it is predicated.”"),
            new Scripture(new Reference("D&C", 88, 118), "“Organize yourselves; prepare every needful thing; and establish a house, even a house of prayer, a house of fasting, a house of faith, a house of learning, a house of glory, a house of order, a house of God.”"),
            new Scripture(new Reference("D&C", 58, 2), "“For verily I say unto you, blessed is he that keepeth my commandments, whether in life or in death; and he that is faithful in tribulation, the reward of the same is greater in the kingdom of heaven.”"),
            new Scripture(new Reference("D&C", 58, 26, 27), "“For behold, it is not meet that I should command in all things; for he that is compelled in all things, the same is a slothful and not a wise servant; wherefore he receiveth no reward. Verily I say, men should be anxiously engaged in a good cause, and do many things of their own free will, and bring to pass much righteousness; For the power is in them, wherein they are agents unto themselves.”"),
            new Scripture(new Reference("D&C", 58, 42), "“Behold, he who has repented of his sins, the same is forgiven, and I, the Lord, remember them no more.”"),
            new Scripture(new Reference("John", 3, 16), "“For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.”"),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "“Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.”"),
            new Scripture(new Reference("Mosiah", 18, 9), "“Stand as witnesses of God at all times and in all things, and in all places.”")
        };

        foreach (Scripture bundle in scriptures)
        {
            string input = "";
            while (input.ToLower() != "quit" && !bundle.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(bundle.GetDisplayText());
                Console.WriteLine("\nPress Enter to hide words, or type 'quit' for next verse.");
                input = Console.ReadLine();

                if (input.ToLower() != "quit")
                {
                    bundle.HideRandomWords(3);
                }
            
                else;
            }
            {
                Console.WriteLine("Thank you for your dedication to scripture memorization! See you again soon.");
                break;
            }
        }
    }
}