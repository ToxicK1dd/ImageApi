﻿using FileShare.DataAccess.UnitOfWork.Primary.Interface;
using FileShare.Models.V2._0.Registration;
using FileShare.Service.Services.V2._0.Registration.Interface;
using FileShare.Service.Services.V2._0.Token.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FileShare.Controllers.V2._0.Registration
{
    /// <summary>
    /// Endpoints for registering users.
    /// </summary>
    [ApiVersion("2.0")]
    public class RegistrationController : BaseController
    {
        private readonly HttpContext _httpContext;
        private readonly ILogger<RegistrationController> _logger;
        private readonly IPrimaryUnitOfWork _unitOfWork;
        private readonly IRegistrationService _registrationService;
        private readonly ITokenService _tokenService;

        public RegistrationController(
            IHttpContextAccessor httpContextAccessor,
            ILogger<RegistrationController> logger,
            IPrimaryUnitOfWork unitOfWork,
            IRegistrationService registrationService,
            ITokenService tokenService)
        {
            _httpContext = httpContextAccessor.HttpContext;
            _logger = logger;
            _unitOfWork = unitOfWork;
            _registrationService = registrationService;
            _tokenService = tokenService;
        }


        /// <summary>
        /// Registers a new account.
        /// </summary>
        /// <param name="model"></param>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /register
        ///     {
        ///        "username": "Superman",
        ///        "email": "superman@kryptonmail.space",
        ///        "password": "!Krypton1t3"
        ///     }
        ///
        /// </remarks>
        /// <response code="201">Returns a newly created JWt, and refresh token.</response>
        /// <response code="500">The username, or email is already in use.</response>
        [HttpPost]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Register([FromBody] RegistrationModel model)
        {
            var (loginId, accountId) = await _registrationService.Register(model.Username, model.Email, model.Password, _httpContext.RequestAborted);

            var token = _tokenService.GetAccessToken(accountId);
            var refreshToken = await _tokenService.GetRefreshTokenAsync(loginId, _httpContext.RequestAborted);

            await _unitOfWork.SaveChangesAsync(_httpContext.RequestAborted);

            return Created(string.Empty, new
            {
                token,
                refreshToken
            });
        }
    }
}