using Microsoft.AspNetCore.Mvc;
using SkillAssessment.Repository.RequestReceivedRepository;
using SkillAssessment.Repository.RequestUserDetailsRepository;

namespace SkillAssessment.Controllers
{
    [Route("HistoryTable")]
    [ApiController]
    public class RequestUserDetailsController:ControllerBase
    {
        private readonly IRequestUserDetailsService _requestUserDetailsService;
        public RequestUserDetailsController(IRequestUserDetailsService requestUserDetailsService)
        {
            _requestUserDetailsService = requestUserDetailsService;
        }
        [HttpGet("GetUserRequestDetails")]
        public async Task<ActionResult<RequestUserDTO?>> GetRequestUser(int RequestId)
        {
            try
            {
                var item = await _requestUserDetailsService.GetRequestUser(RequestId);
                return Ok(item);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
