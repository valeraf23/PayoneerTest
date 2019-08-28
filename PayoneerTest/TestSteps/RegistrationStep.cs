using System;
using PayoneerTest.Models;
using PayoneerTest.Pages;
using VF.Serenity.AutomationFramework.Infrastructure.Factory;

namespace PayoneerTest.TestSteps
{
    public class RegistrationStep
    {
        public FinishRegistrationPage RegistAsCompanyUser(CompanyUserModel companyUser)
        {
            Step1(companyUser.DetailsSecurityInfo);
            Step2(companyUser.ContactDataInfo);
            Step3(companyUser.BeginRegistrationInfo);
            Step4(companyUser.LastInfo);

            var finishPage = PageFactory.Get<FinishRegistrationPage>();
            finishPage.WaitForReady();
            return finishPage;

        }

        private static void Step4(LastInfo companyUserLastInfo)
        {
            var lastPage = PageFactory.Get<LastPage>();
            lastPage.WaitForReady();
            lastPage.Iachfield.SetText(companyUserLastInfo.Iachfield);
            lastPage.SignDocument.SetText(companyUserLastInfo.SignDocument);
            lastPage.SignDocument2.SetText(companyUserLastInfo.SignDocument2);
            lastPage.combobox.Select(companyUserLastInfo.combobox);
            lastPage.iachfield2.SetText(companyUserLastInfo.iachfield2);
        }

        private static void Step2(ContactDataInfo companyUserContactDataInfo)
        {
            var contactDataPage = PageFactory.Get<ContactDataPage>();
            contactDataPage.WaitForReady();
            contactDataPage.Address.SetText(companyUserContactDataInfo.Address);
            contactDataPage.City.SetText(companyUserContactDataInfo.City);
            contactDataPage.ContactPersonPhoneNumber.PhoneNumber.SetText(companyUserContactDataInfo
                .ContactPersonPhoneNumber);
            contactDataPage.Zip.SetText(companyUserContactDataInfo.Zip);
            contactDataPage.Next.Click();
        }

        private static void Step3(BeginRegistrationInfo companyUserBeginRegistrationInfo)
        {
            var beginRegistrationPage = PageFactory.Get<BeginRegistrationPage>();
            beginRegistrationPage.WaitForReady();
            beginRegistrationPage.CompanyRegistrationNumber.SetText(companyUserBeginRegistrationInfo
                .CompanyRegistrationNumber);
            beginRegistrationPage.LAccountDetailsCaptcha.SetText(
                companyUserBeginRegistrationInfo.LAccountDetailsCaptcha);
            beginRegistrationPage.Password.SetText(companyUserBeginRegistrationInfo.Password);
            beginRegistrationPage.RetypePassword.SetText(companyUserBeginRegistrationInfo.Password);
            beginRegistrationPage.SecurityAnswer.SetText(companyUserBeginRegistrationInfo.SecurityAnswer);
            beginRegistrationPage.SecurityQuestions.Select(companyUserBeginRegistrationInfo.SecurityQuestions);
        }

        private static void Step1(DetailsSecurityInfo companyUserDetailsSecurityInfo)
        {
            var detailsSecurityPage = PageFactory.Get<DetailsSecurityPage>();
            detailsSecurityPage.Open();
            detailsSecurityPage.AccountType.SetValue("Company");
            detailsSecurityPage.Birthday.SetValue(DateTime.Parse(companyUserDetailsSecurityInfo.Birthday).ToString("MM/dd/yyyy"));
            detailsSecurityPage.BusinessOrganization.Select(companyUserDetailsSecurityInfo.BusinessOrganization);
            detailsSecurityPage.CompanyName.SetText(companyUserDetailsSecurityInfo.CompanyName);
            detailsSecurityPage.ConfirmEmail.SetText(companyUserDetailsSecurityInfo.Email);
            detailsSecurityPage.Email.SetText(companyUserDetailsSecurityInfo.Email);
            detailsSecurityPage.FirstName.SetText(companyUserDetailsSecurityInfo.FirstName);
            detailsSecurityPage.LastName.SetText(companyUserDetailsSecurityInfo.LastName);
            detailsSecurityPage.Next.Click();
        }
    }
}
