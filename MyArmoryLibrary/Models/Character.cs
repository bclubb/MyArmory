using System;
using System.ComponentModel.DataAnnotations;

namespace MyArmoryLibrary.Models
{
    public class Character
    {
        private string m_name;

        #region Methods

        public override string ToString()
        {
            return m_name;
        }

        #endregion

        #region Properties

        [Key]
        public string Name
        {
            get
            {
                return m_name;
            }

            set
            {
                m_name = value;
            }
        }

        #endregion
    }
}
