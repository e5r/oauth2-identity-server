// Copyright (c) E5R Development Team. All rights reserved.
// This file is a part of E5R.OAuth2.IdentityServer.
// Licensed under the Apache version 2.0: https://github.com/e5r/manifest/blob/master/license/APACHE-2.0.txt

using E5R.Architecture.Core;

using static E5R.Architecture.Core.MetaTagAttribute;

namespace E5R.OAuth2.IdentityServer.Enums
{
    public enum ClientType
    {
        [MetaTag(CustomIdKey, "confidential")]
        Confidential,

        [MetaTag(CustomIdKey, "public")]
        Public
    }
}
