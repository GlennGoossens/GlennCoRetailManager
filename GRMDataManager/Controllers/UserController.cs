﻿using GRMDataManager.Library.DataAccess;
using GRMDataManager.Library.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace GRMDataManager.Controllers
{
    [Authorize]
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {
        public UserModel GetById()
        {
            string userId = RequestContext.Principal.Identity.GetUserId();

            UserData data = new UserData();

            return data.GetUserById(userId).First();
        }
    }
}
