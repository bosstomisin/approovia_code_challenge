using MongoDB.Driver;
using SparkPlugDao.IRepository;
using SparkPlugDao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkPlugDao.Repository
{

    public class FeedbackRepo : IFeedbackRepo
    {
        private readonly IMongoClient _client;

        public FeedbackRepo(IMongoClient client)
        {
            _client = client;

            
        }

        /// <summary>
        /// this method makes a call th the database to add new record
        /// </summary>
        /// <param name="model"></param>
        /// <returns>returns a true or false response status and a successful or failed message</returns>
        public async Task<BaseResponse> InsertRecord(SparkPlugFeedback model)
        {        
            try
            {
                var database =  _client.GetDatabase(model._formDomainName);
                var collection = database.GetCollection<SparkPlugFeedback>(model._formName);
                collection.InsertOne(model);
                return new BaseResponse { Message = "Feedback successfully submitted", Success = true };
            }
            catch (Exception)
            {
                return new BaseResponse { Message = "Feedback not submitted", Success = false };
            }

        }
    }
}
