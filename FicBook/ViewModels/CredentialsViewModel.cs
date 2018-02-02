
using FicBook.ViewModels.Validations;
using FluentValidation.Attributes;

namespace FicBook.ViewModels
{
    [Validator(typeof(CredentialsViewModelValidator))]
    public class CredentialsViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
