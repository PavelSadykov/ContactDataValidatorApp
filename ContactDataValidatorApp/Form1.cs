using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary_ContactDataValidator;

namespace ContactDataValidatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            string fullName = fullNameTextBox.Text;
            string age = ageTextBox.Text;
            string phoneNumber = phoneTextBox.Text;
            string email = emailTextBox.Text;

            bool isFullNameValid = ContactValidator.IsFullNameValid(fullName);
            bool isAgeValid = ContactValidator.IsAgeValid(age);
            bool isPhoneNumberValid = ContactValidator.IsPhoneNumberValid(phoneNumber);
            bool isEmailValid = ContactValidator.IsEmailValid(email);

            ShowValidationResults(isFullNameValid, isAgeValid, isPhoneNumberValid, isEmailValid);
        }

        private void ShowValidationResults(bool isFullNameValid, bool isAgeValid, bool isPhoneNumberValid, bool isEmailValid)
        {
            fullNameStatusLabel.Text = $"ФИО статус: {isFullNameValid}";
            ageStatusLabel.Text = $"Возраст статус: {isAgeValid}";
            phoneStatusLabel.Text = $"Телефонный номер статус: {isPhoneNumberValid}";
            emailStatusLabel.Text = $"Email статус: {isEmailValid}";
        }
    }
}
