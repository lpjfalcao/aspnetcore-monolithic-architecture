﻿using ProjetoModeloDDD.Infra.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Data.Helpers
{
    public class MessageHelper<T>
    {
        public T Data { get; set; }
        public bool Success { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }

        public IList<string> Validations { get; set; }

        public void Ok(T data)
        {
            Data = data;
            Success = Success;
            StatusCode = (int)StatusCodeEnum.Ok;
        }

        public void NotFound(string message)
        {
            Success = false;
            StatusCode = (int)StatusCodeEnum.NotFound;
            Message = message;
        }

        public void BadRequest(IList<string> validations)
        {
            Success = false;
            StatusCode = (int)StatusCodeEnum.BadRequest;
            Validations = validations;
        }

        public void Error(Exception ex)
        {
            Success = false;
            StatusCode = (int)StatusCodeEnum.InternalServerError;
            Message = ex.Message;
            StackTrace = ex.StackTrace;
        }
    }
    public class MessageHelper
    {
        public bool Success { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }

        public IList<string> Validations { get; set; }

        public void Ok()
        {
            Success = Success;
            StatusCode = (int)StatusCodeEnum.Ok;
        }

        public void NotFound(string message)
        {
            Success = false;
            StatusCode = (int)StatusCodeEnum.NotFound;
            Message = message;
        }

        public void BadRequest(IList<string> validations)
        {
            Success = false;
            StatusCode = (int)StatusCodeEnum.BadRequest;
            Validations = validations;
        }

        public void Error(Exception ex)
        {
            Success = false;
            StatusCode = (int)StatusCodeEnum.InternalServerError;
            Message = ex.Message;
            StackTrace = ex.StackTrace;
        }
    }
}
