using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeyCommit.Client
{
    public static class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var loginView = new Member.View.LoginView();
            loginView.ShowDialog();
        }
    }
}
