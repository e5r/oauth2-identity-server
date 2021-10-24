// Copyright (c) E5R Development Team. All rights reserved.
// This file is a part of E5R.OAuth2.IdentityServer.
// Licensed under the Apache version 2.0: https://github.com/e5r/manifest/blob/master/license/APACHE-2.0.txt

using System;

using E5R.Architecture.Core;
using E5R.OAuth2.IdentityServer.Enums;

namespace E5R.OAuth2.IdentityServer.Entities
{
    public class Client : IIdentifiable
    {
        public object[] Identifiers => new[] { Id };

        public string Id { get; set; }
        public string Secret { get; set; }
        public string Description { get; set; }
        public Uri OwnerUrl { get; set; }
        public ClientType Type { get; set; }
        public Uri[] RedirectUris { get; set; }
    }
}
