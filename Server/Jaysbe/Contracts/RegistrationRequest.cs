﻿using System.ComponentModel.DataAnnotations;

namespace Jaysbe.Contracts;

public record RegistrationRequest(
    [Required]string Email,
    [Required]string UserName,
    [Required]string Password
    );