using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailMaskingApp
{
    public class EmailMasker
    {
        public string MaskEmail(string email, int visibleCharacters, char maskChar, bool staticLength)
        {
            var emailParts = EmailSplitter.Split(email);
            var maskedLocalPart = MaskLocalPart(emailParts.LocalPart, visibleCharacters, maskChar, staticLength);
            return maskedLocalPart + emailParts.DomainPart;
        }

        private string MaskLocalPart(string localPart, int visibleCharacters, char maskChar, bool staticLength)
        {
            if (localPart.Length <= visibleCharacters)
            {
                return localPart; 
            }

            int maskLength = CalculateMaskLength(localPart.Length, visibleCharacters, staticLength);
            return localPart.Substring(0, visibleCharacters) + new string(maskChar, maskLength);
        }

        private int CalculateMaskLength(int totalLength, int visibleCharacters, bool staticLength)
        {
            if (staticLength)
            {
                return 4;
            }
            else
            {
                return totalLength - visibleCharacters;
            }
        }
    }

  





}
