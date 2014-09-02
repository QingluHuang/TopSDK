using System;
using System.Collections.Generic;
using Aliyun.Api.ECS.ECS20140526.Response;
using Top.Api.Util;
using Top.Api;

namespace Aliyun.Api.ECS.ECS20140526.Request
{	
    
    /// <summary>
    /// TOP API: ecs.aliyuncs.com.CreateVpc.2014-05-26
    /// </summary>
    public class CreateVpcRequest : IAliyunRequest<CreateVpcResponse>
    {
        /// <summary>
        /// 可选值 192.168.0.0/16和172.16.0.0/16，新建的虚拟网络分配的网络地址。不指定时，默认是172.16.0.0/16
        /// </summary>
        public string CidrBlock { get; set; }

        /// <summary>
        /// 用于保证请求的幂等性。由客户端生成该参数值，要保证在不同请求间唯一，最大不值过64个ASCII字符。 具体参见附录：如何保证幂等性。
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// [1,256]英文或中文字符，不能以http://和https://开头。
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 新建的虚拟网络所在的地域
        /// </summary>
        public string RegionId { get; set; }

        /// <summary>
        /// VPC名称，[1,128]英文或中文字符，不能以http://和https://开头
        /// </summary>
        public string VpcName { get; set; }

    
    	/// <summary>
    	///仅用于渠道商发起API调用时，指定访问的资源拥有者的ID
    	/// </summary>
        public string OwnerId { get; set; }
        
        /// <summary>
    	///仅用于渠道商发起API调用时，指定访问的资源拥有者的账号
    	/// </summary>
    	public string OwnerAccount { get; set; }
    	
    	/// <summary>
    	///API调用者试图通过API调用来访问别人拥有但已经授权给他的资源时，通过使用该参数来声明此次操作涉及到的资源是谁名下的.该参数仅官网用户可用
    	/// </summary>
    	public string ResourceOwnerAccount { get; set; }
    	
        private IDictionary<string, string> otherParameters;

        #region IAliyunRequest Members

        public string GetApiName()
        {
            return "ecs.aliyuncs.com.CreateVpc.2014-05-26";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("OwnerId", this.OwnerId);
            parameters.Add("OwnerAccount", this.OwnerAccount);
            parameters.Add("ResourceOwnerAccount", this.ResourceOwnerAccount);
            parameters.Add("CidrBlock", this.CidrBlock);
            parameters.Add("ClientToken", this.ClientToken);
            parameters.Add("Description", this.Description);
            parameters.Add("RegionId", this.RegionId);
            parameters.Add("VpcName", this.VpcName);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("RegionId", this.RegionId);
        }

        #endregion

        public void AddOtherParameter(string key, string value)
        {
            if (this.otherParameters == null)
            {
                this.otherParameters = new TopDictionary();
            }
            this.otherParameters.Add(key, value);
        }
        
    }
}
