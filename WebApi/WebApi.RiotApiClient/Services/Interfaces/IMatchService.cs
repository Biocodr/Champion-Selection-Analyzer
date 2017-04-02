﻿using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Model.Dtos.Match;
using WebApi.RiotApiClient.Misc;

namespace WebApi.RiotApiClient.Services.Interfaces
{
    public interface IMatchService
    {
        Task<MatchList> GetMatchListAsync(
            Region region, 
            long summonerId,
            ICollection<string> rankedQueues,
            ICollection<string> seasons);

        Task<MatchDetail> GetMatchAsync(Region region, long matchId);
    }
}
