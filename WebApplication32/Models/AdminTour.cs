using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication32.Models
{
    public class AdminTour
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Display(Name = "Tour ID")]
        public int TourID { get; set; }

        [Display(Name = "Tour Name")]
        public string Tour_Name { get; set; }

        [Display(Name = "Tour Duration")]
        public string Tour_Duration { get; set; }

        [Display(Name = "Number of Adults")]
        public int Num_Adults { get; set; }
        [Display(Name = "Number of Kids")]
        public int Num_Kids { get; set; }

        //[Display(Name = "From")]
        //public string LocationFrom { get; set; }
        //[Display(Name = "TO")]
        //public string LocationTO { get; set; }

        [Display(Name = "Tour Date")]
        [DataType(DataType.Date)]
        public DateTime TourDate { get; set; }


        [Display(Name = "Tour Start Time")]
        [DataType(DataType.Time)]
        public DateTime TourStartTime { get; set; }



        //[Display(Name = "Tour Type")]
        //[Required(ErrorMessage = " required")]
        //[MaxLength(30, ErrorMessage = "Maxinum 30 charecters allowed"), MinLength(3, ErrorMessage = "Minimun 3 charecters allowed")]
        //public string TourName { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Price Required")]
        public float Price { get; set; }

        //[Display(Name = "Deposit")]
        //[Required(ErrorMessage = "Deposit Required")]
        //[Display(Name = "Capacity")]
        //public int[] capacity = new int[50];

        //public string FriendlyMessage { get; set; }
        public double Deposit { get; set; }
        //public double GuestCost { get; set; }
        //public double Total_Cost { get; set; }
        //public int TTickets { get; set; }
        //public object Email { get; internal set; }
        //public object CustomerID { get; internal set; }

        public double deposit()
        {

            double deposit = 0;
            if (Price <= 150)
            {
                deposit = Price * 0.15;
            }
            else
                if (Price > 150 && Price <= 300)
            {
                deposit = Price * 0.20;
            }
            else
                if (Price > 300 && Price <= 500)
            {
                deposit = Price * 0.25;
            }
            else
                if (Price > 500 && Price <= 800)
            {
                deposit = Price * 0.30;
            }
            else
                if (Price > 800)
            {
                deposit = Price * 0.40;
            }
            return deposit;
        }
        public double Guest_Cost()
        {
            double x = 0;
            x = (Price * Num_Adults) + ((Price * Num_Kids) / 0.50);
            return x;
        }

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

        //if (TourType == Tours.Izilo_Bo_Kaap_Museum)
        //{
        //    x = Price + Guest_Cost() + deposit() - Discount();

        //}

        //if (TourType == Tours.Johannesburg_Zoo)
        //{
        //    x = Price + Guest_Cost() + deposit() - Discount();

        //}

        //if (TourType == Tours.Kirstenboch_National_Botanical_Garden)
        //{
        //    x = Price + Guest_Cost() + deposit() - Discount();

        //}

        //if (TourType == Tours.Kruger_National_Park)
        //{
        //    x = Price + Guest_Cost() + deposit() - Discount();

        //}

        //if (TourType == Tours.KWA_Muhle_Museum)
        //{
        //    x = Price + Guest_Cost() + deposit() - Discount();

        //}

        //if (TourType == Tours.Lions_Head)
        //{
        //    x = Price + Guest_Cost() + deposit() - Discount();

        //}

        //if (TourType == Tours.Lion_and_Safari_Park)
        //{
        //    x = Price + Guest_Cost() + deposit() - Discount();

        //}

        //if (TourType == Tours.Maclears_Beacon)
        //{
        //    x = Price + Guest_Cost() + deposit() - Discount();

        //}

        //if (TourType == Tours.Minitown)
        //{
        //    x = Price + Guest_Cost() + deposit() - Discount();

        //}

        //if (TourType == Tours.Robben_Island)
        //{
        //    x = Price + Guest_Cost() + deposit() - Discount();

        //}

        //if (TourType == Tours.Ushaka)
        //{
        //    x = Price + Guest_Cost() + deposit() - Discount();

        //}

        //if (TourType == Tours.Table_Mountain)
        //{
        //    x = Price + Guest_Cost() + deposit() - Discount();

        //}

        //if (TourType == Tours.V_and_A_Waterfront)
        //{
        //    x = Price + Guest_Cost() + deposit() - Discount();

        //}
        //    return x;

        //}
        //public double discount { get; set; }
        //public double Discount()
        //{
        //    double x = 0;
        //    if (Num_Adults + Num_Kids >= 4 && Num_Adults + Num_Kids <= 6)
        //    {
        //        x = Price * 0.05;

        //    }
        //    if (Num_Adults + Num_Kids > 6 && Num_Adults + Num_Kids <= 10)
        //    {
        //        x = Price * 0.10;

        //    }
        //    if (Num_Adults + Num_Kids > 10 && Num_Adults + Num_Kids <= 15)
        //    {
        //        x = Price * 0.15;

        //    }
        //    if (Num_Adults + Num_Kids > 15 && Num_Adults + Num_Kids <= 20)
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
        //    int x = Num_Adults + Num_Kids;
        //    return x;
        //}

        //public int tourCapacity()
        //{
        //    int x = 0;
        //    foreach (var c in capacity)
        //    {
        //        if (capacity[50] == 0)
        //        {
        //            string message = "Fully booked";
        //        }
        //        else
        //        {
        //            x = capacity.Length - numOfTickets();
        //        }

        //    }
        //    return x;
        //}  

        //public int TourCapacity()
        //{
        //    int x = 0;
        //    foreach (var c in capacity)
        //    {
        //        if (capacity[50] == 0)
        //        {
        //            string message = "Fully booked";
        //        }
        //        else
        //        {
        //            x = capacity.Length - numOfTickets();
        //        }

        //    }
        //    return x;
        //}

        //public string TourCapacity()
        //{
        //    string friendlymessage;
        //    int CapacityAvailable = 0;

        //    CapacityAvailable = capacity.Length - numOfTickets();

        //    do
        //    {
        //        if (CapacityAvailable == capacity.Length)
        //        {
        //            return friendlymessage = "unavailable ";
        //        }

        //        return friendlymessage = "available";
        //    }
        //    while (capacity.Length != 0);


        //    return friendlymessage;
        //}

        //public string Booked()
        //{
        //    string x = "";
        //    if (numOfTickets() > capacity.Length)
        //    {
        //        x = "Fully booked";
        //    }
        //    else
        //    {
        //        x = "Available";
        //        Counter = Counter + numOfTickets();
        //        {
        //            for (Counter = 2; Counter >= 2; Counter++) ;

        //        }
        //    }
        //    return x;

        //}


        //public int Counter = 0;


        //public int TourCapacity()
        //{
        //    int capacity = 50;
        //    int AvailableSeats = 0;
        //    int NewAvailableSeats = 0;
        //    int NewTickets = 0;

        //    AvailableSeats = capacity - numOfTickets();

        //    if (capacity >= 0 && capacity <=50)
        //    {
        //        NewAvailableSeats = AvailableSeats
        //    }
        //}
    }
}
