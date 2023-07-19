using Microsoft.AspNetCore.Mvc;
using SkillAssessment.Models;

namespace SkillAssessment.Repository.RequestReceivedRepository
{
    public interface IRequestReceivedService
    {
        public Task<List<RequestDTO>> GetRequest();
        public Task<UserRequest> UpdateUserRequest(int RequestId, UserRequest userRequest);
    }
}
