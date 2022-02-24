using SparkPlugDao.IRepository;
using SparkPlugDao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SparkPlug.Services
{
    public class FeedbackService
    {
        private readonly IFeedbackRepo _repo;

        public FeedbackService(IFeedbackRepo repo)
        {
            _repo = repo;
        }
        public async Task<BaseResponse> AddFeedback(sparkPlugFeedback model)
        {
           return await _repo.InsertRecord(model);
        }
    }
}
