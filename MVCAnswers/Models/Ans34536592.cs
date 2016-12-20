using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVCAnswers.Models
{
    public class Ans34536592
    {
        public LinkListOperation Operation { get; set; }//set custom attribute that will return the 'name' of the enum value.
        [DisplayName("data-removeat")]
        public int Data_RemoveAt { get; set; }
    }
    public enum LinkListOperation
    {
        AddOne,
        RemoveOne,
        RemoveAll,
        Submit,
        RemoveAt
    }
}