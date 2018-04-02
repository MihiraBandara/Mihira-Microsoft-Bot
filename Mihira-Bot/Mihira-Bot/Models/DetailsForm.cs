using Microsoft.Bot.Builder.FormFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bot_Application1.Models
{
    public enum GenderOptions
    {
        Male,
        Female
    }

    public enum ProvincialOptions
    {
        CentralProv,
        Western,
        NorthCent,
        Sabaragamuwa,
        Uva,
        NorthWest,
        South,
        North,
        East
    }

    [Serializable]
    public class DetailsForm
    {
        public String FirstName;
        public String LastName;
        public GenderOptions? Gender;
        public int? PostalCode;
        public DateTime? DateOfBirth;
        public int? Telephone;
        public ProvincialOptions? Province;

        public static IForm<DetailsForm> BuildForm()
        {
            return new FormBuilder<DetailsForm>()
                .Message("Welcome to the contact details bot!")
                .Confirm("Do you want to add your Details?")
                .Build();
        }

    }
}