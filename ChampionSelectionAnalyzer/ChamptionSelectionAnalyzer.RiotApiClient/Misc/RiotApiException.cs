﻿using System;
using System.Net;

namespace ChampionSelectionAnalyzer.RiotApiClient.Misc
{
    public class RioApiException : Exception
    {
        public readonly HttpStatusCode HttpStatusCode;

        public RioApiException(string message)
            : base(message)
        {

        }

        public RioApiException(string message, HttpStatusCode httpStatusCode)
            : this(message)
        {
            HttpStatusCode = httpStatusCode;
        }
    }
}
