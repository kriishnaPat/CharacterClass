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
        private string firstName;
        private string firstcp;
        private string secondcp;
         private int levelnum;
        public Character(String name, string phrase1, string phrase2, int level){
            firstName = name;
            firstcp = phrase1;
            secondcp = phrase2;
            levelnum = level;
        }

        public void speak(int phraseNum){
            if (phraseNum ==1){
                Console.Write(this.firstcp);
            }else if (phraseNum == 2){
                Console.Write(this.secondcp);
            }

        }

        public void setLevel(int newLevel){
            this.levelnum = newLevel;
        }
    }
}
