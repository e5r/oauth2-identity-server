// Copyright (c) E5R Development Team. All rights reserved.
// This file is a part of E5R.OAuth2.IdentityServer.
// Licensed under the Apache version 2.0: https://github.com/e5r/manifest/blob/master/license/APACHE-2.0.txt

using System.Threading.Tasks;

using E5R.Architecture.Business;
using E5R.Architecture.Core;
using E5R.OAuth2.IdentityServer.Data.TransferObjects;
using E5R.OAuth2.IdentityServer.Services;

namespace E5R.OAuth2.IdentityServer.Handlers
{
    public class ResourceOwnerPasswordCredentialsGrantHandler : ActionHandler<AccessTokenRequest, AccessTokenResponse>
    {
        private IOAuth2IdentityServerProvider Provider { get; }

        public ResourceOwnerPasswordCredentialsGrantHandler(IOAuth2IdentityServerProvider provider)
        {
            Checker.NotNullArgument(provider, nameof(provider));

            Provider = provider;
        }

        protected override Task<AccessTokenResponse> ExecActionAsync(AccessTokenRequest input)
        {
            throw new System.NotImplementedException();
        }
    }
}
