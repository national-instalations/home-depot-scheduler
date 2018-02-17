using HomeDepotScheduler.Models.AccountViewModels;
using HomeDepotScheduler.Models.ManageViewModels;
using System.ComponentModel.DataAnnotations;

namespace HomeDepotScheduler.Models.ValidationAttributes
{
    public class StoreNumberAttribute : ValidationAttribute
    {

        private int _caseSwitch = 0;
        public StoreNumberAttribute(int caseSwitch)
        {
            this._caseSwitch = caseSwitch;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            switch (_caseSwitch)
            {
                case 1:
                    IndexViewModel user = (IndexViewModel)validationContext.ObjectInstance;

                    if (user.BusinessAccount == true && user.StoreNumber == null)
                    {
                        return new ValidationResult(GetErrorMessage());
                    }
                    break;

                default:
                    RegisterViewModel userRegister = (RegisterViewModel)validationContext.ObjectInstance;

                    if (userRegister.BusinessAccount == true && userRegister.Company == null)
                    {
                        return new ValidationResult(GetErrorMessage());
                    }
                    break;
            }

            return ValidationResult.Success;
        }


        //public void AddValidation(ClientModelValidationContext context)
        //{
        //    throw new NotImplementedException();
        //}


        private string GetErrorMessage()
        {
            return $"Please enter a company name.";
        }

    }
}
