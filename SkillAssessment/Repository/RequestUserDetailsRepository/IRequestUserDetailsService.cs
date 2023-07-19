using Microsoft.AspNetCore.Mvc;

namespace SkillAssessment.Repository.RequestUserDetailsRepository
{
    public interface IRequestUserDetailsService
    {
        public Task<RequestUserDTO?> GetRequestUser(int RequestId);
    }
}
