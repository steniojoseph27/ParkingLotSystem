using System;
using Core.Interfaces;
using Core.Entities;

namespace Core.Repository
{
    // TODO - Rename namespace: UseCases, class: GetUserByIdUseCases
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