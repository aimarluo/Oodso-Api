﻿using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class AddRelationRoleFunctionRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 功能ID，多个功能之间用英文逗号分隔
        /// </summary>
        public string FunctionIds { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        public int RoleId { get; set; }
        public string GetApiName()
        {
            return "chenggou.permission.role.function.addrelation";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"functionids", FunctionIds},
                {"roleid",RoleId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("functionids", FunctionIds);
            RequestValidator.ValidateMaxLength("functionids", this.FunctionIds, 2000);
            RequestValidator.ValidateRequired("roleid", RoleId);
        }
    }
}
