﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nether.Data.PlayerManagement;

namespace Nether.Web.Features.PlayerManagement
{
    public class GroupGetResponseModel
    {
        public GroupEntry Group { get; set; }

        public class GroupEntry
        {
            public static implicit operator GroupEntry(Group group)
            {
                return new GroupEntry { Name = group.Name, CustomType = group.CustomType, Description = group.Description, Image = group.Image };
            }

            public string Name { get; set; }
            public string CustomType { get; set; }
            public string Description { get; set; }
            public byte[] Image { get; set; }
        }
    }
}
