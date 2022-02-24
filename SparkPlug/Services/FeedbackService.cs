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
        public async Task<BaseResponse> AddFeedback(SparkPlugDto model)
        {
            var newRecord =_map.Map<SparkPlugFeedback>(model);

            //var newRecord = new SparkPlugFeedback()
            //{
            //    CustomerEmail = model.customerEmail,
            //    CustomerMessage = model.customerMessage,
            //    CustomerName = model.customerName,
            //    FormDomainName = model._formDomainName,
            //    FormName = model._formName
            //};
           return await _repo.InsertRecord(newRecord);
        }
    }
}
