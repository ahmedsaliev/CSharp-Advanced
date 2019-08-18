using System.Collections;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class Smartphone : ICallingFunctionality, IBrowsingFunctionality
    {
        private ICollection Contacts;
        private ICollection Sites;

        public Smartphone(ICollection contacts, ICollection sites)
        {
            this.Contacts = contacts;
            this.Sites = sites;
        }

        public string Call(string number)
        {
            return !number.All(char.IsDigit) ? "Invalid number!" : $"Calling... {number}";
        }

        public string Browse(string url)
        {
            return url.Any(char.IsDigit) ? "Invalid URL!" : $"Browsing: {url}!";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var contact in this.Contacts)
            {
                sb.AppendLine(Call(contact.ToString()));
            }

            foreach (var site in this.Sites)
            {
                sb.AppendLine(Browse(site.ToString()));
            }

            return sb.ToString();
        }
    }
}