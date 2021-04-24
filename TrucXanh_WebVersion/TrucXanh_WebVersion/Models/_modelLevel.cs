using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ModelGame;
using BUS;
namespace TrucXanh_WebVersion.Models
{
    public class _modelLevel
    {
        busLevel busLevelObject = new busLevel();
        public tblLevel getFirstLevel()
        {
            return busLevelObject.getFirstLevel();
        }
    }
}