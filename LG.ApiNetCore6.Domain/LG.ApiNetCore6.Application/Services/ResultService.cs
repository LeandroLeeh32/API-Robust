﻿using FluentValidation.Results;


namespace LG.ApiNetCore6.Application.Services
{
    //Responsavel por tratar nossos retornos dos nossos serviços 
    public class ResultService
    {

        public bool IsSucess { get; set; }
        public string? Message { get; set; }
        public ICollection<ErrorValidation>? Errors { get; set; }

        public static ResultService RequestError(string message, ValidationResult validationResult)
        {
            return new ResultService
            {
                IsSucess = false,
                Message = message,
                Errors = validationResult.Errors.Select(x => new ErrorValidation { Field = x.PropertyName, Message = x.ErrorMessage }).ToList() 
            };
        }

        public static ResultService<T> RequestError<T>(string message, ValidationResult validationResult)
        {
            return new ResultService<T>
            {
                IsSucess = false,
                Message = message,
                Errors = validationResult.Errors.Select(x => new ErrorValidation { Field = x.PropertyName, Message = x.ErrorMessage }).ToList()
            };
        }

        public static ResultService Fail(string message)=> new ResultService { IsSucess=false, Message = message};
        public static ResultService<T> Fail<T>(string message) => new ResultService<T> { IsSucess = false, Message = message };

        public static ResultService Sucess(string message) => new ResultService { IsSucess = true, Message = message };
        public static ResultService<T> Sucess<T>(T data) => new ResultService<T> { IsSucess = true, Data = data };



    }

    public class ResultService<T> : ResultService
    {
        public T? Data { get; set; }
    }
}
