using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScrumBoard.Services;
using ScrumBoardLibrary.model;

namespace ScrumBoard.MockData
{
    public class MockUserStories:UserStoryService
    {
        private static List<UserStory> userStories = new List<UserStory>()
        {
            new UserStory("Create Story", "As P.O I want to create a new Story So ..."),
            new UserStory("Edit Story", "As P.O I want to edit a Story So ..."),
            new UserStory("Move Story", "As team member I want to move a Story So ..."),
            new UserStory("Delete Story", "As team member I want to delete a Story So ...")
        };

        public static List<UserStory> GetMockUserStories()
        {
            return new List<UserStory>(userStories);
        }

        public override UserStory Create(UserStory newUserStory)
        {
            _userStories.Add(newUserStory);
            return newUserStory;


        }
    }
}
