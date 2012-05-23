﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebAPIDoodle {

    public interface IApiKeyAuthorizer {

        bool IsAuthorized(string apiKey);
        bool IsAuthorized(string apiKey, string[] roles);
    }
}