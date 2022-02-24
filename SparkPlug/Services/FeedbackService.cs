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

        public FeedbackService(IFeedbackRepo repo)
        {
            _repo = repo;
        }
        public async Task<BaseResponse> AddFeedback(SparkPlugDto model)
        {
            var newRecord = new sparkPlugFeedback()
            {
                customerEmail = model.customerEmail,
                customerMessage = model.customerMessage,
                customerName = model.customerName,
                _formDomainName = model._formDomainName,
                _formName = model._formName
            };
           return await _repo.InsertRecord(newRecord);
        }
    }
}
