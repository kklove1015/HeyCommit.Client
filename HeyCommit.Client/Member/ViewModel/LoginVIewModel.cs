using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HeyCommit.Client.Member.ViewModel
{
    public class LoginVIewModel
    {
        public string LoginText { get; set; }
        public ICommand LoginButton { get; set; }
        public LoginVIewModel()
        {
            LoginButton = new RelayCommand(OnLoginButton);
        }

        private void OnLoginButton() 
        {
            Main.View.MainView mainView = new Main.View.MainView();
            mainView.ShowDialog();
        }
    }
}
