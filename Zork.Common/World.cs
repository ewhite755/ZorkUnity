using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Zork.Common
{
    public class World : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public List<Room> Rooms { get; set; }

        [JsonIgnore]
        public Dictionary<string, Room> RoomsByName => mRoomsByName;
        public string StartingLocation { get; set; }
        public string WelcomeMessage { get; set; }

        public Player SpawnPlayer() => new Player(this, StartingLocation);

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            mRoomsByName = Rooms.ToDictionary(room => room.Name, room => room);

            foreach (Room room in Rooms)
            {
                room.UpdateNeighbors(this);
            }
        }


        private Dictionary<string, Room> mRoomsByName;
    }
}
