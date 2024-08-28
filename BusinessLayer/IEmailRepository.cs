using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IEmailRepository
    {
        public void SendEmail(string FromAddress, string ToAddress, string Password, string Body, string Subject);
    }
}
