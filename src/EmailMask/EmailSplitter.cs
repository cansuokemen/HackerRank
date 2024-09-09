using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailMaskingApp

{
        public static class EmailSplitter
        {
            public static (string LocalPart, string DomainPart) Split(string email)
            {
                if (string.IsNullOrEmpty(email) || !email.Contains('@'))
                {
                    throw new ArgumentException("Invalid email address.");
                }

                int atIndex = email.IndexOf('@');
                string localPart = email.Substring(0, atIndex);
                string domainPart = email.Substring(atIndex);

                return (localPart, domainPart);
            }
        }



    }

