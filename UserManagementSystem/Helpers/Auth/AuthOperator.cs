using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementSystem.Helpers.Auth
{
    
        class AuthOperator
        {
            Views.Auth.FormLogin frmLogin = new Views.Auth.FormLogin();
            Views.Auth.FormRegister frmRegister = new Views.Auth.FormRegister();
            Views.Auth.FormPasswordReset frmReset = new Views.Auth.FormPasswordReset();

            public bool Login()
            {
                do
                {
                    switch (frmLogin.ShowDialog())
                    {
                        // Если пользовтаель нажал отменить
                        case System.Windows.Forms.DialogResult.Cancel:
                            return false;
                        case System.Windows.Forms.DialogResult.OK:
                            tryLogin();
                            break;
                        case System.Windows.Forms.DialogResult.Yes:
                            SignIn();
                            break;

                    }
                }
                while (!Program._auth.isLogin);

                return true;
            }

            private void tryLogin()
            {
                Program._auth.CurrentUser = Program._db.Users.Where(u =>
                                u.Email == frmLogin.textBoxEmail.Text &&
                                u.Password == frmLogin.textBoxPassword.Text
                                ).FirstOrDefault();
                if (Program._auth.CurrentUser != null)
                {
                    Program._auth.isLogin = true;
                }

            }

            public void SignIn()
            {
                frmRegister.ShowDialog();
            }

            private void trySignIn()
            {

            }
        }
    
}
