using Microsoft.AspNetCore.Mvc;
using SkillAssessment.Models;
using SkillAssessment.Repository.HistoryTableRepository;
using SkillAssessment.Repository.RequestReceivedRepository;

namespace SkillAssessment.Controllers
{
    [Route("HistoryTable")]
    [ApiController]
    public class RequestReceivedController:ControllerBase
    {
        private readonly IRequestReceivedService _requestReceivedService;
        public RequestReceivedController(IRequestReceivedService requestReceivedService)
        {
            _requestReceivedService = requestReceivedService;
        }
        [HttpGet("GetAllRequestReceived")]
        public async Task<ActionResult<List<RequestDTO>>> GetRequest()
        {
            try
            {
                var item = await _requestReceivedService.GetRequest();
                return Ok(item);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPut("UpdatingIsChecked")]
        public async Task<ActionResult<UserRequest>> UpdateUserRequest(int RequestId, UserRequest userRequest)
        {
            try
            {
                var item = await _requestReceivedService.UpdateUserRequest(RequestId, userRequest);
                return Ok(item);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
