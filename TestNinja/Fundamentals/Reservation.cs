﻿namespace TestNinja.Fundamentals
{
    public class Reservation
    {
        public User MadeBy { get; set; }

        public bool CanBeCancelledBy(User user)
        {
            //if (user.IsAdmin)
            //    return true;
            //if(MadeBy==user)
            //    return true;
            //return false;
            //if(user.IsAdmin || MadeBy == user)
            //    return true;
            //return false;
            return (user.IsAdmin || MadeBy == user);
        }
        
    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }
}