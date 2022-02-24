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
        [HttpPost("add-record")]
        public async Task<BaseResponse> AddRecord([FromForm] SparkPlugDto model)
        {
            return await _service.AddFeedback(model);
        }
    }
}
