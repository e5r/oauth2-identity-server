// Copyright (c) E5R Development Team. All rights reserved.
// This file is a part of E5R.OAuth2.IdentityServer.
// Licensed under the Apache version 2.0: https://github.com/e5r/manifest/blob/master/license/APACHE-2.0.txt

using System;

using E5R.OAuth2.IdentityServer.Enums;
using E5R.OAuth2.IdentityServer.Resources;

namespace E5R.OAuth2.IdentityServer.Extensions
{
    public static class ErrorResponseTypeExtensions
    {
        public static string GetErrorMessage(this ErrorResponseType error)
        {
            return error switch
            {
                ErrorResponseType.InvalidRequest => OAuthErrors.InvalidRequest,
                ErrorResponseType.UnauthorizedClient => OAuthErrors.UnauthorizedClient,
                ErrorResponseType.AccessDenied => OAuthErrors.AccessDenied,
                ErrorResponseType.UnsupportedResponseType => OAuthErrors.UnsupportedResponseType,
                ErrorResponseType.InvalidScope => OAuthErrors.InvalidScope,
                ErrorResponseType.ServerError => OAuthErrors.ServerError,
                ErrorResponseType.TemporarilyUnavailable => OAuthErrors.TemporarilyUnavailable,
                _ => throw new ArgumentOutOfRangeException(nameof(error), error, null)
            };
        }
    }
}
