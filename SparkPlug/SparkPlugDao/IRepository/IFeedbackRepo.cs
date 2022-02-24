using SparkPlugDao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkPlugDao.IRepository
{
    public interface IFeedbackRepo
    {
        Task<BaseResponse> InsertRecord(sparkPlugFeedback model);
    }
}
