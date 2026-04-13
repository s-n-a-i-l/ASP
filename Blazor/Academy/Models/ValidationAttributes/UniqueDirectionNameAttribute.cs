using Academy.Data;
using Microsoft.CodeAnalysis.FlowAnalysis;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Academy.Models.ValidationAttributes
{
    public class UniqueDirectionNameAttribute: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrWhiteSpace(value.ToString())) return ValidationResult.Success;
            string directionName = value.ToString() /*as string*/;
            IDbContextFactory<AcademyContext> dbContextFactory = validationContext.GetService<IDbContextFactory<AcademyContext>>();
            if(dbContextFactory == null)return new ValidationResult("Ошибка! нет такой животний...");
            using (var context = dbContextFactory.CreateDbContext()) 
            {
                bool exists = context.Directions.Any(d => d.direction_name.ToLower() == directionName);
                if (exists) return new ValidationResult(ErrorMessage ?? $"Direction '{directionName}' already exist.");
            }
            return ValidationResult.Success;
        }
    }
}
