using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScrumBoard.MockData;
using ScrumBoardLibrary.model;

namespace ScrumBoard.Services
{
    public abstract class UserStoryService:IUserStoryService
    {
        protected  List<UserStory> _userStories;

        public UserStoryService()
        {
            _userStories = MockUserStories.GetMockUserStories();
        }

        //public List<UserStory> GetUserStories()
        //{
        //    return new List<UserStory>(_userStories);
        //}

        //public UserStory GetUserStoryById(int id)
        //{
        //    UserStory userStory = _userStories.Find(u => u.Id == id);

        //    if (userStory == null)
        //    {
        //        throw new KeyNotFoundException();
        //    }

        //    return userStory;
        //}

        //public UserStory DeleteUserStory(int id)
        //{
        //    UserStory userStory = GetUserStoryById(id);

        //    _userStories.Remove(userStory);

        //    return userStory;
        //}

        public List<UserStory> GetAll()
        {
            return new List<UserStory>(_userStories);
        }

        public UserStory GetById(int id)
        {
            UserStory userStory = _userStories.Find(u => u.Id == id);
            if (userStory == null)
            {
                throw new KeyNotFoundException();
            }

            return userStory;
        }

        public abstract UserStory Create(UserStory newUserStory);

        public UserStory Delete(int id)
        {
            UserStory userStory = GetById(id);

            _userStories.Remove(userStory);

            return userStory;
        }

        public UserStory Modify(UserStory modifiedUserStory)
        {
            throw new NotImplementedException();
        }
    }
}
