using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagementApplication.Core.Model
{
    public class AppSettings
    {
        public string ConnectionString { get; set; } = $@"Server=.;Initial Catalog=SchoolManagementAppDB;Trust_Connection=true";
    }
}
