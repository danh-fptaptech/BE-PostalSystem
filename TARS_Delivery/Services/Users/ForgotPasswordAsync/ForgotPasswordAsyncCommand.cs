﻿using MediatR;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.ForgotPasswordAsync;

internal sealed record ForgotPasswordAsyncCommand(string Email) : IRequest<Result>
