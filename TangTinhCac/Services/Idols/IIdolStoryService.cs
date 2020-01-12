using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TangTinhCac.Models.EntityModels.Idols;
using TangTinhCac.Models.ViewModels.Idols;

namespace TangTinhCac.Services.Idols
{
    public interface IIdolStoryService 
    {
        IEnumerable<IdolStory> GetAllIdolStories();
        IdolStory GetIdolStoryByStoryID(int storyID);
        bool CreateNewIdolStory(IdolStoryViewModel model, string userId);
        bool UpdateIdolStory(IdolStoryViewModel model, string userId);
        bool DeleteIdolStory(int storyID);
        IEnumerable<IdolStory> GetIdolStoryByIdolID(Guid idolID);
    }
}
