using System;
using System.ComponentModel.DataAnnotations;

namespace MyArmoryLibrary.Models
{
    class User
    {
        private string m_username;

        #region Properties

        [Key]
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

        #endregion
    }
}
