using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication32.Models
{
    public class UserTour 
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int UserID { get; set; }
        [Display(Name = "Number of Adults")]
       
        //public virtual AdminTour Num_Adults { get; set; }


       
        //public virtual AdminTour Num_Kids { get; set; }
        
        //public virtual AdminTour Price { get; set; }
        //public virtual AdminTour Deposit { get; set; }
        //public double GuestCost { get; set; }
        //public double Total_Cost { get; set; }
        //public int TTickets { get; set; }

        //public double deposit()
        //{

        //    double deposit = 0;
        //    if (Price <= 150)
        //    {
        //        deposit = Price * 0.15;
        //    }
        //    else
        //        if (Price > 150 && Price <= 300)
        //    {
        //        deposit = Price * 0.20;
        //    }
        //    else
        //        if (Price > 300 && Price <= 500)
        //    {
        //        deposit = Price * 0.25;
        //    }
        //    else
        //        if (Price > 500 && Price <= 800)
        //    {
        //        deposit = Price * 0.30;
        //    }
        //    else
        //        if (Price > 800)
        //    {
        //        deposit = Price * 0.40;
        //    }
        //    return deposit;
        //}
        //public double Guest_Cost()
        //{
        //    double x = 0;
        //    x = (Price * NumAdults) + ((Price * NumKids) / 0.50);
        //    return x;
        //}

        //public double TotalCost()
        //{
        //    double x = 0;
        //    if (Tour_Name == "Ushaka" || Tour_Name == "ushaka")
        //    {
        //        x = Price + Guest_Cost() + deposit() - Discount();

        //    }
        //    if (Tour_Name == "Kruger National Park" || Tour_Name == "kruger national park")
        //    {
        //        x = Price + Guest_Cost() + deposit() - Discount();

        //    }

        //    if (Tour_Name == "V&A Waterfront" || Tour_Name == "v&a waterfront")
        //    {
        //        x = Price + Guest_Cost() + deposit() - Discount();

        //    }

        //    if (Tour_Name == "Gold Reef City Theme Park" || Tour_Name == "gold reef city theme park")

        //    {
        //        x = Price + Guest_Cost() + deposit() - Discount();

        //    }
        //    return x;

        //}
        //public double discount { get; set; }
        //public double Discount()
        //{
        //    double x = 0;
        //    if (NumAdults + NumKids >= 4 && NumAdults + NumKids <= 6)
        //    {
        //        x = Price * 0.05;

        //    }
        //    if (NumAdults + NumKids > 6 && NumAdults + NumKids <= 10)
        //    {
        //        x = Price * 0.10;

        //    }
        //    if (NumAdults + NumKids > 10 && NumAdults + NumKids <= 15)
        //    {
        //        x = Price * 0.15;

        //    }
        //    if (NumAdults + NumKids > 15 && NumAdults + NumKids <= 20)
        //    {
        //        x = Price * 0.20;

        //    }
        //    else
        //    {
        //        x = 0;
        //    }
        //    return x;



        //}
        //public int numOfTickets()
        //{
        //    int x = NumAdults + NumKids;
        //    return x;
        //}

    }
}