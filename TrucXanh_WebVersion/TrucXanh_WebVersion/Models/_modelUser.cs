﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BUS;
using ModelGame;
namespace TrucXanh_WebVersion.Models
{
    public class _modelUser
    {
        busUsers busUser = new busUsers();
        public int insertUserModel(tblUser user)
        {
            return busUser.insertUser(user);
        }
    }
}