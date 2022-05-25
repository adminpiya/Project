using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanzhouBeefNoodles.Models
{
    public interface IFeedbackRepository
    {
        IEnumerable<Feedbacks> GetAllFeedbacks();
        void AddFeedback(Feedbacks feedback);
    }
}
