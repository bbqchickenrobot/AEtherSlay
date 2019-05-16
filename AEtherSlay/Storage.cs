using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEtherSlay
{
    class Storage
    {
        private List<Catalog.PlayerCharacter> storedCharacterSheets;
        // private List<Catalog.PlayerCharacter> storedEnemySheets;

        public Storage()
        {
            storedCharacterSheets = new List<Catalog.PlayerCharacter>();
            //storedEnemySheets = new List<Catalog.EnemyCharacter>();
        }

        public void addCharacterSheet(Catalog.PlayerCharacter charToAdd)
        {
            storedCharacterSheets.Add(charToAdd);
        }

        public Catalog.PlayerCharacter retrieveCharacterSheet(String characterName)
        {
            foreach(Catalog.PlayerCharacter character in storedCharacterSheets) {
                if(character.name == characterName)
                {
                    return character;
                }
            }
            return null;
        }

        public List<Catalog.PlayerCharacter> retrieveAllCharacterSheets()
        {
            return storedCharacterSheets;
        }
    }
}
