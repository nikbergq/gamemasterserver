using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameRegistrationServer.Models
{
    public class GameRegistrationReply
    {
        String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        String ip;

        public String Ip
        {
            get { return ip; }
            set { ip = value; }
        }
        String registrationNumber;

        public String RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value; }
        }
        String registrationStatus;

        public String RegistrationStatus
        {
            get { return registrationStatus; }
            set { registrationStatus = value; }
        }
    }
}