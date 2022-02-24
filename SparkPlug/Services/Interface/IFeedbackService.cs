using SparkPlugDao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SparkPlug.Services.Interface
{
    public interface IFeedbackService
    {
        Task<BaseResponse> AddFeedback(sparkPlugFeedback model);

    }
}
