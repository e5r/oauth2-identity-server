// Copyright (c) E5R Development Team. All rights reserved.
// This file is a part of E5R.OAuth2.IdentityServer.
// Licensed under the Apache version 2.0: https://github.com/e5r/manifest/blob/master/license/APACHE-2.0.txt

using E5R.OAuth2.IdentityServer.Enums;

namespace E5R.OAuth2.IdentityServer.Data.TransferObjects
{
    public class AccessTokenRequest
    {
        public GrantType GrantType { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Scope { get; set; }
    }
}
