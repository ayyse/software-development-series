using GameProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Contracts
{
    public interface IAuthenticationService
    {
        bool Authentication(Gamer gamer);
    }
}
