using Core.Entities;
using Core.Interfaces;
using System;

namespace Core.Repository
{
    public class UserRepository
    {
        private readonly IUserRepository _userRepository;

        public UserRepository(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> ExecuteAsync(int userId)
        {
            return await _userRepository.GetUserByIdAsync(userId);
        }
    }
}