using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Models
{
    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Damage { get; set; }
        public Character? Character { get; set; }
        public int CharacterId { get; set; }
        //!Para evitar el siguiente error y determinar esto como FK
        /*The dependent side could not be determined for the one-to-one relationship between 'Character.Weapon' 
        and 'Weapon.Character'. To identify the dependent side of the relationship, configure the foreign 
        key property. If these navigations should not be part of the same relationship, configure 
        them independently via separate method chains in 'OnModelCreating'. 
        See http://go.microsoft.com/fwlink/?LinkId=724062 for more details.*/

    }
}