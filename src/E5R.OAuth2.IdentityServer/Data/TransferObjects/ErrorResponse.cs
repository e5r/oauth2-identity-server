// Copyright (c) E5R Development Team. All rights reserved.
// This file is a part of E5R.OAuth2.IdentityServer.
// Licensed under the Apache version 2.0: https://github.com/e5r/manifest/blob/master/license/APACHE-2.0.txt

using System;

using E5R.OAuth2.IdentityServer.Enums;

namespace E5R.OAuth2.IdentityServer.Data.TransferObjects
{
    public class ErrorResponse
    {
        public ErrorResponseType Error { get; set; }
        public Uri ErrorUri { get; set; }
        public string State { get; set; }
    }
}
