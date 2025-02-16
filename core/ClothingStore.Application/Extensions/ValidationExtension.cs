﻿using ClothingStore.Application.Exception;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Application.Extensions
{
    public static class ValidationExtension
    {

        public static async Task ThrowIfValidationFailAsync<T>(this IValidator<T> validator, T instance)
        {
            var validationResult = await validator.ValidateAsync(instance);
            if (!validationResult.IsValid)
            {
                throw new ClothingStoreValidationException(validationResult.Errors);
            }
        }
        public static IRuleBuilderOptions<T, TProperty> CheckNull<T, TProperty>(this IRuleBuilderOptions<T, TProperty> ruleBuilder)
        {
            return ruleBuilder.WithMessage($"{nameof(TProperty)} is required");
        }
    }
}
