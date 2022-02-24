using AutoMapper;
using SparkPlug.Services.Interface;
using SparkPlug.SparkPlugDao.Dto;
using SparkPlugDao.IRepository;
using SparkPlugDao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SparkPlug.Services
{
    public class FeedbackService : IFeedbackService
    {
        private readonly IFeedbackRepo _repo;
        private readonly IMapper _map;

        public FeedbackService(IFeedbackRepo repo, IMapper map)
        {
            _repo = repo;
            _map = map;
        }

        /// <summary>
        /// this method makes a call to feedbackRepo to add a record to the database
        /// </summary>
        /// <param name="model"></param>
        /// <returns>returns a true or false response status and a successful or failed message</returns>
        public async Task<BaseResponse> AddFeedback(SparkPlugDto model)
        {
            var newRecord =_map.Map<SparkPlugFeedback>(model);// maps SparkPlugFeedback model to SparkPlugDto model
            return await _repo.InsertRecord(newRecord);
        }
    }
}
