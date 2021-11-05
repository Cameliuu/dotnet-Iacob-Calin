using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Net.Mail;
namespace Iacob_Calin
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior();
            Mage mage = new Mage();
            List <CharacterType> characters = new List<CharacterType>() { mage, warrior };
            doattack(characters);
        }   
        static void doattack(List<CharacterType> characters)
        {
            foreach(var character in characters)
                character.attack();
        }
    }
}

