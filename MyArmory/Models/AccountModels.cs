using System;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MyArmory.Models
{
    public class UserLoginModel
    {
        private string m_username;
        private string m_password;

        #region Properties

        [Required]
        public string Username
        {
            get
            {
                return m_username;
            }

            set
            {
                m_username = value;
            }
        }

        [Required]
        [DataType(DataType.Password)]
        public string Password
        {
            get
            {
                return m_password;
            }

            set
            {
                m_password = value;
            }
        }

        #endregion
    }

    public class UserRegisterModel
    {
        private string m_username;
        private string m_password;
        private string m_passwordAgain;

        #region Properties

        [Required]
        public string Username
        {
            get
            {
                return m_username;
            }

            set
            {
                m_username = value;
            }
        }

        [Required, DataType(DataType.Password), StringLength(100, MinimumLength = 4)]
        public string Password
        {
            get
            {
                return m_password;
            }

            set
            {
                m_password = value;
            }
        }

        [DataType(DataType.Password), Compare("Password")]
        public string PasswordAgain
        {
            get
            {
                return m_passwordAgain;
            }

            set
            {
                m_passwordAgain = value;
            }
        }

        #endregion
    }
}