using System;
using System.Collections.Generic;
using System.Text;

namespace System.Application.Services.CloudService.Clients.Abstractions
{
    public interface IAdvertisementClient
    {
        /// <summary>
        /// 获取加速列表
        /// 常量 OfficialWebsite_Advertisement_Jump 为跳转地址
        /// 常量 OfficialWebsite_Advertisement_Image 为图片显示地址地址
        /// </summary>
        /// <returns>按Order排序 id展示就行了 接口只会返回没过期的</returns>
        Task<IApiResponse<List<AdvertisementDTO>>> Scripts(EAdvertisementType? type = EAdvertisementType.Banner);
    }
}
