using System;

namespace The_Wizard
{
    class Wizard
    {
        public string name; 
        public string favouriteSpell;
        private int spellSlots;
        public float experience;
        public float potion;
        public static int Count;

        public Wizard(string _name, string _favouriteSpell)
        {
            name = _name;
            favouriteSpell = _favouriteSpell;
            spellSlots = 2;
            experience = 0f;
            potion = 3f;

            Count++;
        }

       
        public void CastFavSpell()
        {
            if (spellSlots > 0)
            {
            Console.WriteLine("\n" + name + " casts " + favouriteSpell);
            spellSlots--;
            experience += 0.3f;
            } else
            {
                Console.WriteLine("\n" + name + " is out of spell slots.");
            }
        }


        public void Meditate()
        {
            Console.WriteLine("\n" + name + " meditates to regain spell slots.");
            spellSlots = 2;
        }

        public void Infection()
        {
            Console.WriteLine("\nThen he sees something in the dark... Wait what's that? AAAAAAAAAAAAAAAAA.....");
            spellSlots += 6;
        }

        public void ConsumePotion()
        {
            if (potion > 0)
            {
            Console.WriteLine("\n" + name + " used a potion to gain experience");
            experience += 1f;
            } else
            {
                Console.WriteLine("\n" + name + " is out of potions!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {   

            Console.Title = "The Story of a young wizard";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Once upon a time there was a wizard named uh? psshh, I don't know your name write it for me please!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nSmall advice young wizard! Press any button on your keyboard to continue the story");
            Console.ReadKey(true);
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nInput the name of your wizard: ");
            string wizardname = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WindowWidth = 165;
            Console.WriteLine("\n" + wizardname + " was a wizard new to the job and was just getting ready for his first spell which is: I don't know your favourite spell either write it down for me!");
            Console.ReadKey(true);

            Console.Write("\nWrite his/her favourite spell: ");
            string favspell = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n" + wizardname + "'s" + " favourite spell was " + favspell + " quite unusual if you ask me!");
            Console.ReadKey(true);
            Wizard wizard02 = new Wizard(wizardname, favspell);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nThen " + wizardname + " encountered an enemy of the kingdom! A very awful Ghoul! What will our hero do?");
            Console.ReadKey(true);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WindowWidth = 165;
            Console.WriteLine("\n" + wizardname + " takes out his trusty wand and swings it around and says the magic words and casts " + favspell + ". The monster was hit very badly!");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.ReadKey(true);
            Console.WriteLine("\nOh no, the Ghoul hits back " + wizardname + " and knocks him out!");
            Console.ReadKey(true);
            Console.WriteLine("\n" + wizardname + " loses his senses and passes out.");
            Console.ReadKey(true);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WindowWidth = 185;
            Console.WriteLine("\n" + wizardname + " was being tortured for days by the Ghoul until he took his wand out and casted " + favspell);
            Console.ReadKey(true);
            Console.WriteLine("\nHe had defeated the Ghoul once for all! The hero returns back to the kingdom and tell the king everything about what happened! Then " + wizardname + " was promoted to the Head of the Wizards!");
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nBut when he gets home for his first lesson to teach he remembered he had lost all of his experience and couldn't do any more spells! So he started consuming a special potion.");
            wizard02.ConsumePotion();
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nHe feels his experience getting back and feeling stronger than ever! He also does some meditating to regain some spell slots back in order to do more spells!");
            wizard02.Meditate();
            Console.ReadKey(true);
            Console.WriteLine("\n" + wizardname + " goes out for a walk in the night after he finished his lessons.");
            Console.ForegroundColor = ConsoleColor.Red;
            wizard02.Infection();
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nWhat happened to our hero? Will he survive the unknown? Find out soon... or not....");
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nSlowly, the young wizard wakes up to his surprise to be a hostage by the Ghoul!");
            Console.ReadKey(true);
            Console.WriteLine("\nSomehow it survived and now it is seeking for revenge! It took the wizard's wand so he couldn't do anything.");
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nThe Ghoul wanted to get all his experience and become as wise as the young wizard! " + wizardname + " tried to resist but it was not helping him.");
            Console.ReadKey(true);
            Console.WriteLine("\nThe Ghoul grabbed all his energy and experience and left " + wizardname + " to die.");
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nDays passed and the Ghoul has taken over the kingdom. But then " + wizardname + " wakes up with his little energy and does a spell to regain his experience!");
            Console.ReadKey(true);
            Console.WriteLine("\n" + wizardname + " used a spell to gain experience!");
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nThe wizard stands up on his feet grabs his wand and heads for the kingdom!");
            Console.ReadKey(true);
            Console.WriteLine("\nHe spent days and days trying to find his way back but after 3 days sees the kingdom destroyed!");
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nHe heads back to the castle and faces the Ghoul! It was surprised he had survived.");
            Console.ReadKey(true);
            Console.WriteLine("\nBoth of them take out their wands and start a fight! A big ray of power came out from both of them and they fought to death.");
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nThe young wizard did everything he could and used a mega energy ray and defeated the Ghoul and gained his energy back!");
            Console.ReadKey(true);
            Console.WriteLine("\nHe then casts a spell he had learned from his teacher and made the kingdom back to where it was!");
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nThe king and everyone living on the village applauded him for saving the kingdom and not letting everyone down!");
            Console.ReadKey(true);
            Console.WriteLine("\nSuddenly a magic power came from the sky, it was the ultimate power evolving him and giving him more knowledge and strength! No one could believe their eyes!");
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n" + wizardname + " had became a very powerful wizard and was declared as the protector of this village!");
            Console.ReadKey(true);
            Console.WriteLine("\nHe then headed back home once for all and everyone lived happily ever after.");
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nA story from Noah hope you enjoyed it! For any questions check out my discord xNo_ah#0001. Thank you to everyone who took the time to read all of this <3. Special thanks to Brackeys for his awesome C# Tutorials <333!");
            Console.ReadKey(true);
        }
    }
}