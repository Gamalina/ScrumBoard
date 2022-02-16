using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScrumBoardLibrary.model;

namespace ScrumBoard.Services
{
    public interface IUserStoryService
    {
        // Methods
        List<UserStory> GetAll();

        UserStory GetById(int id);

        UserStory Create(UserStory newUserStory);

        UserStory Delete(int id);

        UserStory Modify(UserStory modifiedUserStory);


    }
}
