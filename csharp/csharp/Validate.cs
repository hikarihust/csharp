using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace csharp
{
    class Validate
    {
        private Dictionary<string, string> errors = null;

        public Validate()
        {
            errors = new Dictionary<string, string>();
        }

        public bool checkName(String value)
        {

            Regex regex = new Regex(@"^[A-Za-z0-9\s]{2,100}$");
            Match match = regex.Match(value);
            bool flagCheck = match.Success;

            if (!flagCheck)
            {
                errors.Add("name", "Giá trị này phải là ký tự hoặc số có độ dài từ 2 đến 100 ký tự");
            }

            return flagCheck;
        }

        public void showError()
        {
            foreach (var kvp in errors)
            {
                WriteLine.Error(kvp.Key.ToUpper() + ": " + kvp.Value);
            }
        }
    }
}
