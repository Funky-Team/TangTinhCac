using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TangTinhCac.Models.EntityModels.Idols;
using TangTinhCac.Models.ViewModels.Idols;

namespace TangTinhCac.Services.Idols
{
    public interface IReactionTypeService
    {
        IEnumerable<ReactionType> GetAllReactionTypes();
        ReactionType GetReactionTypeByReactionTypeID(int reactionTypeID); 
        bool CreateNewReactionType(ReactionTypeViewModel model, string userId);
        bool UpdateReactionTypeID(ReactionTypeViewModel model, string userId);
        bool DeleteReactionTypeID(int reactionTypeID);
    }
}
