﻿namespace supermarket.sharp.api.Domain.Services.Communication
{
    public abstract class BaseResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public BaseResponse(bool success, string message)
        {
            Success = success;
            message = message;
        }
          
    }
}