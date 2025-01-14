﻿using GraphQL.Types;
using GraphQL_0_0.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL_0_0.GraphType
{
    public class SysInfoType:ObjectGraphType<SysInfo>
    {
        public SysInfoType()
        {
            Name = "sysInfoType";
            Description = "系统信息";
            Field(s => s.SysId).Description("系统id");
            Field(s => s.SysName).Description("系统名称");
            Field(s => s.HostName).Description("主机名");

        }
    }
}
