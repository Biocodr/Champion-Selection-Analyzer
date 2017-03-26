﻿using System.Collections.Generic;
using WebApi.Misc;
using WebApi.Models;

namespace WebApi.Services.Interfaces
{
    public interface ISuggestionService
    {
        Suggestion GetSuggestion(TeamConstellation friendly, TeamConstellation enemy, IEnumerable<long> championBans);
    }
}