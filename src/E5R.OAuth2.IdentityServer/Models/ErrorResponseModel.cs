// Copyright (c) E5R Development Team. All rights reserved.
// This file is a part of E5R.OAuth2.IdentityServer.
// Licensed under the Apache version 2.0: https://github.com/e5r/manifest/blob/master/license/APACHE-2.0.txt

namespace E5R.OAuth2.IdentityServer.Models
{
    public class ErrorResponseModel
    {
        public string Error { get; set; }
        public string ErrorDescription { get; set; }
        public string ErrorUri { get; set; }
        public string State { get; set; }
    }
}
