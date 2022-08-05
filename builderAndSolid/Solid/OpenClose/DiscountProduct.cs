using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Solid.OpenClose
{
    public class DiscountProduct
    {
        private readonly UserType _userType;

        public DiscountProduct():this(new UserType())
        {
          
        }
        public DiscountProduct(UserType userType)
        {
            this._userType = userType;
        }

        public double GetProductPrice(double Price)
        {
            return Price * (double)_userType.GetUserDiscount();
        }
    }

     public  class UserType
    {
       public virtual decimal GetUserDiscount() 
        {
            return 1;
        }
    }



    public class GoldentUser : UserType
    {
        public override decimal GetUserDiscount()
        {
            return (decimal)0.02;
        }
    }
    public  class silverUser : UserType
    {
        public override decimal GetUserDiscount()
        {
            return (decimal)0.9;
        }
    }


}
