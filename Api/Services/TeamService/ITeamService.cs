﻿using Api.DTOs;
using Api.Models;

namespace Api.Services.TeamService
{
    public interface ITeamService
    {
        Task<IEnumerable<Team>> GetTeamsAsync();
        Task AddTeamAsync(Team team);
        Task AddTeamMemberAsync(Team team, User user);
        Task<List<User>> GetTeamMembersAsync(int teamId);
        Team GetTeamByTeamNameAsync(string teamName);
        Task<Team> GetTeamByUserAsync(User user);
    }
}
