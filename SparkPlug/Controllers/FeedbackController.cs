using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SparkPlug.Services;
using SparkPlug.Services.Interface;
using SparkPlug.SparkPlugDao.Dto;
using SparkPlugDao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SparkPlug.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        private readonly IFeedbackService _service;

        public FeedbackController(IFeedbackService service )
        {
            _service = service;
        }

        /// <summary>
        /// This action makes a call to FeedbackService class
        /// </summary>
        /// <param name="model"></param>
        /// <returns>returns a true or false response status and a successful or failed message</returns>
        [HttpPost("add-record")]
        public async Task<BaseResponse> AddRecord([FromForm] SparkPlugDto model)
        {
            return await _service.AddFeedback(model);
        }
    }
}
