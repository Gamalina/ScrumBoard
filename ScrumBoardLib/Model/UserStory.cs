using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumBoardLib.Model
{
    public class UserStory
    {
        // Instance Field
        private int _id;
        private string _title;
        private string _description;
        private int _storyPoints;
        private int _businessValue;

        private static int nextID = 1;

        // Default Constructor
        public UserStory():this("Dummy", "Dummy")
        {
        }
        // Constructor
        public UserStory(string title, string description)
        {
            _id = nextID++; // Sætter værdien af nextID til Id, og tæller op 1
            Title = title;
            _description = description;
            _storyPoints = 0;
            _businessValue = 0;
        }

        // Properties
        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Title
        {
            get => _title;
            set
            {
                CheckTitle(value);
                _title = value;
            }
        }

        private void CheckTitle(string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentNullException("Title needs a value.");
            }

            if (title.Length < 3)
            {
                throw new ArgumentException("Title needs to contain atleast 3 words.");
            }

        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public int StoryPoints
        {
            get => _storyPoints;
            set => _storyPoints = value;
        }

        public int BusinessValue
        {
            get => _businessValue;
            set => _businessValue = value;
        }
    }
}
