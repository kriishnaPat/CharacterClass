using System;

namespace CharacterClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Character chandler = new Character("Chandler Bing","Hi, I'm Chandler. I make jokes when I'm uncomfortable.", "Okay, you have to stop the Q-Tip when there's resistance.", 1);
            Character spiderMan = new Character("Spiderman", "My Spider-Sense is tingling.", "Your friendly neighbourhood spiderman.", 1);

            chandler.speak(1);
            spiderMan.setLevel(2);
            spiderMan.speak(2);
        }
    }
    public class Character{
        private string name;
        private string phrase1;
        private string phrase2;
        private int level;
        public Character(string name, string phrase1, string phrase2, int level){
            this.name = name;
            this.phrase1 = phrase1;
            this.phrase2 = phrase2;
            this.level = level;
        }

        public void speak(int phraseNum){
            if (phraseNum ==1){
                Console.Write(this.phrase1);
            }else if (phraseNum == 2){
                Console.Write(this.phrase2);
            }

        }

        public void setLevel(int newLevel){
            this.level = newLevel;
        }
    }
}
