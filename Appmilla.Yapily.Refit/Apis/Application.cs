﻿using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace Cms
{
    public interface IApplication
    {
        /// <summary>
        /// Returns the details of the application that owns the request credentials
        /// </summary>
        /// <returns>OK</returns>
        [Get("me")]
        [Headers("x-yapily-api-version")] 
        Task<Application> GetApplicationMeUsingGETAsync();

    }
}