﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppActs.Client.View
{
    public interface IViewLoggedIn : IView
    {
        void RedirectToLogin();
    }
}
