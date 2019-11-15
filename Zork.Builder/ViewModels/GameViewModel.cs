using System;
using System.IO;
using System.Linq;
using System.ComponentModel;
using Newtonsoft.Json;
using Zork.Common;

namespace Zork.Builder.ViewModels
{
    class GameViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Filename { get; set; }

        public string StartingLocation
        {
            get => mGame?.World?.StartingLocation;
            set
            {
                mGame.World.StartingLocation = value;
            }
        }

        public string WelcomeMessage
        {
            get => mGame?.World?.WelcomeMessage;
            set
            {
                mGame.World.WelcomeMessage = value;

            }
        }

        public BindingList<Room> Rooms { get; set; }

        public GameViewModel()
        {
            Rooms = new BindingList<Room>();
        }

        public Game Game
        {
            get => mGame;
            set
            {
                if (mGame != value)
                {
                    mGame = value;
                    if (mGame != null && mGame.World != null && mGame.World.Rooms != null)
                    {
                        Rooms = new BindingList<Room>(mGame.World.Rooms);
                    }
                    else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                    }
                }
            }
        }

        public void SaveGame()
        {
            if (string.IsNullOrEmpty(Filename))
            {
                throw new InvalidProgramException("Filename expected.");
            }

            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented
            };
            using (StreamWriter streamWriter = new StreamWriter(Filename))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(jsonWriter, mGame);
            }
        }

        private Game mGame;
    }
}
