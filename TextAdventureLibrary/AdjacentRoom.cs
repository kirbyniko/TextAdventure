using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureLibrary
{
    public class AdjacentRoom
    {
        public string Name { get; set; } = "";

        public Room Room { get; set; }


        public List<string> Keywords { get; set; } = new List<string>();

        //might not want to make it so adjacent room takes in string name. Or at least inantiate name like I will above
        public AdjacentRoom(string name, Room room)
        {
            Name = name;
            Room room1 = room;
            Room = room1;

            
        }
    }
}
