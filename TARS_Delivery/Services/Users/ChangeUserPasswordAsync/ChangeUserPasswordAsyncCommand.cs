﻿using MediatR;
using TARS_Delivery.Shared;

namespace TARS_Delivery.Services.Users.ChangeUserPasswordAsync;

internal sealed record ChangeUserPasswordAsyncCommand(
    int Id, string OldPassword, string NewPassword) : IRequest<Result>;
