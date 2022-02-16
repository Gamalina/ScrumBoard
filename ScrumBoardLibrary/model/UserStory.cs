using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumBoardLibrary.model
{
    public class UserStory
    {
        // Instance Field
        private int _id;
        private string _title;
        private string _description;
        private int _storyPoints;
        private int _businessValue;

        private static int _nextId = 1;

        // Default Constructor
        public UserStory():this("Dummy", "Dummy")
        {
        }
        // Constructor
        public UserStory(string title, string description)
        {
            _id = _nextId++; // Sætter værdien af nextID til Id, og tæller op 1
            Title = title;
            Description = description;
            StoryPoints = 0;
            BusinessValue = 0;
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
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Title must be at least 3 words long.");
                }

                if (value.Length < 3)
                {
                    throw new ArgumentException("Title must be at least 3 words long");
                }

                _title = value;
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Description must be at least 10 words long.");
                }

                //if (value.Length < 10)
                //{
                //    throw new ArgumentException("Description must be at least 3 words long");
                //}

                // Kan ikke få det kode til at virke. Hvis jeg har aktiveret det kan jeg ikke slette. 
                
                _description = value;
            }
        }

        public int StoryPoints
        {
            get => _storyPoints;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("StoryPoints must be 0 or positive. Can not be negative.");
                }
                
                _storyPoints = value;
            }
        }


        public int BusinessValue
        {
            get => _businessValue;
            set
            {
                if (value < 0 || 10 < value)
                {
                    throw new ArgumentException("BusinessValue must be between 0-10");
                }
                _businessValue = value;
            }
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Title)}: {Title}, {nameof(Description)}: {Description}, {nameof(StoryPoints)}: {StoryPoints}, {nameof(BusinessValue)}: {BusinessValue}";
        }
    }
}

