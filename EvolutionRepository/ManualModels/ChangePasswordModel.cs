﻿using System;

namespace EvolutionRepository.ManualModels
{
    public class ChangePasswordModel
    {
        public string Username { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
        public string ChangePasswordResult { get; set; }
    }
}
