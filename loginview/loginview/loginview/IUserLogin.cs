using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace loginview
{
    public interface IUserLogin
    {

        Task<bool> Login(string username, string password);

    }
}
