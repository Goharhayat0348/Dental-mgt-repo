using Dental_Managment.Model;
using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Dental_Managment.Validators
{
    //public class PersonValidator : AbstractValidator<Patient>
    //{
    //    public  PersonValidator()
    //    {
           
    //        RuleFor(p => p.Name)
    //            .Cascade(CascadeMode.Stop)
    //            .NotEmpty().WithMessage("{PropertyName} is Empty")
    //            .Length(2, 50).WithMessage("Length ({TotalLength})of {PropertyName} Invalid")
    //            .Must(BeAValidName).WithMessage("{PropertyName} Contains Characters");


    //        RuleFor(p => p.Phone)
    //            .Cascade(CascadeMode.Stop)
    //            .NotEmpty().WithMessage("{PropertyName} is Empty")
    //            .Must(IsNumber).WithMessage("{PropertyName} Contains Characters");


    //    //    RuleFor(p => p.Email)
    //    //        .EmailAddress(EmailValidationMode.Net4xRegex)
    //    //        .NotEmpty().WithMessage("{PropertyName} is Empty");


    //    //    RuleFor(p => p.Address)
    //    //        .Cascade(CascadeMode.Stop)
    //    //        .NotEmpty().WithMessage("{PropertyName} is Empty")
    //    //        .Length(2, 50).WithMessage("Length ({TotalLength})of {PropertyName} Invalid")
    //    //        .Must(BeAValidName).WithMessage("{PropertyName} Contains Characters");


    //    //    RuleFor(p => p.DOB)
    //    //        .Must(BeAValidAge).WithMessage("Invalid {PropertyName}");


    //    //    RuleFor(p => p.Gender)
    //    //       .Must(IsValidGender).WithMessage("Invalid {PropertyName}");



    //    //    RuleFor(p => p.Allergies)
    //    //   .Cascade(CascadeMode.Stop)
    //    //   .NotEmpty().WithMessage("{PropertyName} is Empty")
    //    //   .Length(2, 50).WithMessage("Length ({TotalLength})of {PropertyName} Invalid")
    //    //   .Must(BeAValidName).WithMessage("{PropertyName} Contains Characters");
    //    }

    //    protected bool BeAValidName(string name)
    //    {
    //        name = name.Replace(" ", "");
    //        name = name.Replace("-", "");
    //        return name.All(char.IsLetter);
    //    }

    //    protected bool BeAValidAge(DateTime date)
    //    {
    //        int currentYear = DateTime.Now.Year;
    //        int dobYear = date.Year;

    //        if (dobYear <= currentYear && dobYear > (currentYear - 120))
    //        {
    //            return true;
    //        }
    //        return false;
    //    }



    //    static bool IsNumber(string number)
    //    {
    //        return number[0] == '0' && number[1] == '3' && number.Length == 11 && BeAValidPhone(number);
    //    }

    //    static bool BeAValidPhone(string input)
    //    {

    //        foreach (char c in input)
    //        {
    //            if (c < '0' || c > '9')

    //                return false;
    //        }
    //        return true;
    //    }

    //    static bool IsValidGender(string gender)
    //    {

    //        foreach (char g in gender)
    //        {
    //            if (g == '1')
    //            {
    //                return true;
    //            }
    //            else if (g == '2')
    //            {
    //                return true;
    //            }
    //            else if (g == '3')
    //            {
    //                return true;
    //            }
               
    //        }
    //        return false;
    //    }

    //}
}
