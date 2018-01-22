﻿
using Microsoft.AspNetCore.Identity;

using System;

using System.Collections.Generic;

using System.Linq;

using System.Threading.Tasks;



namespace RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Data

{

    public class UsersLogin : IdentityUser

    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EyeColour { get; set; }

        public string RepeatPassword { get; set; }



        public static implicit operator UsersLogin(IdentityResult v)

        {

            throw new NotImplementedException();

        }

    }

}