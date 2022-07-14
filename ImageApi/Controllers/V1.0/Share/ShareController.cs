﻿using ImageApi.Service.Services.Share.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ImageApi.Controllers.V1._0.Share
{
    public class ShareController : BaseController
    {
        private readonly ILogger<ShareController> _logger;
        private readonly IShareService _shareService;

        public ShareController(ILogger<ShareController> logger, IShareService shareService)
        {
            _logger = logger;
            _shareService = shareService;
        }
    }
}