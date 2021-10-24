// Copyright (c) E5R Development Team. All rights reserved.
// This file is a part of E5R.OAuth2.IdentityServer.
// Licensed under the Apache version 2.0: https://github.com/e5r/manifest/blob/master/license/APACHE-2.0.txt

using E5R.Architecture.Core;
using E5R.Architecture.Core.Extensions;
using E5R.OAuth2.IdentityServer.Data.TransferObjects;
using E5R.OAuth2.IdentityServer.Extensions;
using E5R.OAuth2.IdentityServer.Models;

using Tag = E5R.Architecture.Core.MetaTagAttribute;

namespace E5R.OAuth2.IdentityServer.Transformers
{
    public class ErrorResponseTransformer : ITransformer<ErrorResponse, ErrorResponseModel>
    {
        public ErrorResponseModel Transform(ErrorResponse from)
        {
            return from != null
                ? new ErrorResponseModel
                {
                    Error = from.Error.GetTag(Tag.CustomIdKey),
                    ErrorDescription = from.Error.GetErrorMessage(),
                    ErrorUri = from.ErrorUri?.ToString(),
                    State = from.State
                }
                : null;
        }
    }
}
