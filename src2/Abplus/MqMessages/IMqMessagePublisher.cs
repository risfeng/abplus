﻿using System.Threading.Tasks;
using Abp.Dependency;
namespace Abp.MqMessages
{
    /// <summary>
    /// 消息发布接口
    /// </summary>
    public interface IMqMessagePublisher : ITransientDependency
    {
        /// <summary>
        /// 发布
        /// </summary>
        /// <param name="mqMessages"></param>
        void Publish(object mqMessages);

        /// <summary>
        /// 发布
        /// </summary>
        /// <param name="mqMessages"></param>
        /// <returns></returns>
        Task PublishAsync(object mqMessages);
    }
}
