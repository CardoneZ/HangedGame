﻿using AhorcadoCliente.UserServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AhorcadoCliente.Pages
{
    /// <summary>
    /// Lógica de interacción para UserRegister.xaml
    /// </summary>
    public partial class UserRegister : Page
    {
        UserServicesClient userServices = new UserServicesClient();
        public UserRegister()
        {
            InitializeComponent();
            disableErrorLabels();
        }

        private void cancelRegister_Click(object sender, RoutedEventArgs e)
        {
            cancelRegister();
        }

        private void cancelRegister()
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }

        private bool checkData()
        {
            bool hasEmptyField = false;

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                labelEmailEmpty.Visibility = Visibility.Visible;
                hasEmptyField = true;
            }
            else
            {
                labelEmailEmpty.Visibility = Visibility.Hidden;
            }

            if (string.IsNullOrWhiteSpace(txtNickname.Text))
            {
                labelNicknameEmpty.Visibility = Visibility.Visible;
                hasEmptyField = true;
            }
            else
            {
                labelNicknameEmpty.Visibility = Visibility.Hidden;
            }

            if (string.IsNullOrWhiteSpace(txtNames.Text))
            {
                labelNamesEmpty.Visibility = Visibility.Visible;
                hasEmptyField = true;
            }
            else
            {
                labelNamesEmpty.Visibility = Visibility.Hidden;
            }

            if (string.IsNullOrWhiteSpace(txtFirstSurname.Text))
            {
                txtLabelFirstSurnameEmpty.Visibility = Visibility.Visible;
                hasEmptyField = true;
            }
            else
            {
                txtLabelFirstSurnameEmpty.Visibility = Visibility.Hidden;
            }

            if (string.IsNullOrWhiteSpace(txtSecondSurname.Text))
            {
                labelSecondSurnameEmpty.Visibility = Visibility.Visible;
                hasEmptyField = true;
            }
            else
            {
                labelSecondSurnameEmpty.Visibility = Visibility.Hidden;
            }

            if (string.IsNullOrWhiteSpace(txtTelephone.Text))
            {
                labelTelephoneEmpty.Visibility = Visibility.Visible;
                hasEmptyField = true;
            }
            else
            {
                labelTelephoneEmpty.Visibility = Visibility.Hidden;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Password))
            {
                labelPasswordEmpty.Visibility = Visibility.Visible;
                hasEmptyField = true;
            }
            else
            {
                labelPasswordEmpty.Visibility = Visibility.Hidden;
            }

            if (string.IsNullOrWhiteSpace(txtPasswordConfirmation.Password))
            {
                labelPasswordConfirmationEmpty.Visibility = Visibility.Visible;
                hasEmptyField = true;
            }
            else
            {
                labelPasswordConfirmationEmpty.Visibility = Visibility.Hidden;
            }

            if (dpBirthDate.SelectedDate == null)
            {
                labelBirthDateEmpty.Visibility = Visibility.Visible;
                hasEmptyField = true;
            }
            else
            {
                labelBirthDateEmpty.Visibility = Visibility.Hidden;
            }

            return hasEmptyField;
        }

        private void disableErrorLabels()
        {
            labelBirthDateEmpty.Visibility = Visibility.Hidden;
            labelEmailEmpty.Visibility = Visibility.Hidden;
            labelNamesEmpty.Visibility = Visibility.Hidden;
            labelNicknameEmpty.Visibility = Visibility.Hidden;
            labelPasswordConfirmationEmpty.Visibility = Visibility.Hidden;
            labelPasswordEmpty.Visibility = Visibility.Hidden;
            labelSecondSurnameEmpty.Visibility = Visibility.Hidden;
            txtLabelFirstSurnameEmpty.Visibility = Visibility.Hidden;
            labelTelephoneEmpty.Visibility = Visibility.Hidden;
        }

        private bool checkPasswords()
        {
            return !string.IsNullOrEmpty(txtPassword.Password) && !string.IsNullOrEmpty(txtPasswordConfirmation.Password);
        }


        private bool checkPasswordsMatch()
        {
            return txtPassword.Password == txtPasswordConfirmation.Password;
        }


        private async void Register_Click(object sender, RoutedEventArgs e)
        {
            if (!checkData())
            {
                if (checkPasswords())
                {
                    if (checkPasswordsMatch())
                    {
                        if (allValidate())
                        {
                            if (await userServices.nicknameAlreadyRegisteredAsync(txtNickname.Text))
                            {
                                string message = Properties.Resources.NicknameAlreadyRegistered;
                                MessageBox.Show(message);
                            }
                            else if (await userServices.emailAlreadyRegisteredAsync(txtEmail.Text))
                            {
                                string message = Properties.Resources.EmailAlreadyRegistered;
                                MessageBox.Show(message);
                            }
                            else if (await userServices.telephoneAlreadyExistAsync(txtTelephone.Text))
                            {
                                string message = Properties.Resources.TelephoneAlreadyRegistered;
                                MessageBox.Show(message);
                            }
                            else
                            {
                                try
                                {
                                    Player newPlayer = createNewPlayer();
                                    bool confirmation = await userServices.registerUserAsync(newPlayer);
                                    if (confirmation)
                                    {
                                        string message = Properties.Resources.ConfirmationUserRegister;
                                        MessageBox.Show(message);
                                        NavigationService.Navigate(new LogIn(Application.Current.MainWindow as MainWindow));
                                    }
                                    else
                                    {
                                        string message = Properties.Resources.ErrorUserRegister;
                                        MessageBox.Show(message);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error: " + ex.Message);
                                }
                            }
                        }
                    }
                    else
                    {
                        string message = Properties.Resources.PasswordDoesntMatch;
                        MessageBox.Show(message);
                    }
                }
            }
        }

        private Player createNewPlayer()
        {
            Player newPlayer = new Player();
            newPlayer.Email = txtEmail.Text.Trim();
            newPlayer.NickName = txtNickname.Text.Trim();
            newPlayer.Password = txtPassword.Password.Trim();
            newPlayer.PhoneNumber = txtTelephone.Text.Trim();
            newPlayer.Names = txtNames.Text.Trim();
            newPlayer.FirstSurname = txtFirstSurname.Text.Trim();
            newPlayer.SecondSurname = txtSecondSurname.Text.Trim();
            newPlayer.PointsEarned = 0;
            newPlayer.BirthDate = dpBirthDate.Text;

            return newPlayer;
        }

        private bool allValidate()
        {
            string email = txtEmail.Text.Trim();
            string nickName = txtNickname.Text.Trim();
            string name = txtNames.Text.Trim();
            string firstSurname = txtFirstSurname.Text.Trim();
            string secondSurname = txtSecondSurname.Text.Trim();
            string password = txtPassword.Password.Trim();
            string phoneNumber = txtTelephone.Text.Trim();

            if (validateNames(name) && validateNames(firstSurname) && validateNames(secondSurname) && validateNick(nickName)
                && validateEmail(email) && validatePassword(password) && validateTelephone(phoneNumber))
            {
                return true;
            }
            return false;
        }

        private bool validateNames(string name)
        {

            if (Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
            {
                return true;
            }
            else
            {
                string message = Properties.Resources.NamesNotValid;
                MessageBox.Show(message);
                return false;
            }
        }

        private bool validateTelephone(string phone)
        {
            string message = Properties.Resources.PhoneNotValid;
            if (phone.Length != 10)
            {
                MessageBox.Show(message);
                return false;
            }

            foreach (char c in phone)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show(message);
                    txtTelephone.Clear();
                    return false;
                }
            }
            return true;
        }

        private bool validateEmail(string email)
        {
            string message = Properties.Resources.EmailNotValid;
            if (Regex.IsMatch(email, @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@"
                + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$"))
            {
                return true;
            }
            else
            {

                MessageBox.Show(message);
                return false;
            }
        }

        private bool validateNick(string nickName)
        {
            string message = Properties.Resources.NicknameNotValid;
            if (Regex.IsMatch(nickName, @"^[a-zA-Z0-9]+$"))
            {
                return true;
            }
            else
            {
                MessageBox.Show(message);
                return false;
            }
        }

        public bool validatePassword(string password)
        {
            string message = Properties.Resources.PasswordNotValid;
            if (Regex.IsMatch(password, @"^[a-zA-Z0-9]{8,15}$"))
            {
                return true;
            }
            else
            {
                MessageBox.Show(message);
                return false;
            }
        }
    }
}
