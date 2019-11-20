using Newtonsoft.Json;
using System;
using System.ComponentModel;

namespace Zork.Common
{
    public class Player
    {

        public event EventHandler<int> ScoreChanged;
        public event EventHandler<int> Moved;

        public World World { get; }

        public int Moves { get; set; }

        public int amtMoved
        {
            get => mMoves;
            set
            {
                mMoves = value;
                Moved?.Invoke(this, mMoves);
            }
        }

        public int Score
        {
            get => mScore;
            set
            {
                mScore = value;
                ScoreChanged?.Invoke(this, mScore);
            }
        }

        [JsonIgnore]
        public Room Location { get; private set; }

        [JsonIgnore]
        public string LocationName
        {
            get
            {
                return Location?.Name;
            }
            set
            {
                Location = World?.RoomsByName.GetValueOrDefault(value);
            }
        }

        public Player(World world, string startingLocation)
        {
            World = world;
            LocationName = startingLocation;
        }

        public bool Move(Directions direction)
        {
            bool isValidMove = Location.Neighbors.TryGetValue(direction, out Room destination);
            if (isValidMove)
            {
                Location = destination;
                amtMoved++;
            }

            return isValidMove;
        }

        private int mScore;
        private int mMoves;
    }
}
